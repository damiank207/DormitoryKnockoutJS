using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Web.Script.Serialization;

namespace A_Dormitory.Models
{
    public abstract class MyBaseModel
    {

        public MyBaseModel()
        {
            DateCreate = DateTime.Now;
        }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [ScriptIgnore]
        public Guid Id { get; set; }
        [ScriptIgnore] 
        public DateTime DateCreate { get; set; }

        
    }
}