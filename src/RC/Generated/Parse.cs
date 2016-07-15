namespace RingCentral
{
    public partial class Parse : Model
    {
        internal Parse(Model parent, string _id = null) : base(parent, _id) { }

        protected override string PathSegment
        {
            get
            {
                return "parse";
            }
        }

        
    }
}