using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace A_Dormitory.Models
{
    public abstract class MyDictBaseModel : MyBaseModel
    {
        public MyDictBaseModel() : base()
        {

        }
        public string Name { get; set; }
        public string Code { get; set; }
    }
}