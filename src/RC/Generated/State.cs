namespace RingCentral
{
    public partial class State : Model
    {
        internal State(Model parent, string _id = null) : base(parent, _id) { }

        protected override string PathSegment
        {
            get
            {
                return "state";
            }
        }

        
    }
}