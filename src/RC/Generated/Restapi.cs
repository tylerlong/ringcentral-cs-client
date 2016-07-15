namespace RingCentral
{
    public partial class Restapi : Model
    {
        internal Restapi(Model parent, string _id = null) : base(parent, _id) { }

        protected override string PathSegment
        {
            get
            {
                return "restapi";
            }
        }

        
        public Oauth Oauth(string _id = null)
        {
            return new Oauth(this, _id);
        }
        
        public Account Account(string _id = "~")
        {
            return new Account(this, _id);
        }
        
        public ClientInfo ClientInfo(string _id = null)
        {
            return new ClientInfo(this, _id);
        }
        
        public Dictionary Dictionary(string _id = null)
        {
            return new Dictionary(this, _id);
        }
        
        public NumberParser NumberParser(string _id = null)
        {
            return new NumberParser(this, _id);
        }
        
        public NumberPool NumberPool(string _id = null)
        {
            return new NumberPool(this, _id);
        }
        
        public Subscription Subscription(string _id = null)
        {
            return new Subscription(this, _id);
        }
        
    }
}