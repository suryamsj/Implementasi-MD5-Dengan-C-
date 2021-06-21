using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hash
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Hash_Click(object sender, EventArgs e)
        {
            MD5Hash hash = new MD5Hash();
            TulisanMD5.Text = hash.MD5(TulisanNormal.Text);
        }
    }
}
