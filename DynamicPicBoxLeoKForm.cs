using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//threading
using System.Threading;

namespace DynamicPicBoxLeoK
{
    public partial class frmDynamicPicBoxLeoK : Form
    {
        public frmDynamicPicBoxLeoK()
        {
            InitializeComponent();
            this.lblRequest.Hide();
        }

        private void GeneratePictureBoxes()
        {
            //generate the picture boxes on the form
            GeneratePictureBox(61, 78);
            GeneratePictureBox(464, 78);
            GeneratePictureBox(61, 358);
            GeneratePictureBox(464, 358);
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            //show the request label
            this.lblRequest.Show();

            //generate the picture boxes
            GeneratePictureBoxes();
        }

        private void GeneratePictureBox(int x, int y)
        {
            //dynamically generate a new picture box and a point at the given location (x,y)
            PictureBox tmpPicMan = new PictureBox();
            Point pntPic = new System.Drawing.Point(x, y);

            //set the location of the picture box
            tmpPicMan.Location = pntPic;

            //set the image of the picture box
            tmpPicMan.Image = Properties.Resources.walk1;

            //stretch the image to the size of the picture box
            tmpPicMan.SizeMode = PictureBoxSizeMode.StretchImage;

            //make the picture box width and height the same as the image
            tmpPicMan.ClientSize = new Size(Properties.Resources.walk1.Width, Properties.Resources.walk1.Height);

            //add the event listener
            tmpPicMan.Click += new System.EventHandler(PictureBox_Click);

            //add the picture box to the form
            this.Controls.Add(tmpPicMan);
        }

        private void PictureBox_Click(object sender, EventArgs e)
        {
            //cast the sender object into a picture box
            PictureBox tmpPicMan = (PictureBox)sender;

            //write a line in console to see if it was clicked
            Console.WriteLine("Picture Box (" + tmpPicMan.Location.X + ", " + tmpPicMan.Location.Y + ") was clicked.");

            //declare local variables and constants
            const byte MAX_FRAMES = 10;
            int pictureFrameCounter = 1;

            //make the man walk
            while (pictureFrameCounter < MAX_FRAMES + 1)
            {
                if (pictureFrameCounter == 1)
                {
                    tmpPicMan.Image = Properties.Resources.walk1;
                }
                else if (pictureFrameCounter == 2)
                {
                    tmpPicMan.Image = Properties.Resources.walk2;
                }
                else if (pictureFrameCounter == 3)
                {
                    tmpPicMan.Image = Properties.Resources.walk3;
                }
                else if (pictureFrameCounter == 4)
                {
                    tmpPicMan.Image = Properties.Resources.walk4;
                }
                else if (pictureFrameCounter == 5)
                {
                    tmpPicMan.Image = Properties.Resources.walk5;
                }
                else if (pictureFrameCounter == 6)
                {
                    tmpPicMan.Image = Properties.Resources.walk6;
                }
                else if (pictureFrameCounter == 7)
                {
                    tmpPicMan.Image = Properties.Resources.walk7;
                }
                else if (pictureFrameCounter == 8)
                {
                    tmpPicMan.Image = Properties.Resources.walk8;
                }
                else if (pictureFrameCounter == 9)
                {
                    tmpPicMan.Image = Properties.Resources.walk9;
                }
                else if (pictureFrameCounter == 10)
                {
                    tmpPicMan.Image = Properties.Resources.walk10;
                }
                //increment the counter
                pictureFrameCounter++;

                //refresh the screen
                this.Refresh();

                //pause the loop
                Thread.Sleep(50);
            }
        }
    }
}
