using System.Threading.Tasks;

namespace RingCentral
{
    public partial class Fax : Model
    {
        internal Fax(Model parent) : base(parent, null) { }


        protected override string PathSegment
        {
            get
            {
                return "fax";
            }
        }


        public Task<PostResponse> Post(PostRequest requestBody)
        {
            return RC.Post<PostResponse>(Endpoint(false), requestBody, null);
        }
        public class PostRequest
        {
            public To[] to;
            public string resolution;
            public string sendTime;
            public int? coverIndex;
            public string coverPageText;
            public string originalMessageId;
        
            public class To
            {
                public string phoneNumber;
                public string extensionNumber;
                public string location;
                public string name;
            }
        }
        public class PostResponse
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