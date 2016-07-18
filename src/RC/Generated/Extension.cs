using System.Threading.Tasks;

namespace RingCentral
{
    public partial class Extension : Model
    {
        internal Extension(Model parent, string _id = null) : base(parent, _id) { }


        protected override string PathSegment
        {
            get
            {
                return "extension";
            }
        }

        public ActiveCalls ActiveCalls()
        {
            return new ActiveCalls(this);
        }
        

        public AddressBookSync AddressBookSync()
        {
            return new AddressBookSync(this);
        }
        

        public AddressBook AddressBook()
        {
            return new AddressBook(this);
        }
        

        public AnsweringRule AnsweringRule(string _id = null)
        {
            return new AnsweringRule(this, _id);
        }
        

        public BlockedNumber BlockedNumber(string _id = null)
        {
            return new BlockedNumber(this, _id);
        }
        

        public BusinessHours BusinessHours()
        {
            return new BusinessHours(this);
        }
        

        public CallLog CallLog(string _id = null)
        {
            return new CallLog(this, _id);
        }
        

        public CallLogSync CallLogSync()
        {
            return new CallLogSync(this);
        }
        

        public CompanyPager CompanyPager()
        {
            return new CompanyPager(this);
        }
        

        public Conferencing Conferencing()
        {
            return new Conferencing(this);
        }
        

        public Device Device(string _id = null)
        {
            return new Device(this, _id);
        }
        

        public Fax Fax()
        {
            return new Fax(this);
        }
        

        public ForwardingNumber ForwardingNumber()
        {
            return new ForwardingNumber(this);
        }
        

        public Grant Grant()
        {
            return new Grant(this);
        }
        

        public Meeting Meeting(string _id = null)
        {
            return new Meeting(this, _id);
        }
        

        public MessageStore MessageStore(string _id = null)
        {
            return new MessageStore(this, _id);
        }
        

        public MessageSync MessageSync()
        {
            return new MessageSync(this);
        }
        

        public PhoneNumber PhoneNumber(string _id = null)
        {
            return new PhoneNumber(this, _id);
        }
        

        public Presence Presence()
        {
            return new Presence(this);
        }
        

        public ProfileImage ProfileImage(string _id = null)
        {
            return new ProfileImage(this, _id);
        }
        

        public Ringout Ringout(string _id = null)
        {
            return new Ringout(this, _id);
        }
        

        public Sms Sms()
        {
            return new Sms(this);
        }
        


        public Task<ListResponse> List(ListQueryParams queryParams = null)
        {
            return RC.Get<ListResponse>(Endpoint(false), queryParams);
        }
        public class ListQueryParams
        {
            public int? page;
            public int? perPage;
            public string status;
            public string type;
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
        

        public Task<GetResponse> Get()
        {
            return RC.Get<GetResponse>(Endpoint(true), null);
        }
        public class GetResponse
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
        

    }
}