using System.Threading.Tasks;

namespace RingCentral
{
    public partial class PhoneNumber : Model
    {
        internal PhoneNumber(Model parent, string _id = null) : base(parent, _id) { }


        protected override string PathSegment
        {
            get
            {
                return "phone-number";
            }
        }


        public Task<ListResponse> List(ListQueryParams queryParams = null)
        {
            return RC.Get<ListResponse>(Endpoint(false), queryParams);
        }
        public class ListQueryParams
        {
            public string usageType;
            public int? page;
            public int? perPage;
        }
        public class ListResponse
        {
            public Record[] records;
            public Navigation navigation;
            public Paging paging;
        
            public class Record
            {
                public int? id;
                public Country country;
                public Extension extension;
                public string[] features;
                public string location;
                public string paymentType;
                public string phoneNumber;
                public string status;
                public string type;
                public string usageType;
        
                public class Country
                {
                    public string id;
                    public string uri;
                    public string name;
                }
        
                public class Extension
                {
                    public string id;
                    public string uri;
                    public string extensionNumber;
                    public string partnerId;
                }
            }
        
            public class Navigation
            {
                public FirstPage firstPage;
                public NextPage nextPage;
                public PreviousPage previousPage;
                public LastPage lastPage;
        
                public class FirstPage
                {
                    public string uri;
                }
        
                public class NextPage
                {
                    public string uri;
                }
        
                public class PreviousPage
                {
                    public string uri;
                }
        
                public class LastPage
                {
                    public string uri;
                }
            }
        
            public class Paging
            {
                public int? page;
                public int? perPage;
                public int? pageStart;
                public int? pageEnd;
                public int? totalPages;
                public int? totalElements;
            }
        }
        

        public Task<GetResponse> Get()
        {
            return RC.Get<GetResponse>(Endpoint(true), null);
        }
        public class GetResponse
        {
            public int? id;
            public Country country;
            public Extension extension;
            public string[] features;
            public string location;
            public string paymentType;
            public string phoneNumber;
            public string status;
            public string type;
            public string usageType;
        
            public class Country
            {
                public string id;
                public string uri;
                public string name;
            }
        
            public class Extension
            {
                public string id;
                public string uri;
                public string extensionNumber;
                public string partnerId;
            }
        }
        

    }
}