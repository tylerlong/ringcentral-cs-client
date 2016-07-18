using System.Threading.Tasks;

namespace RingCentral
{
    public partial class Ringout : Model
    {
        internal Ringout(Model parent, string _id = null) : base(parent, _id) { }


        protected override string PathSegment
        {
            get
            {
                return "ringout";
            }
        }


        public Task<PostResponse> Post(PostRequest requestBody)
        {
            return RC.Post<PostResponse>(Endpoint(false), requestBody, null);
        }
        public class PostRequest
        {
            public From from;
            public To to;
            public CallerId callerId;
            public bool? playPrompt;
            public Country country;
        
            public class From
            {
                public string phoneNumber;
                public string forwardingNumberId;
            }
        
            public class To
            {
                public string phoneNumber;
            }
        
            public class CallerId
            {
                public string phoneNumber;
            }
        
            public class Country
            {
                public string id;
            }
        }
        public class PostResponse
        {
            public string id;
            public Status status;
        
            public class Status
            {
                public string callStatus;
                public string callerStatus;
                public string calleeStatus;
            }
        }
        

        public Task<System.Net.Http.HttpResponseMessage> Delete()
        {
            return RC.Delete(Endpoint(true), null);
        }
        
        

        public Task<GetResponse> Get()
        {
            return RC.Get<GetResponse>(Endpoint(true), null);
        }
        public class GetResponse
        {
            public string id;
            public Status status;
        
            public class Status
            {
                public string callStatus;
                public string callerStatus;
                public string calleeStatus;
            }
        }
        

    }
}