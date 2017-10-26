using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace курсовая1
{
    public partial class для_вывода_графика : Form
    {
        public для_вывода_графика(float[] Mas,float miny,float maxy,float st,float maxx,float minx)
        {
            InitializeComponent();
             Chart s = new Chart{Parent = this, Dock = DockStyle.Fill};
            if (maxx >= 5)
            {
                s.MaxX = maxx + 1;
            }else
            {
                s.MaxX = 5;
            }
            s.GridStep = st;
            if (minx < -1)
            {
                s.MinX = minx-1;
            }else
            {
                s.MinX = -1;
            }
            if (maxy >= 5)
            {
                s.MaxY = maxy + 1;
            }
            else
            {
                s.MaxY = 5;
            }
            if (miny < -1)
            {
                s.MinY = miny-1;
            }
            else
            {
                s.MinY = -1;
            }
            s.MinXreal = minx;
            s.MaxXreal = maxx;
            s.Mas = Mas;
        }
        public class Chart : Control
        {
            
            [DefaultValue(20)]
            public int Indent { get; set; }

            [DefaultValue(5)]
            public float MaxX { get; set; }

            [DefaultValue(-5)]
            public float MinX { get; set; }

            [DefaultValue(5)]
            public float MaxY { get; set; }
        
            [DefaultValue(-5)]
            public float MinY { get; set; }

            
            [DefaultValue(1)]
            public float[] Mas { get; set; }
            public float GridStep { get; set; }
            public float MaxXreal { get; set; }
            public float MinXreal { get; set; }
            


            public Chart()
            {
                SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer | ControlStyles.ResizeRedraw | ControlStyles.UserPaint, true);
                Indent = 20;
                MinX = -5;
                MaxX = 5;
                MinY = -5;
                MaxY = 5;
                GridStep = 1;
            }

            
            private Rectangle ChartArea
            {
                get
                {
                    var rect = ClientRectangle;
                    rect.Inflate(-Indent, -Indent);
                    return rect;
                }

            }

   
            float YToPixels(float y)
            {
                return ChartArea.Height * (y - MinY) / (MaxY - MinY);
            }

            
            float XToPixels(float x)
            {
                return ChartArea.Width * (x - MinX) / (MaxX - MinX);
            }

            
            protected override void OnPaint(PaintEventArgs e)
            {
                var rect = ChartArea;
                var gr = e.Graphics;

                gr.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;

                var center = new PointF(rect.Left + XToPixels(0), rect.Bottom - YToPixels(0));

                //рисуем сетку
                using (var font = new Font(Font.FontFamily, 8f))
                using (var pen = new Pen(Color.FromArgb(50, Color.Navy), 1))
                {
                    for (var x = MinX; x <= MaxX; x += GridStep)
                    {
                        var absX = rect.Left + XToPixels(x);
                        gr.DrawLine(pen, absX, rect.Bottom, absX, rect.Top);
                        gr.DrawString(x.ToString("0.0"), font, Brushes.Navy, absX - 7, center.Y + 5);
                    }

                    for (var y = MinY; y <= MaxY; y += GridStep)
                    {
                        var absY = rect.Bottom - YToPixels(y);
                        gr.DrawLine(pen, rect.Left, absY, rect.Right + 5, absY);
                        gr.DrawString(y.ToString("0.0"), font, Brushes.Navy, center.X - 25, absY - 5);
                    }
                }

                //рис оси
                using (var pen = new Pen(Color.Navy, 1))
                {
                    pen.EndCap = System.Drawing.Drawing2D.LineCap.ArrowAnchor;
                    gr.DrawLine(pen, center.X, rect.Bottom, center.X, rect.Top - 10);
                    gr.DrawLine(pen, rect.Left, center.Y, rect.Right + 7, center.Y);
                }

                //рис ф по знач
                int i = 0;
                    using (var pen = new Pen(Color.Red, 2))
                    {
                        var step = GridStep;
                        for (var x = MinXreal; x+0.0001 < MaxXreal; x += step)
                        {
                            var y1 = Mas[i];
                            var y2 = Mas[i+1];
                        
                            i++;
                        
                        e.Graphics.DrawLine(pen, rect.Left + XToPixels(x), rect.Bottom - YToPixels(y1), rect.Left + XToPixels(x + step), rect.Bottom - YToPixels(y2));
                        
                        }
                    }
            }
            }
        }
    }
