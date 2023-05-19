using App.ApplicationCore.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.ApplicationCore.Interfaces
{
    public interface IPrestataireService : IService<Prestataire>
    {
        public List<Prestataire> GetPrestataireMieuxNote();
        public List<Prestataire> GetPresOrderByNom();

        public Prestation GetPrestationById(int id);
    }
}
