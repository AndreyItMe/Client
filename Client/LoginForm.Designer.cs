namespace Client
{
    partial class LoginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TBName = new System.Windows.Forms.TextBox();
            this.BCansel = new System.Windows.Forms.Button();
            this.BContinue = new System.Windows.Forms.Button();
            this.TBPassword = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // TBName
            // 
            this.TBName.Location = new System.Drawing.Point(183, 64);
            this.TBName.Name = "TBName";
            this.TBName.Size = new System.Drawing.Size(194, 20);
            this.TBName.TabIndex = 0;
            // 
            // BCansel
            // 
            this.BCansel.Location = new System.Drawing.Point(183, 145);
            this.BCansel.Name = "BCansel";
            this.BCansel.Size = new System.Drawing.Size(75, 23);
            this.BCansel.TabIndex = 2;
            this.BCansel.Text = "Cancel";
            this.BCansel.UseVisualStyleBackColor = true;
            // 
            // BContinue
            // 
            this.BContinue.Location = new System.Drawing.Point(302, 145);
            this.BContinue.Name = "BContinue";
            this.BContinue.Size = new System.Drawing.Size(75, 23);
            this.BContinue.TabIndex = 3;
            this.BContinue.Text = "Continue";
            this.BContinue.UseVisualStyleBackColor = true;
            this.BContinue.Click += new System.EventHandler(this.BContinue_Click);
            // 
            // TBPassword
            // 
            this.TBPassword.Location = new System.Drawing.Point(183, 106);
            this.TBPassword.Name = "TBPassword";
            this.TBPassword.Size = new System.Drawing.Size(194, 20);
            this.TBPassword.TabIndex = 1;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 259);
            this.Controls.Add(this.TBPassword);
            this.Controls.Add(this.BContinue);
            this.Controls.Add(this.BCansel);
            this.Controls.Add(this.TBName);
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TBName;
        private System.Windows.Forms.Button BCansel;
        private System.Windows.Forms.Button BContinue;
        private System.Windows.Forms.TextBox TBPassword;
    }
}