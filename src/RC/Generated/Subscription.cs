using System.Threading.Tasks;

namespace RingCentral
{
    public partial class Subscription : Model
    {
        internal Subscription(Model parent, string _id = null) : base(parent, _id) { }


        protected override string PathSegment
        {
            get
            {
                return "subscription";
            }
        }


        public Task<PostResponse> Post(PostRequest requestBody, PostQueryParams queryParams = null)
        {
            return RC.Post<PostResponse>(Endpoint(false), requestBody, queryParams);
        }
        public class PostQueryParams
        {
            public bool? aggregated;
        }
        public class PostRequest
        {
            public string[] eventFilters;
            public DeliveryMode deliveryMode;
        
            public class DeliveryMode
            {
                public string transportType;
                public bool? encryption;
            }
        }
        public class PostResponse
        {
            public string id;
            public string uri;
            public string[] eventFilters;
            public string expirationTime;
            public int? expiresIn;
            public string status;
            public string creationTime;
            public DeliveryMode deliveryMode;
        
            public class DeliveryMode
            {
                public string transportType;
                public bool? encryption;
                public string address;
                public string subscriberKey;
                public string secretKey;
                public string encryptionAlgorithm;
                public string encryptionKey;
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
            public string uri;
            public string[] eventFilters;
            public string expirationTime;
            public int? expiresIn;
            public string status;
            public string creationTime;
            public DeliveryMode deliveryMode;
        
            public class DeliveryMode
            {
                public string transportType;
                public bool? encryption;
                public string address;
                public string subscriberKey;
                public string secretKey;
                public string encryptionAlgorithm;
                public string encryptionKey;
            }
        }
        

        public Task<PutResponse> Put(PutRequest requestBody, PutQueryParams queryParams = null)
        {
            return RC.Put<PutResponse>(Endpoint(true), requestBody, queryParams);
        }
        public class PutQueryParams
        {
            public bool? aggregated;
        }
        public class PutRequest
        {
            public string[] eventFilters;
        }
        public class PutResponse
        {
            public string id;
            public string uri;
            public string[] eventFilters;
            public string expirationTime;
            public int? expiresIn;
            public string status;
            public string creationTime;
            public DeliveryMode deliveryMode;
        
            public class DeliveryMode
            {
                public string transportType;
                public bool? encryption;
                public string address;
                public string subscriberKey;
                public string secretKey;
                public string encryptionAlgorithm;
                public string encryptionKey;
            }
        }
        

    }
}