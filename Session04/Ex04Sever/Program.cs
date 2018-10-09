using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;

namespace Ex04Sever
{
    class Program
    {
        private const int PORT_NO = 5000;
        private const string SERVER_IP = "127.0.0.1";

        private static void ProcessClientRequest(object argument)
        {
            TcpClient client = (TcpClient) argument;
            try
            {
                var reader = new StreamReader(client.GetStream());
                var writer = new StreamWriter(client.GetStream());
                var message = String.Empty;
                while (!(message = reader.ReadLine()).Equals("Exit") || (message == null))
                {
                    Console.WriteLine($"From client: {message}");
                    writer.WriteLine($"From server: {message}");
                    writer.Flush();
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("Problem with client communication. Exiting thread!");
            }
            finally
            {
                if (client != null)
                    client.Close();
            }

        }
        
        static void Main(string[] args)
        {
            TcpListener listener = null;

            try
            {
                listener = new TcpListener(IPAddress.Parse(SERVER_IP),PORT_NO);
                listener.Start();
                Console.WriteLine("Server started...");
                while (true)
                {
                    Console.WriteLine("Waiting for incoming client connections..");
                    TcpClient client = listener.AcceptTcpClient();
                    Console.WriteLine("Accepted new client connection...");
                    Thread t = new Thread(ProcessClientRequest);
                    t.Start(client);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }

//            NetworkStream stream = client.GetStream();
//            var buffer = new byte[client.ReceiveBufferSize];
//
//            int bytesRead = stream.Read(buffer, 0, client.ReceiveBufferSize);
//            var clientMessage = Encoding.ASCII.GetString(buffer, 0, bytesRead);
//            
//            Console.WriteLine($"Client: {clientMessage}");
//
//            var bytesToSend = ASCIIEncoding.ASCII.GetBytes("Hi client!");
//            stream.Write(bytesToSend,0,bytesToSend.Length); 
//           
//            
//            listener.Stop();
            
            
        }
    }
}