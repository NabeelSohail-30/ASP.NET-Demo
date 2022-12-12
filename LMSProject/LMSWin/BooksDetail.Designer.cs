namespace LMSWin
{
    partial class BooksDetail
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
            this.LblHeader = new System.Windows.Forms.Label();
            this.header1 = new LMSWin.Header();
            this.footer1 = new LMSWin.Footer();
            this.PanelAction = new System.Windows.Forms.Panel();
            this.TableAddBtn = new System.Windows.Forms.TableLayoutPanel();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.TableSearch = new System.Windows.Forms.TableLayoutPanel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.ListAuthor = new System.Windows.Forms.ComboBox();
            this.ListCategory = new System.Windows.Forms.ComboBox();
            this.ListPublisher = new System.Windows.Forms.ComboBox();
            this.ListLanguage = new System.Windows.Forms.ComboBox();
            this.BtnSearch = new System.Windows.Forms.Button();
            this.PanelGrid = new System.Windows.Forms.Panel();
            this.GridBooks = new System.Windows.Forms.DataGridView();
            this.PanelAction.SuspendLayout();
            this.TableAddBtn.SuspendLayout();
            this.TableSearch.SuspendLayout();
            this.PanelGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridBooks)).BeginInit();
            this.SuspendLayout();
            // 
            // LblHeader
            // 
            this.LblHeader.BackColor = System.Drawing.Color.MidnightBlue;
            this.LblHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.LblHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblHeader.ForeColor = System.Drawing.Color.White;
            this.LblHeader.Location = new System.Drawing.Point(0, 48);
            this.LblHeader.Name = "LblHeader";
            this.LblHeader.Size = new System.Drawing.Size(1369, 49);
            this.LblHeader.TabIndex = 3;
            this.LblHeader.Text = "Library Management System";
            this.LblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // header1
            // 
            this.header1.Dock = System.Windows.Forms.DockStyle.Top;
            this.header1.Location = new System.Drawing.Point(0, 0);
            this.header1.Name = "header1";
            this.header1.Size = new System.Drawing.Size(1369, 48);
            this.header1.TabIndex = 2;
            // 
            // footer1
            // 
            this.footer1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.footer1.Location = new System.Drawing.Point(0, 869);
            this.footer1.Name = "footer1";
            this.footer1.Size = new System.Drawing.Size(1369, 74);
            this.footer1.TabIndex = 4;
            // 
            // PanelAction
            // 
            this.PanelAction.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(112)))), ((int)(((byte)(180)))));
            this.PanelAction.Controls.Add(this.TableAddBtn);
            this.PanelAction.Controls.Add(this.TableSearch);
            this.PanelAction.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelAction.Location = new System.Drawing.Point(0, 97);
            this.PanelAction.Name = "PanelAction";
            this.PanelAction.Size = new System.Drawing.Size(1369, 125);
            this.PanelAction.TabIndex = 5;
            // 
            // TableAddBtn
            // 
            this.TableAddBtn.ColumnCount = 3;
            this.TableAddBtn.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 44.44444F));
            this.TableAddBtn.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.TableAddBtn.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 44.44444F));
            this.TableAddBtn.Controls.Add(this.BtnAdd, 1, 0);
            this.TableAddBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.TableAddBtn.Location = new System.Drawing.Point(0, 79);
            this.TableAddBtn.Name = "TableAddBtn";
            this.TableAddBtn.RowCount = 1;
            this.TableAddBtn.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TableAddBtn.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.TableAddBtn.Size = new System.Drawing.Size(1369, 46);
            this.TableAddBtn.TabIndex = 2;
            // 
            // BtnAdd
            // 
            this.BtnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(43)))), ((int)(((byte)(111)))));
            this.BtnAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(46)))), ((int)(((byte)(132)))));
            this.BtnAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(46)))), ((int)(((byte)(132)))));
            this.BtnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAdd.ForeColor = System.Drawing.Color.White;
            this.BtnAdd.Location = new System.Drawing.Point(611, 3);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(146, 40);
            this.BtnAdd.TabIndex = 0;
            this.BtnAdd.Text = "Add New Book";
            this.BtnAdd.UseVisualStyleBackColor = false;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // TableSearch
            // 
            this.TableSearch.ColumnCount = 8;
            this.TableSearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.532374F));
            this.TableSearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.38849F));
            this.TableSearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.38849F));
            this.TableSearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.38849F));
            this.TableSearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.38849F));
            this.TableSearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.38849F));
            this.TableSearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.992805F));
            this.TableSearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.532374F));
            this.TableSearch.Controls.Add(this.textBox1, 1, 0);
            this.TableSearch.Controls.Add(this.ListAuthor, 2, 0);
            this.TableSearch.Controls.Add(this.ListCategory, 3, 0);
            this.TableSearch.Controls.Add(this.ListPublisher, 4, 0);
            this.TableSearch.Controls.Add(this.ListLanguage, 5, 0);
            this.TableSearch.Controls.Add(this.BtnSearch, 6, 0);
            this.TableSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.TableSearch.Location = new System.Drawing.Point(0, 0);
            this.TableSearch.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.TableSearch.Name = "TableSearch";
            this.TableSearch.RowCount = 1;
            this.TableSearch.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TableSearch.Size = new System.Drawing.Size(1369, 35);
            this.TableSearch.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(133, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(190, 29);
            this.textBox1.TabIndex = 0;
            // 
            // ListAuthor
            // 
            this.ListAuthor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListAuthor.FormattingEnabled = true;
            this.ListAuthor.Location = new System.Drawing.Point(329, 3);
            this.ListAuthor.Name = "ListAuthor";
            this.ListAuthor.Size = new System.Drawing.Size(190, 28);
            this.ListAuthor.TabIndex = 1;
            // 
            // ListCategory
            // 
            this.ListCategory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListCategory.FormattingEnabled = true;
            this.ListCategory.Location = new System.Drawing.Point(525, 3);
            this.ListCategory.Name = "ListCategory";
            this.ListCategory.Size = new System.Drawing.Size(190, 28);
            this.ListCategory.TabIndex = 2;
            // 
            // ListPublisher
            // 
            this.ListPublisher.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListPublisher.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListPublisher.FormattingEnabled = true;
            this.ListPublisher.Location = new System.Drawing.Point(721, 3);
            this.ListPublisher.Name = "ListPublisher";
            this.ListPublisher.Size = new System.Drawing.Size(190, 28);
            this.ListPublisher.TabIndex = 3;
            // 
            // ListLanguage
            // 
            this.ListLanguage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListLanguage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListLanguage.FormattingEnabled = true;
            this.ListLanguage.Location = new System.Drawing.Point(917, 3);
            this.ListLanguage.Name = "ListLanguage";
            this.ListLanguage.Size = new System.Drawing.Size(190, 28);
            this.ListLanguage.TabIndex = 4;
            // 
            // BtnSearch
            // 
            this.BtnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(46)))), ((int)(((byte)(132)))));
            this.BtnSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSearch.ForeColor = System.Drawing.Color.White;
            this.BtnSearch.Location = new System.Drawing.Point(1113, 3);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(117, 29);
            this.BtnSearch.TabIndex = 5;
            this.BtnSearch.Text = "Search";
            this.BtnSearch.UseVisualStyleBackColor = false;
            // 
            // PanelGrid
            // 
            this.PanelGrid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(46)))), ((int)(((byte)(132)))));
            this.PanelGrid.Controls.Add(this.GridBooks);
            this.PanelGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelGrid.Location = new System.Drawing.Point(0, 222);
            this.PanelGrid.Name = "PanelGrid";
            this.PanelGrid.Size = new System.Drawing.Size(1369, 647);
            this.PanelGrid.TabIndex = 6;
            // 
            // GridBooks
            // 
            this.GridBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridBooks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridBooks.Location = new System.Drawing.Point(0, 0);
            this.GridBooks.Name = "GridBooks";
            this.GridBooks.Size = new System.Drawing.Size(1369, 647);
            this.GridBooks.TabIndex = 0;
            // 
            // BooksDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1369, 943);
            this.Controls.Add(this.PanelGrid);
            this.Controls.Add(this.PanelAction);
            this.Controls.Add(this.footer1);
            this.Controls.Add(this.LblHeader);
            this.Controls.Add(this.header1);
            this.MaximizeBox = false;
            this.Name = "BooksDetail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Books";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.BooksDetail_Load);
            this.PanelAction.ResumeLayout(false);
            this.TableAddBtn.ResumeLayout(false);
            this.TableSearch.ResumeLayout(false);
            this.TableSearch.PerformLayout();
            this.PanelGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridBooks)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LblHeader;
        private Header header1;
        private Footer footer1;
        private System.Windows.Forms.Panel PanelAction;
        private System.Windows.Forms.TableLayoutPanel TableSearch;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox ListAuthor;
        private System.Windows.Forms.ComboBox ListCategory;
        private System.Windows.Forms.ComboBox ListPublisher;
        private System.Windows.Forms.ComboBox ListLanguage;
        private System.Windows.Forms.Button BtnSearch;
        private System.Windows.Forms.Panel PanelGrid;
        private System.Windows.Forms.TableLayoutPanel TableAddBtn;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.DataGridView GridBooks;
    }
}