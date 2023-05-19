using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.ApplicationCore.Domain
{
    public class RDV
    {
        public bool Confirmation { get; set; }
        public DateTime DateRDV { get; set; }

        public int ClientFK { get; set; }

        public int PrestationFK { get; set; }

        [ForeignKey("ClientFK")]
        public virtual Client Client { get; set; }

        [ForeignKey("PrestationFK")]
        public virtual Prestation Prestation { get; set; }
    }
}
