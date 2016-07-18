using System.Threading.Tasks;

namespace RingCentral
{
    public partial class Restapi : Model
    {
        internal Restapi(Model parent, string _id = null) : base(parent, _id) { }


        protected override string PathSegment
        {
            get
            {
                return "restapi";
            }
        }

        public Oauth Oauth()
        {
            return new Oauth(this);
        }
        

        public Account Account(string _id = "~")
        {
            return new Account(this, _id);
        }
        

        public ClientInfo ClientInfo()
        {
            return new ClientInfo(this);
        }
        

        public Dictionary Dictionary()
        {
            return new Dictionary(this);
        }
        

        public NumberParser NumberParser()
        {
            return new NumberParser(this);
        }
        

        public NumberPool NumberPool()
        {
            return new NumberPool(this);
        }
        

        public Subscription Subscription(string _id = null)
        {
            return new Subscription(this, _id);
        }
        


        public Task<ListResponse> List()
        {
            return RC.Get<ListResponse>(Endpoint(false), null);
        }
        public class ListResponse
        {
            public string uri;
            public ApiVersion[] apiVersions;
            public string serverVersion;
            public string serverRevision;
        
            public class ApiVersion
            {
                public string uri;
                public string versionString;
                public string releaseDate;
                public string uriString;
            }
        }
        

        public Task<GetResponse> Get()
        {
            return RC.Get<GetResponse>(Endpoint(true), null);
        }
        public class GetResponse
        {
            public string uri;
            public string versionString;
            public string releaseDate;
            public string uriString;
        }
        

    }
}