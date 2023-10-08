using System;

namespace Triangle_Battleship
{
    class Program
    {
        static void Main(string[] args)
        {

            //Start
            string Player1 = "Nazan Kaya";
            string Player2 = "Ali Kurt";
            string Player3 = "Sibel Arslan";
            double Score1 = 60;
            double Score2 = 30;
            double Score3 = 10;
            double a, b, c, p, s, area, a_xm, a_ym, b_xm, b_ym, c_xm, c_ym, tc_x, tc_y, sh_x, sh_y;
            double entry_c = 0;
            //tc means triangle centroid
            string Player_name;
            double Player_score;
            string option;
            double a_x = 0, a_y = 0, b_x = 0, b_y = 0, c_x = 0, c_y = 0;
            double uangle_A;
            double uangle_B;
            double uangle_C;
            double angle_A;
            double angle_B;
            double angle_C;
            double height;
            double l_bisector;
            double r_in_circle;
            double r_ci_circle;
            double S_in_circle;
            double S_ci_circle;
            int i, j;
            string uloc_in, st_i;// user location input ,convert to string i
            int locb = 0;
            //in means inscribed , ci is circumscribed

            do
            {
                a = Math.Sqrt(Math.Pow((b_x - c_x), 2) + Math.Pow((b_y - c_y), 2));
                b = Math.Sqrt(Math.Pow((a_x - c_x), 2) + Math.Pow((a_y - c_y), 2));
                c = Math.Sqrt(Math.Pow((b_x - a_x), 2) + Math.Pow((b_y - a_y), 2));
                p = a + b + c;
                s = p / 2;
                area = Math.Abs(((c_x * (a_y - b_y)) + (a_x * (b_y - c_y)) + (b_x * (c_y - a_y))) / 2);
                a_xm = (b_x + c_x) / 2;
                a_ym = (b_y + c_y) / 2;
                b_xm = (a_x + c_x) / 2;
                b_ym = (a_y + c_y) / 2;
                c_xm = (b_x + a_x) / 2;
                c_ym = (b_y + a_y) / 2;
                tc_x = (b_x + c_x + a_x) / 3;
                tc_y = (a_y + b_y + c_y) / 3;

                uangle_A = Math.Acos((((Math.Pow(b, 2)) + (Math.Pow(c, 2)) - (Math.Pow(a, 2))) / (2 * b * c)));
                uangle_B = Math.Acos((((Math.Pow(a, 2)) + (Math.Pow(c, 2)) - (Math.Pow(b, 2))) / (2 * a * c)));
                uangle_C = Math.Acos((((Math.Pow(a, 2)) + (Math.Pow(b, 2)) - (Math.Pow(c, 2))) / (2 * a * b)));
                angle_A = (uangle_A * (180 / Math.PI));
                angle_B = (uangle_B * (180 / Math.PI));
                angle_C = (uangle_C * (180 / Math.PI));

                r_in_circle = Math.Round((2 * (area) / p), 2);
                S_in_circle = Math.PI * (r_in_circle * r_in_circle);
                r_ci_circle = Math.Round((a / (2 * Math.Sin(uangle_A))), 2);
                S_ci_circle = Math.PI * (r_ci_circle * r_ci_circle);
                height = Math.Round((2 * Math.Sqrt(s * (s - a) * (s - b) * (s - c)) / a), 2);
                l_bisector = Math.Round(height / (Math.Cos((uangle_A - uangle_B) / 2)), 2);


                Console.WriteLine("            - MENU - \n Please select from the option below: \n 1– Enter ship location  \n 2- Ship info \n 3- Shoot at the ship \n 4- Show high score table \n 5- Exit");
                option = Console.ReadLine();
                if (option == "5")
                    Console.WriteLine("goodbye!");


                else if (option == "4")

                {
                    Console.Clear();
                    Console.WriteLine("\n  Name       Score \n" + Player1 + "   " + Score1 + "\n" + Player2 + "   " + Score2 + "\n" + Player3 + "   " + Score3);
                    Console.ReadKey();
                    Console.Clear();


                }
                else if (option == "1")
                {
                    Console.Clear();
                    do
                    {
                        Console.Write("Please enter the location of the ship: \n\nX(A)(Must be between 0 and 30):");
                        uloc_in = Console.ReadLine();
                        a_x = 0;
                        locb = 0;
                        for (i = 1; i < 31; i++)
                        {
                            st_i = Convert.ToString(i);
                            if (st_i == uloc_in)
                            {
                                locb = 1;
                                a_x = i;
                            }
                        }
                        if (locb == 0)
                            Console.WriteLine("Please Enter Valid Number!");


                    }
                    while (30 < a_x || a_x <= 0);
                    do
                    {
                        Console.Write("Y(A)(Must be between 0 and 12):");
                        uloc_in = Console.ReadLine();
                        a_y = 0;
                        locb = 0;
                        for (i = 1; i < 13; i++)
                        {
                            st_i = Convert.ToString(i);
                            if (st_i == uloc_in)
                            {
                                locb = 1;
                                a_y = i;
                            }
                        }
                        if (locb == 0)
                            Console.Write("Please Enter Valid Number!");



                    }
                    while (12 < a_y || a_y <= 0);
                    do
                    {
                        Console.Write("X(B)(Must be between 0 and 30):");
                        uloc_in = Console.ReadLine();
                        b_x = 0;
                        locb = 0;
                        for (i = 1; i < 31; i++)
                        {
                            st_i = Convert.ToString(i);
                            if (st_i == uloc_in)
                            {
                                locb = 1;
                                b_x = i;
                            }
                        }
                        if (locb == 0)
                            Console.WriteLine("Please Enter Valid Number!");




                    }
                    while (30 < b_x || b_x <= 0);
                    do
                    {
                        Console.Write("Y(B)(Must be between 0 and 12):");
                        uloc_in = Console.ReadLine();
                        b_y = 0;
                        locb = 0;
                        for (i = 1; i < 13; i++)
                        {
                            st_i = Convert.ToString(i);
                            if (st_i == uloc_in)
                            {
                                locb = 1;
                                b_y = i;
                            }
                        }
                        if (locb == 0)
                            Console.WriteLine("Please Enter Valid Number!");

                    }
                    while (12 < b_y || b_y <= 0);
                    do
                    {
                        Console.Write("X(C)(Must be between 0 and 30):");
                        uloc_in = Console.ReadLine();
                        c_x = 0;
                        locb = 0;
                        for (i = 1; i < 31; i++)
                        {
                            st_i = Convert.ToString(i);
                            if (st_i == uloc_in)
                            {
                                locb = 1;
                                c_x = i;
                            }
                        }
                        if (locb == 0)
                            Console.WriteLine("Please Enter Valid Number!");

                    }
                    while (30 < c_x || c_x <= 0);
                    do
                    {
                        Console.Write("Y(C)(Must be between 0 and 12):");
                        uloc_in = Console.ReadLine();
                        c_y = 0;
                        locb = 0;
                        for (i = 1; i < 13; i++)
                        {
                            st_i = Convert.ToString(i);
                            if (st_i == uloc_in)
                            {
                                locb = 1;
                                c_y = i;
                            }
                        }
                        if (locb == 0)
                            Console.WriteLine("Please Enter Valid Number!");

                    }
                    while (12 < c_y || c_y <= 0);

                    area = Math.Abs(((c_x * (a_y - b_y)) + (a_x * (b_y - c_y)) + (b_x * (c_y - a_y))) / 2);
                    if (area == 0)
                    {
                        Console.WriteLine("no triangle formed, please again enter location");
                    }
                    else
                    {
                        Console.ReadKey();



                        Console.WriteLine("\nThis would the location of your ship: \nA:(" + a_x + "," + a_y + ")\n" + "B:(" + b_x + "," + b_y + ")\n" + "C:(" + c_x + "," + c_y + ")" + "\n\n");



                        for (i = 12; i > -2; i--)
                        {


                            for (j = -2; j < 31; j++)
                            {
                                if (i > 9 & j == -2)
                                    Console.Write(i + "|");
                                else if (i > 0 & j == -2)
                                    Console.Write(" " + i + "|");
                                else if (i == -1 & j > 0)
                                    Console.Write(j % 10);
                                else if (i == 0 & j == 0)
                                    Console.Write("+");
                                else if (i == 0 & j > 0)
                                    Console.Write("-");
                                else if (a_x == j + 2 & a_y == i)
                                    Console.Write("A");
                                else if (b_x == j + 2 & b_y == i)
                                    Console.Write("B");
                                else if (c_x == j + 2 & c_y == i)
                                    Console.Write("C");
                                else
                                    Console.Write(" ");



                            }
                            Console.Write("\n");

                        }
                        Console.Write("\n");




                        /* Console.WriteLine("\n    ↑\n 12 | \n 11 | \n 10 | \n  9 | \n  8 | \n  7 | \n  6 | \n  5 | \n  4 | \n  3 | \n  2 | \n  1 | ");
                        Console.WriteLine("    +------------------------------→ \n     123456789012345678901234567890");


                        xA = Convert.ToInt32(a_x);
                        xB = Convert.ToInt32(b_x);
                        xC = Convert.ToInt32(c_x);
                        yA = Convert.ToInt32(a_y);
                        yB = Convert.ToInt32(b_y);
                        yC = Convert.ToInt32(c_y);

                        Console.SetCursorPosition(xA + 4, Console.CursorTop - 2 - yA);
                        Console.WriteLine("A");
                        Console.SetCursorPosition(xB + 4, Console.CursorTop - 1 - yB + yA);
                        Console.WriteLine("B");
                        Console.SetCursorPosition(xC + 4, Console.CursorTop - 1 - yC + yB);
                        Console.WriteLine("C");

                        Console.SetCursorPosition(1, Console.CursorTop + yC + 2);
                        */

                        entry_c = 1;
                        Console.ReadKey();
                        Console.Clear();

                    }
                }
                else if (option == "2")
                {
                    Console.Clear();

                    if (entry_c == 1)
                    {

                        for (i = 12; i > -2; i--)
                        {


                            for (j = -2; j < 31; j++)
                            {
                                if (i > 9 & j == -2)
                                    Console.Write(i + "|");
                                else if (i > 0 & j == -2)
                                    Console.Write(" " + i + "|");
                                else if (i == -1 & j > 0)
                                    Console.Write(j % 10);
                                else if (i == 0 & j == 0)
                                    Console.Write("+");
                                else if (i == 0 & j > 0)
                                    Console.Write("-");
                                else if (a_x == j + 2 & a_y == i)
                                    Console.Write("A");
                                else if (b_x == j + 2 & b_y == i)
                                    Console.Write("B");
                                else if (c_x == j + 2 & c_y == i)
                                    Console.Write("C");
                                else
                                    Console.Write(" ");



                            }
                            Console.Write("\n");

                        }








                        Console.WriteLine("\nSHIP INFO  \nThe size of the ship: a=" + Math.Round(a, 2) + "  " + "b=" + Math.Round(b, 2) + "  " + "c=" + Math.Round(c, 2));
                        Console.WriteLine("The perimeter of the ship:" + Math.Round(p, 2));
                        Console.WriteLine("The area of the ship:" + Math.Round(area, 2));
                        Console.WriteLine("The angles of the ship: " + "A=" + Math.Round(angle_A, 2) + "  " + "B=" + Math.Round(angle_B, 2) + "  " + "C=" + Math.Round(angle_C, 2));
                        Console.WriteLine("The median points: (" + a_xm + "," + a_ym + ")" + "(" + b_xm + "," + b_ym + ")" + "(" + c_xm + "," + c_ym + ")");
                        Console.WriteLine("The centroid of the ship: (" + Math.Round(tc_x, 2) + "," + Math.Round(tc_y, 2) + ")");
                        Console.WriteLine("The length of the bisector:" + l_bisector);
                        Console.WriteLine("The area of the inscribed circle:" + Math.Round(S_in_circle, 2));
                        Console.WriteLine("The area of circumscribed circle:" + Math.Round(S_ci_circle, 2));

                        if ((a == b & a != c) || (a == c & a != b) || (b == c & b != a))
                            Console.Write("The type of the ship:Isoacles");
                        else if (a == b && b == c)
                            Console.Write(" The type of the ship:equilateral");
                        else
                            Console.Write("The type of the ship:scalene");
                        if ((angle_A == 90) || (angle_B == 90) || (angle_C == 90))
                            Console.WriteLine("(right_angled)");
                        else if (angle_A > 90 || angle_B > 90 || angle_C > 90)
                            Console.WriteLine("(Obtuse_angled)");
                        else
                            Console.WriteLine("(Acute_angled)");


                    }
                    else
                    {
                        Console.WriteLine("Please Enter Ship Location First!");

                    }
                    Console.ReadKey();
                    Console.Clear();

                }
                else if (option == "3")

                {
                    Console.Clear();
                    if (entry_c == 1)
                    {
                        Random rand = new Random();
                        sh_x = rand.Next(1, 30);
                        sh_y = rand.Next(1, 12);
                        Console.WriteLine("X:(" + sh_x + "," + sh_y + ")");
                        //Area A = [ x1(y2 – y3) + x2(y3 – y1) + x3(y1-y2)]/2 
                        double Sxab = Math.Abs(((sh_x * (a_y - b_y)) + (a_x * (b_y - sh_y)) + (b_x * (sh_y - a_y))) / 2);
                        double Sxcb = Math.Abs(((sh_x * (c_y - b_y)) + (c_x * (b_y - sh_y)) + (b_x * (sh_y - c_y))) / 2);
                        double Sxac = Math.Abs(((sh_x * (a_y - c_y)) + (a_x * (c_y - sh_y)) + (c_x * (sh_y - a_y))) / 2);
                        double Sc = Sxab + Sxac + Sxcb;
                        //Sc is score




                        for (i = 12; i > -2; i--)
                        {


                            for (j = -2; j < 31; j++)
                            {
                                if (i > 9 & j == -2)
                                    Console.Write(i + "|");
                                else if (i > 0 & j == -2)
                                    Console.Write(" " + i + "|");
                                else if (i == -1 & j > 0)
                                    Console.Write(j % 10);
                                else if (i == 0 & j == 0)
                                    Console.Write("+");
                                else if (i == 0 & j > 0)
                                    Console.Write("-");
                                else if (a_x == j + 2 & a_y == i)
                                    Console.Write("A");
                                else if (b_x == j + 2 & b_y == i)
                                    Console.Write("B");
                                else if (c_x == j + 2 & c_y == i)
                                    Console.Write("C");
                                else if (sh_x == j + 2 & sh_y == i)
                                    Console.Write("X");
                                else
                                    Console.Write(" ");



                            }
                            Console.Write("\n");
                        }

                        /*

                            Console.WriteLine("\n    ↑\n 12 | \n 11 | \n 10 | \n  9 | \n  8 | \n  7 | \n  6 | \n  5 | \n  4 | \n  3 | \n  2 | \n  1 | ");
                            Console.WriteLine("    +------------------------------→ \n     123456789012345678901234567890");


                            xA = Convert.ToInt32(a_x);
                            xB = Convert.ToInt32(b_x);
                            xC = Convert.ToInt32(c_x);
                            yA = Convert.ToInt32(a_y);
                            yB = Convert.ToInt32(b_y);
                            yC = Convert.ToInt32(c_y);
                            xS = Convert.ToInt32(sh_x);
                            yS = Convert.ToInt32(sh_y);


                            Console.SetCursorPosition(xA + 4, Console.CursorTop - 2 - yA);
                            Console.WriteLine("A");
                            Console.SetCursorPosition(xB + 4, Console.CursorTop - 1 - yB + yA);
                            Console.WriteLine("B");
                            Console.SetCursorPosition(xC + 4, Console.CursorTop - 1 - yC + yB);
                            Console.WriteLine("C");
                            Console.SetCursorPosition(xS + 4, Console.CursorTop - 1 - yS + yC);
                            Console.WriteLine("X");
                            Console.SetCursorPosition(1, Console.CursorTop + yC + 2);
                            */




                        //Console.WriteLine("A"+a_x + a_y + "B"+ b_x+b_y + "c" + c_x + c_y);
                        //Console.WriteLine("Area:"+area);
                        //Console.WriteLine("Sc"+Sc+"Sxab"+Sxab+"Sxcb"+Sxcb+"Sxac"+Sxac);


                        if (Sc == area)
                        {
                            Console.WriteLine("\nYour Ship Sank! \n Total Score:0!");
                            Console.WriteLine("\nName       Score \n" + Player1 + "   " + Score1 + "\n" + Player2 + "   " + Score2 + "\n" + Player3 + "   " + Score3);
                        }

                        else
                        {
                            Console.WriteLine("\nYour ship survived! Total score is " + area);

                            Player_score = area;

                            if (area > Score1)
                            {
                                Console.Write("Enter your name: ");
                                Player_name = Console.ReadLine();
                                Player3 = Player2;
                                Player2 = Player1;
                                Player1 = Player_name;
                                Score3 = Score2;
                                Score2 = Score1;
                                Score1 = Player_score;
                                Console.WriteLine("\nName       Score \n" + Player1 + "   " + Score1 + "\n" + Player2 + "   " + Score2 + "\n" + Player3 + "   " + Score3);
                                Console.ReadKey();
                            }
                            else if (area > Score2)
                            {
                                Console.Write("Enter your name: ");
                                Player_name = Console.ReadLine();
                                Player3 = Player2;
                                Player2 = Player_name;
                                Score3 = Score2;
                                Score2 = Player_score;
                                Console.WriteLine("\nName       Score \n" + Player1 + "   " + Score1 + "\n" + Player2 + "   " + Score2 + "\n" + Player3 + "   " + Score3);
                                Console.ReadKey();

                            }
                            else if (area > Score3)
                            {
                                Console.Write("Enter your name: ");
                                Player_name = Console.ReadLine();
                                Player3 = Player_name;
                                Score3 = Player_score;
                                Console.WriteLine("\nName       Score \n" + Player1 + "   " + Score1 + "\n" + Player2 + "   " + Score2 + "\n" + Player3 + "   " + Score3);
                                Console.ReadKey();
                            }
                            else
                            {
                                Console.WriteLine("\nName       Score \n" + Player1 + "   " + Score1 + "\n" + Player2 + "   " + Score2 + "\n" + Player3 + "   " + Score3);
                                Console.ReadKey();

                            }

                            Console.Clear();
                        }

                    }
                    else
                    {
                        Console.WriteLine("Please Enter Ship Location First!");

                    }


                }
                else
                {
                    Console.WriteLine("Please Choose an option Between 1 and 5");

                }
            }
            while (option != "5");


            Console.ReadLine();


        }

    }
}

