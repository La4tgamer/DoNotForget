using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    class Clock
    {
        public Graphics m_graphic;
        public Timer m_timer;
        public float m_width;
        public float m_height;

        public void OnPaint(PaintEventArgs e)
        {
            float m_radius = 100;

            m_graphic = e.Graphics;
            m_graphic.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            m_graphic.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            //设置坐标原点
            m_graphic.TranslateTransform((float)(4 * m_width / 5), (float)(m_height / 4));
            m_graphic.FillEllipse(new SolidBrush(Color.AliceBlue), -m_radius, -m_radius, m_radius * 2, m_radius * 2);
            //画外边框
            Pen pen = new Pen(Color.Gray, 2);
            m_graphic.DrawEllipse(pen, m_radius * (-1), m_radius * (-1), m_radius * 2, m_radius * 2);
            //画小刻度
            for (int i = 0; i < 60; i++)
            {
                m_graphic.FillRectangle(new SolidBrush(Color.Gray), -2, 2 - m_radius, 3, 10);
                m_graphic.RotateTransform(6);
            }
            //画大刻度
            for (int i = 0; i < 12; i++)
            {
                m_graphic.FillRectangle(new SolidBrush(Color.Gray), -3, 2 - m_radius, 5, 18);
                m_graphic.RotateTransform(30);
            }
            //获取当期时间
            int second = DateTime.Now.Second;
            int minute = DateTime.Now.Minute;
            int hour = DateTime.Now.Hour;
            //画秒针
            pen.Color = Color.Red;
            m_graphic.RotateTransform(6 * second);
            m_graphic.DrawLine(pen, 0, 0, 0, (-1) * (float)(m_radius / 1.2));
            //画分针
            Pen pen1 = new Pen(Color.Blue, 3);
            m_graphic.RotateTransform(-6 * second);
            m_graphic.RotateTransform((float)(0.1 * second + 6 * minute));
            m_graphic.DrawLine(pen1, 0, 0, 0, (-1) * (float)(m_radius / 1.5));
            //画时针
            Pen pen2 = new Pen(Color.Green, 4);
            m_graphic.RotateTransform((float)(0.1 * second + 6 * minute) * (-1));
            m_graphic.RotateTransform((float)(30 / 3600 * second + 30 / 60 * minute + hour * 30));
            m_graphic.DrawLine(pen2, 0, 0, 0, (-1) * (float)(m_radius / 2.4));
            Rectangle rect = new Rectangle(-5, -5, 10, 10);
            m_graphic.FillPie(new SolidBrush(Color.Red), rect, 0, 360);
        }
    }
}
