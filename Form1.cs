using System;
using System.Windows.Forms;

namespace translatorEnglishPolish
{
    public partial class MainFormTranslator : Form
    {
        Translator translator = new Translator();

        public MainFormTranslator()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            string toTranslate = textBoxEnglish.Text;
            string interpretation = translator.translate(toTranslate);
            if (interpretation == "404")
            {
                string message = "Nie można znaleźć tłumaczenia";
                MessageBox.Show(message);
                textBoxPolish.Text = "";
            }
            else
            {
                textBoxPolish.Text = interpretation;
            }
        }
    }
}
