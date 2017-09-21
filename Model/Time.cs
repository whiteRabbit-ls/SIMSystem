using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace Model
{
    public class Time
    {
        public readonly ArrayList YEAR;
        public readonly ArrayList MONTH;
        public ArrayList getYear()
        {
            return YEAR;
        }
        int d;
        public ArrayList getMonth()
        {
            return MONTH;
        }

        public ArrayList getDay(int y, int m)
        {
            switch (m)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    d = 31;
                    break;

                case 4:
                case 6:
                case 9:
                case 11:
                    d = 30;
                    break;
                case 2:
                    if (y % 4 == 0)
                        d = 28;
                    else
                        d = 29;
                    break;
            }
            ArrayList Mlist = new ArrayList();
            for (int i = d; i > 0; i--)

            { Mlist.Add(i); }


            return Mlist;
        }

        public Time()
        {
            ArrayList temp2 = new ArrayList(12);
            ArrayList temp = new ArrayList(100);
            for (int i = 1900; i < 2020; i++)
                temp.Add(i);
            this.YEAR = temp;
            for (int i = 1; i <= 12; i++)
                temp2.Add(i);
            this.MONTH = temp2;
        }

    }
}
