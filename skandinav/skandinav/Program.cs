using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace skandianvlotto
{
    public class Program
    {


        [STAThread]
        public static void Main(string[] args)
        {
            //lotto(5, 90);
            //lotto(6, 45);
            //lotto(7, 35);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());



            //Console.ReadKey();

        }
    }
}
