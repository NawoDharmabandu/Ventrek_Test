using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace NebulaToDo.Models
{
    public class TASK_DETAILS
    {
        [Key]
        public int TASK_ID { get; set; }

        [Column(TypeName = "nvarchar(250)")]
        public string TASK_NAME { get; set; }

        [Column(TypeName = "datetime")]
        public DateTime DUE_DATE { get; set; }

        [Column(TypeName = "int")]
        public int TASK_STATUS { get; set; }

        [Column(TypeName = "nvarchar(250)")]
        public string DESCRIPTION { get; set; }

        [Column(TypeName = "nvarchar(250)")]
        public string CREATED_BY { get; set; }

        [Column(TypeName = "datetime")]
        public DateTime CREATED_DATE { get; set; }

        [Column(TypeName = "nvarchar(250)")]
        public string MODIFIED_BY { get; set; }

        [Column(TypeName = "datetime")]
        public DateTime MODIFIED_DATE { get; set; }


    }
}
