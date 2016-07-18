using System.Threading.Tasks;

namespace RingCentral
{
    public partial class ActiveCalls : Model
    {
        internal ActiveCalls(Model parent) : base(parent, null) { }


        protected override string PathSegment
        {
            get
            {
                return "active-calls";
            }
        }


        public Task<ListResponse> List(ListQueryParams queryParams = null)
        {
            return RC.Get<ListResponse>(Endpoint(false), queryParams);
        }
        public class ListQueryParams
        {
            public string direction;
            public string type;
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
                public string sessionId;
                public From from;
                public To to;
                public string type;
                public string direction;
                public string action;
                public string result;
                public string startTime;
                public int? duration;
                public Recording recording;
                public string lastModifiedTime;
                public string transport;
                public Leg[] legs;
        
                public class From
                {
                    public string phoneNumber;
                    public string extensionNumber;
                    public string location;
                    public string name;
                }
        
                public class To
                {
                    public string phoneNumber;
                    public string extensionNumber;
                    public string location;
                    public string name;
                }
        
                public class Recording
                {
                    public int? id;
                    public string uri;
                    public string type;
                    public string contentUri;
                }
        
                public class Leg
                {
                    public string action;
                    public string direction;
                    public int? duration;
                    public Extension extension;
                    public string legType;
                    public string startTime;
                    public string type;
                    public string result;
                    public From from;
                    public To to;
                    public string transport;
                    public Recording recording;
        
                    public class Extension
                    {
                        public int? id;
                        public string uri;
                    }
        
                    public class From
                    {
                        public string phoneNumber;
                        public string extensionNumber;
                        public string location;
                        public string name;
                    }
        
                    public class To
                    {
                        public string phoneNumber;
                        public string extensionNumber;
                        public string location;
                        public string name;
                    }
        
                    public class Recording
                    {
                        public int? id;
                        public string uri;
                        public string type;
                        public string contentUri;
                    }
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