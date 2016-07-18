using System.Threading.Tasks;

namespace RingCentral
{
    public partial class Presence : Model
    {
        internal Presence(Model parent) : base(parent, null) { }


        protected override string PathSegment
        {
            get
            {
                return "presence";
            }
        }


        public Task<GetResponse> Get()
        {
            return RC.Get<GetResponse>(Endpoint(false), null);
        }
        public class GetResponse
        {
            public string uri;
            public bool? allowSeeMyPresence;
            public string dndStatus;
            public Extension extension;
            public string message;
            public bool? pickUpCallsOnHold;
            public string presenceStatus;
            public bool? ringOnMonitoredCall;
            public string telephonyStatus;
            public string userStatus;
        
            public class Extension
            {
                public string id;
                public string uri;
                public string extensionNumber;
            }
        }
        

    }
}