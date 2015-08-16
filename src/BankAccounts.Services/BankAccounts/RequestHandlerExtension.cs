using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankAccounts.Repository.Entities;

namespace BankAccounts.Services.BankAccounts
{
    public static class RequestHandlerExtension
    {
        public static void TrySuccessor(this IRequestAccountHandler current, CustomerDto customer)
        {
            if (current.Successor != null)
            {
                Console.WriteLine("Can't approve - Passing request to {0}", typeof(IRequestAccountHandler));
                current.Successor.ProcessRequest(customer);
            }
            else
            {
                Console.WriteLine("Amount invaid, no approval given");
            }
        }
    }
}
