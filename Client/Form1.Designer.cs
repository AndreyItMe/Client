namespace Client
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.SendMessage = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.GetMessages = new System.Windows.Forms.Button();
            this.ReceiverNameTextBox3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.CurrentUserlabel2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // SendMessage
            // 
            this.SendMessage.Location = new System.Drawing.Point(421, 378);
            this.SendMessage.Name = "SendMessage";
            this.SendMessage.Size = new System.Drawing.Size(88, 23);
            this.SendMessage.TabIndex = 3;
            this.SendMessage.Text = "SendMessage";
            this.SendMessage.UseVisualStyleBackColor = true;
            this.SendMessage.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(33, 381);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(382, 20);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "Hello!";
            // 
            // GetMessages
            // 
            this.GetMessages.Location = new System.Drawing.Point(230, 43);
            this.GetMessages.Name = "GetMessages";
            this.GetMessages.Size = new System.Drawing.Size(75, 23);
            this.GetMessages.TabIndex = 1;
            this.GetMessages.Text = "GetMessages";
            this.GetMessages.UseVisualStyleBackColor = true;
            this.GetMessages.Click += new System.EventHandler(this.button2_Click);
            // 
            // ReceiverNameTextBox3
            // 
            this.ReceiverNameTextBox3.Location = new System.Drawing.Point(124, 45);
            this.ReceiverNameTextBox3.Name = "ReceiverNameTextBox3";
            this.ReceiverNameTextBox3.Size = new System.Drawing.Size(100, 20);
            this.ReceiverNameTextBox3.TabIndex = 0;
            this.ReceiverNameTextBox3.Text = "anton";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Select contact";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(33, 72);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(465, 300);
            this.richTextBox1.TabIndex = 6;
            this.richTextBox1.Text = "";
            // 
            // CurrentUserlabel2
            // 
            this.CurrentUserlabel2.AutoSize = true;
            this.CurrentUserlabel2.Location = new System.Drawing.Point(34, 9);
            this.CurrentUserlabel2.Name = "CurrentUserlabel2";
            this.CurrentUserlabel2.Size = new System.Drawing.Size(35, 13);
            this.CurrentUserlabel2.TabIndex = 7;
            this.CurrentUserlabel2.Text = "label2";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10000;
            this.timer1.Tick += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CurrentUserlabel2);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ReceiverNameTextBox3);
            this.Controls.Add(this.GetMessages);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.SendMessage);
            this.Name = "Form1";
            this.Text = "AndreyGramm";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SendMessage;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button GetMessages;
        private System.Windows.Forms.TextBox ReceiverNameTextBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label CurrentUserlabel2;
        private System.Windows.Forms.Timer timer1;
    }
}

