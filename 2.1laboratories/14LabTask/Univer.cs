using System;
using System.Collections.Generic;
using System.Text;

namespace _14LabTask
{
    class Univer
    {
        public Challenge[] Firstd()
        {
            Challenge[] Firstd = new Challenge[3];

            for (int i = 0; i < 3; i++)
            {
                Firstd[i] = new Challenge();
            }
            return Firstd;
        }

        public Challenge[] Secondd()
        {
            Challenge[] Secondd = new Challenge[3];

            for (int i = 0; i < 3; i++)
            {
                Secondd[i] = new Challenge();
            }
            return Secondd;
        }
        public Challenge[][] CreateUniver()
        {
            Challenge[][] uni = new Challenge[2][];
            uni[0] = new Univer().Firstd();
            uni[1] = new Univer().Secondd();
            return uni;
        }
    }
}
