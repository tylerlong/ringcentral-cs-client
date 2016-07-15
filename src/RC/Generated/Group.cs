namespace RingCentral
{
    public partial class Group : Model
    {
        internal Group(Model parent, string _id = null) : base(parent, _id) { }

        protected override string PathSegment
        {
            get
            {
                return "group";
            }
        }

        
    }
}