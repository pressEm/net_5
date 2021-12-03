using System;
using System.Collections.Generic;

namespace net_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Paper p1 = new DrawNotebook(4, 12, "4f", 30, 30, "red");
            Paper p2 = new DrawNotebook(8, 48, "line", 50, 120, "white");
            Paper p3 = new DrawNotebook(8, 60, "empty", 100, 300, "black");
            Paper p4 = new DrawNotebook(8, 24, "empty", 30, 30, "white");


            List<Paper> list = new List<Paper>(4);
            list.Add(p1);
            list.Add(p2);
            list.Add(p3);
            list.Add(p4);
            foreach (Paper p in list)
            {
                Console.WriteLine(p.ToString());
            }

            /*
            n.draw(2);
            n.draw(4);
            n.draw(5);
            n.draw(9);
            n.tear_out(8);
            n.erase(2);
            */
        }
    }
}
