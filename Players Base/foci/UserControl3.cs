using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace foci
{
    public partial class UserControl3 : UserControl
    {
        DataClasses1DataContext db = new DataClasses1DataContext();

        public UserControl3()
        {
            InitializeComponent();
            focistakBindingSource.DataSource = db.Focistaks;
            Keres();

        }

        private void UserControl3_Load(object sender, EventArgs e)
        {
            BackColor = Color.FromArgb(50, 50, 50, 0);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Keres();
        }

        private void Keres()
        {
            var foc = from s in db.Focistaks where s.Név.StartsWith(textBox1.Text) select s;



            listBox1.DisplayMember = "Név";
            listBox1.ValueMember = "FocistaID";
            listBox1.DataSource = foc;

            listBox2.DisplayMember = "SPE";
            listBox2.ValueMember = "FocistaID";
            listBox2.DataSource = foc;

            listBox3.DisplayMember = "SHO";
            listBox3.ValueMember = "FocistaID";
            listBox3.DataSource = foc;

            listBox4.DisplayMember = "PAS";
            listBox4.ValueMember = "FocistaID";
            listBox4.DataSource = foc;

            listBox5.DisplayMember = "DRI";
            listBox5.ValueMember = "FocistaID";
            listBox5.DataSource = foc;

            listBox6.DisplayMember = "DEF";
            listBox6.ValueMember = "FocistaID";
            listBox6.DataSource = foc;

            listBox7.DisplayMember = "PHY";
            listBox7.ValueMember = "FocistaID";
            listBox7.DataSource = foc;

            
            
        }


        

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            

            try
            {
                string text = listBox1.GetItemText(listBox1.SelectedItem);
                //MessageBox.Show(text);
                panel1.BackgroundImage = Image.FromFile(string.Format("fut/{0}.png", text));
                panel1.BackgroundImageLayout = ImageLayout.Center;
            }
            catch (Exception)
            {
                panel1.BackgroundImage = Image.FromFile(string.Format("fut/empty.png"));
                panel1.BackgroundImageLayout = ImageLayout.Center;
                
            }
        }

       
    }
}
