namespace RingCentral
{
    public partial class CallLogSync : Model
    {
        internal CallLogSync(Model parent, string _id = null) : base(parent, _id) { }

        protected override string PathSegment
        {
            get
            {
                return "call-log-sync";
            }
        }

        
    }
}