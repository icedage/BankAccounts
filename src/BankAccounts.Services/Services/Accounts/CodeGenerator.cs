using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountsAPI.Services.Services
{
    public sealed class CodeGenerator
    {
        static Random rand;
        private static readonly Lazy<CodeGenerator> lazy = new Lazy<CodeGenerator>(() => new CodeGenerator());

        public static CodeGenerator Instance { get { return lazy.Value; } }

        private CodeGenerator()
        {
            rand = new Random();
        }

        public int GenerateSortCode()
        {
            int result = 0;
            result = rand.Next(100000, 999999);
            return result;
        }

        public int GenerateAccountNumber()
        {
            int result = 0;
            result = rand.Next(10000000, 99999999);
            return result;
        }
    }
}
