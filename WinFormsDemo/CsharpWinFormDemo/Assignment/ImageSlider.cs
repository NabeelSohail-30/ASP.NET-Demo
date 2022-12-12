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
    public partial class ImageSlider : Form
    {
        string[] ImageList = {
                                    @"E:\Programming-Web-DB\DotNet\WinFormsDemo\CsharpWinFormDemo\Images\Img01.jpg",
                                    @"E:\Programming-Web-DB\DotNet\WinFormsDemo\CsharpWinFormDemo\Images\Img02.jpg",
                                    @"E:\Programming-Web-DB\DotNet\WinFormsDemo\CsharpWinFormDemo\Images\Img03.jpg",
                                    @"E:\Programming-Web-DB\DotNet\WinFormsDemo\CsharpWinFormDemo\Images\Img04.jpg",
                                    @"E:\Programming-Web-DB\DotNet\WinFormsDemo\CsharpWinFormDemo\Images\Img05.jpg",
                                    @"E:\Programming-Web-DB\DotNet\WinFormsDemo\CsharpWinFormDemo\Images\Img06.jpg",
                                    @"E:\Programming-Web-DB\DotNet\WinFormsDemo\CsharpWinFormDemo\Images\Img07.jpeg",
                                    @"E:\Programming-Web-DB\DotNet\WinFormsDemo\CsharpWinFormDemo\Images\Img08.jpg",
                                    @"E:\Programming-Web-DB\DotNet\WinFormsDemo\CsharpWinFormDemo\Images\Img09.jpg",
                                    @"E:\Programming-Web-DB\DotNet\WinFormsDemo\CsharpWinFormDemo\Images\Img10.jpg",
                                    @"E:\Programming-Web-DB\DotNet\WinFormsDemo\CsharpWinFormDemo\Images\Img11.jpg",
                                    @"E:\Programming-Web-DB\DotNet\WinFormsDemo\CsharpWinFormDemo\Images\Img12.png",
                                    @"E:\Programming-Web-DB\DotNet\WinFormsDemo\CsharpWinFormDemo\Images\Img13.jpg",
                                    @"E:\Programming-Web-DB\DotNet\WinFormsDemo\CsharpWinFormDemo\Images\Img14.jpg",
                                    @"E:\Programming-Web-DB\DotNet\WinFormsDemo\CsharpWinFormDemo\Images\Img15.jpg"
                                 };
        int Index = 0;

        public ImageSlider()
        {
            InitializeComponent();
        }

        private void ImageSlider_Load(object sender, EventArgs e)
        {

            //this.pictureBox1.Image = new Bitmap(ImageList[Index]);
            this.pictureBox1.Image = Image.FromFile(ImageList[Index]);

        }

        private void NextImage()
        {
            if(this.Index < this.ImageList.Length-1)
            {
                Index++;
                this.pictureBox1.Image = new Bitmap(ImageList[Index]);
            }
        }

        private void PreviousImage()
        {
            if (this.Index > 0)
            {
                Index--;
                this.pictureBox1.Image = new Bitmap(ImageList[Index]);
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            NextImage();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            PreviousImage();
        }
    }
}
