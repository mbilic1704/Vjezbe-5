using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gradjevina
{
    public interface IProstor
    {
        string Oznaka { get; set; }
        double Povrsina { get; set; }

        double IzracunajNetoPovrsinu();
    }
}
