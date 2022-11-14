using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace FileIODemo
{
    public class BinarySerialization
    {
        public void SerialiZation()
        {
            Demo sample = new Demo();
            FileStream fileStream = new FileStream(@"C:\Users\Gajanan\source\repos\FileIODemo\FileIODemo\BinaryDemo.txt", FileMode.Create);
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(fileStream, sample);
        }

        public void Deserlization()
        {
            FileStream fileStream = new FileStream(@"C:\Users\Gajanan\source\repos\FileIODemo\FileIODemo\BinaryDemo.txt", FileMode.Open);
            BinaryFormatter formatter = new BinaryFormatter();
            Demo deserilaizationSampleDemo = (Demo)formatter.Deserialize(fileStream);
            Console.WriteLine("ApplicationName: " + deserilaizationSampleDemo.ApplicationName + "ApplicationID: " + deserilaizationSampleDemo.ApplicationID);
        }
        [Serializable]
        public class Demo
        {
            public string ApplicationName { get; set; } = "BinarySerialzation";
            public int ApplicationID { get; set; } = 1001;
        }
    }
}
