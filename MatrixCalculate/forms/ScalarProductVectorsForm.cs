using System;
using System.Windows.Forms;

namespace MatrixCalculate.forms
{
    public partial class ScalarProductVectorsForm : Form
    {
        public ScalarProductVectorsForm()
        {
            InitializeComponent();
        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            if (tbA1.Text == "" ||
                tbA2.Text == "" ||
                tbA3.Text == "" ||
                tbB1.Text == "" ||
                tbB2.Text == "" ||
                tbB3.Text == "")
                return;
            
            var a1 = int.Parse(tbA1.Text);
            var a2 = int.Parse(tbA2.Text);
            var a3 = int.Parse(tbA3.Text);

            var b1 = int.Parse(tbB1.Text);
            var b2 = int.Parse(tbB2.Text);
            var b3 = int.Parse(tbB3.Text);

            var vectorA = new Vector(a1, a2, a3);
            var vectorB = new Vector(b1,b2,b3);

            var scalar = Vector.ScalarProduct(vectorA, vectorB);

            lbResult.Text += scalar;
        }
    }
}