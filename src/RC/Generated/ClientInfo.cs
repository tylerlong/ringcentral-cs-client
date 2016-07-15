namespace RingCentral
{
    public partial class ClientInfo : Model
    {
        internal ClientInfo(Model parent, string _id = null) : base(parent, _id) { }

        protected override string PathSegment
        {
            get
            {
                return "client-info";
            }
        }

        
        public CustomData CustomData(string _id = null)
        {
            return new CustomData(this, _id);
        }
        
    }
}