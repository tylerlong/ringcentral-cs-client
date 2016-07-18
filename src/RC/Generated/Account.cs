using System.Threading.Tasks;

namespace RingCentral
{
    public partial class Account : Model
    {
        internal Account(Model parent, string _id = null) : base(parent, _id) { }


        protected override string PathSegment
        {
            get
            {
                return "account";
            }
        }

        public ActiveCalls ActiveCalls()
        {
            return new ActiveCalls(this);
        }
        

        public BusinessAddress BusinessAddress()
        {
            return new BusinessAddress(this);
        }
        

        public CallLog CallLog(string _id = null)
        {
            return new CallLog(this, _id);
        }
        

        public Department Department(string _id = null)
        {
            return new Department(this, _id);
        }
        

        public Device Device(string _id = null)
        {
            return new Device(this, _id);
        }
        

        public Extension Extension(string _id = "~")
        {
            return new Extension(this, _id);
        }
        

        public Order Order(string _id = null)
        {
            return new Order(this, _id);
        }
        

        public PhoneNumber PhoneNumber(string _id = null)
        {
            return new PhoneNumber(this, _id);
        }
        

        public Recording Recording(string _id = null)
        {
            return new Recording(this, _id);
        }
        

        public ServiceInfo ServiceInfo()
        {
            return new ServiceInfo(this);
        }
        


        public Task<GetResponse> Get()
        {
            return RC.Get<GetResponse>(Endpoint(true), null);
        }
        public class GetResponse
        {
            public string id;
            public string uri;
            public string mainNumber;
            public Operator @operator;
            public string partnerId;
            public ServiceInfo serviceInfo;
            public string setupWizardState;
            public string status;
            public StatusInfo statusInfo;
        
            public class Operator
            {
                public string id;
                public string uri;
                public Contact contact;
                public Departments departments;
                public string extensionNumber;
                public string name;
                public string partnerId;
                public Permissions permissions;
                public ProfileImage profileImage;
                public Reference[] references;
                public RegionalSettings regionalSettings;
                public ServiceFeature[] serviceFeatures;
                public string setupWizardState;
                public string status;
                public StatusInfo statusInfo;
                public string type;
        
                public class Contact
                {
                    public string firstName;
                    public string lastName;
                    public string company;
                    public string email;
                    public string businessPhone;
                    public BusinessAddress businessAddress;
        
                    public class BusinessAddress
                    {
                        public string country;
                        public string state;
                        public string city;
                        public string street;
                        public string zip;
                    }
                }
        
                public class Departments
                {
                    public string id;
                    public string uri;
                    public string extensionNumber;
                }
        
                public class Permissions
                {
                    public Admin admin;
                    public InternationalCalling internationalCalling;
        
                    public class Admin
                    {
                        public bool? enabled;
                    }
        
                    public class InternationalCalling
                    {
                        public bool? enabled;
                    }
                }
        
                public class ProfileImage
                {
                    public string uri;
                    public string etag;
                    public string lastModified;
                    public string contentType;
                    public string[] scales;
                }
        
                public class Reference
                {
                    public string @ref;
                    public string type;
                }
        
                public class RegionalSettings
                {
                    public HomeCountry homeCountry;
                    public Timezone timezone;
                    public Language language;
                    public GreetingLanguage greetingLanguage;
                    public FormattingLocale formattingLocale;
        
                    public class HomeCountry
                    {
                        public string id;
                        public string uri;
                        public string name;
                    }
        
                    public class Timezone
                    {
                        public string id;
                        public string uri;
                        public string name;
                        public string description;
                    }
        
                    public class Language
                    {
                        public string id;
                        public string uri;
                        public bool? greeting;
                        public bool? formattingLocale;
                        public string localeCode;
                        public string name;
                        public bool? ui;
                    }
        
                    public class GreetingLanguage
                    {
                        public string id;
                        public string localeCode;
                        public string name;
                    }
        
                    public class FormattingLocale
                    {
                        public string id;
                        public string localeCode;
                        public string name;
                    }
                }
        
                public class ServiceFeature
                {
                    public bool? enabled;
                    public string featureName;
                    public string reason;
                }
        
                public class StatusInfo
                {
                    public string comment;
                    public string reason;
                }
            }
        
            public class ServiceInfo
            {
                public string uri;
                public BillingPlan billingPlan;
                public Brand brand;
                public ServicePlan servicePlan;
                public TargetServicePlan targetServicePlan;
        
                public class BillingPlan
                {
                    public string id;
                    public string name;
                    public string durationUnit;
                    public string duration;
                    public string type;
                }
        
                public class Brand
                {
                    public string id;
                    public string name;
                    public HomeCountry homeCountry;
        
                    public class HomeCountry
                    {
                        public string id;
                        public string uri;
                        public string name;
                    }
                }
        
                public class ServicePlan
                {
                    public string id;
                    public string name;
                    public string edition;
                }
        
                public class TargetServicePlan
                {
                    public string id;
                    public string name;
                }
            }
        
            public class StatusInfo
            {
                public string comment;
                public string reason;
            }
        }
        

    }
}