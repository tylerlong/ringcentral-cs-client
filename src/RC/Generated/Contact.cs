using System.Threading.Tasks;

namespace RingCentral
{
    public partial class Contact : Model
    {
        internal Contact(Model parent, string _id = null) : base(parent, _id) { }


        protected override string PathSegment
        {
            get
            {
                return "contact";
            }
        }


        public Task<PostResponse> Post(PostRequest requestBody)
        {
            return RC.Post<PostResponse>(Endpoint(false), requestBody, null);
        }
        public class PostRequest
        {
            public int? id;
            public string url;
            public string availability;
            public string firstName;
            public string lastName;
            public string middleName;
            public string nickName;
            public string company;
            public string jobTitle;
            public string homePhone;
            public string homePhone2;
            public string businessPhone;
            public string businessPhone2;
            public string mobilePhone;
            public string businessFax;
            public string companyPhone;
            public string assistantPhone;
            public string carPhone;
            public string otherPhone;
            public string otherFax;
            public string callbackPhone;
            public string email;
            public string email2;
            public string email3;
            public HomeAddress homeAddress;
            public BusinessAddress businessAddress;
            public OtherAddress otherAddress;
            public string birthday;
            public string webPage;
            public string notes;
        
            public class HomeAddress
            {
                public string country;
                public string state;
                public string city;
                public string street;
                public string zip;
            }
        
            public class BusinessAddress
            {
                public string country;
                public string state;
                public string city;
                public string street;
                public string zip;
            }
        
            public class OtherAddress
            {
                public string country;
                public string state;
                public string city;
                public string street;
                public string zip;
            }
        }
        public class PostResponse
        {
            public int? id;
            public string url;
            public string availability;
            public string firstName;
            public string lastName;
            public string middleName;
            public string nickName;
            public string company;
            public string jobTitle;
            public string homePhone;
            public string homePhone2;
            public string businessPhone;
            public string businessPhone2;
            public string mobilePhone;
            public string businessFax;
            public string companyPhone;
            public string assistantPhone;
            public string carPhone;
            public string otherPhone;
            public string otherFax;
            public string callbackPhone;
            public string email;
            public string email2;
            public string email3;
            public HomeAddress homeAddress;
            public BusinessAddress businessAddress;
            public OtherAddress otherAddress;
            public string birthday;
            public string webPage;
            public string notes;
        
            public class HomeAddress
            {
                public string country;
                public string state;
                public string city;
                public string street;
                public string zip;
            }
        
            public class BusinessAddress
            {
                public string country;
                public string state;
                public string city;
                public string street;
                public string zip;
            }
        
            public class OtherAddress
            {
                public string country;
                public string state;
                public string city;
                public string street;
                public string zip;
            }
        }
        

        public Task<ListResponse> List(ListQueryParams queryParams = null)
        {
            return RC.Get<ListResponse>(Endpoint(false), queryParams);
        }
        public class ListQueryParams
        {
            public string phoneNumber;
            public string startsWith;
            public string sortBy;
            public int? page;
            public int? perPage;
        }
        public class ListResponse
        {
            public Record[] records;
            public Navigation navigation;
            public Paging paging;
        
            public class Record
            {
                public int? id;
                public string url;
                public string availability;
                public string firstName;
                public string lastName;
                public string middleName;
                public string nickName;
                public string company;
                public string jobTitle;
                public string homePhone;
                public string homePhone2;
                public string businessPhone;
                public string businessPhone2;
                public string mobilePhone;
                public string businessFax;
                public string companyPhone;
                public string assistantPhone;
                public string carPhone;
                public string otherPhone;
                public string otherFax;
                public string callbackPhone;
                public string email;
                public string email2;
                public string email3;
                public HomeAddress homeAddress;
                public BusinessAddress businessAddress;
                public OtherAddress otherAddress;
                public string birthday;
                public string webPage;
                public string notes;
        
                public class HomeAddress
                {
                    public string country;
                    public string state;
                    public string city;
                    public string street;
                    public string zip;
                }
        
                public class BusinessAddress
                {
                    public string country;
                    public string state;
                    public string city;
                    public string street;
                    public string zip;
                }
        
                public class OtherAddress
                {
                    public string country;
                    public string state;
                    public string city;
                    public string street;
                    public string zip;
                }
            }
        
            public class Navigation
            {
                public FirstPage firstPage;
                public NextPage nextPage;
                public PreviousPage previousPage;
                public LastPage lastPage;
        
                public class FirstPage
                {
                    public string uri;
                }
        
                public class NextPage
                {
                    public string uri;
                }
        
                public class PreviousPage
                {
                    public string uri;
                }
        
                public class LastPage
                {
                    public string uri;
                }
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
        

        public Task<System.Net.Http.HttpResponseMessage> Delete()
        {
            return RC.Delete(Endpoint(true), null);
        }
        
        

        public Task<GetResponse> Get()
        {
            return RC.Get<GetResponse>(Endpoint(true), null);
        }
        public class GetResponse
        {
            public int? id;
            public string url;
            public string availability;
            public string firstName;
            public string lastName;
            public string middleName;
            public string nickName;
            public string company;
            public string jobTitle;
            public string homePhone;
            public string homePhone2;
            public string businessPhone;
            public string businessPhone2;
            public string mobilePhone;
            public string businessFax;
            public string companyPhone;
            public string assistantPhone;
            public string carPhone;
            public string otherPhone;
            public string otherFax;
            public string callbackPhone;
            public string email;
            public string email2;
            public string email3;
            public HomeAddress homeAddress;
            public BusinessAddress businessAddress;
            public OtherAddress otherAddress;
            public string birthday;
            public string webPage;
            public string notes;
        
            public class HomeAddress
            {
                public string country;
                public string state;
                public string city;
                public string street;
                public string zip;
            }
        
            public class BusinessAddress
            {
                public string country;
                public string state;
                public string city;
                public string street;
                public string zip;
            }
        
            public class OtherAddress
            {
                public string country;
                public string state;
                public string city;
                public string street;
                public string zip;
            }
        }
        

        public Task<PutResponse> Put(PutRequest requestBody)
        {
            return RC.Put<PutResponse>(Endpoint(true), requestBody, null);
        }
        public class PutRequest
        {
            public int? id;
            public string url;
            public string availability;
            public string firstName;
            public string lastName;
            public string middleName;
            public string nickName;
            public string company;
            public string jobTitle;
            public string homePhone;
            public string homePhone2;
            public string businessPhone;
            public string businessPhone2;
            public string mobilePhone;
            public string businessFax;
            public string companyPhone;
            public string assistantPhone;
            public string carPhone;
            public string otherPhone;
            public string otherFax;
            public string callbackPhone;
            public string email;
            public string email2;
            public string email3;
            public HomeAddress homeAddress;
            public BusinessAddress businessAddress;
            public OtherAddress otherAddress;
            public string birthday;
            public string webPage;
            public string notes;
        
            public class HomeAddress
            {
                public string country;
                public string state;
                public string city;
                public string street;
                public string zip;
            }
        
            public class BusinessAddress
            {
                public string country;
                public string state;
                public string city;
                public string street;
                public string zip;
            }
        
            public class OtherAddress
            {
                public string country;
                public string state;
                public string city;
                public string street;
                public string zip;
            }
        }
        public class PutResponse
        {
            public int? id;
            public string url;
            public string availability;
            public string firstName;
            public string lastName;
            public string middleName;
            public string nickName;
            public string company;
            public string jobTitle;
            public string homePhone;
            public string homePhone2;
            public string businessPhone;
            public string businessPhone2;
            public string mobilePhone;
            public string businessFax;
            public string companyPhone;
            public string assistantPhone;
            public string carPhone;
            public string otherPhone;
            public string otherFax;
            public string callbackPhone;
            public string email;
            public string email2;
            public string email3;
            public HomeAddress homeAddress;
            public BusinessAddress businessAddress;
            public OtherAddress otherAddress;
            public string birthday;
            public string webPage;
            public string notes;
        
            public class HomeAddress
            {
                public string country;
                public string state;
                public string city;
                public string street;
                public string zip;
            }
        
            public class BusinessAddress
            {
                public string country;
                public string state;
                public string city;
                public string street;
                public string zip;
            }
        
            public class OtherAddress
            {
                public string country;
                public string state;
                public string city;
                public string street;
                public string zip;
            }
        }
        

    }
}