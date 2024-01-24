using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace inventory
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
           // Application.Run(new Form1());
      //      Application.Run(new ManageCategories());
          //  Application.Run(new ManageCustomers());
         //   Application.Run(new Login());
            Application.Run(new SplashForm());
            // Application.Run(new ss());
         //   Application.Run(new ManageOrders());
            // Application.Run(new ViewOrders());

        }
    }
}
