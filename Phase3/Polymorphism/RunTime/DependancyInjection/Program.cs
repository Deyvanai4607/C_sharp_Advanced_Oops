using System;
using System.Collections.Generic;
namespace DependancyInjection;
public class Program{
    public static void Main(string[] args)
    {
        CCAccount cCAccount=new CCAccount();
        cCAccount.AccountNumber=123;
        cCAccount.Name="devi";
        cCAccount.Balance=50000;

        SVAccount sVAccount=new SVAccount();
        sVAccount.AccountNumber=123;
        sVAccount.Name="Deyvanai";
        sVAccount.Balance=10000;

        List<CCAccount> ccList=new List<CCAccount>();
        ccList.Add(cCAccount);

        List<SVAccount> svList=new List<SVAccount>();
        svList.Add(sVAccount);

        List<IAccount> accountsList=new List<IAccount>();
        accountsList.Add(cCAccount);
        accountsList.Add(sVAccount);
    }
}
