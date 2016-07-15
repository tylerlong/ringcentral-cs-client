namespace RingCentral
{
    public partial class Account : Model
    {
        internal Account(Model parent, string _id = null) : base(parent, _id) { }

        protected override string PathSegment
        {
            get
            {
                return "account";
            }
        }

        
        public ActiveCalls ActiveCalls(string _id = null)
        {
            return new ActiveCalls(this, _id);
        }
        
        public BusinessAddress BusinessAddress(string _id = null)
        {
            return new BusinessAddress(this, _id);
        }
        
        public CallLog CallLog(string _id = null)
        {
            return new CallLog(this, _id);
        }
        
        public Department Department(string _id = null)
        {
            return new Department(this, _id);
        }
        
        public Device Device(string _id = null)
        {
            return new Device(this, _id);
        }
        
        public Extension Extension(string _id = "~")
        {
            return new Extension(this, _id);
        }
        
        public Order Order(string _id = null)
        {
            return new Order(this, _id);
        }
        
        public PhoneNumber PhoneNumber(string _id = null)
        {
            return new PhoneNumber(this, _id);
        }
        
        public Recording Recording(string _id = null)
        {
            return new Recording(this, _id);
        }
        
        public ServiceInfo ServiceInfo(string _id = null)
        {
            return new ServiceInfo(this, _id);
        }
        
    }
}