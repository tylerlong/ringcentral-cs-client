namespace RingCentral
{
    public partial class PhoneNumber : Model
    {
        internal PhoneNumber(Model parent, string _id = null) : base(parent, _id) { }

        protected override string PathSegment
        {
            get
            {
                return "phone-number";
            }
        }

        
    }
}