﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniERP.Models
{
    public class Cliente
    {

        [Key]
        public int Id { get; set; }
        public string Nome { get; set; }      
        public string Cnpj { get; set; }
        public string Email { get; set; }       
        public string Telefone { get; set; }
    }
}

