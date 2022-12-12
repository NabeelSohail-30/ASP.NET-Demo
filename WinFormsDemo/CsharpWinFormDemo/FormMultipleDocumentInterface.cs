using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CsharpWinFormDemo
{
    public partial class FormMultipleDocumentInterface : Form
    {
        int DocNumber = 0;
        FormMDIChild01 newChild = null;
        public FormMultipleDocumentInterface()
        {
            InitializeComponent();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormMDIChild01 newDoc = new FormMDIChild01();
            DocNumber++;
            newDoc.Text = "New Document " + DocNumber.ToString();
            newDoc.Name = "MyChild01Form" + DocNumber.ToString();
            newDoc.MdiParent = this;
            newDoc.Show();
        }

        private void openRecentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Get All the Details about Opened Forms.

            FormCollection fc = Application.OpenForms;

            foreach(Form curForm in fc)
            {
                MessageBox.Show(curForm.Name);
                if(curForm.Name=="MyChild01Form2")
                {
                    //To Do List
                    //MessageBox.Show("Found your required Form");
                    curForm.Activate();
                }
            }

            
        }

        private void newProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (newChild==null)
            {
                newChild = new FormMDIChild01();

                newChild.MdiParent = this;
                newChild.FormClosed += NewChild_FormClosed;
                newChild.Show();
            }
            else
            {
                newChild.Focus();

                //or
                //newChild.Activate();
            }
        }

        private void NewChild_FormClosed(object sender, FormClosedEventArgs e)
        {
            newChild = null;
        }

        private void cascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);

        }
    }
}
