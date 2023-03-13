using System;

namespace Heist
{
    public class Bank
    {
        int CashOnHand { get; set; }
        int AlarmScore { get; set; }
        int VaultScore { get; set; }
        int SecurityGuardScore { get; set; }
        /*
        bool IsSecure(int Cash, int Alarm, int Vault, int SecurityGuard)
        {
            bool secure = true;
            if (Cash + Alarm + Vault + SecurityGuard <= 0)
            {
                secure = false;
            }
            else
            {
                secure = true;
            }
        }

        Bank(int CashOnHandParam, int AlarmScoreParam, int VaultScoreParam, int SecurityGuardParam, bool IsSecureParam)
        {
            CashOnHand = CashOnHandParam;
            AlarmScore = AlarmScoreParam;
            VaultScore = VaultScoreParam;
            SecurityGuardScore = SecurityGuardParam;
            IsSecure = IsSecureParam;
        }
        */
    }
}