using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace menustrip.Properties
{
    public partial class log : Form
    {
        public log()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string email = textBox1.Text;
            string password = textBox2.Text;
            
                                                                    
            string correctEmail = "amnasheikh@gmail.com";
            string correctPassword = "1122";
           


            if (email == correctEmail && password == correctPassword)
            {
                this.Hide();
                Form1 form = new Form1();
                form.ShowDialog();


            }
            else
            {
                MessageBox.Show("Error");
            }


        }
    }
}
