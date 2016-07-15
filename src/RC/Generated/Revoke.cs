namespace RingCentral
{
    public partial class Revoke : Model
    {
        internal Revoke(Model parent, string _id = null) : base(parent, _id) { }

        protected override string PathSegment
        {
            get
            {
                return "revoke";
            }
        }

        
    }
}