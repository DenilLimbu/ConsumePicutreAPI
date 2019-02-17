using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvcMovie.RequestHandlers
{
    public interface IRequestHandler
    {
        string GetReleases(string url);
    }
}

