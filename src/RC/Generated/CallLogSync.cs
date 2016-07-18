using System.Threading.Tasks;

namespace RingCentral
{
    public partial class CallLogSync : Model
    {
        internal CallLogSync(Model parent) : base(parent, null) { }


        protected override string PathSegment
        {
            get
            {
                return "call-log-sync";
            }
        }


        public Task<GetResponse> Get(GetQueryParams queryParams = null)
        {
            return RC.Get<GetResponse>(Endpoint(false), queryParams);
        }
        public class GetQueryParams
        {
            public string syncType;
            public string syncToken;
            public string dateFrom;
            public int? recordCount;
            public string statusGroup;
        }
        public class GetResponse
        {
            public Record[] records;
            public SyncInfo syncInfo;
        
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
        
            public class SyncInfo
            {
                public string syncType;
                public string syncToken;
                public string syncTime;
            }
        }
        

    }
}