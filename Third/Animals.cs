using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Third
{
    public class Animals
    {
        public int Life { get; set; }
        public int Damage { get; set; }

        public virtual void ShowPoperties()
        {
            Console.WriteLine(GetType().Name);
            foreach (var propertyInfo in GetType().GetProperties())
            {
                Console.WriteLine($"{propertyInfo.PropertyType} {propertyInfo.Name}");
            }
            Console.WriteLine();
        }
    }
}