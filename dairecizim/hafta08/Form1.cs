using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hafta08
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            label1.Text = folderBrowserDialog1.SelectedPath;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            float d1, d2, d3, toplam;

            //grafik arayuzu oluşturma 
            Graphics g = this.CreateGraphics();
            Pen p = new Pen(Color.Black, 4);
            //onceki cizimleri temizleme
            g.Clear(Form1.DefaultBackColor);

            //1-> cizgi yatay
            //(p,x ve y baslangıci, x ve y bitişi)

            g.DrawLine(p, 50, 50, 150, 50);

            //2 ->ucgen (orta lana)
            //sol ust kose
            g.DrawLine(p, 50, 150, 100, 100);
            //sag ust kose
            g.DrawLine(p, 100, 100, 150, 150);
            //alt kenar
            g.DrawLine(p, 150, 150, 50, 150);

            //3 ->kare (alt sola)
            Rectangle rectangle = new Rectangle(50, 200, 100, 100);
            Brush redbrush = new SolidBrush(Color.Red);
            g.FillRectangle(redbrush, rectangle);
            //(kalem, dikdörtgen bilgiler)
            g.DrawRectangle(p, rectangle);

            try
            {
                //kulanıcı girislerini alma
                d1 = float.Parse(textBox1.Text);
                d2 = float.Parse(textBox2.Text);
                d3 = float.Parse(textBox3.Text);
                toplam = d1 + d2 + d3;

                if (toplam == 0)
                {
                    MessageBox.Show("Toplam 0 olamaz lutfen gecerli degerler girin");
                    return;
                }

                //derece hesaplama
                float pd1 = (d1 / toplam) * 360;
                float pd2 = (d2 / toplam) * 360;
                float pd3 = (d3 / toplam) * 360;

                //4-> Pasta grafiği
                Rectangle rec2 = new Rectangle(300, 50, 200, 200);
                g.DrawPie(p, rec2, 0, pd1);
                g.DrawPie(p, rec2 , pd1, pd2);
                g.DrawPie(p, rec2, pd1 + pd2, pd3);

                //pasta renkleri 
                Brush b1 = new SolidBrush(Color.Red);
                Brush b2 = new SolidBrush(Color.Blue);
                Brush b3 = new SolidBrush(Color.Yellow);

                g.FillPie(b1, rec2, 0, pd1);
                g.FillPie(b2, rec2, pd1, pd2);
                g.FillPie(b3, rec2, pd1+pd2, pd3);
            }
            catch
            {
                MessageBox.Show("Lutfen gecerli sayılar girin");
            }
        }
        
    }
}
