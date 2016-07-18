using System.Threading.Tasks;

namespace RingCentral
{
    public partial class Authorize : Model
    {
        internal Authorize(Model parent) : base(parent, null) { }


        protected override string PathSegment
        {
            get
            {
                return "authorize";
            }
        }


        public Task<PostResponse> Post(PostRequest requestBody)
        {
            return RC.Post<PostResponse>(Endpoint(false), requestBody, null);
        }
        public class PostRequest
        {
            public string response_type;
            public string client_id;
            public string redirect_uri;
            public string state;
        }
        public class PostResponse
        {
            public string code;
            public int? expires_in;
            public string state;
        }
        

    }
}