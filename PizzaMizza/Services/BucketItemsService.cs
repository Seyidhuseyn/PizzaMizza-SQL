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
    internal class BucketItemsService : IService<BucketItems>
    {
        public void Add(BucketItems model)
        {
            Sql.ExecCommand($"INSERT INTO BucketItems VALUES (N'{model.SubPrice}', N'{model.Count}', {model.PizzaId}, {model.BucketsId})");
        }
        public void Delete(int id)
        {
            Sql.ExecCommand($"DELETE BucketItems WHERE Id = {id}");
        }
        public List<BucketItems> GetAll()
        {
            DataTable dt = Sql.ExecQuery("SELECT * FROM BucketItems");
            List<BucketItems> bucketitems = new List<BucketItems>();
            foreach (DataRow dr in dt.Rows)
            {
                bucketitems.Add(new BucketItems { Id = Convert.ToInt32(dr["Id"]), SubPrice = Convert.ToInt32(dr["SubPrice"]), Count = Convert.ToInt32(dr["Count"]), PizzaId = Convert.ToInt32(dr["PizzaId"]), BucketsId = Convert.ToInt32(dr["BucketsId"]), });
            }
            return bucketitems;
        }
    }
}
