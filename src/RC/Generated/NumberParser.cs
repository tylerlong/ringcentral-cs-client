namespace RingCentral
{
    public partial class NumberParser : Model
    {
        internal NumberParser(Model parent, string _id = null) : base(parent, _id) { }

        protected override string PathSegment
        {
            get
            {
                return "number-parser";
            }
        }

        
        public Parse Parse(string _id = null)
        {
            return new Parse(this, _id);
        }
        
    }
}