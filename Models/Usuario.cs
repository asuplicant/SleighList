using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SleighList.Models
{
    public class Usuario
    {
        [Key] 

        public string? Nome;
        public string? Email;
        public string? Senha;
    }
}