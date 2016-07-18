using System.Threading.Tasks;

namespace RingCentral
{
    public partial class MessageStore : Model
    {
        internal MessageStore(Model parent, string _id = null) : base(parent, _id) { }


        protected override string PathSegment
        {
            get
            {
                return "message-store";
            }
        }

        public Content Content(string _id = null)
        {
            return new Content(this, _id);
        }
        


        public Task<ListResponse> List(ListQueryParams queryParams = null)
        {
            return RC.Get<ListResponse>(Endpoint(false), queryParams);
        }
        public class ListQueryParams
        {
            public string availability;
            public int? conversationId;
            public string dateFrom;
            public string dateTo;
            public string direction;
            public bool? distinctConversations;
            public string messageType;
            public string readStatus;
            public int? page;
            public int? perPage;
            public string phoneNumber;
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
        

        public void Delete(DeleteQueryParams queryParams = null)
        {
            RC.Delete(Endpoint(true), queryParams);
        }
        public class DeleteQueryParams
        {
            public bool? purge;
            public int? conversationId;
        }
        
        

        public Task<GetResponse> Get()
        {
            return RC.Get<GetResponse>(Endpoint(true), null);
        }
        public class GetResponse
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
        

        public Task<PutResponse> Put(PutRequest requestBody)
        {
            return RC.Put<PutResponse>(Endpoint(true), requestBody, null);
        }
        public class PutRequest
        {
            public string readStatus;
        }
        public class PutResponse
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
        

    }
}