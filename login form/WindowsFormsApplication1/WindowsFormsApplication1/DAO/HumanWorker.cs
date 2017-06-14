using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.DAO
{
    public class HumanWorker<T>
    {
        FileWorker worker;
        ISerializer<T> serializer;

        public HumanWorker(string path)
        {
            worker = new FileWorker(path);
            serializer = new JSONSerializer<T>();
        }
        public List<T> ReadAll()
        {
            string humans_string = worker.Read();
            if (humans_string.Equals(""))
            {
                Write(new List<T>() { });
                humans_string = worker.Read();
            }
            var humans_list = serializer.Deserialize(humans_string);
            return humans_list;
        }

        public void Write(List<T> human)
        {
            string convertedHuman = serializer.Serialize(human);
            worker.Write(convertedHuman);
        }

    }
}
