using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arsenal
{
    public partial class Aut_Form : Form
    {
        public static string Login = "";

        public Aut_Form()
        {
            InitializeComponent();

            Text = "Авторизация";

           

        }

        public void button1_Click(object sender, EventArgs e)
        {
            if (Login_textBox1.Text == "Maximilian" && Pass_textBox2.Text == "caca")
            {
                Login = Login_textBox1.Text;
            }
            else
            {
                MessageBox.Show("Hren tebe");
            };

        }

        private void Login_textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
