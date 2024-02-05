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
    public partial class InfoForm : Form
    {
        public InfoForm(string name)
        {
            InitializeComponent();

            Text = name;
            label1.Text = name;
            pictureBox1.Load("../../Pic/" + name + ".png");
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;

        }
    }
}
