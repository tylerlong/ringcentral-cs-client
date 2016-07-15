namespace RingCentral
{
    public partial class BlockedNumber : Model
    {
        internal BlockedNumber(Model parent, string _id = null) : base(parent, _id) { }

        protected override string PathSegment
        {
            get
            {
                return "blocked-number";
            }
        }

        
    }
}