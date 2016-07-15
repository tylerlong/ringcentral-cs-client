namespace RingCentral
{
    public partial class Conferencing : Model
    {
        internal Conferencing(Model parent, string _id = null) : base(parent, _id) { }

        protected override string PathSegment
        {
            get
            {
                return "conferencing";
            }
        }

        
    }
}