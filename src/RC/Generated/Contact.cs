namespace RingCentral
{
    public partial class Contact : Model
    {
        internal Contact(Model parent, string _id = null) : base(parent, _id) { }

        protected override string PathSegment
        {
            get
            {
                return "contact";
            }
        }

        
    }
}