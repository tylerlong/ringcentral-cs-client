using System.Threading.Tasks;

namespace RingCentral
{
    public partial class Recording : Model
    {
        internal Recording(Model parent, string _id = null) : base(parent, _id) { }


        protected override string PathSegment
        {
            get
            {
                return "recording";
            }
        }

        public Content Content(string _id = null)
        {
            return new Content(this, _id);
        }
        


        public Task<GetResponse> Get()
        {
            return RC.Get<GetResponse>(Endpoint(true), null);
        }
        public class GetResponse
        {
            public int? id;
            public string contentUri;
            public string contentType;
            public int? duration;
        }
        

    }
}