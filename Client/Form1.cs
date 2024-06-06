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
using Newtonsoft.Json;
using System.Net.NetworkInformation;
using System.Net.Http.Headers;
using System.Runtime.Remoting.Contexts;
using Try1Server.Massage;
using System.Runtime;

namespace Client
{
    public partial class Form1 : Form
    {
        const string SERVER_URL = "http://localhost:8080/";

        List<TextMassage> currentMassageList;
        public string UserName { get; set; }
        public string UserPassword { get; set; }
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string text = textBox1.Text;
            string receiverName = ReceiverNameTextBox3.Text;
            string url = SERVER_URL + "message";
            WebClient client = new WebClient();
            try
            {
                TextMassage currentMassage = new TextMassage();
                currentMassage.Text = text;
                currentMassage.Time = DateTime.Now.TimeOfDay;
                currentMassage.SenderName = this.UserName;
                currentMassage.ReceiverName = receiverName;

                string Auth = UserName + ":" + UserPassword;
                string str = Convert.ToBase64String(Encoding.UTF8.GetBytes(Auth));
                client.Headers.Add("Authorization", "Basic " + str);
                client.Headers.Add("ReceiverName", receiverName);

                string json = currentMassage.toString();
                client.UploadString(url, json); //тоже "PUT" запрос
                currentMassageList.Add(currentMassage);
                this.richTextBox1.Text = "";
                foreach (TextMassage message in currentMassageList)
                {
                    this.richTextBox1.Text += (message.SenderName + ": " + message.Text + "\n");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error': {ex.Message}");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //GET message
            string url = SERVER_URL + "messages";
            WebClient client = new WebClient();
            try
            {
                string Auth = UserName + ":" + UserPassword;
                string str = Convert.ToBase64String(Encoding.UTF8.GetBytes(Auth));
                client.Headers.Add("Authorization", "Basic " + str);
                client.Headers.Add("AnotherContact", ReceiverNameTextBox3.Text); //кому сообщение
                string MessagesListJSON = client.DownloadString(url);
                var settings = new JsonSerializerSettings
                {
                    Formatting = Formatting.Indented
                };
                currentMassageList = Newtonsoft.Json.JsonConvert.DeserializeObject<List<TextMassage>>(MessagesListJSON, settings);
                this.richTextBox1.Text = "";
                foreach (TextMassage message in currentMassageList) 
                {
                    this.richTextBox1.Text += (message.SenderName + ": " + message.Text + "\n");
                }
                Console.WriteLine($"Content of file message:\n{MessagesListJSON}");
                //в currency хранитятся данные о сообщениях
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error downloading file message: {ex.Message}");
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.CurrentUserlabel2.Text = "CurrentUser: " + this.UserName;
            List<TextMassage> currentMassageList = new List<TextMassage>(); //инициализация
        }
    }
}
