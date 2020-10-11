using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private Button[,] buttons = new Button[3, 3];
        private int player;
        public Form1()
        {
            InitializeComponent();
            this.Height = 650;
            this.Width = 500;
            player = 1;          
            for (int i = 0; i < buttons.Length / 3; i++)
            {
                for (int j = 0; j < buttons.Length / 3; j++)
                {
                    buttons[i, j] = new Button();
                    buttons[i, j].Size = new Size(150, 150);
                }
            }
            setButtons();

        }

        const int N = 3;
        const int Y = 3;

        private void setButtons()
        {
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < Y; j++)
                {
                    buttons[i, j].Location = new Point(12 + 157 * j, 12 + 157 * i);
                    buttons[i, j].Click += button1_Click;
                    buttons[i, j].Font = new Font(new FontFamily("Microsoft Sans Serif"), 100);
                    buttons[i, j].Text = "";
                    this.Controls.Add(buttons[i, j]);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {                                  
                    sender.GetType().GetProperty("Text").SetValue(sender, "x");
                    player = 0;
            if (radioButton1.Checked) { diff_easy(); }
            if (radioButton2.Checked) { diff_medium(); }
            if (radioButton3.Checked) { diff_hard(); }            
            player = 1;                                                  
            sender.GetType().GetProperty("Enabled").SetValue(sender, false);
            checkWin();
        }

        private void diff_easy()
        {
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < Y; j++)
                {
                    if (buttons[i, j].Text == "")
                    {
                        buttons[i, j].Text = "o";
                        buttons[i, j].Enabled = false;
                        player = 0;
                        return;
                    }                  
                }
            }
        }

        private void diff_check(Button a, Button b, Button c)
        {
            if(a.Text == "x" && b.Text == "x")
            {
                c.Text = "o";
                c.Enabled = false;
            }
        }

        private void diff_medium()
        {
            // По горизонталі 

            if (buttons[0, 0].Text == "x" && buttons[0, 1].Text == "x" && buttons[0, 2].Text == "")
            {                
                buttons[0, 2].Text = "o";
                buttons[0, 2].Enabled = false;
            }

            else if (buttons[1, 0].Text == "x" && buttons[1, 1].Text == "x" && buttons[1, 2].Text == "")
            {
                buttons[1, 2].Text = "o";
                buttons[1, 2].Enabled = false;
            }

            else if(buttons[2, 0].Text == "x" && buttons[2, 1].Text == "x" && buttons[2, 2].Text == "")
            {
                buttons[2, 2].Text = "o";
                buttons[2, 2].Enabled = false;
            }

            else if(buttons[0, 1].Text == "x" && buttons[0, 2].Text == "x" && buttons[0, 0].Text == "")
            {
                buttons[0, 0].Text = "o";
                buttons[0, 0].Enabled = false;
            }

            else if(buttons[1, 1].Text == "x" && buttons[1, 2].Text == "x" && buttons[1, 0].Text == "")
            {
                buttons[1, 0].Text = "o";
                buttons[1, 0].Enabled = false;
            }

            else if(buttons[2, 1].Text == "x" && buttons[2, 2].Text == "x" && buttons[2, 0].Text == "")
            {
                buttons[2, 0].Text = "o";
                buttons[2, 0].Enabled = false;
            }

            // По вертиклаі

            else if(buttons[0, 0].Text == "x" && buttons[1, 0].Text == "x" && buttons[2, 0].Text == "")
            {
                buttons[2, 0].Text = "o";
                buttons[2, 0].Enabled = false;
            }

            else if(buttons[0, 1].Text == "x" && buttons[1, 1].Text == "x" && buttons[2, 1].Text == "")
            {
                buttons[2, 1].Text = "o";
                buttons[2, 1].Enabled = false;
            }

            else if(buttons[0, 2].Text == "x" && buttons[1, 2].Text == "x" && buttons[2, 2].Text == "")
            {
                buttons[2, 2].Text = "o";
                buttons[2, 2].Enabled = false;
            }

            else if(buttons[1, 0].Text == "x" && buttons[2, 0].Text == "x" && buttons[0, 0].Text == "")
            {
                buttons[0, 0].Text = "o";
                buttons[0, 0].Enabled = false;
            }

            else if(buttons[2, 1].Text == "x" && buttons[1, 1].Text == "x" && buttons[0, 1].Text == "")
            {
                buttons[0, 1].Text = "o";
                buttons[0, 1].Enabled = false;
            }

            else if(buttons[1, 2].Text == "x" && buttons[2, 2].Text == "x" && buttons[0, 2].Text == "")
            {
                buttons[0, 2].Text = "o";
                buttons[0, 2].Enabled = false;
            }

            // По діагоналі

            else if(buttons[2, 0].Text == "x" && buttons[1, 1].Text == "x" && buttons[0, 2].Text == "")
            {
                buttons[0, 2].Text = "o";
                buttons[0, 2].Enabled = false;
            }

            else if(buttons[0, 2].Text == "x" && buttons[1, 1].Text == "x" && buttons[2, 0].Text == "")
            {
                buttons[2, 0].Text = "o";
                buttons[2, 0].Enabled = false;
            }

            else if(buttons[2, 2].Text == "x" && buttons[1, 1].Text == "x" && buttons[0, 0].Text == "")
            {
                buttons[0, 0].Text = "o";
                buttons[0, 0].Enabled = false;
            }

            else if(buttons[0, 0].Text == "x" && buttons[1, 1].Text == "x" && buttons[2, 2].Text == "")
            {
                buttons[2, 2].Text = "o";
                buttons[2, 2].Enabled = false;
            }

            // По бокам горизонаталі

            else if(buttons[0, 0].Text == "x" && buttons[0, 2].Text == "x" && buttons[0, 1].Text == "")
            {
                buttons[0, 1].Text = "o";
                buttons[0, 1].Enabled = false;
            }

            else if(buttons[1, 0].Text == "x" && buttons[1, 2].Text == "x" && buttons[1, 1].Text == "")
            {
                buttons[1, 1].Text = "o";
                buttons[1, 1].Enabled = false;
            }

            else if(buttons[2, 0].Text == "x" && buttons[2, 2].Text == "x" && buttons[2, 1].Text == "")
            {
                buttons[2, 1].Text = "o";
                buttons[2, 1].Enabled = false;
            }

            // По бокам вертикалі

            else if(buttons[0, 0].Text == "x" && buttons[2, 0].Text == "x" && buttons[1, 0].Text == "")
            {
                buttons[1, 0].Text = "o";
                buttons[1, 0].Enabled = false;
            }

            else if(buttons[0, 1].Text == "x" && buttons[2, 1].Text == "x" && buttons[1, 1].Text == "")
            {
                buttons[1, 1].Text = "o";
                buttons[1, 1].Enabled = false;
            }

            else if(buttons[0, 2].Text == "x" && buttons[2, 2].Text == "x" && buttons[1, 2].Text == "")
            {
                buttons[1, 2].Text = "o";
                buttons[1, 2].Enabled = false;
            }

            // По бокам діагоналі

            else if(buttons[0, 0].Text == "x" && buttons[2, 2].Text == "x" && buttons[1, 1].Text == "")
            {
                buttons[1, 1].Text = "o";
                buttons[1, 1].Enabled = false;
            }

            else if(buttons[0, 2].Text == "x" && buttons[2, 0].Text == "x" && buttons[1, 1].Text == "")
            {
                buttons[1, 1].Text = "o";
                buttons[1, 1].Enabled = false;
            }

            else diff_easy();
        }

        private void diff_hard()
        {
            if (buttons[1, 1].Text == "")
            {
                buttons[1, 1].Text = "o";
                buttons[1, 1].Enabled = false;

            }

            else if (buttons[0, 0].Text == "o" && buttons[0, 1].Text == "o" && buttons[0, 2].Text == "")
            {                
                buttons[0, 2].Text = "o";
                buttons[0, 2].Enabled = false;
            }

            else if (buttons[1, 0].Text == "o" && buttons[1, 1].Text == "o" && buttons[1, 2].Text == "")
            {
                buttons[1, 2].Text = "o";
                buttons[1, 2].Enabled = false;
            }

            else if(buttons[2, 0].Text == "o" && buttons[2, 1].Text == "o" && buttons[2, 2].Text == "")
            {
                buttons[2, 2].Text = "o";
                buttons[2, 2].Enabled = false;
            }

            else if(buttons[0, 1].Text == "o" && buttons[0, 2].Text == "o" && buttons[0, 0].Text == "")
            {
                buttons[0, 0].Text = "o";
                buttons[0, 0].Enabled = false;
            }

            else if(buttons[1, 1].Text == "o" && buttons[1, 2].Text == "o" && buttons[1, 0].Text == "")
            {
                buttons[1, 0].Text = "o";
                buttons[1, 0].Enabled = false;
            }

            else if(buttons[2, 1].Text == "o" && buttons[2, 2].Text == "o" && buttons[2, 0].Text == "")
            {
                buttons[2, 0].Text = "o";
                buttons[2, 0].Enabled = false;
            }

            // По вертиклаі

            else if(buttons[0, 0].Text == "o" && buttons[1, 0].Text == "o" && buttons[2, 0].Text == "")
            {
                buttons[2, 0].Text = "o";
                buttons[2, 0].Enabled = false;
            }

            else if(buttons[0, 1].Text == "o" && buttons[1, 1].Text == "o" && buttons[2, 1].Text == "")
            {
                buttons[2, 1].Text = "o";
                buttons[2, 1].Enabled = false;
            }

            else if(buttons[0, 2].Text == "o" && buttons[1, 2].Text == "o" && buttons[2, 2].Text == "")
            {
                buttons[2, 2].Text = "o";
                buttons[2, 2].Enabled = false;
            }

            else if(buttons[1, 0].Text == "o" && buttons[2, 0].Text == "o" && buttons[0, 0].Text == "")
            {
                buttons[0, 0].Text = "o";
                buttons[0, 0].Enabled = false;
            }

            else if(buttons[2, 1].Text == "o" && buttons[1, 1].Text == "o" && buttons[0, 1].Text == "")
            {
                buttons[0, 1].Text = "o";
                buttons[0, 1].Enabled = false;
            }

            else if(buttons[1, 2].Text == "o" && buttons[2, 2].Text == "o" && buttons[0, 2].Text == "")
            {
                buttons[0, 2].Text = "o";
                buttons[0, 2].Enabled = false;
            }

            // По діагоналі

            else if(buttons[2, 0].Text == "o" && buttons[1, 1].Text == "o" && buttons[0, 2].Text == "")
            {
                buttons[0, 2].Text = "o";
                buttons[0, 2].Enabled = false;
            }

            else if(buttons[0, 2].Text == "o" && buttons[1, 1].Text == "o" && buttons[2, 0].Text == "")
            {
                buttons[2, 0].Text = "o";
                buttons[2, 0].Enabled = false;
            }

            else if(buttons[2, 2].Text == "o" && buttons[1, 1].Text == "o" && buttons[0, 0].Text == "")
            {
                buttons[0, 0].Text = "o";
                buttons[0, 0].Enabled = false;
            }

            else if(buttons[0, 0].Text == "o" && buttons[1, 1].Text == "o" && buttons[2, 2].Text == "")
            {
                buttons[2, 2].Text = "o";
                buttons[2, 2].Enabled = false;
            }

            // По бокам горизонаталі

            else if(buttons[0, 0].Text == "o" && buttons[0, 2].Text == "o" && buttons[0, 1].Text == "")
            {
                buttons[0, 1].Text = "o";
                buttons[0, 1].Enabled = false;
            }

            else if(buttons[1, 0].Text == "o" && buttons[1, 2].Text == "o" && buttons[1, 1].Text == "")
            {
                buttons[1, 1].Text = "o";
                buttons[1, 1].Enabled = false;
            }

            else if(buttons[2, 0].Text == "o" && buttons[2, 2].Text == "o" && buttons[2, 1].Text == "")
            {
                buttons[2, 1].Text = "o";
                buttons[2, 1].Enabled = false;
            }

            // По бокам вертикалі

            else if(buttons[0, 0].Text == "o" && buttons[2, 0].Text == "o" && buttons[1, 0].Text == "")
            {
                buttons[1, 0].Text = "o";
                buttons[1, 0].Enabled = false;
            }

            else if(buttons[0, 1].Text == "o" && buttons[2, 1].Text == "o" && buttons[1, 1].Text == "")
            {
                buttons[1, 1].Text = "o";
                buttons[1, 1].Enabled = false;
            }

            else if(buttons[0, 2].Text == "o" && buttons[2, 2].Text == "o" && buttons[1, 2].Text == "")
            {
                buttons[1, 2].Text = "o";
                buttons[1, 2].Enabled = false;
            }

            // По бокам діагоналі

            else if(buttons[0, 0].Text == "o" && buttons[2, 2].Text == "o" && buttons[1, 1].Text == "")
            {
                buttons[1, 1].Text = "o";
                buttons[1, 1].Enabled = false;
            }

            else if(buttons[0, 2].Text == "o" && buttons[2, 0].Text == "o" && buttons[1, 1].Text == "")
            {
                buttons[1, 1].Text = "o";
                buttons[1, 1].Enabled = false;
            }

            else diff_medium();           
        }

        private void checkWin()
        {

            if (buttons[0, 0].Text == buttons[0, 1].Text && buttons[0, 1].Text == buttons[0, 2].Text)
            {

                if (buttons[0, 0].Text != "")
                {
                    MessageBox.Show("Someone Win!");
                    return;
                }
            }
            if (buttons[1, 0].Text == buttons[1, 1].Text && buttons[1, 1].Text == buttons[1, 2].Text)
            {
                if (buttons[1, 0].Text != "")
                    MessageBox.Show("Someone Win!");
            }
            if (buttons[2, 0].Text == buttons[2, 1].Text && buttons[2, 1].Text == buttons[2, 2].Text)
            {
                if (buttons[2, 0].Text != "")
                    MessageBox.Show("Someone Win!");
            }
            if (buttons[0, 0].Text == buttons[1, 0].Text && buttons[1, 0].Text == buttons[2, 0].Text)
            {
                if (buttons[0, 0].Text != "")
                    MessageBox.Show("Someone Win!");
            }
            if (buttons[0, 1].Text == buttons[1, 1].Text && buttons[1, 1].Text == buttons[2, 1].Text)
            {
                if (buttons[0, 1].Text != "")
                    MessageBox.Show("Someone Win!!");
            }
            if (buttons[0, 2].Text == buttons[1, 2].Text && buttons[1, 2].Text == buttons[2, 2].Text)
            {
                if (buttons[0, 2].Text != "")
                    MessageBox.Show("Someone Win!!");
            }
            if (buttons[0, 0].Text == buttons[1, 1].Text && buttons[1, 1].Text == buttons[2, 2].Text)
            {
                if (buttons[0, 0].Text != "")
                    MessageBox.Show("Someone Win!");
            }
            if (buttons[2, 0].Text == buttons[1, 1].Text && buttons[1, 1].Text == buttons[0, 2].Text)
            {
                if (buttons[2, 0].Text != "")
                    MessageBox.Show("Someone Win!");
            }
        }


        private void button10_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    buttons[i, j].Text = "";
                    buttons[i, j].Enabled = true;
                }
            }
        }
    }
}