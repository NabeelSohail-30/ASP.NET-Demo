namespace CsharpWinFormDemo.Db
{
    partial class db03_DS
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
            this.Lbl = new System.Windows.Forms.Label();
            this.TxtAuthorId = new System.Windows.Forms.TextBox();
            this.TxtAuthor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnFirst = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.LblRecord = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Lbl
            // 
            this.Lbl.AutoSize = true;
            this.Lbl.Location = new System.Drawing.Point(331, 123);
            this.Lbl.Name = "Lbl";
            this.Lbl.Size = new System.Drawing.Size(47, 13);
            this.Lbl.TabIndex = 0;
            this.Lbl.Text = "AuthorId";
            // 
            // TxtAuthorId
            // 
            this.TxtAuthorId.Location = new System.Drawing.Point(384, 120);
            this.TxtAuthorId.Name = "TxtAuthorId";
            this.TxtAuthorId.Size = new System.Drawing.Size(100, 20);
            this.TxtAuthorId.TabIndex = 1;
            // 
            // TxtAuthor
            // 
            this.TxtAuthor.Location = new System.Drawing.Point(384, 146);
            this.TxtAuthor.Name = "TxtAuthor";
            this.TxtAuthor.Size = new System.Drawing.Size(255, 20);
            this.TxtAuthor.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(309, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Author Name";
            // 
            // BtnFirst
            // 
            this.BtnFirst.Location = new System.Drawing.Point(233, 187);
            this.BtnFirst.Name = "BtnFirst";
            this.BtnFirst.Size = new System.Drawing.Size(75, 23);
            this.BtnFirst.TabIndex = 4;
            this.BtnFirst.Text = "Move First";
            this.BtnFirst.UseVisualStyleBackColor = true;
            this.BtnFirst.Click += new System.EventHandler(this.BtnFirst_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(474, 187);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Move Prev";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(393, 187);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Move Next";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(312, 187);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 7;
            this.button3.Text = "Move Last";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // LblRecord
            // 
            this.LblRecord.AutoSize = true;
            this.LblRecord.Location = new System.Drawing.Point(381, 224);
            this.LblRecord.Name = "LblRecord";
            this.LblRecord.Size = new System.Drawing.Size(42, 13);
            this.LblRecord.TabIndex = 8;
            this.LblRecord.Text = "Record";
            // 
            // db03_DS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1011, 687);
            this.Controls.Add(this.LblRecord);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BtnFirst);
            this.Controls.Add(this.TxtAuthor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtAuthorId);
            this.Controls.Add(this.Lbl);
            this.Name = "db03_DS";
            this.Text = "db03_DS";
            this.Load += new System.EventHandler(this.db03_DS_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl;
        private System.Windows.Forms.TextBox TxtAuthorId;
        private System.Windows.Forms.TextBox TxtAuthor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnFirst;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label LblRecord;
    }
}