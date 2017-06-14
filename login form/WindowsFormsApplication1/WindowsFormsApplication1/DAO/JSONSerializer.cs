using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Json;
using System.IO;

namespace WindowsFormsApplication1.DAO
{
    public class JSONSerializer<T> : ISerializer<T>
    {
        public List<T> Deserialize(string input)
        {
            var instance = typeof(T);
            var deserializer = new DataContractJsonSerializer(typeof(List<T>));

            using (MemoryStream ms = new MemoryStream(Encoding.UTF8.GetBytes(input)))
            {
                return (List<T>)deserializer.ReadObject(ms);
            }
        }

        public string Serialize(List<T> input)
        {
            var serializer = new DataContractJsonSerializer(input.GetType());
            using (MemoryStream ms = new MemoryStream())
            {
                serializer.WriteObject(ms, input);
                return Encoding.Default.GetString(ms.ToArray());
            }

        }
    }
}
