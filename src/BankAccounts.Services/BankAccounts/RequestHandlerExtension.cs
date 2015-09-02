using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccountsAPI.Repository.Entities;
using AccountsAPI.Contracts;

namespace AccountsAPI.Services.BankAccounts
{
    public static class RequestHandlerExtension
    {
        public static void TrySuccessor(this IRequestAccountHandler current, BankAccountBenefits accountBenefits)
        {
            if (current.Successor != null)
            {
                Console.WriteLine("Can't approve - Passing request to {0}", typeof(IRequestAccountHandler));
                current.Successor.ProcessRequest(accountBenefits);
            }
            else
            {
                Console.WriteLine("Amount invaid, no approval given");
            }
        }
    }
}
