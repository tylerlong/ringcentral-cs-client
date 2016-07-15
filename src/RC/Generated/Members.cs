namespace RingCentral
{
    public partial class Members : Model
    {
        internal Members(Model parent, string _id = null) : base(parent, _id) { }

        protected override string PathSegment
        {
            get
            {
                return "members";
            }
        }

        
    }
}