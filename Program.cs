using System;
using ConsoleApp3;
using System.IO;


namespace ConsoleApp3
{
    public class Program
    {
        
        public Program()
        {

            Console.WriteLine("Cunstraucter calling ");

        }
        static void Main(string[] args)
        {
           // Program obj = new Program();
            Class1 obj2 = new Class1("Hyndai",2020);
            Class1 obj3 = new Class1(1998, "creata");
            Console.ReadKey();


            // obj2.Display();

        }
        public static void Breakcontinu()
        {
            int i = 0;
            for (i = 2; i <= 20; i++)
            {
                if (i % 2 != 0)
                {
                    continue;
                }
                Console.Write(i+"*"+i);
                Console.WriteLine(i + "\t");
            }
        }
        public void Bank()
        {
            int acount_balance = 5000;
            int withdrol_amount = 7000;
           try
            {
                if (acount_balance < withdrol_amount)
                {
                    throw new Exception("Infuslent Balance");
                }
                else
                {
                    acount_balance = acount_balance - withdrol_amount;
                    Console.WriteLine("Remaing balance is " + acount_balance);
                    Console.WriteLine("Transtion Suucesfull");
                }

            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);

            }
            finally
            {
                Console.WriteLine("Finaly Exicute");
               
            }
        }
        public void throwexp(int age)
        {
            try
            {
                if (age < 18)
                {

                    throw new Exception("Access Denied you Age is lessthen 18 Sorry");
                }
                else
                {
                    Console.WriteLine("Accesss granted ");
                }

            }
            catch(Exception ex)

            {

                Console.WriteLine(ex.Message);
            }


                }

            public void Prime()
            {
            try
             { 
                int num = int.Parse(Console.ReadLine());
                int count = 0;
                for (int i = 1; i <= num; i++)
                {

                    if (num % i == 0)
                    {
                        count++;
                    }
                }
                if (count == 2)
                {
                    Console.WriteLine("Number Is prime" + num);

                }
                else
                {
                    Console.WriteLine("Number Is Not Prime");
                }

                }
            catch(Exception ex)
            {
                try
                { 
                int n=5;
               int i;
                i = n / 0;
                Console.WriteLine(ex.Message);
                }
                catch(FormatException ex2)
                {
                    Console.WriteLine(ex2.Message);
                }
                catch(Exception fr)
                {
                    Console.WriteLine("khsjsh"+fr.Message);
                }
                finally
                {
                    Console.WriteLine("Sub Finaly Excute");
                }
            }
            finally
            {
                Console.WriteLine("The Finaly Bolock Is Execute ");
                Console.WriteLine("Connection is closd");
            }
            }
        


            public void Oddeven()
            {
                Console.WriteLine("Enter any Number");
                int num = int.Parse(Console.ReadLine());
                if (num % 2 == 0)
                {
                    Console.WriteLine("Number is even ");

                }
                else
                {
                    Console.WriteLine("numer is odd");

                }
            }
            public void Switchcasemethed()
            {
                int day = int.Parse(Console.ReadLine());

                switch (day)
                {
                    case 1:
                        Console.WriteLine("Monday");
                        break;
                    case 2:
                        Console.WriteLine("Tusday");
                        break;
                    case 3:
                        Console.WriteLine("Wesneday");
                        break;
                    case 4:
                        Console.WriteLine("thusday");

                        break;
                    case 5:
                        Console.WriteLine("Friday");
                        break;
                    case 6:
                        Console.WriteLine("Sutarday");
                        break;
                    case 7:
                        Console.WriteLine("Sunday");
                        break;

                    default:
                        Console.WriteLine("Its call Defultes Call");
                        break;






                }


            }
            public void Star1()
            {
                for (int i = 1; i <= 4; i++)
                {
                    for (int j = 1; j <= 4 - i + 1; j++)
                    {
                        Console.Write("*");

                    }
                    Console.WriteLine();
                }
            }

            public void Star()

            {
                // Console.WriteLine("plz enter n value");
                // int n = int.Parse(Console.ReadLine());
                for (int i = 1; i <= 5; i++)
                {
                    for (int j = i; j >= 1; j--)
                    {
                        Console.Write("*");

                    }
                    Console.WriteLine();
                }
                // Console.ReadKey();

            }

            public void Methed()
            {
                string[] car = { "VERNA", "I20", "CRETA", "VALENO", "DZIRE" };

                int[] num = { 10, 20, 30, 40, 50 };

                {

                    {
                        int count = 1;
                        foreach (var s in car)

                        {

                            foreach (int i in num)
                            {
                                if (count == 1)

                                {
                                    Console.WriteLine(s + " the value of car is " + i);
                                    count++;

                                }
                                else
                                {
                                    count--;
                                break;
                               
                            }

                            }


                        }



                    }
                }


            }
            public static void Preman()
            {
                Console.WriteLine("Plz Enter true And false");
                bool Yseno = Convert.ToBoolean(Console.ReadLine());
                if (Yseno == false)
                {
                    Program.Dispaly();
                }
                else
                {
                    Console.WriteLine("Exit");
                }

            }
            public static void Dispaly()
            {

                //const int i = 10;
                //Console.WriteLine(i+ " The Value of I=" + i);
                //long n = 15000;
                //Console.WriteLine(n);

                //double mydul = 9.99;
                //int myint =(int) mydul;
                //Console.WriteLine(myint);
                //Console.WriteLine(mydul);

                string name;
                int age;
                int i = 0;
                Console.WriteLine("Enter Name");
                name = Console.ReadLine();
                Console.WriteLine("Enter Age");
                age = Convert.ToInt32(Console.ReadLine());
                if (name == "Naved Alam")
                {

                    do
                    {
                        Console.WriteLine("Your Name is :" + name + " And Your Age Is " + age + " Years " + i);
                        i++;
                    }
                    while (i < 10);
                }
                else
                {
                    Console.WriteLine("sorry ");
                }


            }
       
    }
}
