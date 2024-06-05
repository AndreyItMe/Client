using Client.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using System.Xml;
using Client.Massage;
using Newtonsoft.Json;
using System.Net.NetworkInformation;

namespace Client
{
    public partial class Form1 : Form
    {
        const string SERVER_URL = "http://localhost:8080/";
        public string UserName { get; set; }
        public string UserPassword { get; set; }
        //public Form1(string Name, string Password)
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string text = textBox1.Text;
            string receiverName = ReceiverNameTextBox3.Text;
            //string url = SERVER_URL + "put/" + fileName;
            string url = SERVER_URL + "message";
            WebClient client = new WebClient();
            try
            {
                string Auth = UserName + ":" + UserPassword;
                string str = Convert.ToBase64String(Encoding.UTF8.GetBytes(Auth));
                client.Headers.Add("Authorization", "Basic " + str);
                client.Headers.Add("ReceiverName", receiverName);
                client.UploadString(url, text); //тоже "PUT" запрос
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error': {ex.Message}");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //GET
            //string url = SERVER_URL + fileName;
            string url = SERVER_URL + "message";
            WebClient client = new WebClient();
            try
            {
                string Auth = UserName + ":" + UserPassword;
                string str = Convert.ToBase64String(Encoding.UTF8.GetBytes(Auth));
                client.Headers.Add("Authorization", "Basic " + str);
                string content = client.DownloadString(url);
                var settings = new JsonSerializerSettings
                {
                    //TypeNameHandling = TypeNameHandling.All,
                    Formatting = Formatting.Indented

                };
                List<TextMassage> currency = Newtonsoft.Json.JsonConvert.DeserializeObject<List<TextMassage>>(content, settings);
                Console.WriteLine($"Content of file message:\n{content}");
                //в currency хранитятся данные о сообщениях
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error downloading file message: {ex.Message}");
            }
        }

        

        private void Form1_Load(object sender, EventArgs e)
        {
            int i = 0; //запрос на сервер чтобы зарегестрировать пользователя
            
            //LoginForm newForm = new LoginForm();
            //newForm.Show();
            //Name = newForm.Name;
            //ewForm.P
            //Password = newForm.Password;
        }
    }
}
