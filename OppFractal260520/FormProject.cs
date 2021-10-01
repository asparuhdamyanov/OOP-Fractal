using System;
using System.Windows.Forms;

using System.Drawing;
using OppFractalClassLibrary;

namespace OOPFractal
{
    public partial class FormProject : Form
    {
        public int tPoly;

        public FormProject()
        {
            InitializeComponent();

        }
        private void button4_Click(object sender, EventArgs e)
        {
          
            double SumArea;
            double R;
            float XX, YY;
            int dim;
            int SumPer;
            SumPer = 0;
            SumArea = 0;
            System.Drawing.Graphics formGraphics;
            formGraphics = this.CreateGraphics();
            SumArea = 0;
         //създаване на 3 инстанции на фигури

            RegPolygon[] scribble = new RegPolygon[3];
            scribble[0] = new Triangle_new(0, 400,650,3);
            scribble[1] = new Carpet_new(350,400,150,4);
            scribble[2] = new Pentagon_new(650, 400, 170, 5);

            // полиморфизъм
            //намиране на сумата от лицата и периметрите на фигурите от списъка
            for (int i = 0; i < scribble.Length; i++)
            {
                SumArea = SumArea + scribble[i].Area();
                SumPer = SumPer + scribble[i].Perimetar();

            }
            textBox3.Text = SumArea.ToString();
            textBox4.Text = SumPer.ToString();

            //изчертаване на фигурите от списъка

            scribble[0].DrawFigures(formGraphics, "Red");
            scribble[1].DrawFigures(formGraphics, "Blue");
            scribble[2].DrawFigures(formGraphics, "GreenYellow");

        }

        private void FormProject_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tPoly = 3;
            FormSceneProperties form2 = new FormSceneProperties(tPoly);
           
                      form2.ShowDialog();

        }
        private void button2_Click(object sender, EventArgs e)
        {
            tPoly = 4;
            FormSceneProperties form2 = new FormSceneProperties(tPoly);
            form2.ShowDialog();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            tPoly = 5;
            FormSceneProperties form2 = new FormSceneProperties(tPoly);

            form2.ShowDialog();
        }

    }
}
