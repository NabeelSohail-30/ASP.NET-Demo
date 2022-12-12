namespace CsharpWinFormDemo
{
    partial class FormTabControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTabControl));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.TabHome = new System.Windows.Forms.TabPage();
            this.TabAbout = new System.Windows.Forms.TabPage();
            this.TabGallery = new System.Windows.Forms.TabPage();
            this.TabContact = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.tabControl1.SuspendLayout();
            this.TabHome.SuspendLayout();
            this.TabAbout.SuspendLayout();
            this.TabGallery.SuspendLayout();
            this.TabContact.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.TabHome);
            this.tabControl1.Controls.Add(this.TabAbout);
            this.tabControl1.Controls.Add(this.TabGallery);
            this.tabControl1.Controls.Add(this.TabContact);
            this.tabControl1.ImageList = this.imageList1;
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(796, 664);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.tabControl1_Selecting);
            // 
            // TabHome
            // 
            this.TabHome.Controls.Add(this.button1);
            this.TabHome.Controls.Add(this.textBox1);
            this.TabHome.Controls.Add(this.comboBox1);
            this.TabHome.Controls.Add(this.label1);
            this.TabHome.ImageIndex = 0;
            this.TabHome.Location = new System.Drawing.Point(4, 23);
            this.TabHome.Name = "TabHome";
            this.TabHome.Padding = new System.Windows.Forms.Padding(3);
            this.TabHome.Size = new System.Drawing.Size(788, 637);
            this.TabHome.TabIndex = 0;
            this.TabHome.Text = "Home";
            this.TabHome.UseVisualStyleBackColor = true;
            // 
            // TabAbout
            // 
            this.TabAbout.Controls.Add(this.button2);
            this.TabAbout.Controls.Add(this.textBox2);
            this.TabAbout.Controls.Add(this.comboBox2);
            this.TabAbout.Controls.Add(this.label2);
            this.TabAbout.ImageIndex = 1;
            this.TabAbout.Location = new System.Drawing.Point(4, 23);
            this.TabAbout.Name = "TabAbout";
            this.TabAbout.Padding = new System.Windows.Forms.Padding(3);
            this.TabAbout.Size = new System.Drawing.Size(788, 637);
            this.TabAbout.TabIndex = 1;
            this.TabAbout.Text = "About Us";
            this.TabAbout.UseVisualStyleBackColor = true;
            // 
            // TabGallery
            // 
            this.TabGallery.Controls.Add(this.textBox3);
            this.TabGallery.Controls.Add(this.comboBox3);
            this.TabGallery.Controls.Add(this.label3);
            this.TabGallery.ImageKey = "view.png";
            this.TabGallery.Location = new System.Drawing.Point(4, 23);
            this.TabGallery.Name = "TabGallery";
            this.TabGallery.Size = new System.Drawing.Size(788, 637);
            this.TabGallery.TabIndex = 2;
            this.TabGallery.Text = "Gallery";
            this.TabGallery.UseVisualStyleBackColor = true;
            // 
            // TabContact
            // 
            this.TabContact.Controls.Add(this.textBox4);
            this.TabContact.Controls.Add(this.comboBox4);
            this.TabContact.Controls.Add(this.label4);
            this.TabContact.ImageKey = "delete.png";
            this.TabContact.Location = new System.Drawing.Point(4, 23);
            this.TabContact.Name = "TabContact";
            this.TabContact.Size = new System.Drawing.Size(788, 637);
            this.TabContact.TabIndex = 3;
            this.TabContact.Text = "Contact Us";
            this.TabContact.UseVisualStyleBackColor = true;
            this.TabContact.Click += new System.EventHandler(this.TabContact_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(311, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Home Page";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(142, 146);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(358, 146);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(383, 147);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 5;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(167, 147);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(336, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "About Us";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(391, 153);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 8;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(175, 153);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 21);
            this.comboBox3.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(344, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "Gallery";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(392, 160);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 8;
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(176, 160);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(121, 21);
            this.comboBox4.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(345, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 24);
            this.label4.TabIndex = 6;
            this.label4.Text = "Contact";
            // 
            // button1
            // 
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.ImageKey = "edit.png";
            this.button1.ImageList = this.imageList1;
            this.button1.Location = new System.Drawing.Point(346, 299);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 36);
            this.button1.TabIndex = 3;
            this.button1.Text = "About Us";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(357, 308);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Gallery";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "delete.png");
            this.imageList1.Images.SetKeyName(1, "edit.png");
            this.imageList1.Images.SetKeyName(2, "view.png");
            // 
            // FormTabControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1137, 688);
            this.Controls.Add(this.tabControl1);
            this.Name = "FormTabControl";
            this.Text = "FormTabControl";
            this.Load += new System.EventHandler(this.FormTabControl_Load);
            this.tabControl1.ResumeLayout(false);
            this.TabHome.ResumeLayout(false);
            this.TabHome.PerformLayout();
            this.TabAbout.ResumeLayout(false);
            this.TabAbout.PerformLayout();
            this.TabGallery.ResumeLayout(false);
            this.TabGallery.PerformLayout();
            this.TabContact.ResumeLayout(false);
            this.TabContact.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage TabHome;
        private System.Windows.Forms.TabPage TabAbout;
        private System.Windows.Forms.TabPage TabGallery;
        private System.Windows.Forms.TabPage TabContact;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ImageList imageList1;
    }
}