using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace Ex04Client
{
    class Program
    {
        private const int PORT_NO = 5000;
        private const string SERVER_IP = "127.0.0.1";
        
        public static void Main(string[] args)
        {
            try
            {
                var client = new TcpClient(SERVER_IP, PORT_NO);
                
                var writer = new StreamWriter(client.GetStream());
                var reader = new StreamReader(client.GetStream());
                
                var message = String.Empty;
                
                while (!(message.Equals("Exit")))
                {
                    Console.Write("Enter message to server: ");
                    message = Console.ReadLine();
                    writer.WriteLine(message);
                    writer.Flush();

                    var messageFromServer = reader.ReadLine();
                    Console.WriteLine(messageFromServer);
                }
                reader.Close();
                writer.Close();
                client.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            

        }
    }
}