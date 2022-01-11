using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
using System.Windows.Forms;

namespace aplikacja
{
    public partial class settings : UserControl
    {

        public settings()
        {
            InitializeComponent();
        }


        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            SoundPlayer player = new System.Media.SoundPlayer();
            
            if (checkBox1.Checked)
            {
                player.SoundLocation = @".\Resources\elevator.wav";
                player.Play();
            }
            else
            {
                player.Stop();
            }
            
        }
    }
}
