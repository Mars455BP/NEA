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
            //Changing colour of specified items

            for (int i = 0; i < Program.itemstopick; i++)
            {
                Console.WriteLine(Program.strList[i] + " is the " + i + " item");
                switch (Program.strList[i])
                {
                    case ("Eggs"):
                        Eggs.BackColor = Color.Green;

                        break;
                    case ("Cheese"):
                        Cheese.BackColor = Color.Green;
                        break;
                    case ("Milk"):
                        Milk.BackColor = Color.Green;
                        break;
                    case ("Tomatoes"):
                        Tomatoes.BackColor = Color.Green;
                        break;
                    case ("Apples"):
                        Apples.BackColor = Color.Green;
                        break;
                    case ("Bananas"):
                        Bananas.BackColor = Color.Green;
                        break;
                    case ("Baked Beans"):
                        BakedBeans.BackColor = Color.Green;
                        break;
                    case ("Chopped Tomatoes"):
                        ChoppedTomatoes.BackColor = Color.Green;
                        break;
                    case ("Chilli Powder"):
                        ChilliPowder.BackColor = Color.Green;
                        break;
                    case ("Frozen Pizza"):
                        FrozenPizza.BackColor = Color.Green;
                        break;
                    case ("Ice Cream"):
                        IceCream.BackColor = Color.Green;
                        break;
                    case ("Cat Food"):
                        CatFood.BackColor = Color.Green;
                        break;
                    case ("Dog Toys"):
                        DogToys.BackColor = Color.Green;
                        break;
                    case ("Dog Food"):
                        DogFood.BackColor = Color.Green;
                        break;
                    default:
                        break;
                }
            }

            

        }
        private void UserInterface_Load(object sender, EventArgs e)
        {
    
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Next Button clicked");
            progressBar1.Maximum = Program.itemstopick;

            progressBar1.Minimum = 0;
            if (progressBar1.Value >= progressBar1.Maximum)
            {
                Console.Beep();
                Console.WriteLine("Addition failed- max reached");
            }
            else
            {
                x++;
                progressBar1.Value++;
                Console.WriteLine("Value progressed");
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
            Graphics gra = this.panel1.CreateGraphics();
            Pen pen = new Pen(Color.Black, 1);
            e.Graphics.DrawLine(pen, Path.locationChecker('x', "Eggs")+'F', Path.locationChecker('y', "Eggs")+'F', Path.locationChecker('x', "Milk")+'F', Path.locationChecker('y', "Milk") + 'F');

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

        private void Eggs_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void Apples_CheckedChanged(object sender, EventArgs e)
        {

        }
    }    

        
}
