using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using assessment.Models;

namespace assessment.DataAccess
{
    public class CarrierRepoInMem : ICarrierRepo
    {
        private List<Carrier> _list;

        public CarrierRepoInMem()
        {
            _list = new List<Carrier>();
            _list.Add(new Carrier()
            {
                CarrierID = 1,
                CarrierName = "Very Good Carrier",
                Address = "123 Abc St.",
                Address2 = "Suite 4",
                City = "San Antonio",
                State = "TX",
                Zip = "78217",
                Contact = "Someone Important",
                Phone = "(123) 456-7890",
                Fax = null,
                Email = "simportant@vgc.com"
            });
            _list.Add(new Carrier()
            {
                CarrierID = 2,
                CarrierName = "Alexandria",
                Address = "456 Def St.",
                Address2 = null,
                City = "Washington",
                State = "DC",
                Zip = "12345",
                Contact = "Rick Grimes",
                Phone = "(123) 456-7890",
                Fax = null,
                Email = "rgrimes@alexandria.net"
            });
        }

        public List<Carrier> GetAll()
        {
            return _list;
        }

        public Carrier GetByID(int carrierID)
        {
            return _list.FirstOrDefault(x => x.CarrierID == carrierID);
        }

        public Carrier Update(Carrier carrier)
        {
            Carrier existing = _list.Find(x => x.CarrierID == carrier.CarrierID);
            if (existing != null)
            {
                _list.Remove(existing);
                _list.Add(carrier);
                return carrier;
            }
            return null;
        }

        public int Delete(int carrierID)
        {
            Carrier carrier = _list.Find(x => x.CarrierID == carrierID);
            if (carrier != null)
            {
                _list.Remove(carrier);
                return 1;
            }
            return 0;
        }

        public Carrier Create(Carrier carrier)
        {
            _list.Add(carrier);
            return carrier;
        }
    }
}