using System;

namespace Heist
{
    public class Member
    {
        public string Name { get; set; }

        public int SkillLevel { get; set; }

        public double CourageLevel { get; set; }


        public Member(string name, int skillParam, double courageParam)
        {
            Name = name;
            SkillLevel = skillParam;
            CourageLevel = courageParam;
        }
    }
}
