using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bhangu_Fire_game
{
    public partial class Form1 : Form
    {
        //instance of the other class to play the game for fun 
        Bhangu_Fire_game.option.option instance_obj = new Bhangu_Fire_game.option.option();

        public Form1()
        {
            InitializeComponent();

            bhg_load.Enabled = false;
            bhg_spin.Enabled = false;
            bhg_shoot.Enabled = false;
            bhg_shoot_away.Enabled = false;
            bhg_reload.Enabled = false;

        }

        private void bhg_srt_Click(object sender, EventArgs e)
        {
            //calling the method of the start game 
            instance_obj.start(bhg_srt,bhg_pb);
            bhg_load.Enabled = true;

        }

        //this click is used to load the bullet in the gun to fire
        private void bhg_load_Click(object sender, EventArgs e)
        {
            //calling the method of the Load  the gun
            instance_obj.bhg_Load(bhg_load, bhg_pb);
            bhg_spin.Enabled =true;

        }

        private void bhg_spin_Click(object sender, EventArgs e)
        {
            //calling the method of the spin the gun
            instance_obj.bhg_Spin(bhg_spin, bhg_pb);

            bhg_shoot.Enabled = true;
            bhg_shoot_away.Enabled = true;
        }


        private void bhg_shoot_Click(object sender, EventArgs e)
        {
            //calling the method of the spin the gun
            instance_obj.bhg_Shot(bhg_shoot, bhg_pb);
            if (instance_obj.count==4) {
                bhg_shoot.Enabled = false;
                
                bhg_reload.Enabled = true;
            }
            if (instance_obj.count == 5)
            {
                bhg_shoot.Enabled = false;
                bhg_shoot_away.Enabled = false;
                bhg_reload.Enabled = true;
            }

        }

        private void bhg_shoot_away_Click(object sender, EventArgs e)
        {
            //calling the method of the spin the gun
            instance_obj.bhg_shotAway(bhg_shoot_away, bhg_pb);
            if (instance_obj.counter == 2)
            {
                bhg_shoot_away.Enabled = false;
                bhg_reload.Enabled = true;
            }

            if (instance_obj.counter == 5)
            {
                bhg_shoot.Enabled = false;
                bhg_shoot_away.Enabled = false;
                bhg_reload.Enabled = true;
            }



        }

        private void bhg_reload_Click(object sender, EventArgs e)
        {
            bhg_reload.Enabled = false;
            bhg_srt.Enabled = true;
            instance_obj.count = 0;
            instance_obj.counter = 0;

        }
    }
}
