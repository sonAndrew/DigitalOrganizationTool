using LCCTemplate.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LCCTemplate
{
    public abstract class SubClass : IClassIdentifier
    {
        public required BasicClassIdentifier BasicClassLetter { get; set; }
        public required char Letter { get; set; }
        public required string Title { get; set; }

        public string Letters { get => $"{BasicClassLetter}{Letter}"; }

        public string FullIdentification { get => $"{Letters} - {Title}"; }
        public List<ITopicIdentifier>? Captions { get; set; }
    }
}
