using System;

namespace Heist
{

    public class Hacker : IRobber
    {
        public string Name { get; set; }
        public int SkillLevel { get; set; }
        public int PercentageCut { get; set; }

        public int PerformSkill(int BankParam)
        {
            int AdjustedBankScore = BankParam--;
            return AdjustedBankScore;
        }
    }
}