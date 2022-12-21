using PizzaMizza.Abstractions;
using PizzaMizza.Helper;
using PizzaMizza.Models;
using System.Data;

namespace PizzaMizza.Services
{
    internal class PizzaService : IService<Pizza>
    {
        public void Add(Pizza model)
        {
            Sql.ExecCommand($"INSERT INTO Pizza VALUES (N'{model.Name}')");
        }
        public void Delete(int id)
        {
            Sql.ExecCommand($"DELETE Pizza WHERE Id = {id}");
        }
        public List<Pizza> GetAll()
        {
            DataTable dt = Sql.ExecQuery("SELECT * FROM Pizza");
            List<Pizza> pizza = new List<Pizza>();
            foreach (DataRow dr in dt.Rows)
            {
                pizza.Add(new Pizza { Id = Convert.ToInt32(dr["Id"]), Name = dr["Name"].ToString() });
            }
            return pizza;
        }
    }
}
