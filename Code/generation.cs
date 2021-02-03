using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DokaPass
{
    class generation
    {
        bool loweraseB, uppercaseB, numbersB, charsB;
        int lenghtI, iSwitch, sizeSwitch; //iSwitch - for switch between bools for right generation / sizeSwitch (lowercaseB == true -> switch = +1)
        string key;
        public generation()
        {
            
        }

        private static Random rnd = new Random();

        public string generate(bool lowercaseB, bool uppercaseB, bool numbersB, bool charsB, int lenghtI)
        {
            this.loweraseB = lowercaseB;
            this.uppercaseB = uppercaseB;
            this.numbersB = numbersB;
            this.charsB = charsB;
            this.lenghtI = lenghtI;

            key = "";

            #region count of bools
            iSwitch = 1;
            sizeSwitch = 0;
            for (int i = 0; i < 4; i++)
            {
                switch (i)
                {
                    case 0:
                        if (lowercaseB == true) sizeSwitch = sizeSwitch + 1;
                        break;
                    case 1:
                        if (uppercaseB == true) sizeSwitch = sizeSwitch + 1;
                        break;
                    case 2:
                        if (numbersB == true) sizeSwitch = sizeSwitch + 1;
                        break;
                    case 3:
                        if (charsB == true) sizeSwitch = sizeSwitch + 1;
                        break;
                }
            }
            #endregion

            #region generation
            if (lowercaseB == true || uppercaseB == true || numbersB == true || charsB == true)
            {
                int number;

                for (int i = 0; i < lenghtI; i++)
                {
                    //0-0-0-1
                    if (lowercaseB == false && uppercaseB == false && numbersB == false && charsB == true)
                    {
                        number = Convert.ToInt32(rnd.Next(1, 7));
                        switch (number)
                        {
                            case 1:
                                key = key + '!';
                                break;
                            case 2:
                                key = key + '@';
                                break;
                            case 3:
                                key = key + '#';
                                break;
                            case 4:
                                key = key + '$';
                                break;
                            case 5:
                                key = key + '%';
                                break;
                            case 6:
                                key = key + '&';
                                break;
                            case 7:
                                key = key + '*';
                                break;
                        }
                    }
                    //0-0-1-0
                    else if(lowercaseB == false && uppercaseB == false && numbersB == true && charsB == false)
                    {
                        number = Convert.ToInt32(rnd.Next(1, 10));
                        key = key + number.ToString();
                    }
                    //0-0-1-1
                    else if (lowercaseB == false && uppercaseB == false && numbersB == true && charsB == true)
                    {
                        switch(iSwitch)
                        {
                            case 1:
                                number = Convert.ToInt32(rnd.Next(1, 7));
                                switch (number)
                                {
                                    case 1:
                                        key = key + '!';
                                        break;
                                    case 2:
                                        key = key + '@';
                                        break;
                                    case 3:
                                        key = key + '#';
                                        break;
                                    case 4:
                                        key = key + '$';
                                        break;
                                    case 5:
                                        key = key + '%';
                                        break;
                                    case 6:
                                        key = key + '&';
                                        break;
                                    case 7:
                                        key = key + '*';
                                        break;
                                }
                                ++iSwitch;
                                break;
                            case 2:
                                number = Convert.ToInt32(rnd.Next(1, 10));
                                key = key + number.ToString();
                                iSwitch = rnd.Next(1, 3);
                                break;
                        }
                    }
                    //0-1-0-0
                    else if (lowercaseB == false && uppercaseB == true && numbersB == false && charsB == false)
                    {
                        number = Convert.ToInt32(rnd.Next(1, 27));
                        switch (number)
                        {
                            case 1:
                                key = key + 'A';
                                break;
                            case 2:
                                key = key + 'B';
                                break;
                            case 3:
                                key = key + 'C';
                                break;
                            case 4:
                                key = key + 'D';
                                break;
                            case 5:
                                key = key + 'E';
                                break;
                            case 6:
                                key = key + 'F';
                                break;
                            case 7:
                                key = key + 'G';
                                break;
                            case 8:
                                key = key + 'H';
                                break;
                            case 9:
                                key = key + 'I';
                                break;
                            case 10:
                                key = key + 'J';
                                break;
                            case 11:
                                key = key + 'K';
                                break;
                            case 12:
                                key = key + 'L';
                                break;
                            case 13:
                                key = key + 'M';
                                break;
                            case 14:
                                key = key + 'N';
                                break;
                            case 15:
                                key = key + 'O';
                                break;
                            case 16:
                                key = key + 'P';
                                break;
                            case 17:
                                key = key + 'Q';
                                break;
                            case 18:
                                key = key + 'R';
                                break;
                            case 19:
                                key = key + 'S';
                                break;
                            case 20:
                                key = key + 'T';
                                break;
                            case 21:
                                key = key + 'U';
                                break;
                            case 22:
                                key = key + 'V';
                                break;
                            case 23:
                                key = key + 'W';
                                break;
                            case 24:
                                key = key + 'X';
                                break;
                            case 25:
                                key = key + 'Y';
                                break;
                            case 26:
                                key = key + 'Z';
                                break;
                        }

                    }
                    //0-1-0-1
                    else if (lowercaseB == false && uppercaseB == true && numbersB == false && charsB == true)
                    {
                        switch(iSwitch)
                        {
                            case 1:
                                number = Convert.ToInt32(rnd.Next(1, 27));
                                switch (number)
                                {
                                    case 1:
                                        key = key + 'A';
                                        break;
                                    case 2:
                                        key = key + 'B';
                                        break;
                                    case 3:
                                        key = key + 'C';
                                        break;
                                    case 4:
                                        key = key + 'D';
                                        break;
                                    case 5:
                                        key = key + 'E';
                                        break;
                                    case 6:
                                        key = key + 'F';
                                        break;
                                    case 7:
                                        key = key + 'G';
                                        break;
                                    case 8:
                                        key = key + 'H';
                                        break;
                                    case 9:
                                        key = key + 'I';
                                        break;
                                    case 10:
                                        key = key + 'J';
                                        break;
                                    case 11:
                                        key = key + 'K';
                                        break;
                                    case 12:
                                        key = key + 'L';
                                        break;
                                    case 13:
                                        key = key + 'M';
                                        break;
                                    case 14:
                                        key = key + 'N';
                                        break;
                                    case 15:
                                        key = key + 'O';
                                        break;
                                    case 16:
                                        key = key + 'P';
                                        break;
                                    case 17:
                                        key = key + 'Q';
                                        break;
                                    case 18:
                                        key = key + 'R';
                                        break;
                                    case 19:
                                        key = key + 'S';
                                        break;
                                    case 20:
                                        key = key + 'T';
                                        break;
                                    case 21:
                                        key = key + 'U';
                                        break;
                                    case 22:
                                        key = key + 'V';
                                        break;
                                    case 23:
                                        key = key + 'W';
                                        break;
                                    case 24:
                                        key = key + 'X';
                                        break;
                                    case 25:
                                        key = key + 'Y';
                                        break;
                                    case 26:
                                        key = key + 'Z';
                                        break;
                                }
                                ++iSwitch;
                                break;
                            case 2:
                                number = Convert.ToInt32(rnd.Next(1, 7));
                                switch (number)
                                {
                                    case 1:
                                        key = key + '!';
                                        break;
                                    case 2:
                                        key = key + '@';
                                        break;
                                    case 3:
                                        key = key + '#';
                                        break;
                                    case 4:
                                        key = key + '$';
                                        break;
                                    case 5:
                                        key = key + '%';
                                        break;
                                    case 6:
                                        key = key + '&';
                                        break;
                                    case 7:
                                        key = key + '*';
                                        break;
                                }
                                iSwitch = rnd.Next(1, 3);
                                break;
                        }
                    }
                    //0-1-1-0
                    else if (lowercaseB == false && uppercaseB == true && numbersB == true && charsB == false)
                    {
                        switch (iSwitch)
                        {
                            case 1:
                                number = Convert.ToInt32(rnd.Next(1, 27));
                                switch (number)
                                {
                                    case 1:
                                        key = key + 'A';
                                        break;
                                    case 2:
                                        key = key + 'B';
                                        break;
                                    case 3:
                                        key = key + 'C';
                                        break;
                                    case 4:
                                        key = key + 'D';
                                        break;
                                    case 5:
                                        key = key + 'E';
                                        break;
                                    case 6:
                                        key = key + 'F';
                                        break;
                                    case 7:
                                        key = key + 'G';
                                        break;
                                    case 8:
                                        key = key + 'H';
                                        break;
                                    case 9:
                                        key = key + 'I';
                                        break;
                                    case 10:
                                        key = key + 'J';
                                        break;
                                    case 11:
                                        key = key + 'K';
                                        break;
                                    case 12:
                                        key = key + 'L';
                                        break;
                                    case 13:
                                        key = key + 'M';
                                        break;
                                    case 14:
                                        key = key + 'N';
                                        break;
                                    case 15:
                                        key = key + 'O';
                                        break;
                                    case 16:
                                        key = key + 'P';
                                        break;
                                    case 17:
                                        key = key + 'Q';
                                        break;
                                    case 18:
                                        key = key + 'R';
                                        break;
                                    case 19:
                                        key = key + 'S';
                                        break;
                                    case 20:
                                        key = key + 'T';
                                        break;
                                    case 21:
                                        key = key + 'U';
                                        break;
                                    case 22:
                                        key = key + 'V';
                                        break;
                                    case 23:
                                        key = key + 'W';
                                        break;
                                    case 24:
                                        key = key + 'X';
                                        break;
                                    case 25:
                                        key = key + 'Y';
                                        break;
                                    case 26:
                                        key = key + 'Z';
                                        break;
                                }
                                ++iSwitch;
                                break;
                            case 2:
                                number = Convert.ToInt32(rnd.Next(1, 10));
                                key = key + number.ToString();
                                iSwitch = rnd.Next(1, 3);
                                break;
                        }
                    }
                    //0-1-1-1
                    else if (lowercaseB == false && uppercaseB == true && numbersB == true && charsB == true)
                    {
                        switch (iSwitch)
                        {
                            case 1:
                                number = Convert.ToInt32(rnd.Next(1, 27));
                                switch (number)
                                {
                                    case 1:
                                        key = key + 'A';
                                        break;
                                    case 2:
                                        key = key + 'B';
                                        break;
                                    case 3:
                                        key = key + 'C';
                                        break;
                                    case 4:
                                        key = key + 'D';
                                        break;
                                    case 5:
                                        key = key + 'E';
                                        break;
                                    case 6:
                                        key = key + 'F';
                                        break;
                                    case 7:
                                        key = key + 'G';
                                        break;
                                    case 8:
                                        key = key + 'H';
                                        break;
                                    case 9:
                                        key = key + 'I';
                                        break;
                                    case 10:
                                        key = key + 'J';
                                        break;
                                    case 11:
                                        key = key + 'K';
                                        break;
                                    case 12:
                                        key = key + 'L';
                                        break;
                                    case 13:
                                        key = key + 'M';
                                        break;
                                    case 14:
                                        key = key + 'N';
                                        break;
                                    case 15:
                                        key = key + 'O';
                                        break;
                                    case 16:
                                        key = key + 'P';
                                        break;
                                    case 17:
                                        key = key + 'Q';
                                        break;
                                    case 18:
                                        key = key + 'R';
                                        break;
                                    case 19:
                                        key = key + 'S';
                                        break;
                                    case 20:
                                        key = key + 'T';
                                        break;
                                    case 21:
                                        key = key + 'U';
                                        break;
                                    case 22:
                                        key = key + 'V';
                                        break;
                                    case 23:
                                        key = key + 'W';
                                        break;
                                    case 24:
                                        key = key + 'X';
                                        break;
                                    case 25:
                                        key = key + 'Y';
                                        break;
                                    case 26:
                                        key = key + 'Z';
                                        break;
                                }
                                ++iSwitch;
                                break;
                            case 2:
                                number = Convert.ToInt32(rnd.Next(1, 10));
                                key = key + number.ToString();
                                ++iSwitch;
                                break;
                            case 3:
                                number = Convert.ToInt32(rnd.Next(1, 7));
                                switch (number)
                                {
                                    case 1:
                                        key = key + '!';
                                        break;
                                    case 2:
                                        key = key + '@';
                                        break;
                                    case 3:
                                        key = key + '#';
                                        break;
                                    case 4:
                                        key = key + '$';
                                        break;
                                    case 5:
                                        key = key + '%';
                                        break;
                                    case 6:
                                        key = key + '&';
                                        break;
                                    case 7:
                                        key = key + '*';
                                        break;
                                }
                                iSwitch = rnd.Next(1, 4);
                                break;
                        }
                    }
                    //1-0-0-0
                    else if (lowercaseB == true && uppercaseB == false && numbersB == false && charsB == false)
                    {
                        number = Convert.ToInt32(rnd.Next(1, 27));
                        switch (number)
                        {
                            case 1:
                                key = key + 'a';
                                break;
                            case 2:
                                key = key + 'b';
                                break;
                            case 3:
                                key = key + 'c';
                                break;
                            case 4:
                                key = key + 'd';
                                break;
                            case 5:
                                key = key + 'e';
                                break;
                            case 6:
                                key = key + 'f';
                                break;
                            case 7:
                                key = key + 'g';
                                break;
                            case 8:
                                key = key + 'h';
                                break;
                            case 9:
                                key = key + 'i';
                                break;
                            case 10:
                                key = key + 'j';
                                break;
                            case 11:
                                key = key + 'k';
                                break;
                            case 12:
                                key = key + 'l';
                                break;
                            case 13:
                                key = key + 'm';
                                break;
                            case 14:
                                key = key + 'n';
                                break;
                            case 15:
                                key = key + 'o';
                                break;
                            case 16:
                                key = key + 'p';
                                break;
                            case 17:
                                key = key + 'q';
                                break;
                            case 18:
                                key = key + 'r';
                                break;
                            case 19:
                                key = key + 's';
                                break;
                            case 20:
                                key = key + 't';
                                break;
                            case 21:
                                key = key + 'u';
                                break;
                            case 22:
                                key = key + 'v';
                                break;
                            case 23:
                                key = key + 'w';
                                break;
                            case 24:
                                key = key + 'x';
                                break;
                            case 25:
                                key = key + 'y';
                                break;
                            case 26:
                                key = key + 'z';
                                break;
                        }

                    }
                    //1-0-0-1
                    else if (lowercaseB == true && uppercaseB == false && numbersB == false && charsB == true)
                    {
                        switch (iSwitch)
                        {
                            case 1:
                                number = Convert.ToInt32(rnd.Next(1, 27));
                                switch (number)
                                {
                                    case 1:
                                        key = key + 'a';
                                        break;
                                    case 2:
                                        key = key + 'b';
                                        break;
                                    case 3:
                                        key = key + 'c';
                                        break;
                                    case 4:
                                        key = key + 'd';
                                        break;
                                    case 5:
                                        key = key + 'e';
                                        break;
                                    case 6:
                                        key = key + 'f';
                                        break;
                                    case 7:
                                        key = key + 'g';
                                        break;
                                    case 8:
                                        key = key + 'h';
                                        break;
                                    case 9:
                                        key = key + 'i';
                                        break;
                                    case 10:
                                        key = key + 'j';
                                        break;
                                    case 11:
                                        key = key + 'k';
                                        break;
                                    case 12:
                                        key = key + 'l';
                                        break;
                                    case 13:
                                        key = key + 'm';
                                        break;
                                    case 14:
                                        key = key + 'n';
                                        break;
                                    case 15:
                                        key = key + 'o';
                                        break;
                                    case 16:
                                        key = key + 'p';
                                        break;
                                    case 17:
                                        key = key + 'q';
                                        break;
                                    case 18:
                                        key = key + 'r';
                                        break;
                                    case 19:
                                        key = key + 's';
                                        break;
                                    case 20:
                                        key = key + 't';
                                        break;
                                    case 21:
                                        key = key + 'u';
                                        break;
                                    case 22:
                                        key = key + 'v';
                                        break;
                                    case 23:
                                        key = key + 'w';
                                        break;
                                    case 24:
                                        key = key + 'x';
                                        break;
                                    case 25:
                                        key = key + 'y';
                                        break;
                                    case 26:
                                        key = key + 'z';
                                        break;
                                }
                                ++iSwitch;
                                break;
                            case 2:
                                number = Convert.ToInt32(rnd.Next(1, 7));
                                switch (number)
                                {
                                    case 1:
                                        key = key + '!';
                                        break;
                                    case 2:
                                        key = key + '@';
                                        break;
                                    case 3:
                                        key = key + '#';
                                        break;
                                    case 4:
                                        key = key + '$';
                                        break;
                                    case 5:
                                        key = key + '%';
                                        break;
                                    case 6:
                                        key = key + '&';
                                        break;
                                    case 7:
                                        key = key + '*';
                                        break;
                                }
                                iSwitch = rnd.Next(1, 3);
                                break;
                        }
                    }
                    //1-0-1-0
                    else if (lowercaseB == true && uppercaseB == false && numbersB == true && charsB == false)
                    {
                        switch (iSwitch)
                        {
                            case 1:
                                number = Convert.ToInt32(rnd.Next(1, 27));
                                switch (number)
                                {
                                    case 1:
                                        key = key + 'a';
                                        break;
                                    case 2:
                                        key = key + 'b';
                                        break;
                                    case 3:
                                        key = key + 'c';
                                        break;
                                    case 4:
                                        key = key + 'd';
                                        break;
                                    case 5:
                                        key = key + 'e';
                                        break;
                                    case 6:
                                        key = key + 'f';
                                        break;
                                    case 7:
                                        key = key + 'g';
                                        break;
                                    case 8:
                                        key = key + 'h';
                                        break;
                                    case 9:
                                        key = key + 'i';
                                        break;
                                    case 10:
                                        key = key + 'j';
                                        break;
                                    case 11:
                                        key = key + 'k';
                                        break;
                                    case 12:
                                        key = key + 'l';
                                        break;
                                    case 13:
                                        key = key + 'm';
                                        break;
                                    case 14:
                                        key = key + 'n';
                                        break;
                                    case 15:
                                        key = key + 'o';
                                        break;
                                    case 16:
                                        key = key + 'p';
                                        break;
                                    case 17:
                                        key = key + 'q';
                                        break;
                                    case 18:
                                        key = key + 'r';
                                        break;
                                    case 19:
                                        key = key + 's';
                                        break;
                                    case 20:
                                        key = key + 't';
                                        break;
                                    case 21:
                                        key = key + 'u';
                                        break;
                                    case 22:
                                        key = key + 'v';
                                        break;
                                    case 23:
                                        key = key + 'w';
                                        break;
                                    case 24:
                                        key = key + 'x';
                                        break;
                                    case 25:
                                        key = key + 'y';
                                        break;
                                    case 26:
                                        key = key + 'z';
                                        break;
                                }
                                ++iSwitch;
                                break;
                            case 2:
                                number = Convert.ToInt32(rnd.Next(1, 10));
                                key = key + number.ToString();
                                iSwitch = rnd.Next(1, 3);
                                break;
                        }
                    }
                    //1-0-1-1
                    else if (lowercaseB == true && uppercaseB == false && numbersB == true && charsB == true)
                    {
                        switch (iSwitch)
                        {
                            case 1:
                                number = Convert.ToInt32(rnd.Next(1, 27));
                                switch (number)
                                {
                                    case 1:
                                        key = key + 'a';
                                        break;
                                    case 2:
                                        key = key + 'b';
                                        break;
                                    case 3:
                                        key = key + 'c';
                                        break;
                                    case 4:
                                        key = key + 'd';
                                        break;
                                    case 5:
                                        key = key + 'e';
                                        break;
                                    case 6:
                                        key = key + 'f';
                                        break;
                                    case 7:
                                        key = key + 'g';
                                        break;
                                    case 8:
                                        key = key + 'h';
                                        break;
                                    case 9:
                                        key = key + 'i';
                                        break;
                                    case 10:
                                        key = key + 'j';
                                        break;
                                    case 11:
                                        key = key + 'k';
                                        break;
                                    case 12:
                                        key = key + 'l';
                                        break;
                                    case 13:
                                        key = key + 'm';
                                        break;
                                    case 14:
                                        key = key + 'n';
                                        break;
                                    case 15:
                                        key = key + 'o';
                                        break;
                                    case 16:
                                        key = key + 'p';
                                        break;
                                    case 17:
                                        key = key + 'q';
                                        break;
                                    case 18:
                                        key = key + 'r';
                                        break;
                                    case 19:
                                        key = key + 's';
                                        break;
                                    case 20:
                                        key = key + 't';
                                        break;
                                    case 21:
                                        key = key + 'u';
                                        break;
                                    case 22:
                                        key = key + 'v';
                                        break;
                                    case 23:
                                        key = key + 'w';
                                        break;
                                    case 24:
                                        key = key + 'x';
                                        break;
                                    case 25:
                                        key = key + 'y';
                                        break;
                                    case 26:
                                        key = key + 'z';
                                        break;
                                }
                                ++iSwitch;
                                break;
                            case 2:
                                number = Convert.ToInt32(rnd.Next(1, 10));
                                key = key + number.ToString();
                                ++iSwitch;
                                break;
                            case 3:
                                number = Convert.ToInt32(rnd.Next(1, 7));
                                switch (number)
                                {
                                    case 1:
                                        key = key + '!';
                                        break;
                                    case 2:
                                        key = key + '@';
                                        break;
                                    case 3:
                                        key = key + '#';
                                        break;
                                    case 4:
                                        key = key + '$';
                                        break;
                                    case 5:
                                        key = key + '%';
                                        break;
                                    case 6:
                                        key = key + '&';
                                        break;
                                    case 7:
                                        key = key + '*';
                                        break;
                                }
                                iSwitch = rnd.Next(1, 4);
                                break;
                        }
                    }
                    //1-1-0-0
                    else if (lowercaseB == true && uppercaseB == true && numbersB == false && charsB == false)
                    {
                        switch (iSwitch)
                        {
                            case 1:
                                number = Convert.ToInt32(rnd.Next(1, 27));
                                switch (number)
                                {
                                    case 1:
                                        key = key + 'a';
                                        break;
                                    case 2:
                                        key = key + 'b';
                                        break;
                                    case 3:
                                        key = key + 'c';
                                        break;
                                    case 4:
                                        key = key + 'd';
                                        break;
                                    case 5:
                                        key = key + 'e';
                                        break;
                                    case 6:
                                        key = key + 'f';
                                        break;
                                    case 7:
                                        key = key + 'g';
                                        break;
                                    case 8:
                                        key = key + 'h';
                                        break;
                                    case 9:
                                        key = key + 'i';
                                        break;
                                    case 10:
                                        key = key + 'j';
                                        break;
                                    case 11:
                                        key = key + 'k';
                                        break;
                                    case 12:
                                        key = key + 'l';
                                        break;
                                    case 13:
                                        key = key + 'm';
                                        break;
                                    case 14:
                                        key = key + 'n';
                                        break;
                                    case 15:
                                        key = key + 'o';
                                        break;
                                    case 16:
                                        key = key + 'p';
                                        break;
                                    case 17:
                                        key = key + 'q';
                                        break;
                                    case 18:
                                        key = key + 'r';
                                        break;
                                    case 19:
                                        key = key + 's';
                                        break;
                                    case 20:
                                        key = key + 't';
                                        break;
                                    case 21:
                                        key = key + 'u';
                                        break;
                                    case 22:
                                        key = key + 'v';
                                        break;
                                    case 23:
                                        key = key + 'w';
                                        break;
                                    case 24:
                                        key = key + 'x';
                                        break;
                                    case 25:
                                        key = key + 'y';
                                        break;
                                    case 26:
                                        key = key + 'z';
                                        break;
                                }
                                ++iSwitch;
                                break;
                            case 2:
                                number = Convert.ToInt32(rnd.Next(1, 27));
                                switch (number)
                                {
                                    case 1:
                                        key = key + 'A';
                                        break;
                                    case 2:
                                        key = key + 'B';
                                        break;
                                    case 3:
                                        key = key + 'C';
                                        break;
                                    case 4:
                                        key = key + 'D';
                                        break;
                                    case 5:
                                        key = key + 'E';
                                        break;
                                    case 6:
                                        key = key + 'F';
                                        break;
                                    case 7:
                                        key = key + 'G';
                                        break;
                                    case 8:
                                        key = key + 'H';
                                        break;
                                    case 9:
                                        key = key + 'I';
                                        break;
                                    case 10:
                                        key = key + 'J';
                                        break;
                                    case 11:
                                        key = key + 'K';
                                        break;
                                    case 12:
                                        key = key + 'L';
                                        break;
                                    case 13:
                                        key = key + 'M';
                                        break;
                                    case 14:
                                        key = key + 'N';
                                        break;
                                    case 15:
                                        key = key + 'O';
                                        break;
                                    case 16:
                                        key = key + 'P';
                                        break;
                                    case 17:
                                        key = key + 'Q';
                                        break;
                                    case 18:
                                        key = key + 'R';
                                        break;
                                    case 19:
                                        key = key + 'S';
                                        break;
                                    case 20:
                                        key = key + 'T';
                                        break;
                                    case 21:
                                        key = key + 'U';
                                        break;
                                    case 22:
                                        key = key + 'V';
                                        break;
                                    case 23:
                                        key = key + 'W';
                                        break;
                                    case 24:
                                        key = key + 'X';
                                        break;
                                    case 25:
                                        key = key + 'Y';
                                        break;
                                    case 26:
                                        key = key + 'Z';
                                        break;
                                }
                                iSwitch = rnd.Next(1, 3);
                                break;
                        }
                    }
                    //1-1-0-1
                    else if (lowercaseB == true && uppercaseB == true && numbersB == false && charsB == true)
                    {
                        switch (iSwitch)
                        {
                            case 1:
                                number = Convert.ToInt32(rnd.Next(1, 27));
                                switch (number)
                                {
                                    case 1:
                                        key = key + 'a';
                                        break;
                                    case 2:
                                        key = key + 'b';
                                        break;
                                    case 3:
                                        key = key + 'c';
                                        break;
                                    case 4:
                                        key = key + 'd';
                                        break;
                                    case 5:
                                        key = key + 'e';
                                        break;
                                    case 6:
                                        key = key + 'f';
                                        break;
                                    case 7:
                                        key = key + 'g';
                                        break;
                                    case 8:
                                        key = key + 'h';
                                        break;
                                    case 9:
                                        key = key + 'i';
                                        break;
                                    case 10:
                                        key = key + 'j';
                                        break;
                                    case 11:
                                        key = key + 'k';
                                        break;
                                    case 12:
                                        key = key + 'l';
                                        break;
                                    case 13:
                                        key = key + 'm';
                                        break;
                                    case 14:
                                        key = key + 'n';
                                        break;
                                    case 15:
                                        key = key + 'o';
                                        break;
                                    case 16:
                                        key = key + 'p';
                                        break;
                                    case 17:
                                        key = key + 'q';
                                        break;
                                    case 18:
                                        key = key + 'r';
                                        break;
                                    case 19:
                                        key = key + 's';
                                        break;
                                    case 20:
                                        key = key + 't';
                                        break;
                                    case 21:
                                        key = key + 'u';
                                        break;
                                    case 22:
                                        key = key + 'v';
                                        break;
                                    case 23:
                                        key = key + 'w';
                                        break;
                                    case 24:
                                        key = key + 'x';
                                        break;
                                    case 25:
                                        key = key + 'y';
                                        break;
                                    case 26:
                                        key = key + 'z';
                                        break;
                                }
                                ++iSwitch;
                                break;
                            case 2:
                                number = Convert.ToInt32(rnd.Next(1, 27));
                                switch (number)
                                {
                                    case 1:
                                        key = key + 'A';
                                        break;
                                    case 2:
                                        key = key + 'B';
                                        break;
                                    case 3:
                                        key = key + 'C';
                                        break;
                                    case 4:
                                        key = key + 'D';
                                        break;
                                    case 5:
                                        key = key + 'E';
                                        break;
                                    case 6:
                                        key = key + 'F';
                                        break;
                                    case 7:
                                        key = key + 'G';
                                        break;
                                    case 8:
                                        key = key + 'H';
                                        break;
                                    case 9:
                                        key = key + 'I';
                                        break;
                                    case 10:
                                        key = key + 'J';
                                        break;
                                    case 11:
                                        key = key + 'K';
                                        break;
                                    case 12:
                                        key = key + 'L';
                                        break;
                                    case 13:
                                        key = key + 'M';
                                        break;
                                    case 14:
                                        key = key + 'N';
                                        break;
                                    case 15:
                                        key = key + 'O';
                                        break;
                                    case 16:
                                        key = key + 'P';
                                        break;
                                    case 17:
                                        key = key + 'Q';
                                        break;
                                    case 18:
                                        key = key + 'R';
                                        break;
                                    case 19:
                                        key = key + 'S';
                                        break;
                                    case 20:
                                        key = key + 'T';
                                        break;
                                    case 21:
                                        key = key + 'U';
                                        break;
                                    case 22:
                                        key = key + 'V';
                                        break;
                                    case 23:
                                        key = key + 'W';
                                        break;
                                    case 24:
                                        key = key + 'X';
                                        break;
                                    case 25:
                                        key = key + 'Y';
                                        break;
                                    case 26:
                                        key = key + 'Z';
                                        break;
                                }
                                ++iSwitch;
                                break;
                            case 3:
                                number = Convert.ToInt32(rnd.Next(1, 7));
                                switch (number)
                                {
                                    case 1:
                                        key = key + '!';
                                        break;
                                    case 2:
                                        key = key + '@';
                                        break;
                                    case 3:
                                        key = key + '#';
                                        break;
                                    case 4:
                                        key = key + '$';
                                        break;
                                    case 5:
                                        key = key + '%';
                                        break;
                                    case 6:
                                        key = key + '&';
                                        break;
                                    case 7:
                                        key = key + '*';
                                        break;
                                }
                                iSwitch = rnd.Next(1,4);
                                break;
                        }
                    }
                    //1-1-1-0
                    else if (lowercaseB == true && uppercaseB == true && numbersB == true && charsB == false)
                    {
                        switch (iSwitch)
                        {
                            case 1:
                                number = Convert.ToInt32(rnd.Next(1, 27));
                                switch (number)
                                {
                                    case 1:
                                        key = key + 'a';
                                        break;
                                    case 2:
                                        key = key + 'b';
                                        break;
                                    case 3:
                                        key = key + 'c';
                                        break;
                                    case 4:
                                        key = key + 'd';
                                        break;
                                    case 5:
                                        key = key + 'e';
                                        break;
                                    case 6:
                                        key = key + 'f';
                                        break;
                                    case 7:
                                        key = key + 'g';
                                        break;
                                    case 8:
                                        key = key + 'h';
                                        break;
                                    case 9:
                                        key = key + 'i';
                                        break;
                                    case 10:
                                        key = key + 'j';
                                        break;
                                    case 11:
                                        key = key + 'k';
                                        break;
                                    case 12:
                                        key = key + 'l';
                                        break;
                                    case 13:
                                        key = key + 'm';
                                        break;
                                    case 14:
                                        key = key + 'n';
                                        break;
                                    case 15:
                                        key = key + 'o';
                                        break;
                                    case 16:
                                        key = key + 'p';
                                        break;
                                    case 17:
                                        key = key + 'q';
                                        break;
                                    case 18:
                                        key = key + 'r';
                                        break;
                                    case 19:
                                        key = key + 's';
                                        break;
                                    case 20:
                                        key = key + 't';
                                        break;
                                    case 21:
                                        key = key + 'u';
                                        break;
                                    case 22:
                                        key = key + 'v';
                                        break;
                                    case 23:
                                        key = key + 'w';
                                        break;
                                    case 24:
                                        key = key + 'x';
                                        break;
                                    case 25:
                                        key = key + 'y';
                                        break;
                                    case 26:
                                        key = key + 'z';
                                        break;
                                }
                                ++iSwitch;
                                break;
                            case 2:
                                number = Convert.ToInt32(rnd.Next(1, 27));
                                switch (number)
                                {
                                    case 1:
                                        key = key + 'A';
                                        break;
                                    case 2:
                                        key = key + 'B';
                                        break;
                                    case 3:
                                        key = key + 'C';
                                        break;
                                    case 4:
                                        key = key + 'D';
                                        break;
                                    case 5:
                                        key = key + 'E';
                                        break;
                                    case 6:
                                        key = key + 'F';
                                        break;
                                    case 7:
                                        key = key + 'G';
                                        break;
                                    case 8:
                                        key = key + 'H';
                                        break;
                                    case 9:
                                        key = key + 'I';
                                        break;
                                    case 10:
                                        key = key + 'J';
                                        break;
                                    case 11:
                                        key = key + 'K';
                                        break;
                                    case 12:
                                        key = key + 'L';
                                        break;
                                    case 13:
                                        key = key + 'M';
                                        break;
                                    case 14:
                                        key = key + 'N';
                                        break;
                                    case 15:
                                        key = key + 'O';
                                        break;
                                    case 16:
                                        key = key + 'P';
                                        break;
                                    case 17:
                                        key = key + 'Q';
                                        break;
                                    case 18:
                                        key = key + 'R';
                                        break;
                                    case 19:
                                        key = key + 'S';
                                        break;
                                    case 20:
                                        key = key + 'T';
                                        break;
                                    case 21:
                                        key = key + 'U';
                                        break;
                                    case 22:
                                        key = key + 'V';
                                        break;
                                    case 23:
                                        key = key + 'W';
                                        break;
                                    case 24:
                                        key = key + 'X';
                                        break;
                                    case 25:
                                        key = key + 'Y';
                                        break;
                                    case 26:
                                        key = key + 'Z';
                                        break;
                                }
                                ++iSwitch;
                                break;
                            case 3:
                                number = Convert.ToInt32(rnd.Next(1, 10));
                                key = key + number.ToString();
                                iSwitch = rnd.Next(1, 4);
                                break;
                        }
                    }
                    //1-1-1-1
                    else if (lowercaseB == true && uppercaseB == true && numbersB == true && charsB == true)
                    {
                        switch (iSwitch)
                        {
                            case 1:
                                number = Convert.ToInt32(rnd.Next(1, 27));
                                switch (number)
                                {
                                    case 1:
                                        key = key + 'a';
                                        break;
                                    case 2:
                                        key = key + 'b';
                                        break;
                                    case 3:
                                        key = key + 'c';
                                        break;
                                    case 4:
                                        key = key + 'd';
                                        break;
                                    case 5:
                                        key = key + 'e';
                                        break;
                                    case 6:
                                        key = key + 'f';
                                        break;
                                    case 7:
                                        key = key + 'g';
                                        break;
                                    case 8:
                                        key = key + 'h';
                                        break;
                                    case 9:
                                        key = key + 'i';
                                        break;
                                    case 10:
                                        key = key + 'j';
                                        break;
                                    case 11:
                                        key = key + 'k';
                                        break;
                                    case 12:
                                        key = key + 'l';
                                        break;
                                    case 13:
                                        key = key + 'm';
                                        break;
                                    case 14:
                                        key = key + 'n';
                                        break;
                                    case 15:
                                        key = key + 'o';
                                        break;
                                    case 16:
                                        key = key + 'p';
                                        break;
                                    case 17:
                                        key = key + 'q';
                                        break;
                                    case 18:
                                        key = key + 'r';
                                        break;
                                    case 19:
                                        key = key + 's';
                                        break;
                                    case 20:
                                        key = key + 't';
                                        break;
                                    case 21:
                                        key = key + 'u';
                                        break;
                                    case 22:
                                        key = key + 'v';
                                        break;
                                    case 23:
                                        key = key + 'w';
                                        break;
                                    case 24:
                                        key = key + 'x';
                                        break;
                                    case 25:
                                        key = key + 'y';
                                        break;
                                    case 26:
                                        key = key + 'z';
                                        break;
                                }
                                ++iSwitch;
                                break;
                            case 2:
                                number = Convert.ToInt32(rnd.Next(1, 27));
                                switch (number)
                                {
                                    case 1:
                                        key = key + 'A';
                                        break;
                                    case 2:
                                        key = key + 'B';
                                        break;
                                    case 3:
                                        key = key + 'C';
                                        break;
                                    case 4:
                                        key = key + 'D';
                                        break;
                                    case 5:
                                        key = key + 'E';
                                        break;
                                    case 6:
                                        key = key + 'F';
                                        break;
                                    case 7:
                                        key = key + 'G';
                                        break;
                                    case 8:
                                        key = key + 'H';
                                        break;
                                    case 9:
                                        key = key + 'I';
                                        break;
                                    case 10:
                                        key = key + 'J';
                                        break;
                                    case 11:
                                        key = key + 'K';
                                        break;
                                    case 12:
                                        key = key + 'L';
                                        break;
                                    case 13:
                                        key = key + 'M';
                                        break;
                                    case 14:
                                        key = key + 'N';
                                        break;
                                    case 15:
                                        key = key + 'O';
                                        break;
                                    case 16:
                                        key = key + 'P';
                                        break;
                                    case 17:
                                        key = key + 'Q';
                                        break;
                                    case 18:
                                        key = key + 'R';
                                        break;
                                    case 19:
                                        key = key + 'S';
                                        break;
                                    case 20:
                                        key = key + 'T';
                                        break;
                                    case 21:
                                        key = key + 'U';
                                        break;
                                    case 22:
                                        key = key + 'V';
                                        break;
                                    case 23:
                                        key = key + 'W';
                                        break;
                                    case 24:
                                        key = key + 'X';
                                        break;
                                    case 25:
                                        key = key + 'Y';
                                        break;
                                    case 26:
                                        key = key + 'Z';
                                        break;
                                }
                                ++iSwitch;
                                break;
                            case 3:
                                number = Convert.ToInt32(rnd.Next(1, 10));
                                key = key + number.ToString();
                                ++iSwitch;
                                break;
                            case 4:
                                number = Convert.ToInt32(rnd.Next(1, 7));
                                switch (number)
                                {
                                    case 1:
                                        key = key + '!';
                                        break;
                                    case 2:
                                        key = key + '@';
                                        break;
                                    case 3:
                                        key = key + '#';
                                        break;
                                    case 4:
                                        key = key + '$';
                                        break;
                                    case 5:
                                        key = key + '%';
                                        break;
                                    case 6:
                                        key = key + '&';
                                        break;
                                    case 7:
                                        key = key + '*';
                                        break;
                                }
                                iSwitch = rnd.Next(1, 5);
                                break;
                        }
                    }

                }

                return key;
            }
            else return "error";
            #endregion 
        }
    }
}
