using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BrandNewFormsGameETC
{
    public partial class GameScreen : Form
    {
        public GameScreen()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            string starter = "Change me";
            StringBuilder bar = new StringBuilder();

            foreach (char c in starter)
            {
                bar.Append(c);
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"C:\Users\ssh21\source\repos\BrandNewFormsGameETC\Resources\DialogSound");
                player.Play();
            }
            Console.WriteLine(starter);
        }

        public void DialogWriting(string[] args)
        {
        }
    }
}


