namespace RingCentral
{
    public partial class Reserve : Model
    {
        internal Reserve(Model parent, string _id = null) : base(parent, _id) { }

        protected override string PathSegment
        {
            get
            {
                return "reserve";
            }
        }

        
    }
}