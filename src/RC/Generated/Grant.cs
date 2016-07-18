using System.Threading.Tasks;

namespace RingCentral
{
    public partial class Grant : Model
    {
        internal Grant(Model parent) : base(parent, null) { }


        protected override string PathSegment
        {
            get
            {
                return "grant";
            }
        }


        public Task<ListResponse> List(ListQueryParams queryParams = null)
        {
            return RC.Get<ListResponse>(Endpoint(false), queryParams);
        }
        public class ListQueryParams
        {
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
                public string uri;
                public Extension extension;
                public bool? callPickup;
                public bool? callMonitoring;
        
                public class Extension
                {
                    public string id;
                    public string uri;
                    public string extensionNumber;
                    public string type;
                }
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
        

    }
}