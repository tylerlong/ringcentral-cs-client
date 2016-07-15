namespace RingCentral
{
    public partial class MessageStore : Model
    {
        internal MessageStore(Model parent, string _id = null) : base(parent, _id) { }

        protected override string PathSegment
        {
            get
            {
                return "message-store";
            }
        }

        
        public Content Content(string _id = null)
        {
            return new Content(this, _id);
        }
        
    }
}