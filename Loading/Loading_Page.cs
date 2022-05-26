using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Threading;
using proWin_Iti.log;

namespace proWin_Iti.Loading
{
    public partial class Loading_Page : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
              int left,
              int top,
              int right,
              int bottom,
              int width,
              int height
              );

        int[] rainSpeedS = { 4, 6, 8, 3, 5, 6, 7, 4, 6 };
        int loadingSpeed = 2;
        float initialPercentage = 0;

        public Loading_Page()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 7, 7));

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void Loading_Page_Load(object sender, EventArgs e)
        {
            timer1.Start();
            timer2.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           

            for (int i = 0; i < 8; i++)
            {
                switch (i)
                {
                    case 0:
                        // for rain 1
                        pictureBox10.Location = new Point(pictureBox10.Location.X, pictureBox10.Location.Y + rainSpeedS[i]);
                        if (pictureBox10.Location.Y > panel1.Size.Height + pictureBox10.Size.Height)
                        {
                            pictureBox10.Location = new Point(pictureBox10.Location.X, 0 - pictureBox10.Size.Height);
                        }

                        break;

                    case 1:
                        // for rain 2
                        pictureBox13.Location = new Point(pictureBox13.Location.X, pictureBox13.Location.Y + rainSpeedS[i]);
                        if (pictureBox13.Location.Y > panel1.Size.Height + pictureBox13.Size.Height)
                        {
                            pictureBox13.Location = new Point(pictureBox13.Location.X, 0 - pictureBox13.Size.Height);
                        }
                        break;

                    case 2:
                        // for rain 3
                        pictureBox6.Location = new Point(pictureBox6.Location.X, pictureBox6.Location.Y + rainSpeedS[i]);
                        if (pictureBox6.Location.Y > panel1.Size.Height + pictureBox6.Size.Height)
                        {
                            pictureBox6.Location = new Point(pictureBox6.Location.X, 0 - pictureBox6.Size.Height);
                        }
                        break;


                    case 3:
                        // for rain 4
                        pictureBox5.Location = new Point(pictureBox5.Location.X, pictureBox5.Location.Y + rainSpeedS[i]);
                        if (pictureBox5.Location.Y > panel1.Size.Height + pictureBox5.Size.Height)
                        {
                            pictureBox5.Location = new Point(pictureBox5.Location.X, 0 - pictureBox5.Size.Height);
                        }
                        break;

                    case 4:
                        // for rain 5
                        pictureBox7.Location = new Point(pictureBox7.Location.X, pictureBox7.Location.Y + rainSpeedS[i]);
                        if (pictureBox7.Location.Y > panel1.Size.Height + pictureBox7.Size.Height)
                        {
                            pictureBox7.Location = new Point(pictureBox7.Location.X, 0 - pictureBox7.Size.Height);
                        }
                        break;

                    case 5:
                        // for rain 6
                        pictureBox9.Location = new Point(pictureBox9.Location.X, pictureBox9.Location.Y + rainSpeedS[i]);
                        if (pictureBox9.Location.Y > panel1.Size.Height + pictureBox9.Size.Height)
                        {
                            pictureBox9.Location = new Point(pictureBox9.Location.X, 0 - pictureBox9.Size.Height);
                        }
                        break;

                    case 6:
                        // for rain 7
                        pictureBox11.Location = new Point(pictureBox11.Location.X, pictureBox11.Location.Y + rainSpeedS[i]);
                        if (pictureBox11.Location.Y > panel1.Size.Height + pictureBox11.Size.Height)
                        {
                            pictureBox11.Location = new Point(pictureBox11.Location.X, 0 - pictureBox11.Size.Height);
                        }
                        break;

                    case 7:
                        // for rain 8
                        pictureBox2.Location = new Point(pictureBox2.Location.X, pictureBox2.Location.Y + rainSpeedS[i]);
                        if (pictureBox2.Location.Y > panel1.Size.Height + pictureBox2.Size.Height)
                        {
                            pictureBox2.Location = new Point(pictureBox2.Location.X, 0 - pictureBox2.Size.Height);
                        }
                        break;

                    case 8:
                        // for rain 9
                        pictureBox8.Location = new Point(pictureBox8.Location.X, pictureBox8.Location.Y + rainSpeedS[i]);
                        if (pictureBox8.Location.Y > panel1.Size.Height + pictureBox8.Size.Height)
                        {
                            pictureBox8.Location = new Point(pictureBox8.Location.X, 0 - pictureBox8.Size.Height);
                        }
                        break;
                }
            }
        }
        private void timer2_Tick(object sender, EventArgs e)
        {

            this.Visible = false;
            timer1.Stop();
            timer2.Stop();
            Logg l = new Logg();
            l.ShowDialog();
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
