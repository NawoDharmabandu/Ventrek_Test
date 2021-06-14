using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace NebulaToDo.Models
{
    public class STATUSES
    {
        [Key]
        public int ID { get; set; }

        [Column(TypeName = "int")] //status : 0, 1
        public int STATUS_ID { get; set; }

        [Column(TypeName = "nvarchar(250)")]
        public string STATUS_NAME { get; set; }
    }
}
