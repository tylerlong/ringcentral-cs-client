using System.Threading.Tasks;

namespace RingCentral
{
    public partial class BusinessHours : Model
    {
        internal BusinessHours(Model parent) : base(parent, null) { }


        protected override string PathSegment
        {
            get
            {
                return "business-hours";
            }
        }


        public Task<GetResponse> Get()
        {
            return RC.Get<GetResponse>(Endpoint(false), null);
        }
        public class GetResponse
        {
            public string uri;
            public Schedule schedule;
        
            public class Schedule
            {
                public WeeklyRanges weeklyRanges;
        
                public class WeeklyRanges
                {
                    public Monday[] monday;
                    public Tuesday[] tuesday;
                    public Wednesday[] wednesday;
                    public Thursday[] thursday;
                    public Friday[] friday;
                    public Saturday[] saturday;
                    public Sunday[] sunday;
        
                    public class Monday
                    {
                        public string from;
                        public string to;
                    }
        
                    public class Tuesday
                    {
                        public string from;
                        public string to;
                    }
        
                    public class Wednesday
                    {
                        public string from;
                        public string to;
                    }
        
                    public class Thursday
                    {
                        public string from;
                        public string to;
                    }
        
                    public class Friday
                    {
                        public string from;
                        public string to;
                    }
        
                    public class Saturday
                    {
                        public string from;
                        public string to;
                    }
        
                    public class Sunday
                    {
                        public string from;
                        public string to;
                    }
                }
            }
        }
        

    }
}