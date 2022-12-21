using PizzaMizza.Abstractions;
using PizzaMizza.Helper;
using PizzaMizza.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaMizza.Services
{
    internal class SizesService : IService<Sizes>
    {
        public void Add(Sizes model)
        {
            Sql.ExecCommand($"INSERT INTO Sizes VALUES (N'{model.Name}')");
        }
        public void Delete(int id)
        {
            Sql.ExecCommand($"DELETE Sizes WHERE Id = {id}");
        }
        public List<Sizes> GetAll()
        {
            DataTable dt = Sql.ExecQuery("SELECT * FROM Sizes");
            List<Sizes> sizes = new List<Sizes>();
            foreach (DataRow dr in dt.Rows)
            {
                sizes.Add(new Sizes { Id = Convert.ToInt32(dr["Id"]), Name = dr["Name"].ToString() });
            }
            return sizes;
        }
    }
}
