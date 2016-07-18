using System.Threading.Tasks;

namespace RingCentral
{
    public partial class Location : Model
    {
        internal Location(Model parent) : base(parent, null) { }


        protected override string PathSegment
        {
            get
            {
                return "location";
            }
        }


        public Task<ListResponse> List(ListQueryParams queryParams = null)
        {
            return RC.Get<ListResponse>(Endpoint(false), queryParams);
        }
        public class ListQueryParams
        {
            public string orderBy;
            public int? page;
            public int? perPage;
            public string stateId;
            public bool? withNxx;
        }
        public class ListResponse
        {
            public Record[] records;
            public Navigation navigation;
            public Paging paging;
        
            public class Record
            {
                public string uri;
                public string areaCode;
                public string city;
                public string npa;
                public string nxx;
                public string state;
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
        

    }
}