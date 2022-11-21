namespace CalculatorApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        //#region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBox = new System.Windows.Forms.TextBox();
            this.n7 = new System.Windows.Forms.Button();
            this.n8 = new System.Windows.Forms.Button();
            this.n9 = new System.Windows.Forms.Button();
            this.ndivide = new System.Windows.Forms.Button();
            this.nce = new System.Windows.Forms.Button();
            this.n4 = new System.Windows.Forms.Button();
            this.n5 = new System.Windows.Forms.Button();
            this.n6 = new System.Windows.Forms.Button();
            this.nmultiply = new System.Windows.Forms.Button();
            this.nc = new System.Windows.Forms.Button();
            this.n1 = new System.Windows.Forms.Button();
            this.n3 = new System.Windows.Forms.Button();
            this.nminus = new System.Windows.Forms.Button();
            this.nequal = new System.Windows.Forms.Button();
            this.n2 = new System.Windows.Forms.Button();
            this.n0 = new System.Windows.Forms.Button();
            this.ndot = new System.Windows.Forms.Button();
            this.nplus = new System.Windows.Forms.Button();
            this.lcurrentOp = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox
            // 
            this.textBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox.Location = new System.Drawing.Point(21, 28);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(407, 45);
            this.textBox.TabIndex = 0;
            this.textBox.Text = "0";
            this.textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // n7
            // 
            this.n7.BackColor = System.Drawing.SystemColors.ControlDark;
            this.n7.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.n7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.n7.Location = new System.Drawing.Point(21, 79);
            this.n7.Name = "n7";
            this.n7.Size = new System.Drawing.Size(71, 59);
            this.n7.TabIndex = 1;
            this.n7.Text = "7";
            this.n7.UseVisualStyleBackColor = false;
            this.n7.Click += new System.EventHandler(this.n_click);
            // 
            // n8
            // 
            this.n8.BackColor = System.Drawing.SystemColors.ControlDark;
            this.n8.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.n8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.n8.Location = new System.Drawing.Point(105, 79);
            this.n8.Name = "n8";
            this.n8.Size = new System.Drawing.Size(71, 59);
            this.n8.TabIndex = 2;
            this.n8.Text = "8";
            this.n8.UseVisualStyleBackColor = false;
            this.n8.Click += new System.EventHandler(this.n_click);
            // 
            // n9
            // 
            this.n9.BackColor = System.Drawing.SystemColors.ControlDark;
            this.n9.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.n9.ForeColor = System.Drawing.SystemColors.ControlText;
            this.n9.Location = new System.Drawing.Point(189, 79);
            this.n9.Name = "n9";
            this.n9.Size = new System.Drawing.Size(71, 59);
            this.n9.TabIndex = 3;
            this.n9.Text = "9";
            this.n9.UseVisualStyleBackColor = false;
            this.n9.Click += new System.EventHandler(this.n_click);
            // 
            // ndivide
            // 
            this.ndivide.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ndivide.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ndivide.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ndivide.Location = new System.Drawing.Point(273, 79);
            this.ndivide.Name = "ndivide";
            this.ndivide.Size = new System.Drawing.Size(71, 59);
            this.ndivide.TabIndex = 4;
            this.ndivide.Text = "/";
            this.ndivide.UseVisualStyleBackColor = false;
            this.ndivide.Click += new System.EventHandler(this.op_click);
            // 
            // nce
            // 
            this.nce.BackColor = System.Drawing.SystemColors.ControlDark;
            this.nce.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.nce.ForeColor = System.Drawing.SystemColors.ControlText;
            this.nce.Location = new System.Drawing.Point(357, 79);
            this.nce.Name = "nce";
            this.nce.Size = new System.Drawing.Size(71, 59);
            this.nce.TabIndex = 5;
            this.nce.Text = "CE";
            this.nce.UseVisualStyleBackColor = false;
            this.nce.Click += new System.EventHandler(this.nce_Click);
            // 
            // n4
            // 
            this.n4.BackColor = System.Drawing.SystemColors.ControlDark;
            this.n4.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.n4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.n4.Location = new System.Drawing.Point(21, 152);
            this.n4.Name = "n4";
            this.n4.Size = new System.Drawing.Size(71, 59);
            this.n4.TabIndex = 6;
            this.n4.Text = "4";
            this.n4.UseVisualStyleBackColor = false;
            this.n4.Click += new System.EventHandler(this.n_click);
            // 
            // n5
            // 
            this.n5.BackColor = System.Drawing.SystemColors.ControlDark;
            this.n5.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.n5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.n5.Location = new System.Drawing.Point(105, 152);
            this.n5.Name = "n5";
            this.n5.Size = new System.Drawing.Size(71, 59);
            this.n5.TabIndex = 7;
            this.n5.Text = "5";
            this.n5.UseVisualStyleBackColor = false;
            this.n5.Click += new System.EventHandler(this.n_click);
            // 
            // n6
            // 
            this.n6.BackColor = System.Drawing.SystemColors.ControlDark;
            this.n6.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.n6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.n6.Location = new System.Drawing.Point(189, 152);
            this.n6.Name = "n6";
            this.n6.Size = new System.Drawing.Size(71, 59);
            this.n6.TabIndex = 8;
            this.n6.Text = "6";
            this.n6.UseVisualStyleBackColor = false;
            this.n6.Click += new System.EventHandler(this.n_click);
            // 
            // nmultiply
            // 
            this.nmultiply.BackColor = System.Drawing.SystemColors.ControlDark;
            this.nmultiply.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.nmultiply.ForeColor = System.Drawing.SystemColors.ControlText;
            this.nmultiply.Location = new System.Drawing.Point(273, 152);
            this.nmultiply.Name = "nmultiply";
            this.nmultiply.Size = new System.Drawing.Size(71, 59);
            this.nmultiply.TabIndex = 9;
            this.nmultiply.Text = "*";
            this.nmultiply.UseVisualStyleBackColor = false;
            this.nmultiply.Click += new System.EventHandler(this.op_click);
            // 
            // nc
            // 
            this.nc.BackColor = System.Drawing.SystemColors.ControlDark;
            this.nc.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.nc.ForeColor = System.Drawing.SystemColors.ControlText;
            this.nc.Location = new System.Drawing.Point(357, 152);
            this.nc.Name = "nc";
            this.nc.Size = new System.Drawing.Size(71, 59);
            this.nc.TabIndex = 10;
            this.nc.Text = "C";
            this.nc.UseVisualStyleBackColor = false;
            this.nc.Click += new System.EventHandler(this.nc_Click);
            // 
            // n1
            // 
            this.n1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.n1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.n1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.n1.Location = new System.Drawing.Point(21, 225);
            this.n1.Name = "n1";
            this.n1.Size = new System.Drawing.Size(71, 59);
            this.n1.TabIndex = 11;
            this.n1.Text = "1";
            this.n1.UseVisualStyleBackColor = false;
            this.n1.Click += new System.EventHandler(this.n_click);
            // 
            // n3
            // 
            this.n3.BackColor = System.Drawing.SystemColors.ControlDark;
            this.n3.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.n3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.n3.Location = new System.Drawing.Point(189, 225);
            this.n3.Name = "n3";
            this.n3.Size = new System.Drawing.Size(71, 59);
            this.n3.TabIndex = 12;
            this.n3.Text = "3";
            this.n3.UseVisualStyleBackColor = false;
            this.n3.Click += new System.EventHandler(this.n_click);
            // 
            // nminus
            // 
            this.nminus.BackColor = System.Drawing.SystemColors.ControlDark;
            this.nminus.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.nminus.ForeColor = System.Drawing.SystemColors.ControlText;
            this.nminus.Location = new System.Drawing.Point(273, 225);
            this.nminus.Name = "nminus";
            this.nminus.Size = new System.Drawing.Size(71, 59);
            this.nminus.TabIndex = 13;
            this.nminus.Text = "-";
            this.nminus.UseVisualStyleBackColor = false;
            this.nminus.Click += new System.EventHandler(this.op_click);
            // 
            // nequal
            // 
            this.nequal.BackColor = System.Drawing.SystemColors.ControlDark;
            this.nequal.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.nequal.ForeColor = System.Drawing.SystemColors.ControlText;
            this.nequal.Location = new System.Drawing.Point(357, 225);
            this.nequal.Name = "nequal";
            this.nequal.Size = new System.Drawing.Size(71, 132);
            this.nequal.TabIndex = 14;
            this.nequal.Text = "=";
            this.nequal.UseVisualStyleBackColor = false;
            this.nequal.Click += new System.EventHandler(this.nequal_click);
            // 
            // n2
            // 
            this.n2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.n2.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.n2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.n2.Location = new System.Drawing.Point(105, 225);
            this.n2.Name = "n2";
            this.n2.Size = new System.Drawing.Size(71, 59);
            this.n2.TabIndex = 15;
            this.n2.Text = "2";
            this.n2.UseVisualStyleBackColor = false;
            this.n2.Click += new System.EventHandler(this.n_click);
            // 
            // n0
            // 
            this.n0.BackColor = System.Drawing.SystemColors.ControlDark;
            this.n0.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.n0.ForeColor = System.Drawing.SystemColors.ControlText;
            this.n0.Location = new System.Drawing.Point(21, 298);
            this.n0.Name = "n0";
            this.n0.Size = new System.Drawing.Size(155, 59);
            this.n0.TabIndex = 16;
            this.n0.Text = "0";
            this.n0.UseVisualStyleBackColor = false;
            this.n0.Click += new System.EventHandler(this.n_click);
            // 
            // ndot
            // 
            this.ndot.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ndot.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ndot.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ndot.Location = new System.Drawing.Point(189, 298);
            this.ndot.Name = "ndot";
            this.ndot.Size = new System.Drawing.Size(71, 59);
            this.ndot.TabIndex = 17;
            this.ndot.Text = ".";
            this.ndot.UseVisualStyleBackColor = false;
            this.ndot.Click += new System.EventHandler(this.n_click);
            // 
            // nplus
            // 
            this.nplus.BackColor = System.Drawing.SystemColors.ControlDark;
            this.nplus.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.nplus.ForeColor = System.Drawing.SystemColors.ControlText;
            this.nplus.Location = new System.Drawing.Point(273, 298);
            this.nplus.Name = "nplus";
            this.nplus.Size = new System.Drawing.Size(71, 59);
            this.nplus.TabIndex = 18;
            this.nplus.Text = "+";
            this.nplus.UseVisualStyleBackColor = false;
            this.nplus.Click += new System.EventHandler(this.op_click);
            // 
            // lcurrentOp
            // 
            this.lcurrentOp.AutoSize = true;
            this.lcurrentOp.Location = new System.Drawing.Point(21, 0);
            this.lcurrentOp.Name = "lcurrentOp";
            this.lcurrentOp.Size = new System.Drawing.Size(0, 25);
            this.lcurrentOp.TabIndex = 19;
            //this.lcurrentOp.Click += new System.EventHandler(this.label_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 450);
            this.Controls.Add(this.lcurrentOp);
            this.Controls.Add(this.nplus);
            this.Controls.Add(this.ndot);
            this.Controls.Add(this.n0);
            this.Controls.Add(this.n2);
            this.Controls.Add(this.nequal);
            this.Controls.Add(this.nminus);
            this.Controls.Add(this.n3);
            this.Controls.Add(this.n1);
            this.Controls.Add(this.nc);
            this.Controls.Add(this.nmultiply);
            this.Controls.Add(this.n6);
            this.Controls.Add(this.n5);
            this.Controls.Add(this.n4);
            this.Controls.Add(this.nce);
            this.Controls.Add(this.ndivide);
            this.Controls.Add(this.n9);
            this.Controls.Add(this.n8);
            this.Controls.Add(this.n7);
            this.Controls.Add(this.textBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Button n7;
        private System.Windows.Forms.Button n8;
        private System.Windows.Forms.Button n9;
        private System.Windows.Forms.Button ndivide;
        private System.Windows.Forms.Button nce;
        private System.Windows.Forms.Button n4;
        private System.Windows.Forms.Button n5;
        private System.Windows.Forms.Button n6;
        private System.Windows.Forms.Button nmultiply;
        private System.Windows.Forms.Button nc;
        private System.Windows.Forms.Button n1;
        private System.Windows.Forms.Button n3;
        private System.Windows.Forms.Button nminus;
        private System.Windows.Forms.Button nequal;
        private System.Windows.Forms.Button n2;
        private System.Windows.Forms.Button n0;
        private System.Windows.Forms.Button ndot;
        private System.Windows.Forms.Button nplus;
        private System.Windows.Forms.Label lcurrentOp;

        //#endregion
    }
}
