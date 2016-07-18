using System.Threading.Tasks;

namespace RingCentral
{
    public partial class AnsweringRule : Model
    {
        internal AnsweringRule(Model parent, string _id = null) : base(parent, _id) { }


        protected override string PathSegment
        {
            get
            {
                return "answering-rule";
            }
        }


        public Task<GetResponse> Get()
        {
            return RC.Get<GetResponse>(Endpoint(true), null);
        }
        public class GetResponse
        {
            public string uri;
            public string id;
            public string type;
            public string name;
            public bool? enabled;
            public Schedule schedule;
            public CalledNumber[] calledNumbers;
            public Caller[] callers;
            public string callHandlingAction;
            public Forwarding forwarding;
            public UnconditionalForwarding unconditionalForwarding;
            public Voicemail voicemail;
        
            public class Schedule
            {
                public WeeklyRanges weeklyRanges;
                public Ranges ranges;
                public string @ref;
        
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
        
                public class Ranges
                {
                    public string from;
                    public string to;
                }
            }
        
            public class CalledNumber
            {
                public string phoneNumber;
            }
        
            public class Caller
            {
                public string callerId;
                public string name;
            }
        
            public class Forwarding
            {
                public bool? notifyMySoftPhones;
                public bool? notifyAdminSoftPhones;
                public int? softPhonesRingCount;
                public string ringingMode;
                public Rule[] rules;
        
                public class Rule
                {
                    public int? index;
                    public int? ringCount;
                    public ForwardingNumber[] forwardingNumbers;
        
                    public class ForwardingNumber
                    {
                        public string uri;
                        public string id;
                        public string phoneNumber;
                        public string label;
                    }
                }
            }
        
            public class UnconditionalForwarding
            {
                public string phoneNumber;
            }
        
            public class Voicemail
            {
                public bool? enabled;
                public Recipient recipient;
        
                public class Recipient
                {
                    public string uri;
                    public string id;
                }
            }
        }
        

    }
}