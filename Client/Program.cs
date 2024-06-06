using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{

    internal static class Program
    {
        
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);


            LoginForm loginForm = new LoginForm();
            
            //loginForm.Close();
            Application.Run(loginForm);
            string Name = loginForm.UserName;
            string Password = loginForm.UserPassword;


            Form1 form1 = new Form1();
            form1.UserName = loginForm.UserName;
            form1.UserPassword = loginForm.UserPassword;
            Application.Run(form1);

            //Application.Run(new Form1(Name, Password));
        }
    }
}
