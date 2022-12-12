namespace LMSWin
{
    partial class Footer
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LabelFooter = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.StLblName = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LabelFooter
            // 
            this.LabelFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(43)))), ((int)(((byte)(111)))));
            this.LabelFooter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LabelFooter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelFooter.ForeColor = System.Drawing.Color.White;
            this.LabelFooter.Location = new System.Drawing.Point(0, 0);
            this.LabelFooter.Name = "LabelFooter";
            this.LabelFooter.Size = new System.Drawing.Size(1385, 50);
            this.LabelFooter.TabIndex = 4;
            this.LabelFooter.Text = "Copyright © 2020 - 2021, Library Management System. All Rights Reserved";
            this.LabelFooter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(46)))), ((int)(((byte)(132)))));
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StLblName});
            this.statusStrip1.Location = new System.Drawing.Point(0, 50);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1385, 24);
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // StLblName
            // 
            this.StLblName.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.StLblName.ForeColor = System.Drawing.Color.White;
            this.StLblName.Name = "StLblName";
            this.StLblName.Size = new System.Drawing.Size(72, 19);
            this.StLblName.Text = "Welcome";
            // 
            // Footer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.LabelFooter);
            this.Controls.Add(this.statusStrip1);
            this.Name = "Footer";
            this.Size = new System.Drawing.Size(1385, 74);
            this.Load += new System.EventHandler(this.Footer_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelFooter;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel StLblName;
    }
}
