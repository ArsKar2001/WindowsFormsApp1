using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp2.Properties;

namespace WindowsFormsApp2
{
    public sealed partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public Form1(Form2 form2)
        {
            InitializeComponent();
            form2.BackColor = Color.Black;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }
    }
}