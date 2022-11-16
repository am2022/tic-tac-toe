using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tic_tac_toe
{
    public class Check_win
    {
        public char is_winner(char[] info, int num)
        {
            if(num > 2)
            {
                if (info[0] == 'x' && info[4] == 'x' && info[8] == 'x')
                {
                    return 'x';
                }
                else if (info[0] == 'o' && info[4] == 'o' && info[8] == 'o')
                {
                    return 'o';
                }
                else if (info[2] == 'x' && info[4] == 'x' && info[6] == 'x')
                {
                    return 'x';
                }
                else if (info[2] == 'o' && info[4] == 'o' && info[6] == 'o')
                {
                    return 'o';
                }

                else if (info[0] == 'x' && info[3] == 'x' && info[6] == 'x')
                {
                    return 'x';
                }
                else if (info[0] == 'o' && info[3] == 'o' && info[6] == 'o')
                {
                    return 'o';
                }
                else if (info[2] == 'x' && info[5] == 'x' && info[8] == 'x')
                {
                    return 'x';
                }
                else if (info[2] == 'o' && info[5] == 'o' && info[8] == 'o')
                {
                    return 'o';
                }
                else if (info[1] == 'x' && info[4] == 'x' && info[7] == 'x')
                {
                    return 'x';
                }
                else if (info[1] == 'o' && info[4] == 'o' && info[7] == 'o')
                {
                    return 'o';
                }

                else if (info[0] == 'x' && info[1] == 'x' && info[2] == 'x')
                {
                    return 'x';
                }
                else if (info[0] == 'o' && info[1] == 'o' && info[2] == 'o')
                {
                    return 'o';
                }
                else if (info[3] == 'x' && info[4] == 'x' && info[5] == 'x')
                {
                    return 'x';
                }
                else if (info[3] == 'o' && info[4] == 'o' && info[5] == 'o')
                {
                    return 'o';
                }
                else if (info[6] == 'x' && info[7] == 'x' && info[8] == 'x')
                {
                    return 'x';
                }
                else if (info[6] == 'o' && info[7] == 'o' && info[8] == 'o')
                {
                    return 'o';
                }

                else
                {
                    return 'n';
                }
            }
            else
            {
                return 'n';
            }
        }
    }
}
