using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace Client
{
    public partial class LoginForm : Form
    {
        public string UserName;
        public string UserPassword;
        bool loginCorrect = false;
        const string SERVER_URL = "http://localhost:8080/";

        public LoginForm()
        {
            InitializeComponent();
        }

        public string ReturnNameString()
        {
            string Name = TBName.Text;
            return Name;
        }

        private bool loginOrRegistrationUser()
        {
            string text = UserName;
            string fileName = "users.txt";
            //string url = SERVER_URL + "put/" + fileName;
            string url = SERVER_URL + "user";
            WebClient client = new WebClient();
            string result = "false";
            try
            {
                //var result = client.UploadString(url, "{'Username': " + UserName + ",'Password': " + UserPassword + "}");
                //согласно Basic access authentication(https://en.wikipedia.org/wiki/Basic_access_authentication) надо делать так
                //https://jasonwatmore.com/post/2021/12/20/net-6-basic-authentication-tutorial-with-example-api
                string authentication = UserName + ":" + UserPassword;
                string str = Convert.ToBase64String( Encoding.UTF8.GetBytes(authentication)  );
                // andrey:qwerty
                // Authorization: Basic YW5kcmV5OnF3ZXJ0eQ==
                client.Headers.Add("Authorization", "Basic " + str);
                result = client.UploadString(url, "body"); //при отправке сообщения вместо str будет body
                //client.
                
                if (result.Equals("201")) //вот тут папа помог, не хватало context.Response.Close(); на сервере
                {
                    //не могу получить result
                    this.loginCorrect = true;
                }

                Console.WriteLine("loginOrRegistrationUser()");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error uploading file '{fileName}': {ex.Message}");
            }
            if (result == "true") //проверка на то что пароль коректный 
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void BContinue_Click(object sender, EventArgs e)
        {
            this.UserName = TBName.Text;
            this.UserPassword = TBPassword.Text;
            //Form1 form1 = new Form1(Name, Password);
            //LoginForm.Close();
            if (loginOrRegistrationUser())
            {
                this.Hide();    
                //this.Close();
                //взял этот код из Program.Main
/*
                Form1 form1 = new Form1();
                form1.UserName = this.UserName;
                form1.UserPassword = this.UserPassword;
                Application.Run(form1);
*/
            }
            Form1 form1 = new Form1();
            form1.UserName = this.UserName;
            form1.UserPassword = this.UserPassword;

            form1.Show();
            //this.Close();
            this.Hide();
        }
    }
}
