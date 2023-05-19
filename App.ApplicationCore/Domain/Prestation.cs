﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.ApplicationCore.Domain
{
    public class Prestation
    {
        [DataType(DataType.MultilineText)]
        public string Description { get; set; }
        public string Intitule { get; set; }
        public int PrestationId { get; set; }
        public Type PrestationType { get; set; }

        [DataType(DataType.Currency)]
        public double Prix { get; set; }

        [ForeignKey("PrestataireFK")]
        public virtual Prestataire Prestataire { get; set; }
        public int PrestataireFK { get; set; }
        public virtual IList<RDV> RDVs { get; set; }


    }
}
