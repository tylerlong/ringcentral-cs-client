using System.Threading.Tasks;

namespace RingCentral
{
    public partial class Country : Model
    {
        internal Country(Model parent, string _id = null) : base(parent, _id) { }


        protected override string PathSegment
        {
            get
            {
                return "country";
            }
        }


        public Task<ListResponse> List(ListQueryParams queryParams = null)
        {
            return RC.Get<ListResponse>(Endpoint(false), queryParams);
        }
        public class ListQueryParams
        {
            public bool? loginAllowed;
            public bool? numberSelling;
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
                public string id;
                public string uri;
                public string callingCode;
                public bool? emergencyCalling;
                public string isoCode;
                public string name;
                public bool? numberSelling;
                public bool? loginAllowed;
            }
        
            public class Navigation
            {
                public string firstPage;
                public string nextPage;
                public string previousPage;
                public string lastPage;
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
            public string id;
            public string uri;
            public string callingCode;
            public bool? emergencyCalling;
            public string isoCode;
            public string name;
            public bool? numberSelling;
            public bool? loginAllowed;
        }
        

    }
}