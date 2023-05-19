using App.ApplicationCore.Domain;
using App.ApplicationCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace App.ApplicationCore.Services
{
    public class PrestataireService : Service<Prestataire>, IPrestataireService
    {
        public PrestataireService(IUnitOfWork unitOfWork) : base(unitOfWork)
        { }

        public List<Prestataire> GetPresOrderByNom()
        {
            return GetAll().OrderBy(p => p.PrestataireNom).ToList();
        }


        public List<Prestataire> GetPrestataireMieuxNote()
        {

            int maxPrestationsCount = GetAll().Max(v => v.Prestations.Count);
            List<Prestataire> LP= GetMany(v => v.Prestations.Count >= maxPrestationsCount).ToList(); ;

            List<Prestataire> ListeMieuxNotes=new List<Prestataire>();  
            foreach(Prestataire p in LP)
            { 
                for(int i = 0; i < 3; i++)
                {
                    LP.Add(p);

                };

            }

             return LP;
        }

        /*public Prestation GetPrestationById(int id)
        {
            return GetMany(p => p.PrestataireId == id).FirstOrDefault();
        }
        */
        
    }
}
