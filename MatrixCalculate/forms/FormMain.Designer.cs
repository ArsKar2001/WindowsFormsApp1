using System.ComponentModel;

namespace MatrixCalculate.forms
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSum = new System.Windows.Forms.Button();
            this.btnSub = new System.Windows.Forms.Button();
            this.btnMul = new System.Windows.Forms.Button();
            this.btnScalar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSum
            // 
            this.btnSum.Location = new System.Drawing.Point(154, 85);
            this.btnSum.Name = "btnSum";
            this.btnSum.Size = new System.Drawing.Size(400, 50);
            this.btnSum.TabIndex = 0;
            this.btnSum.Text = "Сложение матриц...";
            this.btnSum.UseVisualStyleBackColor = true;
            this.btnSum.Click += new System.EventHandler(this.btnSum_Click);
            // 
            // btnSub
            // 
            this.btnSub.Location = new System.Drawing.Point(154, 164);
            this.btnSub.Name = "btnSub";
            this.btnSub.Size = new System.Drawing.Size(400, 50);
            this.btnSub.TabIndex = 0;
            this.btnSub.Text = "Вычитание матриц...";
            this.btnSub.UseVisualStyleBackColor = true;
            this.btnSub.Click += new System.EventHandler(this.btnSub_Click);
            // 
            // btnMul
            // 
            this.btnMul.Location = new System.Drawing.Point(154, 250);
            this.btnMul.Name = "btnMul";
            this.btnMul.Size = new System.Drawing.Size(400, 50);
            this.btnMul.TabIndex = 0;
            this.btnMul.Text = "Умножение матриц...";
            this.btnMul.UseVisualStyleBackColor = true;
            this.btnMul.Click += new System.EventHandler(this.btnMul_Click);
            // 
            // btnScalar
            // 
            this.btnScalar.Location = new System.Drawing.Point(154, 335);
            this.btnScalar.Name = "btnScalar";
            this.btnScalar.Size = new System.Drawing.Size(400, 50);
            this.btnScalar.TabIndex = 1;
            this.btnScalar.Text = "Скаларное произведение векторов";
            this.btnScalar.UseVisualStyleBackColor = true;
            this.btnScalar.Click += new System.EventHandler(this.btnScalar_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 461);
            this.Controls.Add(this.btnScalar);
            this.Controls.Add(this.btnSub);
            this.Controls.Add(this.btnMul);
            this.Controls.Add(this.btnSum);
            this.MaximumSize = new System.Drawing.Size(700, 500);
            this.MinimumSize = new System.Drawing.Size(700, 500);
            this.Name = "FormMain";
            this.Text = "FormMain";
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button btnScalar;

        private System.Windows.Forms.Button btnMul;

        private System.Windows.Forms.Button btnSub;
        private System.Windows.Forms.Button btnSum;

        #endregion
    }
}