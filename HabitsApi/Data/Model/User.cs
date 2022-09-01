using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Data.Model
{
    public class User : BaseModel
    {
        public string Email { get; set; }
       
        public string Senha { get; set; }
        public string Nome { get; set; }
        public string Image { get; set; }
    }
}
