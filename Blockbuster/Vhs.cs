using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blockbuster
{
    public class Vhs : Movie
    {
        public int CurrentTime { get; set; } = 0;

        public Vhs(string Title, int RunTime, Genre Category, params string[] Scenes) : base(Title, RunTime, Category, Scenes)
        {
        }

        
        public void Rewind()
        {
            CurrentTime = 0;
        }
        public  void Play()
        {
            if (CurrentTime < Scenes.Count)
            {
                string scene = Scenes[CurrentTime];
                Console.WriteLine(scene);
                CurrentTime++;
            }
            else
            {
                Rewind();
            }
        }

    }
}
