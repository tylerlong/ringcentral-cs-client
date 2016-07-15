namespace RingCentral
{
    public partial class CompanyPager : Model
    {
        internal CompanyPager(Model parent, string _id = null) : base(parent, _id) { }

        protected override string PathSegment
        {
            get
            {
                return "company-pager";
            }
        }

        
    }
}