using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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

        public LoginForm()
        {
            InitializeComponent();
        }

        public string ReturnNameString()
        {
            string Name = TBName.Text;
            return Name;
        }

        private void BContinue_Click(object sender, EventArgs e)
        {
            this.UserName = TBName.Text;
            this.UserPassword = TBPassword.Text;
            //Form1 form1 = new Form1(Name, Password);
            //LoginForm.Close();
            this.Close();
        }
    }
}
