using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DI.Web.Repository
{
    public class BookRepository : IDataRepository
    {
        public List<dynamic> GetList()
        {
            return new List<dynamic>() {
                new { Id =1, Name = "Naa Hanyatee" },
                new { Id =2, Name = "Laa Nui Bengali" },
                new { Id =3, Name = "Perfume" }
            };
        }
    }
}
