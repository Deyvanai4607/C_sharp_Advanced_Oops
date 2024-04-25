using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MetroCardManagement
{
    /// <summary>
    /// IBalance interface used to declare the balance and wallet recharge and deduct balance methods
    /// </summary>
    public interface IBalance 
    {
        /*Properties:
        •	Balance
            Methods:
        •	WalletRecharge
        •	DeductBalance
        */
        //Properties
        public int Balance { get; set; }
        //methods
        void WalletRecharge(int rechargeAmount);
        void DeductBalance(int deductAmount);
    }
}