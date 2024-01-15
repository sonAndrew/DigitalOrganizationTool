using LCCTemplate.BasicClassIdentifiers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LCCTemplate
{
    public interface IClassSubClass : IClass
    {
        BasicClassLetters BasicClassLetter { get; set; }
        IEnumerable<ITopic>? Captions { get; set; }
    }
}
