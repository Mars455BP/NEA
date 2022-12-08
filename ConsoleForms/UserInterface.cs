using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Media;

namespace ConsoleForms
{
    public partial class UserInterface : Form
    {
        public static int x = -1;
        public UserInterface()
        {
            InitializeComponent();
            
            
        }

        private void UserInterface_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            progressBar1.Maximum = Program.itemstopick;

            progressBar1.Minimum = 0;
            if (progressBar1.Value >= progressBar1.Maximum)
            {
                Console.Beep();
            }
            else
            {
                x++;
                progressBar1.Value++;
                this.Milk.BackColor = System.Drawing.Color.Blue;
            }


        }



        private void ProgressBar1_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void ToolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            PickList PL = new PickList();
            PL.ShowDialog();
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ListView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ListView1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BackgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            SoundPlayer player = new SoundPlayer();
            player.SoundLocation = AppDomain.CurrentDomain.BaseDirectory + @"\The Nothing Battles Remastered - 02 - Endure Emptiness (1).wav";
            player.Play();
        }

        private void PlayMusic_Click(object sender, EventArgs e)
        {
            if (backgroundWorker1.IsBusy)
            {
                backgroundWorker1.CancelAsync();
            }
            else
            {
                backgroundWorker1.RunWorkerAsync();
            }
            

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox14_CheckedChanged(object sender, EventArgs e)
        {

        }
    }    

        
}
