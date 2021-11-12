using System;
using System.Drawing;
using System.Windows.Forms;
using MatrixCalculate.forms;

namespace MatrixCalculate
{
    public partial class FormMain : Form
    {
        private const int WIDTH = 700;
        private const int HEIGHT = 500;

        public FormMain()
        {
            Width = WIDTH;
            Height = HEIGHT;
            InitializeComponent();
        }

        private void btnSum_Click(object sender, EventArgs e)
        {
            new OperationForm(Operation.SUM, WIDTH, HEIGHT).Show();
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            new OperationForm(Operation.SUB, WIDTH, HEIGHT).Show();
        }

        private void btnMul_Click(object sender, EventArgs e)
        {
            new OperationForm(Operation.MUL, WIDTH, HEIGHT).Show();
        }
    }
}