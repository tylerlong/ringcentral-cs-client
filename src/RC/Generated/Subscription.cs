namespace RingCentral
{
    public partial class Subscription : Model
    {
        internal Subscription(Model parent, string _id = null) : base(parent, _id) { }

        protected override string PathSegment
        {
            get
            {
                return "subscription";
            }
        }

        
    }
}