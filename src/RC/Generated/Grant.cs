namespace RingCentral
{
    public partial class Grant : Model
    {
        internal Grant(Model parent, string _id = null) : base(parent, _id) { }

        protected override string PathSegment
        {
            get
            {
                return "grant";
            }
        }

        
    }
}