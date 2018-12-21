using System;
using System.Drawing;
using System.Windows.Forms;

namespace Interface
{
    class Clock
    {
        public Graphics m_graphic;
        public Timer m_timer;
        public float m_width;
        public float m_height;
        public bool flag = false;//判断是否绘画事件时间
        public void OnPaint(PaintEventArgs e, DateTime dateTime)
        {
            float m_radius = 50;

            m_graphic = e.Graphics;
            m_graphic.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            m_graphic.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            //设置坐标原点
            m_graphic.TranslateTransform((float)(m_width * 4.05 / 5), (float)(m_height * 0.8 / 5));
            m_graphic.FillEllipse(new SolidBrush(Color.AliceBlue), -m_radius, -m_radius, m_radius * 2, m_radius * 2);
            //画外边框
            Pen pen = new Pen(Color.Gray, 1);
            m_graphic.DrawEllipse(pen, m_radius * (-1), m_radius * (-1), m_radius * 2, m_radius * 2);
            //画小刻度
            for (int i = 0; i < 60; i++)
            {
                m_graphic.FillRectangle(new SolidBrush(Color.Gray), -2, 2 - m_radius, 1, 5);
                m_graphic.RotateTransform(6);
            }
            //画大刻度
            for (int i = 0; i < 12; i++)
            {
                m_graphic.FillRectangle(new SolidBrush(Color.Gray), -3, 2 - m_radius, 2, 10);
                m_graphic.RotateTransform(30);
            }
            //获取当期时间
            int second = DateTime.Now.Second;
            int minute = DateTime.Now.Minute;
            int hour = DateTime.Now.Hour;
            //画秒针
            pen.Color = Color.Red;
            m_graphic.RotateTransform(6 * second);
            m_graphic.DrawLine(pen, 0.5f, 0.5f, 0, (-1) * (float)(m_radius / 1.2));
            //画分针
            Pen pen1 = new Pen(Color.Blue, 2);
            m_graphic.RotateTransform(-6 * second);
            m_graphic.RotateTransform((float)(0.1 * second + 6 * minute));
            m_graphic.DrawLine(pen1, 0.5f, 0.5f, 0, (-1) * (float)(m_radius / 1.5));
            //画时针
            Pen pen2 = new Pen(Color.Green, 3);
            m_graphic.RotateTransform((float)(0.1 * second + 6 * minute) * (-1));
            m_graphic.RotateTransform((float)(30 / 3600 * second + 30 / 60 * minute + hour * 30));
            m_graphic.DrawLine(pen2, 0.5f, 0.5f, 0, (-1) * (float)(m_radius / 2.4));
            Rectangle rect = new Rectangle(-4, -4, 8, 8);
            m_graphic.FillPie(new SolidBrush(Color.Red), rect, 0, 360);

            //绘画具体时间
            if (flag) {
                int minuteC = dateTime.Minute;
                int hourC = dateTime.Hour;
                Pen pen3_1 = new Pen(Color.Black, 1.8f);
                Pen pen3_2 = new Pen(Color.Black, 2.8f);
                m_graphic.RotateTransform((float)(6 * minuteC));
                m_graphic.DrawLine(pen3_1, 0, 0, 0, (-1) * (float)(m_radius / 1.5));
                m_graphic.RotateTransform((float)(30 * hourC));
                m_graphic.DrawLine(pen3_2, 0, 0, 0, (-1) * (float)(m_radius / 2.4));

            }
            
        }
    }
}
