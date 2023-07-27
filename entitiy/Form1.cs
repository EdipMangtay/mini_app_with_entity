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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }






        DbEntityUrunEntities db = new DbEntityUrunEntities(); // SQL İÇERİSİNDEKİ VERİLERİ YÖNETMEMİ SAĞLATAN KÜTÜPHANEDEN VERİLERİ ALDIM

        
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Btnlistele_Click(object sender, EventArgs e)
        {
            var kategorıler = db.TBLKATEGORIs.ToList();
            dataGridView1.DataSource = kategorıler;
        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            TBLKATEGORI t = new TBLKATEGORI(); // ilgili tablonun stünlarına ulaşmak için o tablodan bir nesne almam lazım
            t.AD = textBox2.Text;
            db.TBLKATEGORIs.Add(t); // t den gelenleri ekle anlamında
            db.SaveChanges();
            MessageBox.Show("Kategörü eklendi");
        }

        private void Btnsil_Click(object sender, EventArgs e)
        {
            int X = Convert.ToInt32(textBox1.Text);
            var ktg = db.TBLKATEGORIs.Find(X);
            db.TBLKATEGORIs.Remove(ktg); // db.
            db.SaveChanges();
            MessageBox.Show("Silme işlemi Gerçekleşti");



        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            // kategorıden bir nesne aldım ve bu nesneye komutlar command yükledim
            int x = int.Parse(textBox1.Text);
            var ktgr = db.TBLKATEGORIs.Find(x);
            ktgr.AD = textBox2.Text;
            db.SaveChanges();
            MessageBox.Show("Güncelleme Yapıldı");
        }
    }
}
