using System.Threading.Tasks;

namespace RingCentral
{
    public partial class Meeting : Model
    {
        internal Meeting(Model parent, string _id = null) : base(parent, _id) { }


        protected override string PathSegment
        {
            get
            {
                return "meeting";
            }
        }

        public ServiceInfo ServiceInfo()
        {
            return new ServiceInfo(this);
        }
        

        public End End()
        {
            return new End(this);
        }
        


        public Task<PostResponse> Post(PostRequest requestBody)
        {
            return RC.Post<PostResponse>(Endpoint(false), requestBody, null);
        }
        public class PostRequest
        {
            public string topic;
            public string meetingType;
            public string password;
            public Schedule schedule;
            public bool? allowJoinBeforeHost;
            public bool? startHostVideo;
            public bool? startParticipantsVideo;
            public string[] audioOptions;
        
            public class Schedule
            {
                public string startTime;
                public int? durationInMinutes;
                public TimeZone timeZone;
        
                public class TimeZone
                {
                    public string id;
                }
            }
        }
        public class PostResponse
        {
            public string uri;
            public string id;
            public string topic;
            public string meetingType;
            public string password;
            public string status;
            public Links links;
            public Schedule schedule;
            public bool? allowJoinBeforeHost;
            public bool? startHostVideo;
            public bool? startParticipantsVideo;
            public string[] audioOptions;
        
            public class Links
            {
                public string startUri;
                public string joinUri;
            }
        
            public class Schedule
            {
                public string startTime;
                public int? durationInMinutes;
                public TimeZone timeZone;
        
                public class TimeZone
                {
                    public string id;
                }
            }
        }
        

        public Task<ListResponse> List()
        {
            return RC.Get<ListResponse>(Endpoint(false), null);
        }
        public class ListResponse
        {
            public string uri;
            public Record[] records;
            public Paging paging;
            public Navigation navigation;
        
            public class Record
            {
                public string uri;
                public string id;
                public string topic;
                public string meetingType;
                public string password;
                public string status;
                public Links links;
                public Schedule schedule;
                public bool? allowJoinBeforeHost;
                public bool? startHostVideo;
                public bool? startParticipantsVideo;
                public string[] audioOptions;
        
                public class Links
                {
                    public string startUri;
                    public string joinUri;
                }
        
                public class Schedule
                {
                    public string startTime;
                    public int? durationInMinutes;
                    public TimeZone timeZone;
        
                    public class TimeZone
                    {
                        public string id;
                    }
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
        }
        

        public Task<System.Net.Http.HttpResponseMessage> Delete()
        {
            return RC.Delete(Endpoint(true), null);
        }
        
        

        public Task<GetResponse> Get()
        {
            return RC.Get<GetResponse>(Endpoint(true), null);
        }
        public class GetResponse
        {
            public string uri;
            public string id;
            public string topic;
            public string meetingType;
            public string password;
            public string status;
            public Links links;
            public Schedule schedule;
            public bool? allowJoinBeforeHost;
            public bool? startHostVideo;
            public bool? startParticipantsVideo;
            public string[] audioOptions;
        
            public class Links
            {
                public string startUri;
                public string joinUri;
            }
        
            public class Schedule
            {
                public string startTime;
                public int? durationInMinutes;
                public TimeZone timeZone;
        
                public class TimeZone
                {
                    public string id;
                }
            }
        }
        

        public Task<PutResponse> Put(PutRequest requestBody)
        {
            return RC.Put<PutResponse>(Endpoint(true), requestBody, null);
        }
        public class PutRequest
        {
            public string topic;
            public string meetingType;
            public string password;
            public Schedule schedule;
            public bool? allowJoinBeforeHost;
            public bool? startHostVideo;
            public bool? startParticipantsVideo;
            public string[] audioOptions;
        
            public class Schedule
            {
                public string startTime;
                public int? durationInMinutes;
                public TimeZone timeZone;
        
                public class TimeZone
                {
                    public string id;
                }
            }
        }
        public class PutResponse
        {
            public string uri;
            public string id;
            public string topic;
            public string meetingType;
            public string password;
            public string status;
            public Links links;
            public Schedule schedule;
            public bool? allowJoinBeforeHost;
            public bool? startHostVideo;
            public bool? startParticipantsVideo;
            public string[] audioOptions;
        
            public class Links
            {
                public string startUri;
                public string joinUri;
            }
        
            public class Schedule
            {
                public string startTime;
                public int? durationInMinutes;
                public TimeZone timeZone;
        
                public class TimeZone
                {
                    public string id;
                }
            }
        }
        

    }
}