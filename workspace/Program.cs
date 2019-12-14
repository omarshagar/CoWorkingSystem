using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace workspace
{
    class person
    {
        
        public string name=null;
        public int id=0;
        public string role=null;
        public string phone=null;
        public string email=null;

    }
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
            public static person user;
        [STAThread]
        static void Main()
        {
            user = new person();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());
            // Application.Run(new Form1());
            //Application.Run(new Form2());
            //Application.Run(new Form5());
            Application.Run(new Form3());

            //Application.Run(new AddRoom());
            //Application.Run(new Form4());
        }
    }
}
