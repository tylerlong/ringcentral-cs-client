using System.Threading.Tasks;

namespace RingCentral
{
    public partial class Conferencing : Model
    {
        internal Conferencing(Model parent) : base(parent, null) { }


        protected override string PathSegment
        {
            get
            {
                return "conferencing";
            }
        }


        public Task<GetResponse> Get(GetQueryParams queryParams = null)
        {
            return RC.Get<GetResponse>(Endpoint(false), queryParams);
        }
        public class GetQueryParams
        {
            public string countryId;
        }
        public class GetResponse
        {
            public string uri;
            public bool? allowJoinBeforeHost;
            public string hostCode;
            public string mode;
            public string participantCode;
            public string phoneNumber;
            public string tapToJoinUri;
            public PhoneNumber[] phoneNumbers;
        
            public class PhoneNumber
            {
                public Country country;
                public bool? @default;
                public bool? hasGreeting;
                public string location;
                public string phoneNumber;
        
                public class Country
                {
                    public string id;
                    public string uri;
                    public string callingCode;
                    public bool? emergencyCalling;
                    public string isoCode;
                    public string name;
                }
            }
        }
        

        public Task<PutResponse> Put(PutRequest requestBody)
        {
            return RC.Put<PutResponse>(Endpoint(false), requestBody, null);
        }
        public class PutRequest
        {
            public PhoneNumber[] phoneNumbers;
            public bool? allowJoinBeforeHost;
        
            public class PhoneNumber
            {
                public string phoneNumber;
                public bool? @default;
            }
        }
        public class PutResponse
        {
            public string uri;
            public bool? allowJoinBeforeHost;
            public string hostCode;
            public string mode;
            public string participantCode;
            public string phoneNumber;
            public string tapToJoinUri;
            public PhoneNumber[] phoneNumbers;
        
            public class PhoneNumber
            {
                public Country country;
                public bool? @default;
                public bool? hasGreeting;
                public string location;
                public string phoneNumber;
        
                public class Country
                {
                    public string id;
                    public string uri;
                    public string callingCode;
                    public bool? emergencyCalling;
                    public string isoCode;
                    public string name;
                }
            }
        }
        

    }
}