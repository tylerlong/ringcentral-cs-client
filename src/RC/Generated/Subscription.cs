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
            public bool? aggregated { get; set; }
        }
        public class PostRequest
        {
            public string[] eventFilters { get; set; }
            public DeliveryMode deliveryMode { get; set; }
        
            public class DeliveryMode
            {
                public string transportType { get; set; }
                public bool? encryption { get; set; }
            }
        }
        public class PostResponse
        {
            public string id { get; set; }
            public string uri { get; set; }
            public string[] eventFilters { get; set; }
            public string expirationTime { get; set; }
            public int? expiresIn { get; set; }
            public string status { get; set; }
            public string creationTime { get; set; }
            public DeliveryMode deliveryMode { get; set; }
        
            public class DeliveryMode
            {
                public string transportType { get; set; }
                public bool? encryption { get; set; }
                public string address { get; set; }
                public string subscriberKey { get; set; }
                public string secretKey { get; set; }
                public string encryptionAlgorithm { get; set; }
                public string encryptionKey { get; set; }
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
            public string id { get; set; }
            public string uri { get; set; }
            public string[] eventFilters { get; set; }
            public string expirationTime { get; set; }
            public int? expiresIn { get; set; }
            public string status { get; set; }
            public string creationTime { get; set; }
            public DeliveryMode deliveryMode { get; set; }
        
            public class DeliveryMode
            {
                public string transportType { get; set; }
                public bool? encryption { get; set; }
                public string address { get; set; }
                public string subscriberKey { get; set; }
                public string secretKey { get; set; }
                public string encryptionAlgorithm { get; set; }
                public string encryptionKey { get; set; }
            }
        }
        

        public Task<PutResponse> Put(PutRequest requestBody, PutQueryParams queryParams = null)
        {
            return RC.Put<PutResponse>(Endpoint(true), requestBody, queryParams);
        }
        public class PutQueryParams
        {
            public bool? aggregated { get; set; }
        }
        public class PutRequest
        {
            public string[] eventFilters { get; set; }
        }
        public class PutResponse
        {
            public string id { get; set; }
            public string uri { get; set; }
            public string[] eventFilters { get; set; }
            public string expirationTime { get; set; }
            public int? expiresIn { get; set; }
            public string status { get; set; }
            public string creationTime { get; set; }
            public DeliveryMode deliveryMode { get; set; }
        
            public class DeliveryMode
            {
                public string transportType { get; set; }
                public bool? encryption { get; set; }
                public string address { get; set; }
                public string subscriberKey { get; set; }
                public string secretKey { get; set; }
                public string encryptionAlgorithm { get; set; }
                public string encryptionKey { get; set; }
            }
        }
        

    }
}