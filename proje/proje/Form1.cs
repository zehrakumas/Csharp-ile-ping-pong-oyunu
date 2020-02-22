using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;
using System.Runtime.InteropServices;
using System.Media;
using System.IO;

namespace proje
{
    public partial class Form1 : Form
    {
        
           //zamanla ilgili değişkenler tanımlanıyor
           public int saniye = 0;
           public int dakika = 0;
           public int saat = 0;


           //topun ilk hizi
           int solhiz = 10;
           int usthiz = 10;



        public Form1()
        {
            InitializeComponent();

            this.TopMost = true;
           
           
            //gameoverin pozisyonu ayarlanıyor
            label2.Left = (oyunalani.Width) - (oyunalani.Width / 2);
            label2.Top = (oyunalani.Height) - (oyunalani.Height / 2);
            
            

        }

        //form ilk açıldığında gerçekleşen olaylar
        private void Form1_Load(object sender, EventArgs e)
        {
            ball.Visible = false;//topun görünürlüğünü false yaptık
            //game over yazısının görünürlüğü false yapılıyor
            label2.Visible = false;

           
        }

        //timer click 
        public void timer1_Tick(object sender, EventArgs e)
        {

            saniye++;
            if (saniye == 60)
            {
                saniye = 0;
                dakika++;
            }


            if (dakika == 60)
            {
                dakika = 0;
                saat++;
            }


            // Düzenleme:
            if (saat == 24)
            {
                saat = 0;
                dakika = 0;
                saniye = 0;
            }
            label1.Text = string.Format("{0:00}:{1:00}:{2:00}", saat, dakika, saniye);


            
            ball.Left += solhiz;
            ball.Top += usthiz;
            if(ball.Bottom>=raket.Top &&
                ball.Top<=raket.Bottom &&
                ball.Right>=raket.Left &&
                ball.Left<=raket.Right)
            {
                //hizi %10 artıyor.
                usthiz = usthiz+((usthiz*10)/100);
                solhiz =solhiz+((solhiz*10)/100);
                usthiz = -usthiz;
                
                
                //ses
                System.Media.SoundPlayer ses = new System.Media.SoundPlayer();
                ses.SoundLocation = "Mario Ziplama Sesi (online-audio-converter.com).wav";
                ses.Play();

            }
            if(ball.Left<=oyunalani.Left)
            {
                solhiz = -solhiz;
                //ses
                System.Media.SoundPlayer ses = new System.Media.SoundPlayer();
                ses.SoundLocation = "Mario Ziplama Sesi (online-audio-converter.com).wav";
                ses.Play();
            }
            if(ball.Right>=oyunalani.Right)
            {
                solhiz = -solhiz;
                //ses
                System.Media.SoundPlayer ses = new System.Media.SoundPlayer();
                ses.SoundLocation = "Mario Ziplama Sesi (online-audio-converter.com).wav";
                ses.Play();
            }
            if(ball.Top<=oyunalani.Top)
            {
                usthiz = -usthiz;
                //ses
                System.Media.SoundPlayer ses = new System.Media.SoundPlayer();
                ses.SoundLocation = "Mario Ziplama Sesi (online-audio-converter.com).wav";
                ses.Play();
            }
            if(ball.Bottom>=oyunalani.Bottom)
            {
                timer1.Enabled = false;
                label2.Visible = true;//game overin görünürlüğü true yapılıyor.
                Cursor.Show();//mouse görünür.
                //ses
                System.Media.SoundPlayer ses = new System.Media.SoundPlayer();
                ses.SoundLocation = "WhatsApp Audio 2018-07-25 at 18.14.01 (online-audio-converter.com).wav";
                ses.Play();


                //form2'ye geçiş 
                Form2 frm = new Form2();               
                frm.Show();
                

                
            }
           

        }
        //oyun alanina mouse ile tıklandığında gerçekleşen olaylar
        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
            //oyun başladığında zaman da başlar.
            timer1.Enabled = true;
            timer1.Start();
            ball.Visible = true; //topun görünürlüğü true oluyor.
            Cursor.Hide();//mouse görünürlüğü kapalı

             //oyun bitince mouse bir kez tıklarsak oyun yeniden başlar
            ball.Top = 300;
            ball.Left =200;
            usthiz = 10;
            solhiz = 10;
            timer1.Enabled = true;
            label2.Visible = false;

        }


        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            //oyun bittiğinde escape tuşuna basınca oyundan çıkıyoruz.
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
                      
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
           
        }

        private void oyunalani_MouseMove(object sender, MouseEventArgs e)
        {

            


            //mouse hareketine göre raket sağa,sola hareket ediyor
            raket.Top = oyunalani.Bottom - (oyunalani.Bottom / 10);           
            raket.Left = Cursor.Position.X-(raket.Width/2);


            

        }

        private void oyunalani_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void oyunalani_MouseLeave(object sender, EventArgs e)
        {
            
        }

        private void oyunalani_MouseHover(object sender, EventArgs e)
        {
            
        }
    }
    }

