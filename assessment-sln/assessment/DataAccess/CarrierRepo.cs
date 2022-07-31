using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using assessment.Models;

namespace assessment.DataAccess
{
    public class CarrierRepoSql : ICarrierRepo
    {
        private readonly DatabaseConfig _dbConfig;

        private static Carrier GetFromReader(IDataReader rdr)
        {
            return new Carrier()
            {
                CarrierID = rdr.GetInt32(0),
                CarrierName = rdr.GetString("CarrierName"),
                Address = rdr.GetString("Address"),
                Address2 = rdr.GetString("Address2"),
                City = rdr.GetString("City"),
                State = rdr.GetString("State"),
                Zip = rdr.GetString("Zip"),
                Contact = rdr.GetString("Contact"),
                Phone = rdr.GetString("Phone"),
                Fax = rdr.GetString("Fax"),
                Email = rdr.GetString("Email")
            };
        }

        public CarrierRepoSql(DatabaseConfig dbConfig)
        {
            _dbConfig = dbConfig;
        }

        public Carrier Create(Carrier carrier)
        {
            return new Carrier();
        }

        public int Delete(int carrierID)
        {
            int ret = 0;
            using (var ctx = new SqlConnection(_dbConfig.ConnectionString))
            using (var cmd = ctx.CreateCommand())
            {
                ctx.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "Carriers_Delete";
                cmd.Parameters.AddWithValue("CarrierID", carrierID);
                using (var rdr = cmd.ExecuteReader())
                {
                    if (rdr.Read())
                        ret = rdr.GetInt32(0);
                }
            }
            return 0;
        }

        public List<Carrier> GetAll()
        {
            List<Carrier> list = new List<Carrier>();
            using (var ctx = new SqlConnection(_dbConfig.ConnectionString))
            using (var cmd = ctx.CreateCommand())
            {
                ctx.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "Carriers_GetAll";
                using (var rdr = cmd.ExecuteReader())
                {
                    while(rdr.Read())
                        list.Add(GetFromReader(rdr));
                }
            }
            return list;
        }

        public Carrier GetByID(int carrierID)
        {
            Carrier ret = null;
            using (var ctx = new SqlConnection(_dbConfig.ConnectionString))
            using (var cmd = ctx.CreateCommand())
            {
                ctx.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "Carriers_GetByID";
                cmd.Parameters.AddWithValue("@CarrierID", carrierID);
                using (var rdr = cmd.ExecuteReader())
                {
                    if (rdr.Read())
                        ret = GetFromReader(rdr);
                }
            }
            return ret;
        }

        public Carrier Update(Carrier carrier)
        {
            using (var ctx = new SqlConnection(_dbConfig.ConnectionString))
            using (var cmd = ctx.CreateCommand())
            {
                ctx.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "Carriers_Update";
                cmd.Parameters.AddWithValue("@CarrierID", carrier.CarrierID);
                cmd.Parameters.AddWithValue("@CarrierName", carrier.CarrierName);
                cmd.Parameters.AddWithValue("@Address", carrier.Address);
                cmd.Parameters.AddWithValue("@Address2", carrier.Address2);
                cmd.Parameters.AddWithValue("@City", carrier.City);
                cmd.Parameters.AddWithValue("@State", carrier.State);
                cmd.Parameters.AddWithValue("@Zip", carrier.Zip);
                cmd.Parameters.AddWithValue("@Contact", carrier.Contact);
                cmd.Parameters.AddWithValue("@Phone", carrier.Phone);
                cmd.Parameters.AddWithValue("@Fax", carrier.Fax);
                cmd.Parameters.AddWithValue("@Email", carrier.Email);
                cmd.ExecuteNonQuery();
            }
            return carrier;
        }
    }

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