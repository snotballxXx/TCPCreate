using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Net.Sockets;
using System.Net;
using BCS.Library.Logging.Log4Net;
using BCS.Library.Logging;

namespace TCPTest
{

    public class TCPClientDevice
    {
        TcpClient _Client = null;
        UdpClient _UdpClient = null;
        UdpClient _UdpListener = null;
        Thread _ClientThread;
        Thread _ConnectThread;
        TCPServerDevice _Server;
        Boolean _Shutdown = false;
        String _Name = "";
        String _IP;
        Int32 _Port;
        Int32 _UDPPort = 0;
        String _EndPoint = String.Empty;
        System.Timers.Timer _StartTimer = new System.Timers.Timer(5);

        readonly ILogger _Logger = new NullLogger();

        public String EndPoint { get { return _EndPoint; } }

        public event Message OnMessage;

        public TCPClientDevice(TcpClient client, TCPServerDevice server)
        {
            _Client = client;
            _Server = server;
            _EndPoint = _Client.Client.RemoteEndPoint.ToString();
            //have client so start listening
            //create a thread to handle communication 
            //with connected client
            _ClientThread = new Thread(new ThreadStart(HandleClientComm));
            _ClientThread.Start();

            _Name = client.Client.RemoteEndPoint.ToString();
            _Logger = _Logger = Log4NetManager.GetLogger(_Name);

            _StartTimer.Elapsed += _StartTimer_Elapsed;
        }

        public TCPClientDevice(String name)
        {
            _Name = name;

            _Logger = _Logger = Log4NetManager.GetLogger(name);

            _StartTimer.Elapsed += _StartTimer_Elapsed;
        }

        public Boolean IsConnected()
        {
            return _Client.Connected;
        }

        public void Connect(String IP, Int32 port, Int32 portUDP)
        {
            _IP = IP;
            _Port = port;
            _UDPPort = portUDP;

            _ConnectThread = new Thread(ConnectThread);
            _ConnectThread.Start();            
        }
        IPEndPoint serverEndPoint;
        
        public void ConnectThread()
        {
            if (_Client == null)
            {
                try
                {
                    IPAddress ipAddress;
                    if (!IPAddress.TryParse(_IP, out ipAddress))
                    {
                        IPHostEntry host = Dns.GetHostEntry(_IP);

                        foreach (var ip in host.AddressList)
                        {
                            if (ip.AddressFamily == AddressFamily.InterNetwork)
                            {
                                ipAddress = ip;
                                break;
                            }
                        }
                    }

                    _Logger.Info(String.Concat("Connect attempt on ", _Name));
                    serverEndPoint = new IPEndPoint(ipAddress, _Port);

                    if (_UDPPort != 0)
                    {
                        _UdpClient = new UdpClient();
                        _UdpClient.Connect(serverEndPoint);

                        _UdpListener = new UdpClient(_UDPPort);
                    }
                    else
                    {
                        _Client = new TcpClient();
                        _Client.Connect(serverEndPoint);
                        OnMessage(_Name, CommsCode.Connected, "", this);
                        _Logger.Info(String.Concat("Connect success on ", _Name));
                    }
                    _Shutdown = false;

                    if (_UDPPort != 0)
                    {
                        _ClientThread = new Thread(new ThreadStart(HandleClientCommUDP));
                        _ClientThread.Start();
                    }
                    else
                        _StartTimer.Start();                    
                }
                catch (Exception e)
                {
                    _Logger.Error(e.Message);

                    if (OnMessage != null)
                    {
                        OnMessage(_Name, CommsCode.Error, "Connect error", e.Message);
                        OnMessage(_Name, CommsCode.Disconnected, "", this);
                    }
                }
            }
        }

        void _StartTimer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            _StartTimer.Stop();
            _ClientThread = new Thread(new ThreadStart(HandleClientComm));
            _ClientThread.Start();
        }

        public void Close()
        {
            _Logger.Info(String.Concat("Client closed - ", _Name));
            _Shutdown = true;

            if (_Client != null && _Client.Client != null && _Client.Connected)
                _Client.Close();

            if (_UdpListener != null)
                _UdpListener.Close();

            if (_UdpClient != null)
                _UdpClient.Close();

            if (_Server != null)
                _Server.ClientClosed(this);

            if (_ConnectThread != null)
                _ConnectThread.Join();
            if (_ClientThread != null)
                _ClientThread.Join();

            _ConnectThread = null;
            _ClientThread = null;
        }

        public void Send(byte[] buffer)
        {
            try
            {
                if (_UDPPort != 0)
                {
                    var i = _UdpClient.Send(buffer, buffer.Length);
                    _Logger.Info(String.Concat("Sent ", i));  
                }
                else
                {
                    NetworkStream clientStream = _Client.GetStream();
                    clientStream.Write(buffer, 0, buffer.Length);
                    clientStream.Flush();
                }
                _Logger.Info(String.Concat("Sent ", buffer.Length, " bytes on ", _Name));                
            }
            catch (Exception e)
            {
                _Logger.Error(String.Concat("Send error - ", e.Message));
                if (OnMessage != null)
                    OnMessage(_Name, CommsCode.Error, "Send error", e.Message);

                _Client.Close();

                if (_Server != null)
                    _Server.ClientClosed(this);
            }
        }
        static byte[] GetBytes(string str)
        {
            byte[] bytes = new byte[str.Length * sizeof(char)];
            System.Buffer.BlockCopy(str.ToCharArray(), 0, bytes, 0, bytes.Length);
            return bytes;
        }

        static string GetString(byte[] bytes)
        {
            char[] chars = new char[bytes.Length / sizeof(char)];
            System.Buffer.BlockCopy(bytes, 0, chars, 0, bytes.Length);
            return new string(chars);
        }
        private void HandleClientCommUDP()
        {
            //IPEndPoint object will allow us to read datagrams sent from any source.
            IPEndPoint RemoteIpEndPoint = new IPEndPoint(IPAddress.Any, _UDPPort);

            Byte[] receiveBytes;

            while (true)
            {
                try
                {
                    // Blocks until a message returns on this socket from a remote host.
                    receiveBytes = _UdpListener.Receive(ref RemoteIpEndPoint);

                    //var x = new UdpClient(RemoteIpEndPoint);
                    String str = "Received message OK";
                    var y = GetBytes(str);
                    _UdpListener.Send(y, y.Length, RemoteIpEndPoint);

                    _Logger.Info(String.Concat("Received ", receiveBytes.Length, " bytes on ", _Name));
                }
                catch (Exception e)
                {
                    _Logger.Error(String.Concat("Read error - ", e.Message));
                    if (OnMessage != null)
                        OnMessage(_Name, CommsCode.Disconnected, "Controlled shutdown", this);

                    if (OnMessage != null && !_Shutdown)
                        OnMessage(_Name, CommsCode.Error, "Receive error", e.Message);
                    break;
                }

                if (receiveBytes.Length == 0)
                {
                    _Logger.Info(String.Concat("Received 0 bytes"));
                    //the client has disconnected from the server
                    if (OnMessage != null)
                        OnMessage(_Name, CommsCode.Disconnected, "Received message", this);
                    break;
                }

                byte[] buffer = new byte[receiveBytes.Length];
                for (int i = 0; i < receiveBytes.Length; ++i)
                    buffer[i] = receiveBytes[i];

                if (OnMessage != null)
                    OnMessage(_Name, CommsCode.Received, "Received message", buffer);
            }

        }
        int count = 0;
        private void HandleClientComm()
        {
            NetworkStream clientStream = _Client.GetStream();

            byte[] message = new byte[65536];
            int bytesRead;

            while (true)
            {
                bytesRead = 0;

                try
                {
                    //blocks until a client sends a message
                    bytesRead = clientStream.Read(message, 0, 65536);
                    //throw new Exception();
                    _Logger.Info(String.Concat("Received ", bytesRead, " bytes on ", _Name));
                    count++;
                }
                catch (Exception e)
                {
                    _Logger.Error(String.Concat("Read error - ", e.Message));
                    if (OnMessage != null)
                        OnMessage(_Name, CommsCode.Disconnected, "Controlled shutdown", this);

                    if (OnMessage != null && !_Shutdown)
                        OnMessage(_Name, CommsCode.Error, "Receive error", e.Message);
                    break;
                }

                if (bytesRead == 0)
                {
                    _Logger.Info(String.Concat("Received 0 bytes"));
                    //the client has disconnected from the server
                    if (OnMessage != null)
                        OnMessage(_Name, CommsCode.Disconnected, "Received message", this);
                    break;
                }

                byte[] buffer = new byte[bytesRead];
                for (int i = 0; i < bytesRead; ++i)
                    buffer[i] = message[i];

                if (OnMessage != null)
                    OnMessage(_Name, CommsCode.Received, "Received message", buffer);
            }

            if (_Client.Connected)
                _Client.Close();

            if (_Server != null)
                _Server.ClientClosed(this);
        }
    }
}
