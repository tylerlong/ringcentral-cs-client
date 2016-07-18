using System.Threading.Tasks;

namespace RingCentral
{
    public partial class Parse : Model
    {
        internal Parse(Model parent) : base(parent, null) { }


        protected override string PathSegment
        {
            get
            {
                return "parse";
            }
        }


        public Task<PostResponse> Post(PostRequest requestBody, PostQueryParams queryParams = null)
        {
            return RC.Post<PostResponse>(Endpoint(false), requestBody, queryParams);
        }
        public class PostQueryParams
        {
            public string homeCountry;
            public bool? nationalAsPriority;
        }
        public class PostRequest
        {
            public string[] originalStrings;
        }
        public class PostResponse
        {
            public string uri;
            public HomeCountry[] homeCountry;
            public PhoneNumber[] phoneNumbers;
            public string originalString;
            public string areaCode;
            public string formattedNational;
            public string formattedInternational;
            public string dialable;
            public string e164;
            public bool? special;
            public string normalized;
            public Country[] country;
        
            public class HomeCountry
            {
                public string id;
                public string uri;
                public string callingCode;
                public bool? emergencyCalling;
                public string isoCode;
                public string name;
            }
        
            public class PhoneNumber
            {
                public string areaCode;
                public Country[] country;
                public string dialable;
                public string e164;
                public string formattedInternational;
                public string formattedNational;
                public string originalString;
                public bool? special;
                public string normalized;
        
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