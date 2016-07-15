namespace RingCentral
{
    public partial class AddressBookSync : Model
    {
        internal AddressBookSync(Model parent, string _id = null) : base(parent, _id) { }

        protected override string PathSegment
        {
            get
            {
                return "address-book-sync";
            }
        }

        
    }
}