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
    public struct Gun
    {
        public string name;
        public string kalibr;
        public string strelba;
        public int price;
        public string country;

        public Button btn;
        public PictureBox pic;
        
        public Gun(string _name, string _kalibr, string _strelba, int _price, string _country)
        {
            name = _name;
            kalibr = _kalibr;
            strelba = _strelba;
            price = _price;
            country = _country;
            pic = new PictureBox();
            btn = new Button();

            btn.Font = new Font("Microsoft Sans Serin", 12F );
            btn.Text = name;
            pic.SizeMode = PictureBoxSizeMode.Zoom;
            pic.Load("../../Pic/" + name + ".png");

        }
    }


    public partial class Form1 : Form
    {

        Gun[] gun_list = new Gun[5];

        public Form1()
        {
            InitializeComponent();

            gun_list[0] = new Gun("ак 74м", "5,45", "auto", 45000, "Россия");
            gun_list[1] = new Gun("ар 15", "5,56", "auto", 90000, "США");
            gun_list[2] = new Gun("ауг", "5,56", "auto", 130000, "Австрия");
            gun_list[3] = new Gun("г36", "5,56", "auto", 150000, "Германия");
            gun_list[4] = new Gun("галил", "5,56", "auto", 120000, "Израиль");

            
              

          
            Text = "Арсенал";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            InfoForm info = new InfoForm(btn.Text);
            info.ShowDialog();
        }

        private void ViewPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        public void Form1_Load(object sender, EventArgs e)
        {
           
            int x = 30;
            int y = 30;
            for (int i = 0; i < 5; i++)
            {


                gun_list[i].btn.Location = new Point(x, y);
                gun_list[i].btn.Size = new Size(272, 62);
                gun_list[i].btn.Click += new EventHandler(button1_Click);
                ViewPanel.Controls.Add(gun_list[i].btn);

                gun_list[i].pic.Location = new Point(x, y + 70);
                gun_list[i].pic.Size = new Size(270, 158);
                gun_list[i].pic.SizeMode = PictureBoxSizeMode.Zoom;
                ViewPanel.Controls.Add(gun_list[i].pic);

                x += 310;
                if (x > this.Size.Width - 150)
                {
                    y += 250;
                    x = 30;
                }
            }
        }

        private void ViewPanel_Resize(object sender, EventArgs e)
        {
            Form1_Load(null, null);
        }

        private void Aut_Button_Click(object sender, EventArgs e)
        {
            if (Aut_Form.Login == "")
            {
                Aut_Form authForm = new Aut_Form();
                authForm.ShowDialog();
            }

            else
            {
                Aut_Form.Login = "";
            }

            if (Aut_Form.Login == "")
            {
                Aut_Button.Text = "Вход";
                Hello_label.Visible = false;
            }
            if (Aut_Form.Login != "")
            {
                Aut_Button.Text = "Выйти";
                Hello_label.Visible = true;
                Hello_label.Text = "Хихихиха" + Aut_Form.Login;
            }
        }

        private void Reg_Button_Click(object sender, EventArgs e)
        {
            Reg_Form reg = new Reg_Form();
            reg.ShowDialog();
        }

        private void FiltrButton_Click(object sender, EventArgs e)
        {
            if(Filtrpanel.Size.Height > FiltrButton.Size.Height)
            {
                Filtrpanel.Size.Height > FiltrButton.Size.Height;
            }
            else
            {
                Filtrpanel.Size.Height = 94;
            }
        }
    }
}
