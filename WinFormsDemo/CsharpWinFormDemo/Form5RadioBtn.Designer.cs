namespace CsharpWinFormDemo
{
    partial class Form5RadioBtn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5RadioBtn));
            this.RDGenderMale = new System.Windows.Forms.RadioButton();
            this.RDGenderOthers = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RDGenderFemale = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.button7 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // RDGenderMale
            // 
            this.RDGenderMale.AutoSize = true;
            this.RDGenderMale.Location = new System.Drawing.Point(6, 19);
            this.RDGenderMale.Name = "RDGenderMale";
            this.RDGenderMale.Size = new System.Drawing.Size(48, 17);
            this.RDGenderMale.TabIndex = 0;
            this.RDGenderMale.TabStop = true;
            this.RDGenderMale.Text = "Male";
            this.RDGenderMale.UseVisualStyleBackColor = true;
            // 
            // RDGenderOthers
            // 
            this.RDGenderOthers.AutoSize = true;
            this.RDGenderOthers.Location = new System.Drawing.Point(6, 70);
            this.RDGenderOthers.Name = "RDGenderOthers";
            this.RDGenderOthers.Size = new System.Drawing.Size(56, 17);
            this.RDGenderOthers.TabIndex = 1;
            this.RDGenderOthers.TabStop = true;
            this.RDGenderOthers.Text = "Others";
            this.RDGenderOthers.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(6, 42);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(98, 26);
            this.radioButton4.TabIndex = 5;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Married";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.Location = new System.Drawing.Point(6, 19);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(82, 26);
            this.radioButton6.TabIndex = 3;
            this.radioButton6.TabStop = true;
            this.radioButton6.Text = "Single";
            this.radioButton6.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RDGenderMale);
            this.groupBox1.Controls.Add(this.RDGenderOthers);
            this.groupBox1.Controls.Add(this.RDGenderFemale);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(117, 100);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Gender";
            // 
            // RDGenderFemale
            // 
            this.RDGenderFemale.Image = global::CsharpWinFormDemo.Properties.Resources.icons8_bullet_30;
            this.RDGenderFemale.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.RDGenderFemale.Location = new System.Drawing.Point(6, 39);
            this.RDGenderFemale.Name = "RDGenderFemale";
            this.RDGenderFemale.Size = new System.Drawing.Size(105, 29);
            this.RDGenderFemale.TabIndex = 2;
            this.RDGenderFemale.TabStop = true;
            this.RDGenderFemale.Text = "Female";
            this.RDGenderFemale.UseVisualStyleBackColor = true;
            this.RDGenderFemale.CheckedChanged += new System.EventHandler(this.RDGenderFemale_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButton6);
            this.groupBox2.Controls.Add(this.radioButton4);
            this.groupBox2.Font = new System.Drawing.Font("Montserrat Alternates Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(135, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(120, 83);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Status";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 119);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Gender";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(12, 173);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(55, 17);
            this.checkBox1.TabIndex = 9;
            this.checkBox1.Text = "Matric";
            this.checkBox1.ThreeState = true;
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(12, 219);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(78, 17);
            this.checkBox2.TabIndex = 10;
            this.checkBox2.Text = "Graduation";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(12, 196);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(47, 17);
            this.checkBox3.TabIndex = 11;
            this.checkBox3.Text = "Inter";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(6, 242);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(117, 23);
            this.button2.TabIndex = 12;
            this.button2.Text = "Education";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(151, 160);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(104, 92);
            this.textBox1.TabIndex = 13;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CsharpWinFormDemo.Properties.Resources.photo_1604695753685_20e756f4aa61;
            this.pictureBox1.Location = new System.Drawing.Point(6, 300);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(151, 170);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(163, 366);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(121, 39);
            this.button3.TabIndex = 15;
            this.button3.Text = "Load Image";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(163, 411);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(121, 39);
            this.button4.TabIndex = 16;
            this.button4.Text = "Load Image (2)";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(317, 300);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(215, 170);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 17;
            this.pictureBox2.TabStop = false;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd-MMMM-yyyy, dddd  hh:mm:ss";
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(709, 30);
            this.dateTimePicker1.MaxDate = new System.DateTime(2025, 12, 31, 0, 0, 0, 0);
            this.dateTimePicker1.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(347, 26);
            this.dateTimePicker1.TabIndex = 18;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(730, 62);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(121, 39);
            this.button5.TabIndex = 19;
            this.button5.Text = "Text";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(857, 62);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(121, 39);
            this.button6.TabIndex = 20;
            this.button6.Text = "Value";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTextBox1.Location = new System.Drawing.Point(709, 116);
            this.maskedTextBox1.Mask = "999999-999999-9";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(142, 26);
            this.maskedTextBox1.TabIndex = 21;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(730, 160);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(121, 39);
            this.button7.TabIndex = 22;
            this.button7.Text = "Text";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // Form5RadioBtn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1109, 801);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form5RadioBtn";
            this.Text = "Form5RadioBtn";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton RDGenderMale;
        private System.Windows.Forms.RadioButton RDGenderOthers;
        private System.Windows.Forms.RadioButton RDGenderFemale;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Button button7;
    }
}