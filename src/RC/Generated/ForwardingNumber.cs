namespace RingCentral
{
    public partial class ForwardingNumber : Model
    {
        internal ForwardingNumber(Model parent, string _id = null) : base(parent, _id) { }

        protected override string PathSegment
        {
            get
            {
                return "forwarding-number";
            }
        }

        
    }
}