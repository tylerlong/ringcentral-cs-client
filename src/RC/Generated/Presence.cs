namespace RingCentral
{
    public partial class Presence : Model
    {
        internal Presence(Model parent, string _id = null) : base(parent, _id) { }

        protected override string PathSegment
        {
            get
            {
                return "presence";
            }
        }

        
    }
}