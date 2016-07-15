namespace RingCentral
{
    public partial class AddressBook : Model
    {
        internal AddressBook(Model parent, string _id = null) : base(parent, _id) { }

        protected override string PathSegment
        {
            get
            {
                return "address-book";
            }
        }

        
        public Contact Contact(string _id = null)
        {
            return new Contact(this, _id);
        }
        
        public Group Group(string _id = null)
        {
            return new Group(this, _id);
        }
        
    }
}