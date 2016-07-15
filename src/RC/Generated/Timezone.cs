namespace RingCentral
{
    public partial class Timezone : Model
    {
        internal Timezone(Model parent, string _id = null) : base(parent, _id) { }

        protected override string PathSegment
        {
            get
            {
                return "timezone";
            }
        }

        
    }
}