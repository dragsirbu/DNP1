using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace Ex04Sever
{
    class Program
    {
        private const int PORT_NO = 5000;
        private const string SERVER_IP = "127.0.0.1";
        static void Main(string[] args)
        {
            IPAddress address = IPAddress.Parse(SERVER_IP);
            TcpListener listener = new TcpListener(address,PORT_NO);
            
            Console.WriteLine("Waiting for client...");
            
            listener.Start();

            TcpClient client = listener.AcceptTcpClient();

            NetworkStream stream = client.GetStream();
            var buffer = new byte[client.ReceiveBufferSize];

            int bytesRead = stream.Read(buffer, 0, client.ReceiveBufferSize);
            var clientMessage = Encoding.ASCII.GetString(buffer, 0, bytesRead);
            
            Console.WriteLine($"Client: {clientMessage}");

            var bytesToSend = ASCIIEncoding.ASCII.GetBytes("Hi client!");
            stream.Write(bytesToSend,0,bytesToSend.Length); 
           
            
            listener.Stop();
            
            
        }
    }
}