using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Boat Beneteau = new Boat("Beneteau", "White", "ER-256", "100 km/h");
            Beneteau.name("Benetaeu");
            Beneteau.color("White");
            Beneteau.model("ER-256");
            Beneteau.speed("100 km/h");
            Beneteau.sail(Beneteau);
            Beneteau.stop(Beneteau);
        }
    }
}
