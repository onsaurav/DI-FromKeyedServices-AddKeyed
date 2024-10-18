using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DI.Web.Repository
{
    public interface IDataRepository
    {
        List<dynamic> GetList();
    }
}
