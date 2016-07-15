namespace RingCentral
{
    public partial class Token
    {
        public Token() : base(null) { }

        public string access_token;
        public string token_type;
        public int? expires_in;
        public string refresh_token;
        public int? refresh_token_expires_in;
        public string scope;
        public string owner_id;
        public string endpoint_id;
    }
}