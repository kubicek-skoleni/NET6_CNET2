using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Company
    {
        [Key]
        public int ComId { get; set; }

        public string Name { get; set; }

        //[ForeignKey("ContractId")]
        //public Contract Contract { get; set; }

        //public int ContractId { get; set; }
    }
}
