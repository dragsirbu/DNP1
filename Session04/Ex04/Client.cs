using System;
using System.Net.Sockets;
using System.Text;

namespace Client
{
    class Program
    {
        private const int PORT_NO = 5000;
        private const string SERVER_IP = "127.0.0.1";
        
        public static void Main(string[] args)
        {
            TcpClient client = new TcpClient(SERVER_IP,PORT_NO);
            NetworkStream stream = client.GetStream();
            
            Console.Write("Enter message to server: ");
            string message = Console.ReadLine();
            
            var bytesToSend = ASCIIEncoding.ASCII.GetBytes(message);
            
            Console.WriteLine($"Sending to server: {message}");
            stream.Write(bytesToSend,0,bytesToSend.Length);
            
            client.Close();

        }
    }
}