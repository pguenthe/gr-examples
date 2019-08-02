using System;

namespace RobotSimGR
{
    class Program
    {
        static void Main(string[] args)
        {
            //WallE wallE = new WallE("Wall-E", 0, 0);
            //Eve eve = new Eve("Eve", 1, 0);

            //Console.WriteLine(wallE);
            //Console.WriteLine(eve);

            //wallE.Move(2, 2);
            //eve.Move(-1, -1);

            //wallE.Act();
            //eve.Act();

            //Console.WriteLine(wallE);
            //Console.WriteLine(eve);

            //eve.Fly(5,5,5);

            //wallE.Recharge(10);
            //eve.Recharge(5);

            //Console.WriteLine(wallE);
            //Console.WriteLine(eve);

            //wallE.Shutdown();
            //eve.Shutdown();
            Robot[] robots = new Robot[32];
            robots[0] = new WallE("Wall-E", 0, 0);
            robots[1] = new Eve("Eve", 1, 0);

            for (int i = 0; i < 10; i++)
            {
                Turn(robots);
                Console.WriteLine();
            }
        }

        static void Turn(Robot[] robots)
        {
            foreach (Robot r in robots)
            {
                if (r is Eve)
                {
                    ((Eve)r).Fly(5, 5, 5);
                }
                else
                {
                    r.Move(2, 2);
                }

                r.Act();
                Console.WriteLine(r);
            }
        }
        //static void OldMain(string[] args)
        //{
        //    Robot WallE = new Robot("Wall-E", 0, 0);
        //    Robot Eve = new Robot("Eve", 1, 0);

        //    Console.WriteLine(WallE);
        //    Console.WriteLine(Eve);

        //    WallE.Recharge(10);
        //    Eve.Recharge(5);

        //    Console.WriteLine(WallE);
        //    Console.WriteLine(Eve);

        //    WallE.Shutdown();
        //    Eve.Shutdown();

        //}
    }
}
