using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
   
    public partial class Form1 : Form
    {
        public int id = 0;
        Queue<customer> cus = new Queue<customer>();
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            if (cus.Count>0)
            {
                customer c1 = cus.Dequeue();
                textBox2.Text = c1.id1.ToString();
                listBox1.Items.Clear();
                foreach (customer cc in cus)
                {
                    int cou=cc.name.Count();
                    string s = " ";
                    for (int z = 0; z < 20-cou; z++) {
                        s += s;
                    
                    }
                        listBox1.Items.Add(cc.id1 + ""+s+"" + cc.name + "  " + cc.query);
                }
            }
            else
            {
                MessageBox.Show("NO Customer", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
          
            

        }

        private void print_Click(object sender, EventArgs e)
        {
            
            string name1 = name.Text;
            string query1 = comboBox1.SelectedItem.ToString();
            id++;
            customer c=new customer(){
            name=name1,
            query=query1,
            id1=id
            };
            cus.Enqueue(c);
            listBox1.Items.Clear();
            foreach (customer cc in cus) {
                listBox1.Items.Add(cc.id1 + "  " + cc.name + "  " + cc.query);
            
            }

        }

        private void Next1_Click(object sender, EventArgs e)
        {
            
            if (cus.Count > 0)
            {
                customer c1 = cus.Dequeue();
                textBox1.Text = c1.id1.ToString();
                listBox1.Items.Clear();
                foreach (customer cc in cus)
                {
                    int cou = cc.name.Length;
                    string s = " ";
                    for (int z = 0; z < 20 - cou; z++)
                    {
                        s=s+" ";

                    }
                    listBox1.Items.Add(cc.id1 + "" + s + "" + cc.name + "  " + cc.query);
                }
            }
            else
            {
                MessageBox.Show("NO Customer", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Next3_Click(object sender, EventArgs e)
        {
            
            if (cus.Count > 0)
            {
                customer c1 = cus.Dequeue();
                textBox3.Text = c1.id1.ToString();
                listBox1.Items.Clear();
                foreach (customer cc in cus)
                {
                    int cou = cc.name.Count();
                    string s = " ";
                    for (int z = 0; z < 20 - cou; z++)
                    {
                        s += s;

                    }
                    listBox1.Items.Add(cc.id1 + "" + s + "" + cc.name + "  " + cc.query);
                }
            }
            else {
                MessageBox.Show("NO Customer", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void admin_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.Show();
            
        }
    }
    public class customer
    {
        public string name { get; set; }
        public string query { get; set; }
        public int id1 { get; set; }

    }
}
