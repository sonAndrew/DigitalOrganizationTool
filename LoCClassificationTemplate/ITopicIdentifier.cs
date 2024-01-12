using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LCCTemplate
{
    public interface ITopicIdentifier
    {
        string? SubClassIdentifier { get; set; }
        char? Number { get; set; }
        string? Name { get; set; }
        string? NumberSpan { get; set; }
    }
}
