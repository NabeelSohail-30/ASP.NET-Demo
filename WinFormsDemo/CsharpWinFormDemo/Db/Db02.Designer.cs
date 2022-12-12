namespace CsharpWinFormDemo.Db
{
    partial class Db02
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
            this.ComboAuthor = new System.Windows.Forms.ComboBox();
            this.ComboAuthor2 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ComboAuthor
            // 
            this.ComboAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboAuthor.FormattingEnabled = true;
            this.ComboAuthor.Location = new System.Drawing.Point(31, 26);
            this.ComboAuthor.Name = "ComboAuthor";
            this.ComboAuthor.Size = new System.Drawing.Size(353, 28);
            this.ComboAuthor.TabIndex = 0;
            this.ComboAuthor.TabStop = false;
            // 
            // ComboAuthor2
            // 
            this.ComboAuthor2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboAuthor2.FormattingEnabled = true;
            this.ComboAuthor2.Location = new System.Drawing.Point(31, 119);
            this.ComboAuthor2.Name = "ComboAuthor2";
            this.ComboAuthor2.Size = new System.Drawing.Size(353, 28);
            this.ComboAuthor2.TabIndex = 1;
            this.ComboAuthor2.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(390, 26);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 28);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(390, 119);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(105, 28);
            this.button2.TabIndex = 3;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Db02
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 796);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ComboAuthor2);
            this.Controls.Add(this.ComboAuthor);
            this.Name = "Db02";
            this.Text = "Db02";
            this.Load += new System.EventHandler(this.Db02_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox ComboAuthor;
        private System.Windows.Forms.ComboBox ComboAuthor2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}