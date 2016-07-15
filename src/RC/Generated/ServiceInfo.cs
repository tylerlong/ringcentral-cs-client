namespace RingCentral
{
    public partial class ServiceInfo : Model
    {
        internal ServiceInfo(Model parent, string _id = null) : base(parent, _id) { }

        protected override string PathSegment
        {
            get
            {
                return "service-info";
            }
        }

        
    }
}