using System.Threading.Tasks;

namespace RingCentral
{
    public partial class Language : Model
    {
        internal Language(Model parent, string _id = null) : base(parent, _id) { }


        protected override string PathSegment
        {
            get
            {
                return "language";
            }
        }


        public Task<ListResponse> List()
        {
            return RC.Get<ListResponse>(Endpoint(false), null);
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
                public bool? greeting;
                public bool? formattingLocale;
                public string localeCode;
                public string name;
                public bool? ui;
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
            public string id;
            public string uri;
            public bool? greeting;
            public bool? formattingLocale;
            public string localeCode;
            public string name;
            public bool? ui;
        }
        

    }
}