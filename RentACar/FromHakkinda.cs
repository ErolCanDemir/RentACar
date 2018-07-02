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
    public partial class FromHakkinda: Form
    {
        public FromHakkinda()
        {
            InitializeComponent();
        }

        private void FromHakkinda_Load(object sender, EventArgs e)
        {
            button1.BackColor = Color.Transparent;
            label1.BackColor = Color.Transparent;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            index i = new index();
            i.Show();
            this.Close();
        }
    }
}
