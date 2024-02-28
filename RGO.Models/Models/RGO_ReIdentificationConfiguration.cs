using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RGO.Models.Models
{
    public class RGO_ReIdentificationConfiguration
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public string Server { get; set; }
        public string Database { get; set; }
        public string Table { get; set; }
        public string DeIdentifiedColumn { get; set; }
        public string IdentityColumn { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
