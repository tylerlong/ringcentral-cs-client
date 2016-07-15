namespace RingCentral
{
    public partial class Device : Model
    {
        internal Device(Model parent, string _id = null) : base(parent, _id) { }

        protected override string PathSegment
        {
            get
            {
                return "device";
            }
        }

        
    }
}