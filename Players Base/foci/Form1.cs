using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace foci
{
    public partial class Form1 : Form
    {
        DataClasses1DataContext db = new DataClasses1DataContext();

        public Form1()
        {
            InitializeComponent();

            csapatBindingSource.DataSource = db.Csapats;
            focistakBindingSource.DataSource = db.Focistaks;
            posztBindingSource.DataSource = db.Poszts;
            BackgroundImage = Image.FromFile("stamford0.png"); //háttér beállítása

            {
                /*var FD = new System.Windows.Forms.OpenFileDialog();
                FD.Filter = "png files|*.png";
                if (FD.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    string fileToOpen = FD.FileName;

                    System.IO.FileInfo File = new System.IO.FileInfo(FD.FileName);
                    BackgroundImage = Image.FromFile("stamford.png"); /*Image.FromFile(FD.FileName);
                }*/ /*

                OpenFileDialog openDialog = new OpenFileDialog();
                if (openDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    Graphics graphics = this.CreateGraphics();
                    Image image = Image.FromFile("a.png");
                    graphics.DrawImage(image, new Point(0, 0));
                }*/
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           /* Csapat cs = (Csapat)csapatBindingSource.Current;
            if (cs.Liga != null)                                     //liganév bekötése manuálisan
            {
                label1.Text = cs.Liga.LigaNév.ToString();
            }  */ 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            focistaksDataGridView.EndEdit();
            focistaksBindingSource.EndEdit(); //Ha benne állok egy sorban is menti
            csapatBindingSource.EndEdit();


            db.SubmitChanges();
           // csapatBindingSource.DataSource = db.Csapats;
            focistakBindingSource.DataSource = db.Focistaks;
            MessageBox.Show("Mentve");
        }

     

        private void focistaksDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
           /* focistaksDataGridView.BackgroundColor = Color.FromArgb(0, 0, 0, 0);*/
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           // listBox1.BackColor = Color.Red;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Csapat cs1 = new Csapat();
            cs1.CsapatNév = textBox1.Text;
            cs1.Ország = textBox2.Text;
            cs1.Monogram = textBox4.Text;
            csapatBindingSource.Add(cs1);
          //  db.Csapats.InsertOnSubmit(cs1);
          //  db.SubmitChanges();
            
            

        }

     

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Biztos be akarod zárni?","Bezárás",MessageBoxButtons.YesNo) == DialogResult.No)
            {
                e.Cancel = true;
               
            }
            // Application.Exit();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.Show();
            //this.Close();
            this.Hide();
            
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_MouseEnter(object sender, EventArgs e)
        {
            button4.BackColor = Color.Yellow;
        }

        private void button4_MouseLeave(object sender, EventArgs e)
        {
            button4.BackColor = Color.Silver;
        }

        private void button3_MouseEnter(object sender, EventArgs e)
        {
            button3.BackColor = Color.Yellow;
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            button3.BackColor = Color.Silver;
            
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.Silver;
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.BackColor = Color.Yellow;
        }

       
        private void textBox4_Validating(object sender, CancelEventArgs e)
        {
            string strRegex = "^[A-Za-z]{3}$";

            Regex re = new Regex(strRegex);
            if (re.IsMatch(textBox4.Text))
            {
                textBox4.BackColor = Color.LightGreen;
                e.Cancel = false;
            }
            else
            {
                textBox4.BackColor = Color.OrangeRed;
               // MessageBox.Show("Adj meg 3 Betűt a csapat rövidítéséhez");
                e.Cancel = true;
            }
        }

      
    }
}
