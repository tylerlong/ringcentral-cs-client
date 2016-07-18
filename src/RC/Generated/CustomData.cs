using System.Threading.Tasks;

namespace RingCentral
{
    public partial class CustomData : Model
    {
        internal CustomData(Model parent, string _id = null) : base(parent, _id) { }


        protected override string PathSegment
        {
            get
            {
                return "custom-data";
            }
        }


        public Task<PutResponse> Put(PutRequest requestBody)
        {
            return RC.Put<PutResponse>(Endpoint(true), requestBody, null);
        }
        public class PutRequest
        {
            public string id;
            public string value;
        }
        public class PutResponse
        {
            public string id;
            public string uri;
            public string value;
            public string lastModifiedTime;
            public Attachment attachment;
        
            public class Attachment
            {
                public string uri;
                public string contentType;
            }
        }
        

    }
}