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
    public partial class admin : Form
    {
        public admin()
        {
            InitializeComponent();
        }
        DbEntityUrunEntities db = new DbEntityUrunEntities();

        private void button1_Click(object sender, EventArgs e)
        {
            var sorgu = from x in db.TBLADMIN where x.user == textBox1.Text && x.PASSWORD == textBox2.Text select x;
            if (sorgu.Any())
            {
                FrmAna fr = new FrmAna();
                fr.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Hatalı Giriş");

            }

        }
    }
}
