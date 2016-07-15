namespace RingCentral
{
    public partial class MessageSync : Model
    {
        internal MessageSync(Model parent, string _id = null) : base(parent, _id) { }

        protected override string PathSegment
        {
            get
            {
                return "message-sync";
            }
        }

        
    }
}