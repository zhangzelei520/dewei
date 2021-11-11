using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Linq;
using System.Data.Linq.Mapping;
namespace Model
{

    [Table(Name = "SectionRoom")]
     public  class SectionRoom
    {
        [Column]
        public int Sid { get; set; }
        [Column]
        public string Sname { get; set; }
        [Column]
        public string Saddr { get; set; }
        [Column]
        public int Sprice { get; set; }
        
        public override string ToString()
        {
            return Sname;
        }
    }
}
