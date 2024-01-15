using LCCTemplate.BasicClassIdentifiers;

namespace LCCTemplate
{
    public abstract class SubClass : IClassSubClass
    {
        public BasicClassLetters BasicClassLetter { get; set; }
        public required char Letter { get; set; }
        public required string Title { get; set; }
        public string Identifier { get => $"{BasicClassLetter}{Letter}"; }
        public string FullIdentification { get => $"{Identifier} - {Title}"; }
        public IEnumerable<ITopic>? Captions { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
