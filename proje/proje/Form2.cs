using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace proje
{
    public partial class Form2 : Form
    {
        
        public Form2()
        {
           
            
            InitializeComponent();
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            //kullanıcı isim giriyor
            string isim;
            isim = Console.ReadLine();
            textBox1.Text = isim;

            
        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            string dosya_yolu = "C:\\Users\\hp\\Desktop\\oyun.txt";
            //İşlem yapacağımız dosyanın yolunu belirtiyoruz.
            FileStream fs = new FileStream(dosya_yolu, FileMode.OpenOrCreate, FileAccess.Write);
            //Bir file stream nesnesi oluşturuyoruz. 1.parametre dosya yolunu,
            //2.parametre dosya varsa açılacağını yoksa oluşturulacağını belirtir,
            //3.parametre dosyaya erişimin veri yazmak için olacağını gösterir.
            StreamWriter sw = new StreamWriter(fs);
            //Yazma işlemi için bir StreamWriter nesnesi oluşturduk.
            sw.WriteLine(textBox1.Text);          
            
            sw.Flush();
            //Veriyi dosyaya aktardık.
            sw.Close();
            fs.Close();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //kullanıcı bu butona tıklarsa form kapanır.
            this.Close();
        }
    }
}
