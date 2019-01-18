using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Doomsday_Rule
{
    class The_Doomsday_Rule
    {
        /////////////////////////////function aimed to control the spaces
        static private bool Spaces(int cy, int md, string d, int ns, string[] dd, char dl)
        {
            for (int i = 0; i < d.Length; i++)
            {
                if (d[i] == ' ')
                {
                    ns++;
                }
            }
            if (ns == 2)
            {
                dd = d.Split(dl); //decomposing date
                return Date(cy, md, dd);
            }
            else
            {
                return false;
            }
        }
        /////////////////////////////function aimed to control the leap year
        static private bool Leapyear(int cy)
        {
            if (cy % 4 == 0) //if divisible for 4 that's leap year
            {
                if (cy % 100 == 0) //BUT only if it's not divisible for 100
                {
                    if (cy % 400 == 0) //OR if it's also divisible for 400
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return true;
                }
            }
            else
            {
                return false;
            }
        }
        /////////////////////////////function aimed to control the date
        static private bool Date(int cy, int md, string[] dd)
        {
            bool con = true; //generic control
            con = int.TryParse(dd[2], out cy);
            if (!con) //year control
            {
                return false;
            }
            else
            {
                if (cy < 1582) //year control
                {
                    return false;
                }
                else
                {
                    switch (dd[1].ToLower()) //month control
                    {
                        case "january": case "march": case "may": case "july": case "august": case "october": case "december":
                            con = int.TryParse(dd[0], out md); //month day control
                            if (!con)
                            {
                                return false;
                            }
                            else
                            {
                                if ((md < 1) || (md > 31)) //month day control
                                {
                                    return false;
                                }
                                else
                                {
                                    return true;
                                }
                            }
                        case "april": case "june": case "september": case "november":
                            con = int.TryParse(dd[0], out md);
                            if (!con) //month day control
                            {
                                return false;
                            }
                            else
                            {
                                if ((md < 1) || (md > 30)) //month day control
                                {
                                    return false;
                                }
                                else
                                {
                                    return true;
                                }
                            }
                        case "february":
                            con = int.TryParse(dd[0], out md); //month day control
                            if (!con)
                            {
                                return false;
                            }
                            else
                            {
                                if (Leapyear(cy))
                                {
                                    if ((md < 1) || (md > 29)) //month day control
                                    {
                                        return false;
                                    }
                                    else
                                    {
                                        return true;
                                    }
                                }
                                else
                                {
                                    if ((md < 1) || (md > 28)) //month day control
                                    {
                                        return false;
                                    }
                                    else
                                    {
                                        return true;
                                    }
                                }
                            }
                        default: //the last path (in case the user didn't type in the correct spelling of the month...)
                            return false;
                    }
                }
            }
        }
        /////////////////////////////main function
        static void Main(string[] args)
        {
            string ch = "no"; //choice
            bool no = ch.Equals("no", StringComparison.OrdinalIgnoreCase); //"no" control
            bool yes = ch.Equals("yes", StringComparison.OrdinalIgnoreCase); //"yes" control
            do //program repeat cycle
            {
                string d = "1 January 2000"; //date
                string[] dd = { "0" }; //decomposed date
                int cy = 0, c, y, cydd, mdd = 0, wd; //century year, century, year, century year doomsday, month doomsday, week day
                int md = 0, ns = 0; //month day, number of spaces
                char dl = ' '; //delimiter character
                do //data insert cycle
                {
                    if (Spaces(cy, md, d, ns, dd, dl))
                    {
                        Console.Clear();
                        Console.Write("The Doomsday Rule\n\n\n\nThis program allows you to discover the week day of a date whose year is not less than 1582.\n\nInsert the date in the form '[Number of the day] [Name of the month] [Year]'.\n\n");
                        d = Convert.ToString(Console.ReadLine());
                        ns = 0;
                    }
                    else
                    {
                        Console.Clear();
                        Console.Write("The Doomsday Rule\n\n\n\nThis program allows you to discover the week day of a date whose year is not less than 1582.\n\nIncorrect form or wrong numbers, insert the date in the form '[Number of the day] [Name of the month] [Year]'.\n\n");
                        d = Convert.ToString(Console.ReadLine());
                    }
                } while (!Spaces(cy, md, d, ns, dd, dl));
                dd = d.Split(dl); //decomposing date
                int.TryParse(dd[2], out cy);
                c = cy / 100; //the century
                y = cy - c * 100; //the year
                cydd = ((((c + 1) * 5 + c / 4) % 7 + 4) % 7 + (y + y / 4) % 7) % 7; //century year doomsday
                switch (dd[1].ToLower()) //month control
                {
                    case "january":
                        if (Leapyear(cy)) //month doomsday
                        {
                            mdd = 4;
                        }
                        else
                        {
                            mdd = 3;
                        }
                        break;
                    case "february":
                        if (Leapyear(cy)) //month doomsday
                        {
                            mdd = 29;
                        }
                        else
                        {
                            mdd = 7;
                        }
                        break;
                    case "march":
                        mdd = 7;
                        break;
                    case "april":
                        mdd = 4;
                        break;
                    case "may":
                        mdd = 9;
                        break;
                    case "june":
                        mdd = 6;
                        break;
                    case "july":
                        mdd = 11;
                        break;
                    case "august":
                        mdd = 8;
                        break;
                    case "september":
                        mdd = 5;
                        break;
                    case "october":
                        mdd = 10;
                        break;
                    case "november":
                        mdd = 7;
                        break;
                    case "december":
                        mdd = 12;
                        break;
                    default: //the last path that will never ever be used: the easter egg that will never be found
                        Console.Write("EASTER EGG");
                        break;
                }
                int.TryParse(dd[0], out wd);
                wd = (wd - mdd + cydd) % 7;
                do //conclusion and repeat question cycle
                {
                    Console.Clear();
                    Console.Write("The Doomsday Rule\n\n\n\nThis program allows you to discover the week day of a date whose year is not less than 1582.\n\nDate: {0}\n\nWeek day: ", d);
                    switch (wd) //week day
                    {
                        case 1:
                            Console.Write("Monday");
                            break;
                        case 2:
                            Console.Write("Tuesday");
                            break;
                        case 3:
                            Console.Write("Wednesday");
                            break;
                        case 4:
                            Console.Write("Thursday");
                            break;
                        case 5:
                            Console.Write("Friday");
                            break;
                        case 6:
                            Console.Write("Saturday");
                            break;
                        case 0:
                            Console.Write("Sunday");
                            break;
                    }
                    if (no || yes) //repeat question
                    {
                        Console.Write("\n\n\n\nDo you wanna exit the program? ");
                        ch = Convert.ToString(Console.ReadLine());
                    }
                    else
                    {
                        Console.Write("\n\n\n\nNon valid choice, do you wanna exit the program? ");
                        ch = Convert.ToString(Console.ReadLine());
                    }
                    no = ch.Equals("no", StringComparison.OrdinalIgnoreCase);
                    yes = ch.Equals("yes", StringComparison.OrdinalIgnoreCase);
                } while (!(no || yes));
            } while (no || !yes);
        }
    }
}