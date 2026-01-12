namespace Names
{
    class Name
    {
        public string NameText { get; set; }
        public int First { get; set; }
        public int Last { get; set; }
        public bool IsMale { get; set; }

        public Name(string nameText, int first, int last, bool isMale)
        {
            NameText = nameText;
            First = first;
            Last = last;
            IsMale = isMale;
        }

        public override string ToString()
        {
            char c = IsMale ? 'M' : 'F';
            return $"{NameText} ({c}) | First: {First}, Last: {Last}";
        }
    }
}
