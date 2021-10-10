using System;

namespace Snake_and_Ladder_Game
{
    class Program
    {

        public const int No_Play = 1;
        public const int Ladder = 2;
        public const int Snake = 3;
        public const int WinSopt = 100;

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Snakes And Ladders!");

            int position=0; ;
            //int player=0;
            int c = 0;
            
            while (position <= WinSopt)
            {
                Random r = new Random();
                int number = r.Next(0, 7);
                //Console.WriteLine("dice {0}",number);
                c++;
                Random r1 = new Random();
               int  randomValue = r1.Next(0, 4);
                //Console.WriteLine(" {0}",randomValue);
                

                switch (randomValue)
                {
                    case No_Play:
                        
                            position = position;
                       
                        break;

                    case Ladder:
                       
                            position = position + number;
                        break;

                    case Snake:
                            position = position - number;
                    
                        
                        break;
                }
                if (position < 0)
                {
                    position = 0;
                }

                if (position > WinSopt)
                {
                    position = position - number;
                    break;
                }

                Console.WriteLine("the postion of player is now:{0}", position);
            }

            Console.WriteLine("no of time dice is rolled {0}", c);
            Console.WriteLine("the palyer position is {0}", position);
            Console.ReadLine();



        }

    }
}
