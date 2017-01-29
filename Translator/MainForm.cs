using System;
using System.Linq;
using System.Windows.Forms;

namespace Translator
{
    public partial class MainForm : Form
    {
        YandexTranslator yt;

        public MainForm()
        {
            InitializeComponent();

            yt = new YandexTranslator();

            cBoxTranslatDirect.Items.AddRange(yt.GetAlldirection().ToArray());

        }

        private void translateButton_Click(object sender, EventArgs e)
        {
            string lang;

            if (tabC.SelectedTab ==  tabPage1)
            {
                if (ruEnRadioButton.Checked == true)
                {
                    lang = "ru-en";
                }
                else
                {
                    lang = "en-ru";
                }
            }
            else
            {
                if (cBoxTranslatDirect.SelectedItem != null)
                {
                    string name = cBoxTranslatDirect.SelectedItem.ToString();
                    string nameKey = yt.nnn.FirstOrDefault(x => x.Value == name).Key;
                    lang = nameKey;
                }
                else
                {
                    MessageBox.Show("Необходимо выбрать направление для перевода!");
                    return;
                }       
            }  
            outputTextBox.Text = yt.Translate(inputTextBox.Text, lang);
        }
    }
}