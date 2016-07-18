using System.Threading.Tasks;

namespace RingCentral
{
    public partial class BlockedNumber : Model
    {
        internal BlockedNumber(Model parent, string _id = null) : base(parent, _id) { }


        protected override string PathSegment
        {
            get
            {
                return "blocked-number";
            }
        }


        public Task<PostResponse> Post(PostRequest requestBody)
        {
            return RC.Post<PostResponse>(Endpoint(false), requestBody, null);
        }
        public class PostRequest
        {
            public string id;
            public string uri;
            public string name;
            public string phoneNumber;
        }
        public class PostResponse
        {
            public string id;
            public string uri;
            public string name;
            public string phoneNumber;
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
                public string name;
                public string phoneNumber;
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
        

        public void Delete()
        {
            RC.Delete(Endpoint(true), null);
        }
        
        

        public Task<GetResponse> Get()
        {
            return RC.Get<GetResponse>(Endpoint(true), null);
        }
        public class GetResponse
        {
            public string id;
            public string uri;
            public string name;
            public string phoneNumber;
        }
        

        public Task<PutResponse> Put(PutRequest requestBody)
        {
            return RC.Put<PutResponse>(Endpoint(true), requestBody, null);
        }
        public class PutRequest
        {
            public string id;
            public string uri;
            public string name;
            public string phoneNumber;
        }
        public class PutResponse
        {
            public string id;
            public string uri;
            public string name;
            public string phoneNumber;
        }
        

    }
}