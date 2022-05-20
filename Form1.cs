using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LSPD_Templates
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            MessageBox.Show("WARNING, DO NOT ABUSE THE TEMPLATES ADDED IN THIS PROGRAM OR LEAK THE PROGRAM / PROGRAM LINK, FAILURE TO DO SO MAY CAUSE A TERMINATION", "WARNING", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            this.Hide();
            frm2.Show();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 frm3 = new Form3();
            frm3.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
