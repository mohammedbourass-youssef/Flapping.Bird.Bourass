using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace FlapyBird
{
    public class clsMusic
    {
       static public void GameOverSound()
        {
            SoundPlayer player = new SoundPlayer("GameOver.wav"); // Replace 'song' with your resource name

            player.Play();
               
        }
        static public void BirdFlappingSound()
        {
            SoundPlayer player = new SoundPlayer("flappingSound.wav"); // Replace 'song' with your resource name

            player.Play();
               
        }
    }
}
