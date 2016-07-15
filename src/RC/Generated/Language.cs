namespace RingCentral
{
    public partial class Language : Model
    {
        internal Language(Model parent, string _id = null) : base(parent, _id) { }

        protected override string PathSegment
        {
            get
            {
                return "language";
            }
        }

        
    }
}