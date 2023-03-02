using System;

namespace Heist
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Plan Your Heist!");
            Console.WriteLine("Enter your a team member's name:");
            string teamMemberName = Console.ReadLine();

            Console.WriteLine("Enter your a team member's skill level:");
            string teamMemberSkill = Console.ReadLine();

            Console.WriteLine("Enter your a team member's courage level between 0 - 2.0:");
            string teamMemberCourage = "";
            while (teamMemberCourage == "")
            {
                teamMemberCourage = Console.ReadLine();
                if (double.Parse(teamMemberCourage) > 2 || double.Parse(teamMemberCourage) < 0)
                {
                    Console.WriteLine("You entered an incorrect value.");
                    Console.WriteLine("Enter your a team member's courage level between 0 - 2.0:");
                    teamMemberCourage = "";
                }

            }

            Member member1 = new Member(teamMemberName, int.Parse(teamMemberSkill), double.Parse(teamMemberCourage));
            Console.WriteLine($"{member1.Name}, has a skill level of: {member1.SkillLevel}, and a courage level of: {member1.CourageLevel}");
        }
    }
}
