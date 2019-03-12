using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Speech.Recognition;


namespace foci
{
    public partial class UserControl2 : UserControl
    {
        SpeechRecognitionEngine hangvezerles = new SpeechRecognitionEngine();
        DataClasses1DataContext db = new DataClasses1DataContext();
        string szo;
        string elotag;

        public UserControl2()
        {
            InitializeComponent();
            focistakBindingSource.DataSource = db.Focistaks;
            


        }

        private void UserControl2_Load(object sender, EventArgs e)
        {
            BackColor = Color.FromArgb(50, 50, 50, 0);
            Choices parancs = new Choices();
            parancs.Add(new string[] { "say hello", "David Luiz", "Gary Cahill", "Harry Kane", "Eden Hazard", "Diego Costa", "Marco Reus",
                "Do you like football?", "What is your name?", "Who is your favourite player?", "Who will win the champions league?",
            "Who is the Chelsea's coach?","Antonio Conte"});
            GrammarBuilder g = new GrammarBuilder();
            g.Append(parancs);
            Grammar grammar = new Grammar(g);

            hangvezerles.LoadGrammarAsync(grammar);
            hangvezerles.SetInputToDefaultAudioDevice();
            hangvezerles.SpeechRecognized += Hangvezerles_SpeechRecognized;
        }

        private void Hangvezerles_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            
            switch (e.Result.Text)
            {
                case "say hello": 
                    break;
                case "David Luiz":
                    szo = "David Luiz";               
                    break;
                case "Gary Cahill":
                    szo = "Gary Cahill";
                    break;
                case "Harry Kane":
                    szo = "Harry Kane";
                     break;
                case "Marco Reus":
                    szo = "Marco Reus";
                    break;
                case "Eden Hazard":
                    szo = "Eden Hazard";
                    break;
                case "Diego Costa":
                    szo = "Diego Costa";
                    break;
                case "Do you like football?":
                    szo = "Yes, I love it";
                    break;
                case "What is your name?":
                    szo = "My name is Players Base";
                    break;
                case "Who is your favourite player?":
                    elotag = "My favourite player is ";
                    szo = "Eden Hazard";
                    break;
                case "Who will win the champions league?":
                    szo = "I hope the Juventus";
                    break;
                case "Who is the Chelsea's coach?":
                    szo = "Antonio Conte";
                    break;



            }
            try
            {
                richTextBox1.Text += string.Format("\n{0} {1}",elotag, szo);
                panel1.BackgroundImage = Image.FromFile(string.Format("fut/{0}.png", szo));
                panel1.BackgroundImageLayout = ImageLayout.Center;
                elotag = "";
            }
            catch (Exception)
            {
                
            } 

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           /* try
            {
               // string text = listBox1.GetItemText(listBox1.SelectedItem);
                //MessageBox.Show(text);
                //panel1.BackgroundImage = Image.FromFile(string.Format("fut/{0}.png", text));
              //  panel1.BackgroundImageLayout = ImageLayout.Center;
            }
            catch (Exception)
            {
               // panel1.BackgroundImage = Image.FromFile(string.Format("fut/empty.png"));
               // panel1.BackgroundImageLayout = ImageLayout.Center;

            }*/
        }

        private void listBox1_Click(object sender, EventArgs e)
        {
            

            
        }

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            hangvezerles.RecognizeAsync(RecognizeMode.Multiple);
            button1.Enabled = false;
            richTextBox1.Text = "Most már beszélhetsz!";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            hangvezerles.RecognizeAsyncStop();
            button1.Enabled = true;
            richTextBox1.Text = "A hangfelismerés leállt";
        }
    }
}
