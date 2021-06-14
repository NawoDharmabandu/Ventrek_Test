using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace NebulaToDo.Models
{
    public class USERS
    {
        [Key]
        public int ID { get; set; }

        [Required(ErrorMessage = "UserID is required")]
        [Column(TypeName = "nvarchar(250)")]
        public string USER_ID { get; set; }

        [Required(ErrorMessage = "Password is required")]
        [Column(TypeName = "nvarchar(250)")]
        public string USER_PASSWORD{ get; set; }

        [Column(TypeName = "nvarchar(250)")]
        public string USER_TITLE { get; set; }

        [Column(TypeName = "nvarchar(250)")]
        public string USER_FNAME { get; set; }

        [Column(TypeName = "nvarchar(250)")]
        public string USER_LNAME { get; set; }

        [Column(TypeName = "nvarchar(250)")]
        public string USER_CONTACT { get; set; }

        [Column(TypeName = "nvarchar(250)")]
        public string USER_EMAIL { get; set; }

        [Column(TypeName = "int")] //status : 0, 1
        public int USER_STATUS { get; set; }

        [Column(TypeName = "nvarchar(250)")]
        public string CREATED_BY { get; set; }

        [Column(TypeName = "datetime")]
        public DateTime CREATED_DATE { get; set; }

        [Column(TypeName = "nvarchar(250)")]
        public string MODERATED_BY { get; set; }

        [Column(TypeName = "datetime")]
        public DateTime MODERATED_DATE { get; set; }

        [Column(TypeName = "nvarchar(250)")]
        public string DEACTIVATED_BY { get; set; }

        [Column(TypeName = "datetime")]
        public DateTime DEATIVATED_DATE { get; set; }
    }
}
