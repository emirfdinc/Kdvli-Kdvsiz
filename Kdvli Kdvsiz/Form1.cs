using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kdvli_Kdvsiz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Hesapla_Click(object sender, EventArgs e)
        {
            string ürünadı;
            Int16 fiyat;
            double kdvoranı1, kdvoranı2, sonuc1,sonuc2;
            

            ürünadı = textBox1.Text;
            fiyat = Convert.ToInt16(textBox2.Text);
            kdvoranı1=Convert.ToInt16(textBox3.Text);
            kdvoranı2 = Convert.ToInt16(textBox4.Text);
            sonuc1 = (fiyat * kdvoranı1) / 100 + fiyat;
            sonuc2 = (fiyat * kdvoranı2) / 100 + fiyat;
            listBox1.Items.Add("Ürün Adı:" + ürünadı + " " +"Ürün Kdvsiz Fiyatı:" +  fiyat + " " +"KDV1:" + sonuc1 + " "+"KDV2:" + sonuc2);

        }
    }
}
