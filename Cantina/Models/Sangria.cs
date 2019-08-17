using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Cantina.Models
{
    public class Sangria
    {
        [Key]
        public int id_sangria { get; set; }
        [DataType(DataType.Date)]
        public DateTime data { get; set; }      
        public decimal valor { get; set; }
    }
}