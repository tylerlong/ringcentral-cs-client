namespace RingCentral
{
    public partial class ActiveCalls : Model
    {
        internal ActiveCalls(Model parent, string _id = null) : base(parent, _id) { }

        protected override string PathSegment
        {
            get
            {
                return "active-calls";
            }
        }

        
    }
}