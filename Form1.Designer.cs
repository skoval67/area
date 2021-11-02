
namespace getarea
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSideA = new System.Windows.Forms.TextBox();
            this.txtSideB = new System.Windows.Forms.TextBox();
            this.txtSideC = new System.Windows.Forms.TextBox();
            this.CalcTriangleArea = new System.Windows.Forms.Button();
            this.TriangleArea = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Сторона a";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(205, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Сторона b";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(352, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Сторона c";
            // 
            // txtSideA
            // 
            this.txtSideA.Location = new System.Drawing.Point(72, 96);
            this.txtSideA.Name = "txtSideA";
            this.txtSideA.Size = new System.Drawing.Size(100, 26);
            this.txtSideA.TabIndex = 3;
            // 
            // txtSideB
            // 
            this.txtSideB.Location = new System.Drawing.Point(209, 95);
            this.txtSideB.Name = "txtSideB";
            this.txtSideB.Size = new System.Drawing.Size(100, 26);
            this.txtSideB.TabIndex = 4;
            // 
            // txtSideC
            // 
            this.txtSideC.Location = new System.Drawing.Point(356, 95);
            this.txtSideC.Name = "txtSideC";
            this.txtSideC.Size = new System.Drawing.Size(100, 26);
            this.txtSideC.TabIndex = 5;
            // 
            // CalcTriangleArea
            // 
            this.CalcTriangleArea.Location = new System.Drawing.Point(517, 98);
            this.CalcTriangleArea.Name = "CalcTriangleArea";
            this.CalcTriangleArea.Size = new System.Drawing.Size(107, 23);
            this.CalcTriangleArea.TabIndex = 6;
            this.CalcTriangleArea.Text = "Рассчитать";
            this.CalcTriangleArea.UseVisualStyleBackColor = true;
            this.CalcTriangleArea.Click += new System.EventHandler(this.CalcTriangleArea_Click);
            // 
            // TriangleArea
            // 
            this.TriangleArea.AutoSize = true;
            this.TriangleArea.Location = new System.Drawing.Point(72, 158);
            this.TriangleArea.Name = "TriangleArea";
            this.TriangleArea.Size = new System.Drawing.Size(198, 20);
            this.TriangleArea.TabIndex = 7;
            this.TriangleArea.Text = "Площадь треугольника: ";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(916, 499);
            this.Controls.Add(this.TriangleArea);
            this.Controls.Add(this.CalcTriangleArea);
            this.Controls.Add(this.txtSideC);
            this.Controls.Add(this.txtSideB);
            this.Controls.Add(this.txtSideA);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion<DirectedGraph xmlns="http://schemas.microsoft.com/vs/2009/dgml">

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSideA;
        private System.Windows.Forms.TextBox txtSideB;
        private System.Windows.Forms.TextBox txtSideC;
        private System.Windows.Forms.Button CalcTriangleArea;
        private System.Windows.Forms.Label TriangleArea;
    }
}

