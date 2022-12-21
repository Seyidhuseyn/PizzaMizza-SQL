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
    internal class IngredentsService : IService<Ingredents>
    {
        public void Add(Ingredents model)
        {
            Sql.ExecCommand($"INSERT INTO Ingredents VALUES (N'{model.Name}')");
        }
        public void Delete(int id)
        {
            Sql.ExecCommand($"DELETE Ingredents WHERE Id = {id}");
        }
        public List<Ingredents> GetAll()
        {
            DataTable dt = Sql.ExecQuery("SELECT * FROM Ingredents");
            List<Ingredents> ingredents = new List<Ingredents>();
            foreach (DataRow dr in dt.Rows)
            {
                ingredents.Add(new Ingredents { Id = Convert.ToInt32(dr["Id"]), Name = dr["Name"].ToString() });
            }
            return ingredents;
        }
    }
}
