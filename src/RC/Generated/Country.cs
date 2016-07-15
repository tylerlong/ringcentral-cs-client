namespace RingCentral
{
    public partial class Country : Model
    {
        internal Country(Model parent, string _id = null) : base(parent, _id) { }

        protected override string PathSegment
        {
            get
            {
                return "country";
            }
        }

        
    }
}