using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Net.Sockets;
using System.Net;
using BCS.Library.Logging;
using BCS.Library.Logging.Log4Net;

namespace TCPTest
{
    public enum CommsCode
    {
        Connected,
        Disconnected,
        Received,
        Error
    }

    public delegate void Message(String sourceName, CommsCode code, String msg, Object buffer);

    public class TCPServerDevice
    {
        private TcpListener _TcpListener;
        private Thread _ListenThread;
        private Message _Callback;
        private String _Name = "";
        List<TCPClientDevice> clients = new List<TCPClientDevice>();
        readonly ILogger _Logger;


        public TCPServerDevice(String name, int port, Message Callback)
        {
            _Logger = _Logger = Log4NetManager.GetLogger(name);
            _Name = name;
            _Callback = Callback;
            this._TcpListener = new TcpListener(IPAddress.Any, port);
            this._ListenThread = new Thread(new ThreadStart(ListenForClients));
            this._ListenThread.Start();
        }

        public void ClientClosed(TCPClientDevice dev)
        {
            _Logger.Info(String.Concat("Client closed - ", dev.EndPoint));
            clients.Remove(dev); 
        }

        public void Close()
        {
            _TcpListener.Stop();

            _Logger.Info(String.Concat("Server Stopped - ", _Name));

            TCPClientDevice[] tmp = clients.ToArray();

            foreach (TCPClientDevice client in tmp)
            {
                if (client.IsConnected())
                    client.Close();
            }

            clients.Clear();
        }

        private void ListenForClients()
        {
            try
            {
                this._TcpListener.Start();
                while (true)
                {
                    //blocks until a client has connected to the server
                    TcpClient client = this._TcpListener.AcceptTcpClient();
                    _Logger.Info(String.Concat("Accepted new connection - ", client.Client.RemoteEndPoint.ToString()));

                    TCPClientDevice dev = new TCPClientDevice(client, this);
                    clients.Add(dev);

                    if (_Callback != null)
                        _Callback(_Name, CommsCode.Connected, client.Client.RemoteEndPoint.ToString(), dev);
                    
                }
            }
            catch (Exception e)
            {
                if (_Callback != null)
                    _Callback(_Name, CommsCode.Error, "Server Error", e.Message);

                _Logger.Error(e.Message);
            }
        }

        public void Send(String msg)
        {
            foreach (TCPClientDevice client in clients)
            {
                if (client.IsConnected())
                {
                    ASCIIEncoding encoder = new ASCIIEncoding();
                    client.Send(encoder.GetBytes(msg));
                }
            }
        }
    }
}
