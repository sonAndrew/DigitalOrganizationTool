﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LCCTemplate
{
    public abstract class BasicClass : IClassBasicClass
    {
        public required char Letter { get; set; }
        public required string Title { get; set; }

        public string Identifier { get => $"{Letter}"; }

        public string FullIdentification { get => $"{Letter} - {Title}"; }
        public List<SubClass>? SubClasses { get; set; }
    }
}
