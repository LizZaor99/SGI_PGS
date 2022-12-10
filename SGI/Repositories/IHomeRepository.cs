using SGI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace SGI.Repositories
{
    public interface IHomeRepository
    {
        int GetByStatus(int tipoEquipo, int status);
        int GetByStore();
    }
}
