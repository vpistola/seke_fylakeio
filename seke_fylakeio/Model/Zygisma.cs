using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace seke_fylakeio.Model
{
    public class Zygisma
    {

        [Key]
        public int Id { get; set; }
        public string Vehicle { get; set; }

        [DataType(DataType.Date)]
        public DateTime DateCreated { get; set; }
        public string Invoice { get; set; }

        //[RegularExpression(@"^\d+\.\d{2}$")]
        public decimal GrossWeight { get; set; }

        //[RegularExpression(@"^\d+\.\d{2}$")]
        public decimal TareWeight { get; set; }

        //[RegularExpression(@"^\d+\.\d{2}$")]
        public decimal NetWeight { get; set; }
        public bool IsOk { get; set; }

    }
}
