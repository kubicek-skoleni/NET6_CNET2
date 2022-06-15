using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Contract
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string Number { get; set; }

        public DateTime Signed { get; set; }

        public bool IsActive { get; set; }
    }
}
