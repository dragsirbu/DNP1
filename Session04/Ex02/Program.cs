using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Json;

namespace Ex02
{
    class Program
    {
        static void Main(string[] args)
        {
            IFormatter formatter = new BinaryFormatter();
//            Stream writeStream = new FileStream("MyFile.bin",FileMode.Create,FileAccess.Write,FileShare.None);
//            
            var person = new Person("Dragos","Sirbu",050399);
//            
//            formatter.Serialize(writeStream,person);
            
            Stream readStream = new FileStream("MyFile.bin",FileMode.Open,FileAccess.Read,FileShare.Read);
            Person deserializedPerson = (Person) formatter.Deserialize(readStream);
            
            Console.WriteLine(deserializedPerson.ToString());
//            
//            Stream jsonStreamWriter = new FileStream("MyFileJson.bin",FileMode.Create, FileAccess.Write, FileShare.None);
            DataContractJsonSerializer jsonSerializer = new DataContractJsonSerializer(typeof(Person));
            
//            jsonSerializer.WriteObject(jsonStreamWriter,person);
            
            Stream jsonStreamReader = new FileStream("MyFileJson.bin",FileMode.Open,FileAccess.Read,FileShare.Read);
            Person p2 =  (Person) jsonSerializer.ReadObject(jsonStreamReader);
            
            
            Console.WriteLine(p2.ToString());
            





        }
    }
}