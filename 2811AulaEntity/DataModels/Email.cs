using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2811Aula.DataModels
{
    public class Email
    {
        public int id { get; set; }
        public string email { get; set; }

        public virtual Pessoa pessoa { get; set; }
    }
}
