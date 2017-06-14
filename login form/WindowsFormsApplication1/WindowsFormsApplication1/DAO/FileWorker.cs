using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.DAO
{
    public class FileWorker
    {
        private string path;
        public string Path { get { return path; } set { path = value; } }
        public FileWorker(string _path)
        {
            path = _path;
        }
        public void Write(string input)
        {
            if (!File.Exists(path))
                using (File.Create(path)) { };

            using (StreamWriter sw = new StreamWriter(path, false, Encoding.Default))
            {
                sw.WriteLine(input);
            }

        }

        public string Read()
        {

            string result = String.Empty;
            if (!File.Exists(path))
                using (File.Create(path)) { };

            using (StreamReader sr = new StreamReader(path, Encoding.Default))
            {
                result = sr.ReadToEnd();
            }
            return result;
        }
    }
}
