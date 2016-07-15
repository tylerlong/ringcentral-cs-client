namespace RingCentral
{
    public partial class Sms : Model
    {
        internal Sms(Model parent, string _id = null) : base(parent, _id) { }

        protected override string PathSegment
        {
            get
            {
                return "sms";
            }
        }

        
    }
}