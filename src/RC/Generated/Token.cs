namespace RingCentral
{
    public partial class Token : Model
    {
        internal Token(Model parent, string _id = null) : base(parent, _id) { }

        protected override string PathSegment
        {
            get
            {
                return "token";
            }
        }

        
    }
}