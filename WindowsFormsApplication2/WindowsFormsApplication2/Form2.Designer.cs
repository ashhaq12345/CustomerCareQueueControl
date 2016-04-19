namespace WindowsFormsApplication2
{
    partial class Form2
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
            this.userbox = new System.Windows.Forms.TextBox();
            this.passbox = new System.Windows.Forms.TextBox();
            this.user = new System.Windows.Forms.Label();
            this.pass = new System.Windows.Forms.Label();
            this.signin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // userbox
            // 
            this.userbox.Location = new System.Drawing.Point(132, 57);
            this.userbox.Name = "userbox";
            this.userbox.Size = new System.Drawing.Size(100, 20);
            this.userbox.TabIndex = 0;
            // 
            // passbox
            // 
            this.passbox.Location = new System.Drawing.Point(132, 106);
            this.passbox.Name = "passbox";
            this.passbox.Size = new System.Drawing.Size(100, 20);
            this.passbox.TabIndex = 1;
            this.passbox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // user
            // 
            this.user.AutoSize = true;
            this.user.Location = new System.Drawing.Point(73, 60);
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(57, 13);
            this.user.TabIndex = 2;
            this.user.Text = "UserName";
            // 
            // pass
            // 
            this.pass.AutoSize = true;
            this.pass.Location = new System.Drawing.Point(73, 106);
            this.pass.Name = "pass";
            this.pass.Size = new System.Drawing.Size(56, 13);
            this.pass.TabIndex = 3;
            this.pass.Text = "PassWord";
            // 
            // signin
            // 
            this.signin.Location = new System.Drawing.Point(132, 160);
            this.signin.Name = "signin";
            this.signin.Size = new System.Drawing.Size(75, 23);
            this.signin.TabIndex = 4;
            this.signin.Text = "Sign In";
            this.signin.UseVisualStyleBackColor = true;
            this.signin.Click += new System.EventHandler(this.signin_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.signin);
            this.Controls.Add(this.pass);
            this.Controls.Add(this.user);
            this.Controls.Add(this.passbox);
            this.Controls.Add(this.userbox);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox userbox;
        private System.Windows.Forms.TextBox passbox;
        private System.Windows.Forms.Label user;
        private System.Windows.Forms.Label pass;
        private System.Windows.Forms.Button signin;
    }
}