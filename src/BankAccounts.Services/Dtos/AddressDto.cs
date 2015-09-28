using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountsAPI.Services.Dtos
{
    public class AddressDto
    {
        public string PostCode { get; set; }

        public string FirstLine { get; set; }

        public string City { get; set; }

        public string County { get; set; }

        public int Length { get; set; }
    }
}
