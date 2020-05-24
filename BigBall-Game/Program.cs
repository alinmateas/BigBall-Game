using System;
using System.Collections.Generic;

namespace BigBall_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Ball> listaBile = new List<Ball>();

            Console.Write("Introduceti numarul de Repelent Balls. ");
            int numarBileRepelent = int.Parse(Console.ReadLine());

            List<RepelentBall> listaBileRepelant = new List<RepelentBall>();
            for (int i = 0; i < numarBileRepelent; i++)
            {
                RepelentBall rp = new RepelentBall();
                listaBileRepelant.Add(rp);

                listaBile.Add(rp);
            }
            
            Console.Write("Introduceti numarul de Regular Balls. ");
            int numarBileRegular = int.Parse(Console.ReadLine());

            List<RegularBall> listaBileRegular = new List<RegularBall>();
            for (int i = 0; i < numarBileRegular; i++)
            {
                RegularBall rb = new RegularBall();
                listaBileRegular.Add(rb);

                listaBile.Add(rb);
            }

            Console.Write("Introduceti numarul de Monster Balls. ");
            int numarBileMonster = int.Parse(Console.ReadLine());

            List<MonsterBall> listaBileMonster = new List<MonsterBall>();
            for (int i = 0; i < numarBileMonster; i++)
            {
                MonsterBall mb = new MonsterBall();
                listaBileMonster.Add(mb);

                listaBile.Add(mb);
            }


            Engine.Start(listaBile);


            //Console.Write("Introduceti numarul de Repelent Balls. ");
            //int regularBallsCount = int.Parse(Console.ReadLine());
            //RepelentBall repelentBall = new RepelentBall();
            //Console.Write("Introduceti numarul de Repelent Balls. ");
            //int regularBallsCount = int.Parse(Console.ReadLine());
            //RepelentBall repelentBall = new RepelentBall();
            //Console.Write("Introduceti numarul de Repelent Balls. ");
            //int regularBallsCount = int.Parse(Console.ReadLine());
            //RepelentBall repelentBall = new RepelentBall();
            
        }
    }
}
