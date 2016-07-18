using System.Threading.Tasks;

namespace RingCentral
{
    public partial class MessageSync : Model
    {
        internal MessageSync(Model parent) : base(parent, null) { }


        protected override string PathSegment
        {
            get
            {
                return "message-sync";
            }
        }


        public Task<GetResponse> Get(GetQueryParams queryParams = null)
        {
            return RC.Get<GetResponse>(Endpoint(false), queryParams);
        }
        public class GetQueryParams
        {
            public int? conversationId;
            public string dateFrom;
            public string dateTo;
            public string direction;
            public bool? distinctConversations;
            public string messageType;
            public int? recordCount;
            public string syncToken;
            public string syncType;
        }
        public class GetResponse
        {
            public Record[] records;
            public SyncInfo syncInfo;
        
            public class Record
            {
                public string id;
                public string uri;
                public Attachment[] attachments;
                public string availability;
                public int? conversationId;
                public string creationTime;
                public string deliveryErrorCode;
                public string direction;
                public int? faxPageCount;
                public string faxResolution;
                public From from;
                public string lastModifiedTime;
                public string messageStatus;
                public bool? pgToDepartment;
                public string priority;
                public string readStatus;
                public string smsDeliveryTime;
                public int? smsSendingAttemptsCount;
                public string subject;
                public To[] to;
                public string type;
                public string vmTranscriptionStatus;
        
                public class Attachment
                {
                    public string id;
                    public string uri;
                    public string type;
                    public string contentType;
                    public int? vmDuration;
                }
        
                public class From
                {
                    public string extensionNumber;
                    public string location;
                    public string messageStatus;
                    public string faxErrorCode;
                    public string name;
                    public string phoneNumber;
                }
        
                public class To
                {
                    public string extensionNumber;
                    public string location;
                    public string messageStatus;
                    public string faxErrorCode;
                    public string name;
                    public string phoneNumber;
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