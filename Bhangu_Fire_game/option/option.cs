using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bhangu_Fire_game.option
{
   public class option
    {
        public int count = 0,rdm=0;
        public int counter =0, rdmnxt = 0;
        public int win = 0,winNxt=0;
        //instance of the random class
        Random instance_obj = new Random();
        
        //first button to start the game to play 
        public void start(Button btn,PictureBox pb) {
            pb.Image = Bhangu_Fire_game.Properties.Resources.start;
            btn.Enabled = false;
            rdm = instance_obj.Next(1, 6);
            rdmnxt = instance_obj.Next(1, 4);
        }
        
        //first button to load the bullet to play 
        public void bhg_Load(Button btn, PictureBox pb)
        {
            pb.Image = Bhangu_Fire_game.Properties.Resources.load;
            btn.Enabled = false;
        }

        //first button to spin the gun to fire  
        public void bhg_Spin(Button btn, PictureBox pb)
        {
            pb.Image = Bhangu_Fire_game.Properties.Resources.spin;
            btn.Enabled = false;
        }

        //first button to spin the gun to fire  
        public void bhg_Shot(Button btn, PictureBox pb)
        {
            pb.Image = Bhangu_Fire_game.Properties.Resources.shoot;
         

            System.Media.SoundPlayer Sound = new System.Media.SoundPlayer(Bhangu_Fire_game.Properties.Resources._10_Guage_Shotgun_SoundBible_com_74120584);
            Sound.Play();
            count++;
            if (count == 4)
            {
                  //when the player click on the trigger and he is not shoot with in 4 chanes then he won the game 
                if (win==0) {

                    MessageBox.Show("Congrats you won the game you got 100 Marks");
                }
                
                btn.Enabled = false;
            }
            else {
                //when the player dead by the trigger then he lose the game and got 0 marks 
                if (count == rdm)
                {
                    win++;
                    MessageBox.Show("You are lose the Game ! ");
                    count = 5;
                    btn.Enabled = false;
                }
               
            }
        }


        public void bhg_shotAway(Button btn, PictureBox pb) {

            pb.Image = Bhangu_Fire_game.Properties.Resources.shoot_away;


            System.Media.SoundPlayer Sound = new System.Media.SoundPlayer(Bhangu_Fire_game.Properties.Resources._10_Guage_Shotgun_SoundBible_com_74120584);
            Sound.Play();
            counter++;

            if (counter == 2)
            {
                if (winNxt==0) {
                    MessageBox.Show("you won the Game ");
                    pb.Enabled = false;
                }
                
               
            }
            else {
                if (counter == rdmnxt)
                {
                    winNxt++;
                    MessageBox.Show("you lose the game ");
                    pb.Enabled = false;
                    counter = 5;
                }
                else {
                    MessageBox.Show("one more chance ");
                }
            }

        }





        public void check() {
            if (count == rdm)
            {
                MessageBox.Show("game over ");
            }
            else {
                MessageBox.Show("have more chance ");

            }
        }




    }
}
