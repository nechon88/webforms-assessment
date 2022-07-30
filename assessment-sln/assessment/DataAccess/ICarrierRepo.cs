using assessment.Models;
using System.Collections.Generic;

namespace assessment.DataAccess
{
    public interface ICarrierRepo
    {
        Carrier Create(Carrier carrier);
        int Delete(int carrierID);
        List<Carrier> GetAll();
        Carrier GetByID(int carrierID);
        Carrier Update(Carrier carrier);
    }
}