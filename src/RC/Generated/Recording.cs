namespace RingCentral
{
    public partial class Recording : Model
    {
        internal Recording(Model parent, string _id = null) : base(parent, _id) { }

        protected override string PathSegment
        {
            get
            {
                return "recording";
            }
        }

        
        public Content Content(string _id = null)
        {
            return new Content(this, _id);
        }
        
    }
}