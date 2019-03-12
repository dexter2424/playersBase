using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace foci
{
    public partial class Form2 : Form
    {
        int novel = 3;

        public Form2()
        {
            InitializeComponent();
            BackgroundImage = Image.FromFile("camp1.jpg");
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            UserControl1 uc = new UserControl1();
            this.panel1.Controls.Add(uc);
            uc.Dock = DockStyle.Fill;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            UserControl2 uc = new UserControl2();
            this.panel1.Controls.Add(uc);
            uc.Dock = DockStyle.Fill;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            UserControl3 uc = new UserControl3();
            this.panel1.Controls.Add(uc);
            uc.Dock = DockStyle.Fill;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Close();
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            novel = novel + 1;
            panel1.BackgroundImage = Image.FromFile(string.Format("id{0}.png",novel));
            panel1.BackgroundImageLayout = ImageLayout.Center;
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
           // Application.Exit();
           /* {
                if (MessageBox.Show("Biztos be akarod zárni?", "Bezárás", MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    
                    e.Cancel = true;
                    

                }
                
            }*/
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
