using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public interface IViewLogin
    {
        DateTime StartTime { get; set; }
        DateTime CurrentTime { get; set; }

        bool CheckTime();

        void Form_KeyDown(object sender, KeyEventArgs e);

        bool ContinueFlag { get; set; }


    }
}
