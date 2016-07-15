namespace RingCentral
{
    public partial class BusinessHours : Model
    {
        internal BusinessHours(Model parent, string _id = null) : base(parent, _id) { }

        protected override string PathSegment
        {
            get
            {
                return "business-hours";
            }
        }

        
    }
}