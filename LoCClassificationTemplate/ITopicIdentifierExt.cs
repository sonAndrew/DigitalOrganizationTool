using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LCCTemplate
{
    public interface ITopicIdentifierExt
    {
        
        string? DecimalExtension { get; set; }
        string? Place { get; set; }
        string? TimePeriod { get; set; }
        List<string>? BibliogrphicForm { get; set; }
        List<ITopicIdentifierExt>? Topics { get; set; }
    }
}
