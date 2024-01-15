using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LCCTemplate
{
    public interface IClass
    {
        char Letter { get; set; }
        string Title { get; set; }
        string Identifier { get; }
        string FullIdentification { get; }
    }
}
