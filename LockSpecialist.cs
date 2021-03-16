using System;

namespace Heist2
{
    public class LockSpecialist : IRobber
    {
        public string Name { get; set; }
        public int SkillLevel { get; set; }
        public int PercentageCut { get; set; }
        public void PerformSkill(int Bank)
        {
            int pickedVault = Bank - SkillLevel;
            Console.WriteLine($"{Name} is cracking the vault. Decreased security {SkillLevel} points");
            if (pickedVault <= 0)
            {
                Console.WriteLine($"{Name} has cracked open the vault!");
            }
        }
    }
}