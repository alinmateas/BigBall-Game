using System;
using System.Collections.Generic;

namespace BigBall_Game
{
    public static class Engine
    {
        
        public static void Start(List<Ball> listaBile)
        {
            while(true)
            {
                moveBalls(listaBile);
                
               
                VerificariColiziuni(listaBile);

                if (!verificareRegular(listaBile))
                {
                    Console.Write("Nu mai exista regular balls");
                    break;
                }

            }

        }

        private static void VerificariColiziuni(List<Ball> listaBile)
        {
            for (int i = 0; i < listaBile.Count; i++)
            {
                for (int j = 0; j < listaBile.Count; j++)
                {
                    if (i == j) continue;

                    if (Coliziune(listaBile[i], listaBile[j]))
                    {
                        listaBile[i].Inghitire(listaBile[j]);
                    }

                }
              
            }
        }

        private static void moveBalls(List<Ball> listaBile)
        {
            foreach (var item in listaBile)
            {
                item.Move();
            }
        }

        private static bool Coliziune(Ball ball1, Ball ball2)
        {
            bool intersectie = false;

            int x1 = ball1.Pozitie.X;
            int y1 = ball1.Pozitie.Y;

            int x2 = ball2.Pozitie.X;
            int y2 = ball2.Pozitie.Y;

            double raza = ball1.Raza + ball2.Raza;
            double d = Math.Sqrt((x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2));
            if (d <= raza)
            {
                intersectie = true;
                Console.WriteLine($"Coliziune intre {ball1.GetType()} si {ball2.GetType()} ");
            }

            return intersectie;
        }

        private static bool verificareRegular(List<Ball> bile)
        {
            foreach( var bila in bile)
            {
                if(bila.GetType() == typeof(RegularBall))
                {
                    if (bila.Exista)
                        return true;
                }
            }
            return false;
        }
    }
}