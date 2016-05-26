namespace AntiCE_Driver
{
    partial class frmMain
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
            this.txtPlayerHp = new System.Windows.Forms.TextBox();
            this.btnReduce = new System.Windows.Forms.Button();
            this.btnIncrement = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSafeMinus = new System.Windows.Forms.Button();
            this.txtSafePlus = new System.Windows.Forms.Button();
            this.txtSafe = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtPlayerHp
            // 
            this.txtPlayerHp.Location = new System.Drawing.Point(112, 33);
            this.txtPlayerHp.Name = "txtPlayerHp";
            this.txtPlayerHp.Size = new System.Drawing.Size(190, 20);
            this.txtPlayerHp.TabIndex = 0;
            // 
            // btnReduce
            // 
            this.btnReduce.Location = new System.Drawing.Point(322, 31);
            this.btnReduce.Name = "btnReduce";
            this.btnReduce.Size = new System.Drawing.Size(42, 23);
            this.btnReduce.TabIndex = 1;
            this.btnReduce.Text = "-";
            this.btnReduce.UseVisualStyleBackColor = true;
            this.btnReduce.Click += new System.EventHandler(this.btnReduce_Click);
            // 
            // btnIncrement
            // 
            this.btnIncrement.Location = new System.Drawing.Point(370, 31);
            this.btnIncrement.Name = "btnIncrement";
            this.btnIncrement.Size = new System.Drawing.Size(42, 23);
            this.btnIncrement.TabIndex = 2;
            this.btnIncrement.Text = "+";
            this.btnIncrement.UseVisualStyleBackColor = true;
            this.btnIncrement.Click += new System.EventHandler(this.btnIncrement_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Player HP";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtSafeMinus
            // 
            this.txtSafeMinus.Location = new System.Drawing.Point(322, 113);
            this.txtSafeMinus.Name = "txtSafeMinus";
            this.txtSafeMinus.Size = new System.Drawing.Size(42, 23);
            this.txtSafeMinus.TabIndex = 4;
            this.txtSafeMinus.Text = "-";
            this.txtSafeMinus.UseVisualStyleBackColor = true;
            // 
            // txtSafePlus
            // 
            this.txtSafePlus.Location = new System.Drawing.Point(371, 113);
            this.txtSafePlus.Name = "txtSafePlus";
            this.txtSafePlus.Size = new System.Drawing.Size(41, 23);
            this.txtSafePlus.TabIndex = 5;
            this.txtSafePlus.Text = "+";
            this.txtSafePlus.UseVisualStyleBackColor = true;
            this.txtSafePlus.Click += new System.EventHandler(this.txtSafePlus_Click);
            // 
            // txtSafe
            // 
            this.txtSafe.Location = new System.Drawing.Point(112, 115);
            this.txtSafe.Name = "txtSafe";
            this.txtSafe.Size = new System.Drawing.Size(190, 20);
            this.txtSafe.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "HP - SafeInt";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 171);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSafe);
            this.Controls.Add(this.txtSafePlus);
            this.Controls.Add(this.txtSafeMinus);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnIncrement);
            this.Controls.Add(this.btnReduce);
            this.Controls.Add(this.txtPlayerHp);
            this.Name = "frmMain";
            this.Text = "Anti CE Driver Demo";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPlayerHp;
        private System.Windows.Forms.Button btnReduce;
        private System.Windows.Forms.Button btnIncrement;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button txtSafeMinus;
        private System.Windows.Forms.Button txtSafePlus;
        private System.Windows.Forms.TextBox txtSafe;
        private System.Windows.Forms.Label label2;
    }
}

