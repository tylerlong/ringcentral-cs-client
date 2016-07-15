namespace RingCentral
{
    public partial class Extension : Model
    {
        internal Extension(Model parent, string _id = null) : base(parent, _id) { }

        protected override string PathSegment
        {
            get
            {
                return "extension";
            }
        }

        
        public ActiveCalls ActiveCalls(string _id = null)
        {
            return new ActiveCalls(this, _id);
        }
        
        public AddressBookSync AddressBookSync(string _id = null)
        {
            return new AddressBookSync(this, _id);
        }
        
        public AddressBook AddressBook(string _id = null)
        {
            return new AddressBook(this, _id);
        }
        
        public AnsweringRule AnsweringRule(string _id = null)
        {
            return new AnsweringRule(this, _id);
        }
        
        public BlockedNumber BlockedNumber(string _id = null)
        {
            return new BlockedNumber(this, _id);
        }
        
        public BusinessHours BusinessHours(string _id = null)
        {
            return new BusinessHours(this, _id);
        }
        
        public CallLog CallLog(string _id = null)
        {
            return new CallLog(this, _id);
        }
        
        public CallLogSync CallLogSync(string _id = null)
        {
            return new CallLogSync(this, _id);
        }
        
        public CompanyPager CompanyPager(string _id = null)
        {
            return new CompanyPager(this, _id);
        }
        
        public Conferencing Conferencing(string _id = null)
        {
            return new Conferencing(this, _id);
        }
        
        public Device Device(string _id = null)
        {
            return new Device(this, _id);
        }
        
        public Fax Fax(string _id = null)
        {
            return new Fax(this, _id);
        }
        
        public ForwardingNumber ForwardingNumber(string _id = null)
        {
            return new ForwardingNumber(this, _id);
        }
        
        public Grant Grant(string _id = null)
        {
            return new Grant(this, _id);
        }
        
        public Meeting Meeting(string _id = null)
        {
            return new Meeting(this, _id);
        }
        
        public MessageStore MessageStore(string _id = null)
        {
            return new MessageStore(this, _id);
        }
        
        public MessageSync MessageSync(string _id = null)
        {
            return new MessageSync(this, _id);
        }
        
        public PhoneNumber PhoneNumber(string _id = null)
        {
            return new PhoneNumber(this, _id);
        }
        
        public Presence Presence(string _id = null)
        {
            return new Presence(this, _id);
        }
        
        public ProfileImage ProfileImage(string _id = null)
        {
            return new ProfileImage(this, _id);
        }
        
        public Ringout Ringout(string _id = null)
        {
            return new Ringout(this, _id);
        }
        
        public Sms Sms(string _id = null)
        {
            return new Sms(this, _id);
        }
        
    }
}