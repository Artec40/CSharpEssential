using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson8._2
{
    enum Post
    {
        Manager = 160,
        Senior = 160,
        Middle = 80,
        Junior = 160
    }

    class Accauntant
    {
        public bool AskForBonus(Post worker, int hours)
        {
            if (hours > (int)worker)    
                return true;
            else
                return false;
        }
    }
}
