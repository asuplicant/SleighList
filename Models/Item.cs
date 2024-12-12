using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SleighList.Models
{
    public class Item
    {
        [Key]
        public int ItemID { get; set; }


        public string? Nome;
        public float PrecoUnidade;
        public int Quantidade;
        

        [ForeignKey("UsuarioID")]
        public int? UsuarioID { get; set; }
        public Item? item { get; set; }
    }
}