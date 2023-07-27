using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace entitiy
{
    public partial class Frmistatistik : Form
    {
        public Frmistatistik()
        {
            InitializeComponent();
        }
        DbEntityUrunEntities db = new DbEntityUrunEntities();
        private void Frmistatistik_Load(object sender, EventArgs e)
        {
            label2.Text = db.TBLKATEGORIs.Count().ToString(); // db.kategorıye git Count al ve tostring döndür
            label3.Text = db.TBLURUNs.Count().ToString(); // ürün sayısını string olarak getir
            label23.Text = db.TBLMUSTERIs.Count(x => x.DURUM == true).ToString(); // databaseden durumu true olanı getir linQ
            label5.Text = db.TBLMUSTERIs.Count(x => x.DURUM == false).ToString(); // **     **      **      **      **
            label9.Text = db.TBLURUNs.Sum(x => x.STOK).ToString();
            label11.Text = (from x in db.TBLURUNs orderby x.FIYAT descending select x.URUNAD).FirstOrDefault(); // tblurunlere git x adında bir değişkenle oradki verileri büyükten küçüğe sırala ve birinci yani en pahalı olanı seç ve getir
            label17.Text = (from y in db.TBLURUNs orderby y.FIYAT ascending select y.URUNAD).FirstOrDefault();
            label13.Text = db.TBLSATIS.Sum(x => x.FIYAT).ToString();
           
            //label7.Text = db.TBLURUNs.Count(x => x.URUNAD == "BUZDOLABI").ToString();
            label7.Text = db.TBLURUNs.Count(x => x.KATEGORI == 1).ToString();
            label15.Text = (from x in db.TBLMUSTERIs select x.SEHIR).Distinct().Count().ToString();// x ile içeriye git sehirleri tekrarsız olarak al ve say daha sonra bana tostring olarak ver
            label21.Text = db.MARKAGETIR().FirstOrDefault(); // prosedür ile en fazla ürüne sahip marka geldi










        }
    }
}
