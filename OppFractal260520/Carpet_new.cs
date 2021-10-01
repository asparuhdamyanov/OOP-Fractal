using System;
using System.Drawing;
using System.Globalization;

using OppFractalClassLibrary;

namespace OOPFractal
{
    //class  Carpet_new наследник на RegPolygon
    class Carpet_new : RegPolygon
    {
        public Color Color { get; set; }
        public bool Solid { get; set; }
        public float Width;

        private int color;



        public Carpet_new()
        {

        }
        public Carpet_new( int newx, int newy, int newwidth, int newdim) :base(newx, newy, newwidth, newdim)
        {
            Width = getWidth();

        }

        public  void DrawFigure_Carpet (RectangleF carpet, Graphics _gr, int rot, string colorone)
        { 
        _gr.FillRectangle(Brushes.Blue, carpet);
        }
        public void DrawCarpetInit(RectangleF carpet, Graphics _gr, int rot, string colorone)
       

        {

           
            if (colorone.StartsWith("7") == false)
            {

                SolidBrush newBrush = new SolidBrush(Color.FromName(colorone));
                _gr.FillRectangle(newBrush, carpet);
            }
            else
            {
                color = Int32.Parse(colorone, NumberStyles.HexNumber);

                SolidBrush newBrush = new SolidBrush(Color.FromArgb(color));

                _gr.FillRectangle(newBrush, carpet);
            }
        }

        
      

        public void DrawCarpet(int level, RectangleF carpet, Graphics _gr, int rot, string colorone, string colortow)
        {
            //проверка за край на постропването
            if (level == 0)
            {
                //Рисуване на квадрат

                if (rot == 0)
                {

                    // _gr.FillRectangle(Brushes.Red, carpet);
                    if (colorone.StartsWith("7") == false)
                    {

                        SolidBrush newBrush = new SolidBrush(Color.FromName(colorone));
                        _gr.FillRectangle(newBrush, carpet);
                    }
                    else
                    {
                        color = Int32.Parse(colorone, NumberStyles.HexNumber);

                        SolidBrush newBrush = new SolidBrush(Color.FromArgb(color));

                        _gr.FillRectangle(newBrush, carpet);
                    }
                }
                else
                {
                    //     _gr.FillRectangle(Brushes.Blue, carpet);
                    if (colortow.StartsWith("7") == false)
                    {

                        SolidBrush newBrush = new SolidBrush(Color.FromName(colortow));
                        _gr.FillRectangle(newBrush, carpet);
                    }
                    else
                    {
                        color = Int32.Parse(colortow, NumberStyles.HexNumber);

                        SolidBrush newBrush = new SolidBrush(Color.FromArgb(color));

                        _gr.FillRectangle(newBrush, carpet);
                    }

                }
            }
            else
            {
                // рзделяне на квадрата  на 9 части
                var width = carpet.Width / 3f;
                var height = carpet.Height / 3f;

                var x1 = carpet.Left;
                var x2 = x1 + width;
                var x3 = x1 + 2f * width;

                var y1 = carpet.Top;
                var y2 = y1 + height;
                var y3 = y1 + 2f * height;

                DrawCarpet(level - 1, new RectangleF(x1, y1, width, height), _gr, rot,
colorone, colortow); // ляв 1
                DrawCarpet(level - 1, new RectangleF(x2, y1, width, height), _gr, rot,
colorone, colortow); // среден 1
                DrawCarpet(level - 1, new RectangleF(x3, y1, width, height), _gr, rot,
colorone, colortow); // десен 1
                DrawCarpet(level - 1, new RectangleF(x1, y2, width, height), _gr, rot,
colorone, colortow); // ляв 2
                DrawCarpet(level - 1, new RectangleF(x3, y2, width, height), _gr, rot,
colorone, colortow); // десен 2
                DrawCarpet(level - 1, new RectangleF(x1, y3, width, height), _gr, rot,
colorone, colortow); // ляв 3
                DrawCarpet(level - 1, new RectangleF(x2, y3, width, height), _gr, rot,
colorone, colortow); // среден 3
                DrawCarpet(level - 1, new RectangleF(x3, y3, width, height), _gr, rot,
colorone, colortow); // десен 3
            }
        }

    }
}
