namespace CsharpWinFormDemo.Assignment
{
    partial class OrderMenuList
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtTotQty = new System.Windows.Forms.TextBox();
            this.TxtTotPrice = new System.Windows.Forms.TextBox();
            this.TxtItemCount = new System.Windows.Forms.TextBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.BtnRemoveAll = new System.Windows.Forms.Button();
            this.BtnRemoveSelected = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.ListMenu = new System.Windows.Forms.ListBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.ListOrder = new System.Windows.Forms.ListBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.BtnPlaceOrder = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Qty = new System.Windows.Forms.NumericUpDown();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Qty)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1614, 100);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arial Black", 30F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1480, 100);
            this.label1.TabIndex = 0;
            this.label1.Text = "Order List";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel7);
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Location = new System.Drawing.Point(12, 115);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1614, 714);
            this.panel2.TabIndex = 1;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Transparent;
            this.panel7.Controls.Add(this.label5);
            this.panel7.Controls.Add(this.label4);
            this.panel7.Controls.Add(this.label3);
            this.panel7.Controls.Add(this.TxtTotQty);
            this.panel7.Controls.Add(this.TxtTotPrice);
            this.panel7.Controls.Add(this.TxtItemCount);
            this.panel7.Location = new System.Drawing.Point(763, 551);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(680, 119);
            this.panel7.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label5.Location = new System.Drawing.Point(487, 7);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(177, 23);
            this.label5.TabIndex = 5;
            this.label5.Text = "Total Price";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label4.Location = new System.Drawing.Point(355, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 23);
            this.label4.TabIndex = 4;
            this.label4.Text = "Total Quantity";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label3.Location = new System.Drawing.Point(223, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "Total Items";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TxtTotQty
            // 
            this.TxtTotQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTotQty.Location = new System.Drawing.Point(355, 33);
            this.TxtTotQty.Name = "TxtTotQty";
            this.TxtTotQty.Size = new System.Drawing.Size(126, 26);
            this.TxtTotQty.TabIndex = 2;
            // 
            // TxtTotPrice
            // 
            this.TxtTotPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTotPrice.Location = new System.Drawing.Point(487, 33);
            this.TxtTotPrice.Name = "TxtTotPrice";
            this.TxtTotPrice.Size = new System.Drawing.Size(177, 26);
            this.TxtTotPrice.TabIndex = 1;
            // 
            // TxtItemCount
            // 
            this.TxtItemCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtItemCount.Location = new System.Drawing.Point(223, 33);
            this.TxtItemCount.Name = "TxtItemCount";
            this.TxtItemCount.Size = new System.Drawing.Size(126, 26);
            this.TxtItemCount.TabIndex = 0;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Transparent;
            this.panel6.Controls.Add(this.BtnRemoveAll);
            this.panel6.Controls.Add(this.BtnRemoveSelected);
            this.panel6.Location = new System.Drawing.Point(1475, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(139, 545);
            this.panel6.TabIndex = 1;
            // 
            // BtnRemoveAll
            // 
            this.BtnRemoveAll.BackColor = System.Drawing.Color.DarkGray;
            this.BtnRemoveAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRemoveAll.Location = new System.Drawing.Point(11, 270);
            this.BtnRemoveAll.Name = "BtnRemoveAll";
            this.BtnRemoveAll.Size = new System.Drawing.Size(117, 36);
            this.BtnRemoveAll.TabIndex = 4;
            this.BtnRemoveAll.TabStop = false;
            this.BtnRemoveAll.Text = "Remove All";
            this.BtnRemoveAll.UseVisualStyleBackColor = false;
            this.BtnRemoveAll.Click += new System.EventHandler(this.BtnRemoveAll_Click);
            // 
            // BtnRemoveSelected
            // 
            this.BtnRemoveSelected.BackColor = System.Drawing.Color.DarkGray;
            this.BtnRemoveSelected.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRemoveSelected.Location = new System.Drawing.Point(11, 189);
            this.BtnRemoveSelected.Name = "BtnRemoveSelected";
            this.BtnRemoveSelected.Size = new System.Drawing.Size(117, 62);
            this.BtnRemoveSelected.TabIndex = 3;
            this.BtnRemoveSelected.TabStop = false;
            this.BtnRemoveSelected.Text = "Remove Selected";
            this.BtnRemoveSelected.UseVisualStyleBackColor = false;
            this.BtnRemoveSelected.Click += new System.EventHandler(this.BtnRemoveSelected_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.ListMenu);
            this.panel3.Location = new System.Drawing.Point(12, 115);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(588, 545);
            this.panel3.TabIndex = 0;
            // 
            // ListMenu
            // 
            this.ListMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListMenu.FormattingEnabled = true;
            this.ListMenu.ItemHeight = 24;
            this.ListMenu.Location = new System.Drawing.Point(3, 3);
            this.ListMenu.Name = "ListMenu";
            this.ListMenu.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.ListMenu.Size = new System.Drawing.Size(582, 532);
            this.ListMenu.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.Controls.Add(this.ListOrder);
            this.panel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel4.Location = new System.Drawing.Point(759, 115);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(722, 545);
            this.panel4.TabIndex = 1;
            // 
            // ListOrder
            // 
            this.ListOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListOrder.FormattingEnabled = true;
            this.ListOrder.ItemHeight = 20;
            this.ListOrder.Location = new System.Drawing.Point(3, 3);
            this.ListOrder.Name = "ListOrder";
            this.ListOrder.ScrollAlwaysVisible = true;
            this.ListOrder.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.ListOrder.Size = new System.Drawing.Size(716, 524);
            this.ListOrder.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Transparent;
            this.panel5.Controls.Add(this.BtnPlaceOrder);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Controls.Add(this.Qty);
            this.panel5.Location = new System.Drawing.Point(606, 115);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(147, 545);
            this.panel5.TabIndex = 0;
            // 
            // BtnPlaceOrder
            // 
            this.BtnPlaceOrder.BackColor = System.Drawing.Color.DarkGray;
            this.BtnPlaceOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPlaceOrder.Location = new System.Drawing.Point(14, 257);
            this.BtnPlaceOrder.Name = "BtnPlaceOrder";
            this.BtnPlaceOrder.Size = new System.Drawing.Size(117, 36);
            this.BtnPlaceOrder.TabIndex = 2;
            this.BtnPlaceOrder.TabStop = false;
            this.BtnPlaceOrder.Text = "Place Order";
            this.BtnPlaceOrder.UseVisualStyleBackColor = false;
            this.BtnPlaceOrder.Click += new System.EventHandler(this.BtnPlaceOrder_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label2.Location = new System.Drawing.Point(14, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Quantity";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Qty
            // 
            this.Qty.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Qty.Location = new System.Drawing.Point(14, 215);
            this.Qty.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Qty.Name = "Qty";
            this.Qty.ReadOnly = true;
            this.Qty.Size = new System.Drawing.Size(117, 26);
            this.Qty.TabIndex = 0;
            this.Qty.TabStop = false;
            this.Qty.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // OrderMenuList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1638, 841);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "OrderMenuList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OrderMenuList";
            this.Load += new System.EventHandler(this.OrderMenuList_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Qty)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.ListBox ListMenu;
        private System.Windows.Forms.ListBox ListOrder;
        private System.Windows.Forms.NumericUpDown Qty;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnPlaceOrder;
        private System.Windows.Forms.TextBox TxtItemCount;
        private System.Windows.Forms.TextBox TxtTotPrice;
        private System.Windows.Forms.TextBox TxtTotQty;
        private System.Windows.Forms.Button BtnRemoveAll;
        private System.Windows.Forms.Button BtnRemoveSelected;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
    }
}