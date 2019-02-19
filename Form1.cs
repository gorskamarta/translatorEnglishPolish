using System;
using System.Windows.Forms;

namespace translatorEnglishPolish
{
    public partial class MainFormTranslator : Form
    {
        Translator translator = new Translator();
        int tryb = 1;

        public MainFormTranslator()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string toTranslate = textBox1.Text;
            string interpretation = translator.translate(toTranslate, tryb);
            if (interpretation == "404")
            {
                string message = "Nie można znaleźć tłumaczenia";
                MessageBox.Show(message);
                textBox2.Text = "";
            }
            else
            {
                textBox2.Text = interpretation;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (tryb == 0)
            {
                label2.Text = "Angielski";
                label3.Text = "Polski";
                tryb = 1;
                Refresh();
            } else
            {
                label2.Text = "Polski";
                label3.Text = "Angielski";
                tryb = 0;
                Refresh();
            }
            textBox1.Text = "";
            textBox2.Text = "";


        }
    }
}
