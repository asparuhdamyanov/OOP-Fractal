using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;
using OppFractalClassLibrary;


namespace OOPFractal
{

    public partial class FormSceneFractal :FormSceneProperties
    {

        private int Level;
        private int Level1;
        private int Level2;
        //широчина и височона
        private int _width;
        private int _widthnew;
        private int _height;
        private int _width1;
        private int _width2;
        private int _width3;
        private int rot, rot1, rot2, rot3;
        private Bitmap _fractal;
        private Graphics _graph;
        private int X;
        private int Y;
        private int ts, ts11, ts22, ts71;
        private int cnn;
        private double Area1, Area2, Area3;
        private double Per1, Per2, Per3;
        public int CounyPictures;
        public string MyColorone;
        public string MyColortow;
        public string MyColorone1;
        public string MyColortow1;
        public string MyColorone2;
        public string MyColortow2;
        public string MyColorone3;
        public string MyColortow3;
        public string MyColoroneNew;
        public string MyColortowNew;
        public int MyFractal;
        public string MyString;
        public int CountPictures;
 

        public int tpoly;
      
        private PictureBox FracralpictureBox1;
        private PictureBox FractalpictureBox2;
        private PictureBox FractalpictureBox3;
        private PictureBox FractalpictureBox4;
        private TextBox textBox7;
        private Label label5;
        private TextBox textBox4;
        private Label label4;
        private TextBox textBox8;
        private TextBox textBox9;
        private Button button2;
        private Button button3;
        private ColorDialog colorDialog1;
        private ColorDialog colorDialog2;
        private TextBox textBox1;
        private Label label3;
        private Button button1;
        private Button button4;
        private FolderBrowserDialog folderBrowserDialog1;
        private OpenFileDialog openFileDialog1;
        private SaveFileDialog saveFileDialog1;
        private Button button5;
        private RichTextBox richTextBox1;
        private RichTextBox richTextBox2;
        private RichTextBox richTextBox3;
        private Label label1;
        private Label label2;
        private Label label6;
        private PictureBox FractalpictureBox5;

        private void InitializeComponent()
        {
            this.FracralpictureBox1 = new System.Windows.Forms.PictureBox();
            this.FractalpictureBox2 = new System.Windows.Forms.PictureBox();
            this.FractalpictureBox3 = new System.Windows.Forms.PictureBox();
            this.FractalpictureBox4 = new System.Windows.Forms.PictureBox();
            this.FractalpictureBox5 = new System.Windows.Forms.PictureBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.colorDialog2 = new System.Windows.Forms.ColorDialog();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.button5 = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.richTextBox3 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.FracralpictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FractalpictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FractalpictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FractalpictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FractalpictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // FracralpictureBox1
            // 
            this.FracralpictureBox1.BackColor = System.Drawing.SystemColors.Control;
            this.FracralpictureBox1.Location = new System.Drawing.Point(32, 310);
            this.FracralpictureBox1.Name = "FracralpictureBox1";
            this.FracralpictureBox1.Size = new System.Drawing.Size(160, 160);
            this.FracralpictureBox1.TabIndex = 0;
            this.FracralpictureBox1.TabStop = false;
            this.FracralpictureBox1.Click += new System.EventHandler(this.FractalpictureBox1_Click);
            this.FracralpictureBox1.DoubleClick += new System.EventHandler(this.FractalpictureBox1_DoubleClick);
            // 
            // FractalpictureBox2
            // 
            this.FractalpictureBox2.Location = new System.Drawing.Point(306, 310);
            this.FractalpictureBox2.Name = "FractalpictureBox2";
            this.FractalpictureBox2.Size = new System.Drawing.Size(160, 160);
            this.FractalpictureBox2.TabIndex = 1;
            this.FractalpictureBox2.TabStop = false;
            this.FractalpictureBox2.Click += new System.EventHandler(this.FractalpictureBox2_Click);
            this.FractalpictureBox2.DoubleClick += new System.EventHandler(this.FractalpictureBox2_DoubleClick);
            // 
            // FractalpictureBox3
            // 
            this.FractalpictureBox3.Location = new System.Drawing.Point(578, 310);
            this.FractalpictureBox3.Name = "FractalpictureBox3";
            this.FractalpictureBox3.Size = new System.Drawing.Size(160, 160);
            this.FractalpictureBox3.TabIndex = 2;
            this.FractalpictureBox3.TabStop = false;
            this.FractalpictureBox3.Click += new System.EventHandler(this.FractalpictureBox3_Click);
            this.FractalpictureBox3.DoubleClick += new System.EventHandler(this.FractalpictureBox3_DoubleClick);
            // 
            // FractalpictureBox4
            // 
            this.FractalpictureBox4.Location = new System.Drawing.Point(1095, 310);
            this.FractalpictureBox4.Name = "FractalpictureBox4";
            this.FractalpictureBox4.Size = new System.Drawing.Size(160, 160);
            this.FractalpictureBox4.TabIndex = 3;
            this.FractalpictureBox4.TabStop = false;
            // 
            // FractalpictureBox5
            // 
            this.FractalpictureBox5.Location = new System.Drawing.Point(1273, 310);
            this.FractalpictureBox5.Name = "FractalpictureBox5";
            this.FractalpictureBox5.Size = new System.Drawing.Size(160, 160);
            this.FractalpictureBox5.TabIndex = 4;
            this.FractalpictureBox5.TabStop = false;
            // 
            // textBox7
            // 
            this.textBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox7.Location = new System.Drawing.Point(415, 73);
            this.textBox7.Margin = new System.Windows.Forms.Padding(4);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(70, 23);
            this.textBox7.TabIndex = 20;
            this.textBox7.Text = "\r\n160";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(287, 75);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 17);
            this.label5.TabIndex = 22;
            this.label5.Text = "Размер";
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox4.Location = new System.Drawing.Point(415, 109);
            this.textBox4.Margin = new System.Windows.Forms.Padding(4);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(70, 23);
            this.textBox4.TabIndex = 23;
            this.textBox4.Text = "5";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(287, 115);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 17);
            this.label4.TabIndex = 24;
            this.label4.Text = "Брой итерации";
            // 
            // textBox8
            // 
            this.textBox8.BackColor = System.Drawing.Color.Red;
            this.textBox8.Location = new System.Drawing.Point(724, 71);
            this.textBox8.Margin = new System.Windows.Forms.Padding(4);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(56, 20);
            this.textBox8.TabIndex = 25;
            // 
            // textBox9
            // 
            this.textBox9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.textBox9.Location = new System.Drawing.Point(724, 118);
            this.textBox9.Margin = new System.Windows.Forms.Padding(4);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(56, 20);
            this.textBox9.TabIndex = 26;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(550, 69);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(136, 23);
            this.button2.TabIndex = 27;
            this.button2.Text = "Основен цвят";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(550, 115);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(136, 23);
            this.button3.TabIndex = 28;
            this.button3.Text = "Втори цвят";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // colorDialog1
            // 
            this.colorDialog1.Color = System.Drawing.Color.Red;
            this.colorDialog1.FullOpen = true;
            this.colorDialog1.ShowHelp = true;
            this.colorDialog1.SolidColorOnly = true;
            // 
            // colorDialog2
            // 
            this.colorDialog2.Color = System.Drawing.Color.Red;
            this.colorDialog2.FullOpen = true;
            this.colorDialog2.ShowHelp = true;
            this.colorDialog2.SolidColorOnly = true;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(616, 27);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(70, 23);
            this.textBox1.TabIndex = 29;
            this.textBox1.Text = "\r\n160";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(485, 30);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 17);
            this.label3.TabIndex = 30;
            this.label3.Text = "Брой фрактали";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(843, 90);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 23);
            this.button1.TabIndex = 31;
            this.button1.Text = "Генериране";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(997, 54);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(113, 37);
            this.button4.TabIndex = 32;
            this.button4.Text = "Зареждане от файл";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "c1";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(997, 102);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(113, 37);
            this.button5.TabIndex = 33;
            this.button5.Text = "Серилизация";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.mnuFileSave_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(379, 184);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(177, 36);
            this.richTextBox1.TabIndex = 34;
            this.richTextBox1.Text = "";
            this.richTextBox1.Click += new System.EventHandler(this.FilterLinq);
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(633, 184);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(177, 36);
            this.richTextBox2.TabIndex = 36;
            this.richTextBox2.Text = "";
            this.richTextBox2.Click += new System.EventHandler(this.FilterRed);
            // 
            // richTextBox3
            // 
            this.richTextBox3.Location = new System.Drawing.Point(843, 184);
            this.richTextBox3.Name = "richTextBox3";
            this.richTextBox3.Size = new System.Drawing.Size(314, 63);
            this.richTextBox3.TabIndex = 37;
            this.richTextBox3.Text = "";
            this.richTextBox3.Click += new System.EventHandler(this.FilterArea);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(376, 152);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 17);
            this.label1.TabIndex = 39;
            this.label1.Text = "Програмно генерирани ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(666, 152);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 17);
            this.label2.TabIndex = 40;
            this.label2.Text = "Червени";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(940, 152);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(153, 17);
            this.label6.TabIndex = 41;
            this.label6.Text = "Сортиране по лица";
            // 
            // FormSceneFractal
            // 
            this.ClientSize = new System.Drawing.Size(1509, 532);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBox3);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.FractalpictureBox5);
            this.Controls.Add(this.FractalpictureBox4);
            this.Controls.Add(this.FractalpictureBox3);
            this.Controls.Add(this.FractalpictureBox2);
            this.Controls.Add(this.FracralpictureBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name = "FormSceneFractal";
            ((System.ComponentModel.ISupportInitialize)(this.FracralpictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FractalpictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FractalpictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FractalpictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FractalpictureBox5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        public const double pi = 3.14;

        //конструктор без параметри/
        public FormSceneFractal()
        {
        }
        public FormSceneFractal(int tpoly, int cn, int ts1, int ts2, int ts4, int ts7, string colorone, string colortow)
        {
            InitializeComponent();

            MyColorone = MyColorone1 = MyColorone2 = MyColorone3 = MyColoroneNew = colorone;
            MyColortow = MyColortow1 = MyColortow2 = MyColortow3 = MyColortowNew = colortow;
            ts11 = ts1;
            ts71 = ts7;
            ts22 = ts2;
            MyFractal = 0;
            MyString = "";
            CountPictures = 0;
            //  this.FracralpictureBox1.Location = new System.Drawing.Point(0, 65);

            this.FracralpictureBox1.Location = new System.Drawing.Point(ts1, ts2);
            this.FracralpictureBox1.Size = new System.Drawing.Size(ts7, ts7);

            this.FractalpictureBox2.Location = new System.Drawing.Point(50 + ts11 + ts71, ts2);

            this.FractalpictureBox3.Location = new System.Drawing.Point(50 + ts11 + 2 * ts71, ts2);
            
            ts = tpoly;
            _width = _height = ts7;
            X = ts1;
            Y = ts2;
            cnn = cn;
            textBox1.Text = cn.ToString();
            Level = ts4;


            FractalpictureBox1();



        }
        private void FractalpictureInit()
        {
            rot = 0;

            _fractal = new Bitmap(_width, _height);
            // нов обект Graphics от укзания Bitmap
            _graph = Graphics.FromImage(_fractal);
       
        }

        private void FractalpictureBox1()

        {
            CountPictures = 1;
            rot1 = 0;
            _width = _width1 = FracralpictureBox1.Width;
            _height = FracralpictureBox1.Height;
            FractalpictureInit();
            //създаване на  инстанция на фигура

            RegPolygon[] scribble = new RegPolygon[1];
            //триъгълник
            if (ts == 3)
            {
                scribble[0] = new Triangle_new(0 , 0,420, ts);
            //квадрат         
            }
            if (ts == 4)
            {
                scribble[0] = new Carpet_new(0, 0, _width, ts);
             }
            if (ts == 5)
            {
             //петоъгълник
                  
                scribble[0] = new Pentagon_new(_width / 2, 0, 2 * _width / 3,ts);
            
            }
            //лице на фигурата
             Area1 = scribble[0].Area();
            //изчертаване
            scribble[0].DrawFigures(_graph, MyColorone);

            FracralpictureBox1.BackgroundImage = _fractal;

            FracralpictureBox1.Image= _fractal;

        }

        private void FractalpictureeBox2()
        {
            Level1 = Int32.Parse(textBox4.Text);
            CountPictures = 2;
            rot2 = 0;
            MyColorone = MyColorone2;

            _width = _width2 = FractalpictureBox2.Width;
            _height = FractalpictureBox2.Height;
            FractalpictureInit();

            RegPolygon[] scribble = new RegPolygon[1];
          
            //триъгълник

            if (ts == 3)
            {

                PointF topPoint = new PointF(_width / 2f, 0);
                PointF leftPoint = new PointF(0, _height);
                PointF rightPoint = new PointF(_width, _height);
                scribble[0] = new Triangle_new(ts11, ts22, _width, ts);
                scribble[0].DrawFigure(topPoint, leftPoint, rightPoint, _graph, rot2, MyColorone);
                Area2 = scribble[0].Area();

            }
            if (ts == 4)
            {
                RectangleF carpet = new RectangleF(0, 0, _width, _height);
                Carpet_new carpet_new = new Carpet_new(ts11, ts22, _width, ts);
                Area2 = carpet_new.Area();
                carpet_new.DrawCarpetInit(carpet, _graph, rot2, MyColorone);

            }
            if (ts == 5)
            {
                PointF topPoint = new PointF(3 * _width / 4, 0);
                PointF leftPoint1 = new PointF(_width, _width / 2);
                PointF leftPoint = new PointF(_width / 2, _width);
                PointF rightPoint = new PointF(0, _width / 2);
                PointF rightPoint1 = new PointF(_width / 4, 0);
                scribble[0] = new Pentagon_new(ts11, ts22, _width, ts);
                scribble[0].DrawFigure_Pentagon(1, topPoint, leftPoint1, leftPoint, rightPoint, rightPoint1, _graph, rot2, MyColorone, MyColortow);
                Area2 = scribble[0].Area();

            }

            FractalpictureBox2.BackgroundImage = _fractal;
        }

        private void FractalpictureeBox3()
        {
            rot3 = 0;
            MyColorone = MyColorone3;
            Level2 = Int32.Parse(textBox4.Text);
            CountPictures = 3;
            _width = _width3 = FractalpictureBox3.Width;
            _height = FractalpictureBox3.Height;
            FractalpictureInit();

            RegPolygon[] scribble = new RegPolygon[1];

            //триъгълник

            if (ts == 3)
            {

                PointF topPoint = new PointF(_width / 2f, 0);
                PointF leftPoint = new PointF(0, _height);
                PointF rightPoint = new PointF(_width, _height);
                scribble[0] = new Triangle_new(ts11, ts22, _width, ts);
                scribble[0].DrawFigure(topPoint, leftPoint, rightPoint, _graph, rot2, MyColorone);
                Area3 = scribble[0].Area();

            }
            if (ts == 4)
            {
                RectangleF carpet = new RectangleF(0, 0, _width, _height);
                Carpet_new carpet_new = new Carpet_new(ts11, ts22, _width, ts);
                Area3 = carpet_new.Area();
                carpet_new.DrawCarpetInit(carpet, _graph, rot2, MyColorone);

            }
            if (ts == 5)
            {
                PointF topPoint = new PointF(3 * _width / 4, 0);
                PointF leftPoint1 = new PointF(_width, _width / 2);
                PointF leftPoint = new PointF(_width / 2, _width);
                PointF rightPoint = new PointF(0, _width / 2);
                PointF rightPoint1 = new PointF(_width / 4, 0);
                scribble[0] = new Pentagon_new(ts11, ts22, _width, ts);
                scribble[0].DrawFigure_Pentagon(1, topPoint, leftPoint1, leftPoint, rightPoint, rightPoint1, _graph, rot2, MyColorone, MyColortow);
                Area3 = scribble[0].Area();

            }

            FractalpictureBox3.BackgroundImage = _fractal;
        }

        private void FractalpictureBox1_Click(object sender, EventArgs e)
        {

            MyColorone = MyColorone1;
            MyColortow = MyColortow1;
            _width = FracralpictureBox1.Width;
            _height = FracralpictureBox1.Height;
            FractalpictureInit();

            if (ts == 3)
            {

                PointF topPoint = new PointF(_width / 2f, 0);
                PointF leftPoint = new PointF(0, _height);
                PointF rightPoint = new PointF(_width, _height);
                
                Triangle_new triangle_new = new Triangle_new(ts11, ts22, _width, ts);
                Area1 = triangle_new.Area();
                if (rot1 == 0)
                {

                    triangle_new.DrawTriangle(Level, topPoint, leftPoint, rightPoint, _graph, rot1, MyColorone, MyColortow);

                    rot1 = 1;
                }
                else
                {
                    triangle_new.DrawTriangle(Level, topPoint, leftPoint, rightPoint, _graph, rot1, MyColorone, MyColortow);

                    rot1 = 0;
                }
            }
            if (ts == 4)
            {
                RectangleF carpet = new RectangleF(0, 0, _width, _height);
                Carpet_new carpet_new = new Carpet_new(ts11, ts22, _width, ts);
                Area1 = carpet_new.Area();
                if (rot1 == 0)
                {


                    carpet_new.DrawCarpet(Level, carpet, _graph, rot1, MyColorone, MyColortow);
                    rot1 = 1;
                }
                else
                {
                    carpet_new.DrawCarpet(Level, carpet, _graph, rot1, MyColorone, MyColortow);
                    rot1 = 0;
                }
            }
            if (ts == 5)
            {
                PointF topPoint = new PointF(3 * _width / 4, 0);
                PointF leftPoint1 = new PointF(_width, _width / 2);
                PointF leftPoint = new PointF(_width / 2, _width);
                PointF rightPoint = new PointF(0, _width / 2);
                PointF rightPoint1 = new PointF(_width / 4, 0);

                Pentagon_new pentagon_new = new Pentagon_new(ts11, ts22, _width, ts);
                Area1 = pentagon_new.Area();
                if (rot1 == 0)
                {
                    pentagon_new.Draw_Pentagon(Level, topPoint, leftPoint1, leftPoint, rightPoint, rightPoint1, _graph, rot1, MyColorone, MyColortow);
                    rot1 = 1;
                }
                else
                {
                    pentagon_new.Draw_Pentagon(Level, topPoint, leftPoint1, leftPoint, rightPoint, rightPoint1, _graph, rot1, MyColorone, MyColortow);
                    rot1 = 0;
                }
            }

            FracralpictureBox1.BackgroundImage = _fractal;
            FracralpictureBox1.Image = _fractal;
        }

        private void FractalpictureBox2_Click(object sender, EventArgs e)
        {

            MyColorone = MyColorone2;
            MyColortow = MyColortow2;

            _width = FractalpictureBox2.Width;

            _width = FractalpictureBox2.Height;
            FractalpictureInit();

            if (ts == 3)
            {

                PointF topPoint = new PointF(_width / 2f, 0);
                PointF leftPoint = new PointF(0, _height);
                PointF rightPoint = new PointF(_width, _height);

                Triangle_new triangle_new = new Triangle_new(ts11, ts22, _width, ts);
                Area2 = triangle_new.Area();
                if (rot2 == 0)
                {

                    triangle_new.DrawTriangle(Level1, topPoint, leftPoint, rightPoint, _graph, rot2, MyColorone, MyColortow);

                    rot2 = 1;
                }
                else
                {
                    triangle_new.DrawTriangle(Level1, topPoint, leftPoint, rightPoint, _graph, rot2, MyColorone, MyColortow);

                    rot2 = 0;
                }
            }
            if (ts == 4)
            {
                RectangleF carpet = new RectangleF(0, 0, _width, _height);
                Carpet_new carpet_new = new Carpet_new(ts11, ts22, _width, ts);
                Area2 = carpet_new.Area();
                if (rot2 == 0)
                {


                    carpet_new.DrawCarpet(Level1, carpet, _graph, rot2, MyColorone, MyColortow);
                    rot2 = 1;
                }
                else
                {
                    carpet_new.DrawCarpet(Level1, carpet, _graph, rot2, MyColorone, MyColortow);
                    rot2 = 0;
                }
            }
            if (ts == 5)
            {
                PointF topPoint = new PointF(3 * _width / 4, 0);
                PointF leftPoint1 = new PointF(_width, _width / 2);
                PointF leftPoint = new PointF(_width / 2, _width);
                PointF rightPoint = new PointF(0, _width / 2);
                PointF rightPoint1 = new PointF(_width / 4, 0);

                Pentagon_new pentagon_new = new Pentagon_new(ts11, ts22, _width, ts);
                Area2 = pentagon_new.Area();
                if (rot2 == 0)
                {
                    pentagon_new.Draw_Pentagon(Level1, topPoint, leftPoint1, leftPoint, rightPoint, rightPoint1, _graph, rot2, MyColorone, MyColortow);
                    rot2 = 1;
                }
                else
                {
                    pentagon_new.Draw_Pentagon(Level1, topPoint, leftPoint1, leftPoint, rightPoint, rightPoint1, _graph, rot2, MyColorone, MyColortow);
                    rot2 = 0;
                }
            }

            FractalpictureBox2.BackgroundImage = _fractal;
        }
        private void FractalpictureBox3_Click(object sender, EventArgs e)
        {


            MyColorone = MyColorone3;
            MyColortow = MyColortow3;
            _width = FractalpictureBox3.Width;

            _width = FractalpictureBox3.Height;
            FractalpictureInit();

            if (ts == 3)
            {

                PointF topPoint = new PointF(_width / 2f, 0);
                PointF leftPoint = new PointF(0, _height);
                PointF rightPoint = new PointF(_width, _height);

                Triangle_new triangle_new = new Triangle_new(ts11, ts22, _width, ts);
                Area3 = triangle_new.Area();
                if (rot3 == 0)
                {

                    triangle_new.DrawTriangle(Level2, topPoint, leftPoint, rightPoint, _graph, rot3, MyColorone, MyColortow);

                    rot3 = 1;
                }
                else
                {
                    triangle_new.DrawTriangle(Level2, topPoint, leftPoint, rightPoint, _graph, rot3, MyColorone, MyColortow);

                    rot3 = 0;
                }
            }
            if (ts == 4)
            {
                RectangleF carpet = new RectangleF(0, 0, _width, _height);
                Carpet_new carpet_new = new Carpet_new(ts11, ts22, _width, ts);
                Area3 = carpet_new.Area();

                if (rot3 == 0)
                {


                    carpet_new.DrawCarpet(Level2, carpet, _graph, rot3, MyColorone, MyColortow);
                    rot3 = 1;
                }
                else
                {
                    carpet_new.DrawCarpet(Level2, carpet, _graph, rot3, MyColorone, MyColortow);
                    rot3 = 0;
                }
            }
            if (ts == 5)
            {
                PointF topPoint = new PointF(3 * _width / 4, 0);
                PointF leftPoint1 = new PointF(_width, _width / 2);
                PointF leftPoint = new PointF(_width / 2, _width);
                PointF rightPoint = new PointF(0, _width / 2);
                PointF rightPoint1 = new PointF(_width / 4, 0);

                Pentagon_new pentagon_new = new Pentagon_new(ts11, ts22, _width, ts);
                Area3 = pentagon_new.Area();
                if (rot3 == 0)
                {
                    pentagon_new.Draw_Pentagon(Level2, topPoint, leftPoint1, leftPoint, rightPoint, rightPoint1, _graph, rot3, MyColorone, MyColortow);
                    rot3 = 1;
                }
                else
                {
                    pentagon_new.Draw_Pentagon(Level2, topPoint, leftPoint1, leftPoint, rightPoint, rightPoint1, _graph, rot3, MyColorone, MyColortow);
                    rot3 = 0;
                }
            }

            FractalpictureBox3.BackgroundImage = _fractal;
        }
        private void button2_Click(object sender, System.EventArgs e)

        {
            ColorDialog MyDialog = new ColorDialog();
            MyDialog.AllowFullOpen = false;
            MyDialog.ShowHelp = true;

            if (MyDialog.ShowDialog() == DialogResult.OK)
                textBox8.BackColor = MyDialog.Color;

            MyColoroneNew = MyDialog.Color.Name;
            if (MyColoroneNew.StartsWith("f") == true)
            {
                MyColoroneNew = "7" + MyColoroneNew.Remove(0, 1);

            }

        }

        private void button3_Click(object sender, System.EventArgs e)
        {
            ColorDialog MyDialog = new ColorDialog();
            MyDialog.AllowFullOpen = false;
            MyDialog.ShowHelp = true;

            if (MyDialog.ShowDialog() == DialogResult.OK)
                textBox9.BackColor = MyDialog.Color;

            MyColortowNew = MyDialog.Color.Name;
            if (MyColortowNew.StartsWith("f") == true)
            {
                MyColortowNew = "7" + MyColortowNew.Remove(0, 1);

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch (cnn)
            {
                case 1:


                    this.FractalpictureBox2.Location = new System.Drawing.Point(50 + ts11 + ts71, ts22);
                    this.FractalpictureBox2.Size = new System.Drawing.Size(Convert.ToInt32(textBox7.Text), Convert.ToInt32(textBox7.Text));

                    this.FractalpictureBox3.Location = new System.Drawing.Point(50 + ts11 + ts71 + Convert.ToInt32(textBox7.Text), ts22);


                    MyColorone2 = MyColoroneNew;
                    MyColortow2 = MyColortowNew;
                    _width = _height = Convert.ToInt32(textBox7.Text);
                    FractalpictureeBox2();
                    break;
                case 2:

                    this.FractalpictureBox3.Location = new System.Drawing.Point(75 + ts11 + 2 * ts71, ts22);
                    this.FractalpictureBox3.Size = new System.Drawing.Size(Convert.ToInt32(textBox7.Text), Convert.ToInt32(textBox7.Text));

                    MyColorone3 = MyColoroneNew;
                    MyColortow3 = MyColortowNew;
                    _width = _height = Convert.ToInt32(textBox7.Text);
                    FractalpictureeBox3();
                    break;


            }
           
            cnn = cnn + 1;
            textBox1.Text = cnn.ToString();
           
        }


        private void button4_Click(object sender, EventArgs e)
        {
            OpenFileDialog openDialog = new OpenFileDialog();
            openDialog.Title = "Select A File";
            openDialog.Filter = "Image Files (*.png;*.jpg)|*.png;*.jpg" + "|" +
                                "All Files (*.*)|*.*";
            if (openDialog.ShowDialog() == DialogResult.OK)
            {
                string file = openDialog.FileName;



                _fractal = new Bitmap(file);
                // нов обект Graphics от укзания Bitmap
                _graph = Graphics.FromImage(_fractal);
                if (MyFractal == 1)
                {
                    FractalpictureBox4.BackgroundImage = _fractal;
                    MyFractal = 2;
                }

                else
                {
                    FractalpictureBox5.BackgroundImage = _fractal;
                    MyFractal = 1;
                }

                cnn = cnn + 1;
            }

        }

        private void FractalpictureBox1_DoubleClick(object sender, EventArgs e)
        {


            SaveFileDialog saveFile = new SaveFileDialog();


            saveFile.Filter = "Image Files(*.jpg, *.png, *.tiff, *.bmp, *.gif) | *.jpg; *.png; *.tiff; *.bmp; *.gif";

            saveFile.Title = "Save an image";

            saveFile.AddExtension = true;

            saveFile.DefaultExt = "bmp";

             saveFile.FilterIndex = 2;

             saveFile.RestoreDirectory = true;




            if (saveFile.ShowDialog() == DialogResult.OK)

            {


                string file = saveFile.FileName;
               

                 FracralpictureBox1.BackgroundImage.Save(file, ImageFormat.Jpeg);
               
            }


        }
        private void FractalpictureBox2_DoubleClick(object sender, EventArgs e)
        {


            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.Filter = "Image Files(*.jpg, *.png, *.tiff, *.bmp, *.gif) | *.jpg; *.png; *.tiff; *.bmp; *.gif";
            saveFile.Title = "Save an image";
            saveFile.AddExtension = true;
            saveFile.DefaultExt = "bmp";
            saveFile.FilterIndex = 2;
            saveFile.RestoreDirectory = true;

            if (saveFile.ShowDialog() == DialogResult.OK)

            {
   string file = saveFile.FileName;

               FractalpictureBox2.BackgroundImage.Save(file, ImageFormat.Jpeg);
              
           }

        }
        private void FractalpictureBox3_DoubleClick(object sender, EventArgs e)
        {

            SaveFileDialog saveFile = new SaveFileDialog();

            saveFile.Filter = "Image Files(*.jpg, *.png, *.tiff, *.bmp, *.gif) | *.jpg; *.png; *.tiff; *.bmp; *.gif";
            saveFile.Title = "Save an image";
            saveFile.AddExtension = true;
            saveFile.DefaultExt = "bmp";
            saveFile.FilterIndex = 2;
            saveFile.RestoreDirectory = true;

            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                string file = saveFile.FileName;

            FractalpictureBox3.BackgroundImage.Save(file, ImageFormat.Jpeg);
            }

        }
        private void mnuFileSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfdSerialization = new SaveFileDialog();

            // Избор на файл.
            if (sfdSerialization.ShowDialog() == DialogResult.OK)
            {
                // Add the files to a list.
                List<Image> input_images = new List<Image>();
                input_images.Add((Bitmap)FracralpictureBox1.Image);
                input_images.Add((Bitmap)FractalpictureBox2.Image);
                input_images.Add((Bitmap)FractalpictureBox3.Image);
                input_images.Add((Bitmap)FractalpictureBox4.Image);
                input_images.Add((Bitmap)FractalpictureBox5.Image);

                // Серилизация

                using (FileStream fs = new FileStream(
                  sfdSerialization.FileName, FileMode.Create))
                {

                    BinaryFormatter formatter = new BinaryFormatter();
                    formatter.Serialize(fs, input_images);
                }
            }
        }

        private void FilterLinq(object sender, EventArgs e)
        {
            MyString = "";
           

            RegPolygon regpolygon = new RegPolygon(ts11, ts22, _width, ts);


            IList<Figure> figureList = new List<Figure>() {

               new RegPolygon() { FigureId = 1, FigureName = "Фигура1", FigureType = "Програмно генерирана"},
               new  RegPolygon() { FigureId = 2, FigureName = "Фигура2", FigureType = "Програмно генерирана"},
               new  RegPolygon() { FigureId = 3, FigureName = "Фигура3", FigureType = "Програмно генерирана"},
               new  RegPolygon() { FigureId = 4, FigureName = "Фигура4", FigureType = "Заредена от файл" },
               new RegPolygon() { FigureId =5, FigureName = "Фигура5", FigureType = "Заредена от файл"},
            };



            var FigureNme = figureList.Where(s => s.FigureType == "Програмно генерирана")
                                          .Select(s => s)

                                        .Select(s => s.FigureName);
            foreach (var std in FigureNme)
                MyString = MyString + std + ";";
            richTextBox1.Text = MyString;
        }
        private void FilterRed(object sender, EventArgs e)
        {
            MyString = "";
            RegPolygon regpolygon = new RegPolygon(ts11, ts22, _width, ts);
            IList<Figure> figureList = new List<Figure>() {

       

           new RegPolygon() { FigureId = 1, FigureName = "Фигура1", FigureColor = MyColorone1},
           new RegPolygon() { FigureId = 2, FigureName = "Фигура2",  FigureColor = MyColorone2},
           new RegPolygon() { FigureId = 3, FigureName = "Фигура3",  FigureColor = MyColorone3},
                    };
             

            
           
                var FigureName = figureList.Where(s => s.FigureColor == "Red")
                                                          .Select(s => s)
                                                          .Where(st => st.FigureId < 4)

                                                        .Select(s => s.FigureName);
                foreach (var std in FigureName)
                    MyString = MyString + std + ";";

                richTextBox2.Text = MyString;
            }

        private void FilterArea(object sender, EventArgs e)
        {
          
            MyString = "";

            RegPolygon regpolygon = new RegPolygon(ts11, ts22,_width, ts);
            
            IList<Figure> figureList = new List<Figure>() {

          new RegPolygon() { FigureId = 1, FigureName = "Фигура1", FigureType = "Програмно генерирана", FigureColor = MyColorone1, FigureArea = Area1, FigurePerimetar =Per1},
          new RegPolygon() { FigureId = 2, FigureName = "Фигура2", FigureType = "Програмно генерирана", FigureColor = MyColorone2, FigureArea =Area2, FigurePerimetar =Per2},
          new RegPolygon() { FigureId = 3, FigureName = "Фигура3", FigureType = "Програмно генерирана", FigureColor = MyColorone3, FigureArea=Area3, FigurePerimetar =Per3},

                 };

            var sortedFigureName = from s in figureList

                                   orderby s.FigureArea
                                   select new
                                   {
                                       Фигура = s.FigureName,
                                       Лице = s.FigureArea

                                   };

            foreach (var std in sortedFigureName.ToList())

                MyString = MyString + std + ";";

            richTextBox3.Text = MyString;
        }
        private void FilterМажArea(object sender, EventArgs e)
        {
           
            MyString = "";
            RegPolygon regpolygon = new RegPolygon(ts11, ts22, _width, ts);

            IList<Figure> figureList = new List<Figure>() {

           // var figures =new  List<Figure> {
          new RegPolygon() { FigureId = 1, FigureName = "Фигура1", FigureType = "Програмно генерирана", FigureColor = MyColorone1, FigureArea = Area1, FigurePerimetar=Per1},
          new RegPolygon() { FigureId = 2, FigureName = "Фигура2", FigureType = "Програмно генерирана", FigureColor = MyColorone2, FigureArea = Area2, FigurePerimetar =Per2},
          new RegPolygon() { FigureId = 3, FigureName = "Фигура3", FigureType = "Програмно генерирана", FigureColor = MyColorone3, FigureArea =  Area3, FigurePerimetar =Per3},

        };
      //      var teamTotalScores =
        //    from regpolygon in figureList
        //    group RegPolygon by RegPolygon.FigureType into FigureGroup
        //    select new
            {
              //  Team = FigureGroup.Key,
//TotalScore = FigureGroup.Sum(x=>x.Area),
                           
            };


        }
    }
}

