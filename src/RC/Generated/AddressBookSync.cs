using System.Threading.Tasks;

namespace RingCentral
{
    public partial class AddressBookSync : Model
    {
        internal AddressBookSync(Model parent) : base(parent, null) { }


        protected override string PathSegment
        {
            get
            {
                return "address-book-sync";
            }
        }


        public Task<GetResponse> Get(GetQueryParams queryParams = null)
        {
            return RC.Get<GetResponse>(Endpoint(false), queryParams);
        }
        public class GetQueryParams
        {
            public string syncType;
            public string syncToken;
            public int? perPage;
            public int? pageId;
        }
        public class GetResponse
        {
            public Record[] records;
            public SyncInfo syncInfo;
            public int? nextPageId;
            public string nextPageUri;
        
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
        
            public class SyncInfo
            {
                public string syncType;
                public string syncToken;
                public string syncTime;
            }
        }
        

    }
}