using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LCCTemplate
{
    public interface ITopicIdentifierExt
    {
        string SubClassIdentifier { get; set; }
        string? DecimalExtension { get; set; }
        string? Place { get; set; }
        string? TimePeriod { get; set; }
        List<string>? BibliogrphicForm { get; set; }
        IEnumerable<ITopic>? Topics { get; set; }
    }
}
