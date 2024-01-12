using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LCCTemplate
{
    public interface IClassIdentifier
    {
        char Letter { get; set; }
        string Title { get; set; }
        string Letters { get; }
        string FullIdentification { get; }
    }
}
