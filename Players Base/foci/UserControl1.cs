using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace foci
{
    public partial class UserControl1 : UserControl
    {
        DataClasses1DataContext db = new DataClasses1DataContext();
        public UserControl1()
        {
            InitializeComponent();
            focistakBindingSource.DataSource = db.Focistaks;
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {
            BackColor = Color.FromArgb(50, 50, 50, 0);
        }

        private void focistakBindingSource_CurrentChanged(object sender, EventArgs e)
        {
           

            
        }

        private void LoadButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            if (sfd.ShowDialog()== DialogResult.OK) 
            {
                StreamWriter sw = new StreamWriter(sfd.FileName,false,Encoding.Unicode);
                foreach (var item in db.Focistaks)
                {
                    sw.WriteLine(string.Format("Név: {0}, Születési dátum:{1}, Sebesség:{2}; Lövés:{3}; Passzolás:{4}; Pörgetés:{5}; Védekezés:{6}; Fizikai{7}; ", item.Név,item.SzulDat,item.SPE,item.SHO,item.PAS,item.DRI,item.DEF,item.PHY));
                }

            

                sw.Close();
            }
        }

        private void BetoltesButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog()==DialogResult.OK)
            {
                StreamReader sr = new StreamReader(ofd.FileName);

                while (!sr.EndOfStream)
                {
                    string[] st = sr.ReadLine().Split(';');
                    Focistak f = new Focistak();
                    f.Név = st[0];
                    f.SzulDat = Convert.ToDateTime(st[1]);
                    f.SPE = Convert.ToInt32(st[2]);
                    f.SHO = Convert.ToInt32(st[3]);
                    f.PAS = Convert.ToInt32(st[4]);
                    f.DRI = Convert.ToInt32(st[5]);
                    f.DEF = Convert.ToInt32(st[6]);
                    f.PHY = Convert.ToInt32(st[7]);
                    db.Focistaks.InsertOnSubmit(f);

                }
                sr.Close();
                db.SubmitChanges();
            }
        }
    }
}
