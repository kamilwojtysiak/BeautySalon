using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace BeautySalon
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Member> members = new List<Member>();

            members.Add(new Member("Monika", 883215734, 100, "02.08.2020r. 13:00"));
            members.Add(new BrownMember("Paulina", 792793997, 100, "02.08.2020r. 12:30"));
            members.Add(new SilverMember("Janek", 765657557, 100, "02.08.2020r. 10:00"));
            members.Add(new GoldMember("Kasia", 881499343, 100, "02.08.2020r. 15:15"));

            foreach (var m in members)
            {
                m.CalculatePrice();
                Console.WriteLine(m.ToString());
            }
        }
    }
}
