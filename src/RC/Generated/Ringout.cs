namespace RingCentral
{
    public partial class Ringout : Model
    {
        internal Ringout(Model parent, string _id = null) : base(parent, _id) { }

        protected override string PathSegment
        {
            get
            {
                return "ringout";
            }
        }

        
    }
}