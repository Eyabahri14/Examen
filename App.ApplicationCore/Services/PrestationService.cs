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
    public class PrestationService : Service<Prestation>, IPrestationService
    {
        public PrestationService(IUnitOfWork unitOfWork) : base(unitOfWork)
        { }

       
    }
}
