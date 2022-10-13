using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab2
{
    public partial class Form1 : Form
    {
        int N;
        Random r;
        Thread thread1, thread2, thread3;
        public Form1()
        {
            InitializeComponent();
            thread1 = new Thread(threadFunc1);
            thread2 = new Thread(threadFunc2);
            thread3 = new Thread(threadFunc3);
            N = 100;
            r = new Random();
        }

        public void threadFunc1()
        {
            for (int i = 0; i < N; i++)
            {
                int x = r.Next(0, Width);
                int y = r.Next(0, Height);
                this.CreateGraphics().DrawEllipse(new Pen(Color.Aqua, 20), x, y, 20, 20);
                Thread.Sleep(500);
            }
        }
        public void threadFunc2()
        {
            for (int i = 0; i < N; i++)
            {
                int x = r.Next(0, Width);
                int y = r.Next(0, Height);
                this.CreateGraphics().DrawEllipse(new Pen(Color.Red, 20), x, y, 20, 20);
                Thread.Sleep(500);
            }
        }

        public void threadFunc3()
        {
            for (int i = 0; i < N; i++)
            {
                int x = r.Next(0, Width);
                int y = r.Next(0, Height);
                this.CreateGraphics().DrawEllipse(new Pen(Color.Green, 20), x, y, 20, 20);
                Thread.Sleep(500);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            thread1.Start();
            thread2.Start();
            thread3.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            thread1.Abort();
            thread2.Abort();
            thread3.Abort();
        }
    }
}
