namespace RingCentral
{
    public partial class Lookup : Model
    {
        internal Lookup(Model parent, string _id = null) : base(parent, _id) { }

        protected override string PathSegment
        {
            get
            {
                return "lookup";
            }
        }

        
    }
}