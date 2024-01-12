using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LCCTemplate
{
    public interface ICaption
    {
        public string? FullSubIdentifier { get; set; }
        public char? Number { get; set; }
        public string? NumberSpan { get; set; }
        public string? Name { get; set; }
        public string? Place { get; set; }
        public string? TimePeriod { get; set; }
        public List<string?> BibliogrphicForm { get; set; }
    }
}
