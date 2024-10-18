using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DI.Web.Repository
{
    public class MovieRepository : IDataRepository
    {
        public List<dynamic> GetList()
        {
            return new List<dynamic>() {
                new { Id = 1, Name = "Pother Pachali" },
                new { Id = 2, Name = "Never Let Me Go" },
                new { Id = 3, Name = "Blood Diamond" },
                new { Id = 4, Name = "Jibon Theke Naoa" }
            };
        }
    }
}
