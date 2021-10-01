using System;
using System.Drawing;
using System.Globalization;
using OppFractalClassLibrary;


namespace OOPFractal
{
    //class  Pentagon_new наследник на RegPolygon
    class Pentagon_new :RegPolygon
    {

        public Color Color { get; set; }
        public bool Solid { get; set; }

        private int color;

        public Pentagon_new()
        {

        }
        public Pentagon_new (int newx, int newy, int newwidth, int newdim) : base(newx, newy, newwidth, newdim)
        {

        }

        //предефиниране на виртуалната  функция DrawFigure_Pentagon при наследяване на клас RegPolygon
        public override void DrawFigure_Pentagon(int level, PointF top, PointF left1, PointF left, PointF right, PointF right1, Graphics _graph, int rot, string colorone, string colortow)
        {

            PointF[] points = new PointF[5]
            {
                top, left1, left,right,right1

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
            //  _graph.FillPolygon(Brushes.GreenYellow, points);
        }
        public void Draw_PentagonInit(PointF top, PointF left1, PointF left, PointF right, PointF right1, Graphics _graph, int rot, string colorone)
        {


            PointF[] points = new PointF[5]
            {
                top, left1, left,right,right1
                };


            //  _graph.FillPolygon(Brushes.Blue, points);
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
        public void Draw_Pentagon(int level, PointF top, PointF left1, PointF left, PointF right, PointF right1, Graphics _graph, int rot, string colorone, string colortow)
        {

            if (level == 0)
            {


                PointF[] points = new PointF[5]
                {
                top, left1, left,right,right1
                    };


                if (rot == 0)
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


                var leftMid = MidPoint(top, left); //1 ва лява страна
                var leftMid1 = MidPoint(top, left1); //2 ра лява страна
                var rightMid = MidPoint(top, right); //1 ва дясна страна
                var rightMid1 = MidPoint(top, right1); //2 ра дясна страна
                var topMid = MidPoint(left, right); // основа
                                                    //рекурсивно извикване на  функцията

                Draw_Pentagon(level - 1, top, leftMid1, leftMid, rightMid, rightMid1, _graph, rot, colorone, colortow);
                Draw_Pentagon(level - 1, leftMid1, leftMid, rightMid, rightMid1, top, _graph, rot, colorone, colortow);
                Draw_Pentagon(level - 1, leftMid, rightMid, rightMid1, top, leftMid1, _graph, rot, colorone, colortow);
                Draw_Pentagon(level - 1, rightMid, rightMid1, top, leftMid1, leftMid, _graph, rot, colorone, colortow);
                Draw_Pentagon(level - 1, rightMid1, top, leftMid1, leftMid, rightMid, _graph, rot, colorone, colortow);


            }

        }

        private PointF MidPoint(PointF p1, PointF p2)
        {
            return new PointF((p1.X + p2.X) / 2f, (p1.Y + p2.Y) / 2f);
        }


    }
}



