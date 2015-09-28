using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace GatewayAPI.Entities
{
    public class Customer : Entity
    {
       

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Nationality { get; set; }

        public string PostCode { get; set; }

        public string BirthDate { get; set; }

        public decimal AnnualGrossSalary { get; set; }

        public decimal AnnualNetSalary { get; set; }

        public string PersonalId { get; set; }
    }

    public static class EntityExtension
    { 
        public static IList<ListA> GetDictionary(this Entity entity)
        {
            Type type = entity.GetType();
            PropertyInfo[] properties = type.GetProperties();

            var dictionary= new List<ListA>();

            foreach (PropertyInfo property in properties)
            {
                if (!string.IsNullOrEmpty(Convert.ToString(property.GetValue(entity, null))))
                    dictionary.Add(new ListA() {A=property.Name.ToString(),B= Convert.ToString(property.GetValue(entity, null))});
            }

            return dictionary;

        }
    }
}
