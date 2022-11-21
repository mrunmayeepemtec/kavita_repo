namespace CalculatorDesktopAppFramework
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBox = new System.Windows.Forms.TextBox();
            this.lcurrentOp = new System.Windows.Forms.Label();
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
            this.n2 = new System.Windows.Forms.Button();
            this.n3 = new System.Windows.Forms.Button();
            this.nminus = new System.Windows.Forms.Button();
            this.nequal = new System.Windows.Forms.Button();
            this.n0 = new System.Windows.Forms.Button();
            this.ndot = new System.Windows.Forms.Button();
            this.nplus = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.SuspendLayout();
            // 
            // textBox
            // 
            this.textBox.BackColor = System.Drawing.SystemColors.Control;
            this.textBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.textBox.Location = new System.Drawing.Point(19, 56);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(379, 39);
            this.textBox.TabIndex = 0;
            this.textBox.Text = "0";
            this.textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lcurrentOp
            // 
            this.lcurrentOp.AutoSize = true;
            this.lcurrentOp.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lcurrentOp.Location = new System.Drawing.Point(28, 20);
            this.lcurrentOp.Name = "lcurrentOp";
            this.lcurrentOp.Size = new System.Drawing.Size(0, 20);
            this.lcurrentOp.TabIndex = 1;
            // 
            // n7
            // 
            this.n7.BackColor = System.Drawing.SystemColors.ControlLight;
            this.n7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.n7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.n7.Location = new System.Drawing.Point(19, 101);
            this.n7.Name = "n7";
            this.n7.Size = new System.Drawing.Size(71, 59);
            this.n7.TabIndex = 2;
            this.n7.Text = "7";
            this.n7.UseVisualStyleBackColor = false;
            this.n7.Click += new System.EventHandler(this.n_click);
            // 
            // n8
            // 
            this.n8.BackColor = System.Drawing.SystemColors.ControlLight;
            this.n8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.n8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.n8.Location = new System.Drawing.Point(96, 101);
            this.n8.Name = "n8";
            this.n8.Size = new System.Drawing.Size(71, 59);
            this.n8.TabIndex = 3;
            this.n8.Text = "8";
            this.n8.UseVisualStyleBackColor = false;
            this.n8.Click += new System.EventHandler(this.n_click);
            // 
            // n9
            // 
            this.n9.BackColor = System.Drawing.SystemColors.ControlLight;
            this.n9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.n9.ForeColor = System.Drawing.SystemColors.ControlText;
            this.n9.Location = new System.Drawing.Point(173, 101);
            this.n9.Name = "n9";
            this.n9.Size = new System.Drawing.Size(71, 59);
            this.n9.TabIndex = 4;
            this.n9.Text = "9";
            this.n9.UseVisualStyleBackColor = false;
            this.n9.Click += new System.EventHandler(this.n_click);
            // 
            // ndivide
            // 
            this.ndivide.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ndivide.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ndivide.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ndivide.Location = new System.Drawing.Point(250, 101);
            this.ndivide.Name = "ndivide";
            this.ndivide.Size = new System.Drawing.Size(71, 59);
            this.ndivide.TabIndex = 5;
            this.ndivide.Text = "/";
            this.ndivide.UseVisualStyleBackColor = false;
            this.ndivide.Click += new System.EventHandler(this.op_click);
            // 
            // nce
            // 
            this.nce.BackColor = System.Drawing.SystemColors.ControlLight;
            this.nce.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nce.ForeColor = System.Drawing.SystemColors.ControlText;
            this.nce.Location = new System.Drawing.Point(327, 101);
            this.nce.Name = "nce";
            this.nce.Size = new System.Drawing.Size(71, 59);
            this.nce.TabIndex = 6;
            this.nce.Text = "CE";
            this.nce.UseVisualStyleBackColor = false;
            this.nce.Click += new System.EventHandler(this.nce_click);
            // 
            // n4
            // 
            this.n4.BackColor = System.Drawing.SystemColors.ControlLight;
            this.n4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.n4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.n4.Location = new System.Drawing.Point(19, 166);
            this.n4.Name = "n4";
            this.n4.Size = new System.Drawing.Size(71, 59);
            this.n4.TabIndex = 7;
            this.n4.Text = "4";
            this.n4.UseVisualStyleBackColor = false;
            this.n4.Click += new System.EventHandler(this.n_click);
            // 
            // n5
            // 
            this.n5.BackColor = System.Drawing.SystemColors.ControlLight;
            this.n5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.n5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.n5.Location = new System.Drawing.Point(96, 166);
            this.n5.Name = "n5";
            this.n5.Size = new System.Drawing.Size(71, 59);
            this.n5.TabIndex = 8;
            this.n5.Text = "5";
            this.n5.UseVisualStyleBackColor = false;
            this.n5.Click += new System.EventHandler(this.n_click);
            // 
            // n6
            // 
            this.n6.BackColor = System.Drawing.SystemColors.ControlLight;
            this.n6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.n6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.n6.Location = new System.Drawing.Point(173, 166);
            this.n6.Name = "n6";
            this.n6.Size = new System.Drawing.Size(71, 59);
            this.n6.TabIndex = 9;
            this.n6.Text = "6";
            this.n6.UseVisualStyleBackColor = false;
            this.n6.Click += new System.EventHandler(this.n_click);
            // 
            // nmultiply
            // 
            this.nmultiply.BackColor = System.Drawing.SystemColors.ControlLight;
            this.nmultiply.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nmultiply.ForeColor = System.Drawing.SystemColors.ControlText;
            this.nmultiply.Location = new System.Drawing.Point(250, 166);
            this.nmultiply.Name = "nmultiply";
            this.nmultiply.Size = new System.Drawing.Size(71, 59);
            this.nmultiply.TabIndex = 10;
            this.nmultiply.Text = "*";
            this.nmultiply.UseVisualStyleBackColor = false;
            this.nmultiply.Click += new System.EventHandler(this.op_click);
            // 
            // nc
            // 
            this.nc.BackColor = System.Drawing.SystemColors.ControlLight;
            this.nc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nc.ForeColor = System.Drawing.SystemColors.ControlText;
            this.nc.Location = new System.Drawing.Point(327, 166);
            this.nc.Name = "nc";
            this.nc.Size = new System.Drawing.Size(71, 59);
            this.nc.TabIndex = 11;
            this.nc.Text = "C";
            this.nc.UseVisualStyleBackColor = false;
            this.nc.Click += new System.EventHandler(this.nc_click);
            // 
            // n1
            // 
            this.n1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.n1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.n1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.n1.Location = new System.Drawing.Point(19, 231);
            this.n1.Name = "n1";
            this.n1.Size = new System.Drawing.Size(71, 59);
            this.n1.TabIndex = 12;
            this.n1.Text = "1";
            this.n1.UseVisualStyleBackColor = false;
            this.n1.Click += new System.EventHandler(this.n_click);
            // 
            // n2
            // 
            this.n2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.n2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.n2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.n2.Location = new System.Drawing.Point(96, 231);
            this.n2.Name = "n2";
            this.n2.Size = new System.Drawing.Size(71, 59);
            this.n2.TabIndex = 13;
            this.n2.Text = "2";
            this.n2.UseVisualStyleBackColor = false;
            this.n2.Click += new System.EventHandler(this.n_click);
            // 
            // n3
            // 
            this.n3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.n3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.n3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.n3.Location = new System.Drawing.Point(173, 231);
            this.n3.Name = "n3";
            this.n3.Size = new System.Drawing.Size(71, 59);
            this.n3.TabIndex = 14;
            this.n3.Text = "3";
            this.n3.UseVisualStyleBackColor = false;
            this.n3.Click += new System.EventHandler(this.n_click);
            // 
            // nminus
            // 
            this.nminus.BackColor = System.Drawing.SystemColors.ControlLight;
            this.nminus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nminus.ForeColor = System.Drawing.SystemColors.ControlText;
            this.nminus.Location = new System.Drawing.Point(250, 231);
            this.nminus.Name = "nminus";
            this.nminus.Size = new System.Drawing.Size(71, 59);
            this.nminus.TabIndex = 15;
            this.nminus.Text = "-";
            this.nminus.UseVisualStyleBackColor = false;
            this.nminus.Click += new System.EventHandler(this.op_click);
            // 
            // nequal
            // 
            this.nequal.BackColor = System.Drawing.SystemColors.ControlLight;
            this.nequal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nequal.ForeColor = System.Drawing.SystemColors.ControlText;
            this.nequal.Location = new System.Drawing.Point(327, 231);
            this.nequal.Name = "nequal";
            this.nequal.Size = new System.Drawing.Size(71, 124);
            this.nequal.TabIndex = 16;
            this.nequal.Text = "=";
            this.nequal.UseVisualStyleBackColor = false;
            this.nequal.Click += new System.EventHandler(this.nequal_click);
            // 
            // n0
            // 
            this.n0.BackColor = System.Drawing.SystemColors.ControlLight;
            this.n0.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.n0.ForeColor = System.Drawing.SystemColors.ControlText;
            this.n0.Location = new System.Drawing.Point(19, 296);
            this.n0.Name = "n0";
            this.n0.Size = new System.Drawing.Size(148, 59);
            this.n0.TabIndex = 17;
            this.n0.Text = "0";
            this.n0.UseVisualStyleBackColor = false;
            this.n0.Click += new System.EventHandler(this.n_click);
            // 
            // ndot
            // 
            this.ndot.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ndot.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ndot.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ndot.Location = new System.Drawing.Point(173, 296);
            this.ndot.Name = "ndot";
            this.ndot.Size = new System.Drawing.Size(71, 59);
            this.ndot.TabIndex = 19;
            this.ndot.Text = ".";
            this.ndot.UseVisualStyleBackColor = false;
            this.ndot.Click += new System.EventHandler(this.n_click);
            // 
            // nplus
            // 
            this.nplus.BackColor = System.Drawing.SystemColors.ControlLight;
            this.nplus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nplus.ForeColor = System.Drawing.SystemColors.ControlText;
            this.nplus.Location = new System.Drawing.Point(250, 296);
            this.nplus.Name = "nplus";
            this.nplus.Size = new System.Drawing.Size(71, 59);
            this.nplus.TabIndex = 20;
            this.nplus.Text = "+";
            this.nplus.UseVisualStyleBackColor = false;
            this.nplus.Click += new System.EventHandler(this.op_click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 362);
            this.Controls.Add(this.nplus);
            this.Controls.Add(this.ndot);
            this.Controls.Add(this.n0);
            this.Controls.Add(this.nequal);
            this.Controls.Add(this.nminus);
            this.Controls.Add(this.n3);
            this.Controls.Add(this.n2);
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
            this.Controls.Add(this.lcurrentOp);
            this.Controls.Add(this.textBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Click += new System.EventHandler(this.n_click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Label lcurrentOp;
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
        private System.Windows.Forms.Button n2;
        private System.Windows.Forms.Button n3;
        private System.Windows.Forms.Button nminus;
        private System.Windows.Forms.Button nequal;
        private System.Windows.Forms.Button n0;
        private System.Windows.Forms.Button ndot;
        private System.Windows.Forms.Button nplus;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}

