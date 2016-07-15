namespace RingCentral
{
    public partial class CustomData : Model
    {
        internal CustomData(Model parent, string _id = null) : base(parent, _id) { }

        protected override string PathSegment
        {
            get
            {
                return "custom-data";
            }
        }

        
    }
}