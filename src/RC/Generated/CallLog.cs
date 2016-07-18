using System.Threading.Tasks;

namespace RingCentral
{
    public partial class CallLog : Model
    {
        internal CallLog(Model parent, string _id = null) : base(parent, _id) { }


        protected override string PathSegment
        {
            get
            {
                return "call-log";
            }
        }


        public Task<ListResponse> List(ListQueryParams queryParams = null)
        {
            return RC.Get<ListResponse>(Endpoint(false), queryParams);
        }
        public class ListQueryParams
        {
            public string extensionNumber;
            public string phoneNumber;
            public string direction;
            public string type;
            public string view;
            public bool? withRecording;
            public string dateFrom;
            public string dateTo;
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
        

        public Task<System.Net.Http.HttpResponseMessage> Delete(DeleteQueryParams queryParams = null)
        {
            return RC.Delete(Endpoint(false), queryParams);
        }
        public class DeleteQueryParams
        {
            public string dateTo;
        }
        
        

    }
}