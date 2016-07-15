namespace RingCentral
{
    public partial class Order : Model
    {
        internal Order(Model parent, string _id = null) : base(parent, _id) { }

        protected override string PathSegment
        {
            get
            {
                return "order";
            }
        }

        
    }
}