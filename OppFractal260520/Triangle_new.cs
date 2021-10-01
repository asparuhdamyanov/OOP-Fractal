using System;
using System.Drawing;
using System.Windows.Forms;
using System.Globalization;
using OppFractalClassLibrary;

namespace OOPFractal
{
    //class Triangle_new наследник на RegPolygon
    class Triangle_new :RegPolygon
    {

        public Point Location { get; set; }
     
      //  public Color Color { get; set; }
      //  public bool Solid { get; set; }

        public float Width;
        private int color;

        public Triangle_new()
        {

        }
        public Triangle_new(int newx, int newy, int newwidth, int newdim) : base(newx, newy, newwidth, newdim)
        {
            Width = getWidth();
    }

        //предефиниране на виртуалната  функция  DrawFigure при наследяване na на класа RegPolygon
        public override void DrawFigure(PointF top, PointF left, PointF right, Graphics _graph, int rot, string colorone)
        {

            PointF[] points = new PointF[3]

          {
                    top, right, left

          };
            _graph.FillPolygon(Brushes.Red, points);
        }
        public void DrawTriangleInit(PointF top, PointF left, PointF right, Graphics _graph, int rot, string colorone)
            
        {

            PointF[] points = new PointF[3]

{
                    top, right, left

};
            

            if (colorone.StartsWith("7") == false)
            {

                SolidBrush newBrush = new SolidBrush(Color.FromName(colorone));
                

          
                _graph.FillPolygon(newBrush, points);
            }
            else
            {
                color = Int32.Parse(colorone, NumberStyles.HexNumber);

                SolidBrush newBrush = new SolidBrush(Color.FromArgb(color));

                _graph.FillPolygon(newBrush, points);
            }

        }

        public void DrawTriangle(int level, PointF top, PointF left, PointF right, Graphics _graph, int rot, string colorone, string colortow)
        {


            //проверка за край
            if (level == 0)
            {

                PointF[] points = new PointF[3]
                {

                    top, right, left

                };
                //Рисуване на  триъгълника
                if (rot == 1)
                {


                    if (colorone.StartsWith("7") == false)
                    {

                        SolidBrush newBrush = new SolidBrush(Color.FromName(colorone));
                        _graph.FillPolygon(newBrush, points);
                    }
                    else
                    {
                        color = Int32.Parse(colorone, NumberStyles.HexNumber);

                        SolidBrush newBrush = new SolidBrush(Color.FromArgb(color));

                        _graph.FillPolygon(newBrush, points);
                    }
                }

                else

                {
                    if (colortow.StartsWith("7") == false)
                    {

                        SolidBrush newBrush = new SolidBrush(Color.FromName(colortow));
                        _graph.FillPolygon(newBrush, points);
                    }
                    else
                    {
                        color = Int32.Parse(colortow, NumberStyles.HexNumber);

                        SolidBrush newBrush = new SolidBrush(Color.FromArgb(color));

                        _graph.FillPolygon(newBrush, points);
                    }
                }
            }
            else
            {
                //изчислпване на средната точка
                var leftMid = MidPoint(top, left); //лява страна
                var rightMid = MidPoint(top, right); //дясна страна
                var topMid = MidPoint(left, right); // основа

                //рекурсивно извикване на  функцията
                DrawTriangle(level - 1, top, leftMid, rightMid, _graph, rot, colorone, colortow);
                DrawTriangle(level - 1, leftMid, left, topMid, _graph, rot, colorone, colortow);
                DrawTriangle(level - 1, rightMid, topMid, right, _graph, rot, colorone, colortow);
            }
        }

        //функция за изчисляване на координатите на средната точка
        private PointF MidPoint(PointF p1, PointF p2)
        {
            return new PointF((p1.X + p2.X) / 2f, (p1.Y + p2.Y) / 2f);
        }
    }
}

