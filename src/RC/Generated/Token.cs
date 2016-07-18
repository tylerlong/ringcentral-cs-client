using System.Threading.Tasks;

namespace RingCentral
{
    public partial class Token : Model
    {
        internal Token(Model parent) : base(parent, null) { }


        protected override string PathSegment
        {
            get
            {
                return "token";
            }
        }


        public Task<PostResponse> Post(PostRequest requestBody)
        {
            return RC.Post<PostResponse>(Endpoint(false), requestBody, null);
        }
        public class PostRequest
        {
            public string grant_type;
            public int? access_token_ttl;
            public int? refresh_token_ttl;
            public string username;
            public string extension;
            public string password;
            public string scope;
            public string endpoint_id;
        }
        public class PostResponse
        {
            public string access_token;
            public int? expires_in;
            public string refresh_token;
            public int? refresh_token_expires_in;
            public string scope;
            public string token_type;
            public string owner_id;
            public string endpoint_id;
        }
        

    }
}