using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace OOPFractal
{
    public partial class FormSceneProperties: Form
    {
     
        private string Colorone;
        private string Colortow;

        //конструктор без параметри/
        public FormSceneProperties()
        {
        }
        public FormSceneProperties(int tPoly)
        {
            InitializeComponent();

            Colorone = textBox8.BackColor.Name;
            Colortow = textBox9.BackColor.Name;
            if (Colorone.StartsWith("f") == true)
            {
                Colorone = "7" + Colorone.Remove(0, 1);

            }
            if (Colortow.StartsWith("f") == true)
            {
                Colortow = "7" + Colortow.Remove(0, 1);

            }

            textBox5.Text = tPoly.ToString();

            if (tPoly == 3)
            {
                textBox6.Text = "Триъгълник";

            }
            if (tPoly == 4)
            {
                textBox6.Text = "Квадрат";

            }
            if (tPoly == 5)
            {
                textBox6.Text = "Петоъгълник";

            }

        }
        private void button1_Click(object sender, EventArgs e)
        {



            FormSceneFractal form2 = new FormSceneFractal(Convert.ToInt32(textBox5.Text), Convert.ToInt32(textBox3.Text), Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text), Convert.ToInt32(textBox4.Text), Convert.ToInt32(textBox7.Text), Colorone, Colortow);


            form2.ShowDialog();
        }
        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void FormSceneProperties_Load(object sender, EventArgs e)
        {

        }

        private void FormSceneProperties_Load_1(object sender, EventArgs e)
        {

        }
        private void button2_Click(object sender, System.EventArgs e)
        {
            ColorDialog MyDialog = new ColorDialog();
            MyDialog.AllowFullOpen = false;
            MyDialog.ShowHelp = true;

            if (MyDialog.ShowDialog() == DialogResult.OK)
                textBox8.BackColor = MyDialog.Color;

            Colorone = MyDialog.Color.Name;
            if (Colorone.StartsWith("f") == true)
            {
                Colorone = "7" + Colorone.Remove(0, 1);

            }


        }
        private void button3_Click(object sender, System.EventArgs e)
        {
            ColorDialog MyDialog = new ColorDialog();
            MyDialog.AllowFullOpen = false;
            MyDialog.ShowHelp = true;

            if (MyDialog.ShowDialog() == DialogResult.OK)
                textBox9.BackColor = MyDialog.Color;

            Colortow = MyDialog.Color.Name;
            if (Colortow.StartsWith("f") == true)
            {
                Colortow = "7" + Colortow.Remove(0, 1);

            }

        }
    }
}
