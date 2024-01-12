using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LCCTemplate
{
    public interface ISubBasic
    {
        public char? BaseIdentifier { get; set; }
        public char? SubIdentifier { get; set; }
        public string? FullIdentifier { get; set; }
        public string? Title { get; set; }
        public string? FullIdentification { get; set; }
        public List<string>? Subjects { get; set; }
    }
}
