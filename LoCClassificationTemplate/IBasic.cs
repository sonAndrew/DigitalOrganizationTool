using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LCCTemplate
{
    public interface IBasic
    {
        public char? Identifier { get; set; }
        public string? Title { get; set; }
        public string FullIdentification { get; }
        public List<string>? SubClasses { get; set; }
    }
}
