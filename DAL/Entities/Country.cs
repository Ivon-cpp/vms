using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class Country
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual List<Producer> Producers { get; set; }
        public virtual List<Vaccine> Vaccines { get; set; }
    }
}
