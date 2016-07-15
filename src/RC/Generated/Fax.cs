namespace RingCentral
{
    public partial class Fax : Model
    {
        internal Fax(Model parent, string _id = null) : base(parent, _id) { }

        protected override string PathSegment
        {
            get
            {
                return "fax";
            }
        }

        
    }
}