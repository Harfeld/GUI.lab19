using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace GUI.lab19.Models
{
    public class Applicant
    {
        public int id { get; set; }
        public string _Name { get; set; }
        public string _Email { get; set; }
        public string _Experience { get; set; }
    }
}
