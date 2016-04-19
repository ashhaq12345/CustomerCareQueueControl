namespace WindowsFormsApplication2
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.Next1 = new System.Windows.Forms.Button();
            this.Next2 = new System.Windows.Forms.Button();
            this.Next3 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.print = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.name = new System.Windows.Forms.TextBox();
            this.admin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(541, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Counter3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(311, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Counter2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(83, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Counter1";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(86, 80);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(314, 80);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 4;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(544, 80);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 5;
            // 
            // Next1
            // 
            this.Next1.Location = new System.Drawing.Point(86, 115);
            this.Next1.Name = "Next1";
            this.Next1.Size = new System.Drawing.Size(75, 23);
            this.Next1.TabIndex = 6;
            this.Next1.Text = "Next";
            this.Next1.UseVisualStyleBackColor = true;
            this.Next1.Click += new System.EventHandler(this.Next1_Click);
            // 
            // Next2
            // 
            this.Next2.Location = new System.Drawing.Point(314, 115);
            this.Next2.Name = "Next2";
            this.Next2.Size = new System.Drawing.Size(75, 23);
            this.Next2.TabIndex = 7;
            this.Next2.Text = "Next";
            this.Next2.UseVisualStyleBackColor = true;
            this.Next2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Next3
            // 
            this.Next3.Location = new System.Drawing.Point(544, 115);
            this.Next3.Name = "Next3";
            this.Next3.Size = new System.Drawing.Size(75, 23);
            this.Next3.TabIndex = 8;
            this.Next3.Text = "Next";
            this.Next3.UseVisualStyleBackColor = true;
            this.Next3.Click += new System.EventHandler(this.Next3_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(86, 167);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(276, 238);
            this.listBox1.TabIndex = 9;
            // 
            // print
            // 
            this.print.Location = new System.Drawing.Point(409, 331);
            this.print.Name = "print";
            this.print.Size = new System.Drawing.Size(121, 23);
            this.print.TabIndex = 10;
            this.print.Text = "print receipt";
            this.print.UseVisualStyleBackColor = true;
            this.print.Click += new System.EventHandler(this.print_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Sim Replacement",
            "Internet",
            "General"});
            this.comboBox1.Location = new System.Drawing.Point(409, 270);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 11;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(409, 206);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(100, 20);
            this.name.TabIndex = 12;
            // 
            // admin
            // 
            this.admin.Location = new System.Drawing.Point(580, 438);
            this.admin.Name = "admin";
            this.admin.Size = new System.Drawing.Size(75, 23);
            this.admin.TabIndex = 13;
            this.admin.Text = "ADMIN";
            this.admin.UseVisualStyleBackColor = true;
            this.admin.Click += new System.EventHandler(this.admin_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 473);
            this.Controls.Add(this.admin);
            this.Controls.Add(this.name);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.print);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.Next3);
            this.Controls.Add(this.Next2);
            this.Controls.Add(this.Next1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button Next1;
        private System.Windows.Forms.Button Next2;
        private System.Windows.Forms.Button Next3;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button print;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Button admin;
    }
}

