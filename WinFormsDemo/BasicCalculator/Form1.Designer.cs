namespace BasicCalculator
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
            this.TxtNum01 = new System.Windows.Forms.TextBox();
            this.TxtNum02 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.BtnSubtract = new System.Windows.Forms.Button();
            this.BtnMultiply = new System.Windows.Forms.Button();
            this.BtnDivide = new System.Windows.Forms.Button();
            this.BtnReset = new System.Windows.Forms.Button();
            this.TxtResult = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.label1.Location = new System.Drawing.Point(146, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Calculator";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(63, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(193, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enter Number 01";
            // 
            // TxtNum01
            // 
            this.TxtNum01.BackColor = System.Drawing.SystemColors.Window;
            this.TxtNum01.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNum01.Location = new System.Drawing.Point(262, 107);
            this.TxtNum01.Name = "TxtNum01";
            this.TxtNum01.Size = new System.Drawing.Size(129, 32);
            this.TxtNum01.TabIndex = 2;
            // 
            // TxtNum02
            // 
            this.TxtNum02.BackColor = System.Drawing.SystemColors.Window;
            this.TxtNum02.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNum02.Location = new System.Drawing.Point(262, 148);
            this.TxtNum02.Name = "TxtNum02";
            this.TxtNum02.Size = new System.Drawing.Size(129, 32);
            this.TxtNum02.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(63, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(193, 26);
            this.label3.TabIndex = 3;
            this.label3.Text = "Enter Number 02";
            // 
            // BtnAdd
            // 
            this.BtnAdd.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BtnAdd.FlatAppearance.BorderSize = 2;
            this.BtnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAdd.ForeColor = System.Drawing.Color.White;
            this.BtnAdd.Location = new System.Drawing.Point(12, 270);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(62, 35);
            this.BtnAdd.TabIndex = 5;
            this.BtnAdd.Text = "Add";
            this.BtnAdd.UseVisualStyleBackColor = false;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // BtnSubtract
            // 
            this.BtnSubtract.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BtnSubtract.FlatAppearance.BorderSize = 2;
            this.BtnSubtract.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSubtract.ForeColor = System.Drawing.Color.White;
            this.BtnSubtract.Location = new System.Drawing.Point(80, 270);
            this.BtnSubtract.Name = "BtnSubtract";
            this.BtnSubtract.Size = new System.Drawing.Size(93, 35);
            this.BtnSubtract.TabIndex = 6;
            this.BtnSubtract.Text = "Subtract";
            this.BtnSubtract.UseVisualStyleBackColor = false;
            this.BtnSubtract.Click += new System.EventHandler(this.BtnSubtract_Click);
            // 
            // BtnMultiply
            // 
            this.BtnMultiply.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BtnMultiply.FlatAppearance.BorderSize = 2;
            this.BtnMultiply.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMultiply.ForeColor = System.Drawing.Color.White;
            this.BtnMultiply.Location = new System.Drawing.Point(179, 270);
            this.BtnMultiply.Name = "BtnMultiply";
            this.BtnMultiply.Size = new System.Drawing.Size(85, 35);
            this.BtnMultiply.TabIndex = 7;
            this.BtnMultiply.Text = "Multiply";
            this.BtnMultiply.UseVisualStyleBackColor = false;
            this.BtnMultiply.Click += new System.EventHandler(this.BtnMultiply_Click);
            // 
            // BtnDivide
            // 
            this.BtnDivide.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BtnDivide.FlatAppearance.BorderSize = 2;
            this.BtnDivide.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDivide.ForeColor = System.Drawing.Color.White;
            this.BtnDivide.Location = new System.Drawing.Point(270, 270);
            this.BtnDivide.Name = "BtnDivide";
            this.BtnDivide.Size = new System.Drawing.Size(85, 35);
            this.BtnDivide.TabIndex = 8;
            this.BtnDivide.Text = "Divide";
            this.BtnDivide.UseVisualStyleBackColor = false;
            this.BtnDivide.Click += new System.EventHandler(this.BtnDivide_Click);
            // 
            // BtnReset
            // 
            this.BtnReset.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BtnReset.FlatAppearance.BorderSize = 2;
            this.BtnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnReset.ForeColor = System.Drawing.Color.White;
            this.BtnReset.Location = new System.Drawing.Point(361, 270);
            this.BtnReset.Name = "BtnReset";
            this.BtnReset.Size = new System.Drawing.Size(85, 35);
            this.BtnReset.TabIndex = 9;
            this.BtnReset.Text = "Reset";
            this.BtnReset.UseVisualStyleBackColor = false;
            this.BtnReset.Click += new System.EventHandler(this.BtnReset_Click);
            // 
            // TxtResult
            // 
            this.TxtResult.BackColor = System.Drawing.SystemColors.Window;
            this.TxtResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtResult.Location = new System.Drawing.Point(226, 210);
            this.TxtResult.Name = "TxtResult";
            this.TxtResult.Size = new System.Drawing.Size(129, 32);
            this.TxtResult.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(140, 213);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 26);
            this.label4.TabIndex = 10;
            this.label4.Text = "Result";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(461, 368);
            this.Controls.Add(this.TxtResult);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BtnReset);
            this.Controls.Add(this.BtnDivide);
            this.Controls.Add(this.BtnMultiply);
            this.Controls.Add(this.BtnSubtract);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.TxtNum02);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtNum01);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Basic Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtNum01;
        private System.Windows.Forms.TextBox TxtNum02;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.Button BtnSubtract;
        private System.Windows.Forms.Button BtnMultiply;
        private System.Windows.Forms.Button BtnDivide;
        private System.Windows.Forms.Button BtnReset;
        private System.Windows.Forms.TextBox TxtResult;
        private System.Windows.Forms.Label label4;
    }
}

