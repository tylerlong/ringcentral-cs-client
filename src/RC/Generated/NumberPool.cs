namespace RingCentral
{
    public partial class NumberPool : Model
    {
        internal NumberPool(Model parent, string _id = null) : base(parent, _id) { }

        protected override string PathSegment
        {
            get
            {
                return "number-pool";
            }
        }

        
        public Lookup Lookup(string _id = null)
        {
            return new Lookup(this, _id);
        }
        
        public Reserve Reserve(string _id = null)
        {
            return new Reserve(this, _id);
        }
        
    }
}