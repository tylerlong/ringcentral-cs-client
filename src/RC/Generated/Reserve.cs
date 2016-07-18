using System.Threading.Tasks;

namespace RingCentral
{
    public partial class Reserve : Model
    {
        internal Reserve(Model parent) : base(parent, null) { }


        protected override string PathSegment
        {
            get
            {
                return "reserve";
            }
        }


        public Task<PostResponse> Post(PostRequest requestBody)
        {
            return RC.Post<PostResponse>(Endpoint(false), requestBody, null);
        }
        public class PostRequest
        {
            public Record[] records;
        
            public class Record
            {
                public string phoneNumber;
                public string reservedTill;
            }
        }
        public class PostResponse
        {
            public Record[] records;
        
            public class Record
            {
                public string phoneNumber;
                public string formattedNumber;
                public string reservedTill;
                public string reservationId;
                public string status;
                public string error;
            }
        }
        

    }
}