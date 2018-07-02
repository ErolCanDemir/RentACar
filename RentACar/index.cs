using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentACar
{
    public partial class index : Form
    {
        public index()
        {
            InitializeComponent();
        }
        public string mesaj;
        private void kiralamakİçinÜyeOlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormKiraUyeOl fkuo = new FormKiraUyeOl();
            fkuo.Show();
            this.Close();
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void araçKiralaToolStripMenuItem_Click(object sender, EventArgs e)
        {

            FormAracKirala fak = new FormAracKirala();
            fak.Show();
            this.Close();
        }

        private void hakkındaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FromHakkinda fh = new FromHakkinda();
            fh.Show();
            this.Close();
        }
  
    }
}
