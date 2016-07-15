namespace RingCentral
{
    public partial class BusinessAddress : Model
    {
        internal BusinessAddress(Model parent, string _id = null) : base(parent, _id) { }

        protected override string PathSegment
        {
            get
            {
                return "business-address";
            }
        }

        
    }
}