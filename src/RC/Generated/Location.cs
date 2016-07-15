namespace RingCentral
{
    public partial class Location : Model
    {
        internal Location(Model parent, string _id = null) : base(parent, _id) { }

        protected override string PathSegment
        {
            get
            {
                return "location";
            }
        }

        
    }
}