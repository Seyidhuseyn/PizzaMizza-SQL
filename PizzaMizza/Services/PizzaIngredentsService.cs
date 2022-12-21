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
    internal class PizzaIngredentsService : IService<PizzaIngredents>
    {
        public void Add(PizzaIngredents model)
        {
            Sql.ExecCommand($"INSERT INTO PizzaIngredents VALUES ({model.PizzaId}, {model.IngredentsId})");
        }
        public void Delete(int id)
        {
            Sql.ExecCommand($"DELETE PizzaIngredents WHERE Id = {id}");
        }
        public List<PizzaIngredents> GetAll()
        {
            DataTable dt = Sql.ExecQuery("SELECT * FROM PizzaIngredents");
            List<PizzaIngredents> pizzaingredents = new List<PizzaIngredents>();
            foreach (DataRow dr in dt.Rows)
            {
                pizzaingredents.Add(new PizzaIngredents { Id = Convert.ToInt32(dr["Id"]), PizzaId = Convert.ToInt32(dr["PizzaId"]), IngredentsId = Convert.ToInt32(dr["IngredentsId"]) });
            }
            return pizzaingredents;
        }
    }
}
