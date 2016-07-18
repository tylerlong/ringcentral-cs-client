using System.Threading.Tasks;

namespace RingCentral
{
    public partial class BusinessAddress : Model
    {
        internal BusinessAddress(Model parent) : base(parent, null) { }


        protected override string PathSegment
        {
            get
            {
                return "business-address";
            }
        }


        public Task<GetResponse> Get()
        {
            return RC.Get<GetResponse>(Endpoint(false), null);
        }
        public class GetResponse
        {
            public string uri;
            public string company;
            public string email;
            public BusinessAddress businessAddress;
        
            public class BusinessAddress
            {
                public string country;
                public string state;
                public string city;
                public string street;
                public string zip;
            }
        }
        

        public Task<PutResponse> Put(PutRequest requestBody)
        {
            return RC.Put<PutResponse>(Endpoint(false), requestBody, null);
        }
        public class PutRequest
        {
            public string company;
            public string email;
            public BusinessAddress businessAddress;
        
            public class BusinessAddress
            {
                public string country;
                public string state;
                public string city;
                public string street;
                public string zip;
            }
        }
        public class PutResponse
        {
            public string uri;
            public string company;
            public string email;
            public BusinessAddress businessAddress;
        
            public class BusinessAddress
            {
                public string country;
                public string state;
                public string city;
                public string street;
                public string zip;
            }
        }
        

    }
}