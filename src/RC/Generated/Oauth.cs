namespace RingCentral
{
    public partial class Oauth : Model
    {
        internal Oauth(Model parent, string _id = null) : base(parent, _id) { }

        protected override string PathSegment
        {
            get
            {
                return "oauth";
            }
        }

        
        public Authorize Authorize(string _id = null)
        {
            return new Authorize(this, _id);
        }
        
        public Revoke Revoke(string _id = null)
        {
            return new Revoke(this, _id);
        }
        
        public Token Token(string _id = null)
        {
            return new Token(this, _id);
        }
        
    }
}