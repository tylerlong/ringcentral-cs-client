namespace RingCentral
{
    public partial class Department : Model
    {
        internal Department(Model parent, string _id = null) : base(parent, _id) { }


        protected override string PathSegment
        {
            get
            {
                return "department";
            }
        }

        public Members Members()
        {
            return new Members(this);
        }
        


    }
}