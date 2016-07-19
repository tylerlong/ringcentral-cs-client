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
            public bool? loginAllowed { get; set; }
            public bool? numberSelling { get; set; }
            public int? page { get; set; }
            public int? perPage { get; set; }
        }
        public class ListResponse
        {
            public Record[] records { get; set; }
            public Navigation navigation { get; set; }
            public Paging paging { get; set; }
        
            public class Record
            {
                public string id { get; set; }
                public string uri { get; set; }
                public string callingCode { get; set; }
                public bool? emergencyCalling { get; set; }
                public string isoCode { get; set; }
                public string name { get; set; }
                public bool? numberSelling { get; set; }
                public bool? loginAllowed { get; set; }
            }
        
            public class Navigation
            {
                public FirstPage firstPage { get; set; }
                public NextPage nextPage { get; set; }
                public PreviousPage previousPage { get; set; }
                public LastPage lastPage { get; set; }
        
                public class FirstPage
                {
                    public string uri { get; set; }
                }
        
                public class NextPage
                {
                    public string uri { get; set; }
                }
        
                public class PreviousPage
                {
                    public string uri { get; set; }
                }
        
                public class LastPage
                {
                    public string uri { get; set; }
                }
            }
        
            public class Paging
            {
                public int? page { get; set; }
                public int? perPage { get; set; }
                public int? pageStart { get; set; }
                public int? pageEnd { get; set; }
                public int? totalPages { get; set; }
                public int? totalElements { get; set; }
            }
        }
        

        public Task<GetResponse> Get()
        {
            return RC.Get<GetResponse>(Endpoint(true), null);
        }
        public class GetResponse
        {
            public string id { get; set; }
            public string uri { get; set; }
            public string callingCode { get; set; }
            public bool? emergencyCalling { get; set; }
            public string isoCode { get; set; }
            public string name { get; set; }
            public bool? numberSelling { get; set; }
            public bool? loginAllowed { get; set; }
        }
        

    }
}