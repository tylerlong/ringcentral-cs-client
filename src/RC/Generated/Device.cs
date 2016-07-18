using System.Threading.Tasks;

namespace RingCentral
{
    public partial class Device : Model
    {
        internal Device(Model parent, string _id = null) : base(parent, _id) { }


        protected override string PathSegment
        {
            get
            {
                return "device";
            }
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
                public string sku;
                public string type;
                public string name;
                public string serial;
                public string computerName;
                public Model model;
                public Extension extension;
                public EmergencyServiceAddress emergencyServiceAddress;
                public PhoneLines phoneLines;
                public Shipping shipping;
                public int? boxBillingId;
        
                public class Model
                {
                    public string id;
                    public string name;
                    public Addon[] addons;
        
                    public class Addon
                    {
                        public string id;
                        public int? count;
                    }
                }
        
                public class Extension
                {
                    public string id;
                    public string uri;
                    public string extensionNumber;
                    public string partnerId;
                }
        
                public class EmergencyServiceAddress
                {
                    public string customerName;
                    public string street;
                    public string street2;
                    public string city;
                    public string state;
                    public string zip;
                    public string country;
                }
        
                public class PhoneLines
                {
                    public string lineType;
                    public PhoneInfo phoneInfo;
        
                    public class PhoneInfo
                    {
                        public int? id;
                        public Country country;
                        public string location;
                        public string paymentType;
                        public string phoneNumber;
                        public string status;
                        public string type;
                        public string usageType;
        
                        public class Country
                        {
                            public string id;
                            public string uri;
                            public string name;
                        }
                    }
                }
        
                public class Shipping
                {
                    public string status;
                    public string carrier;
                    public string trackingNumber;
                    public Method[] method;
                    public Address[] address;
        
                    public class Method
                    {
                        public string id;
                        public string name;
                    }
        
                    public class Address
                    {
                        public string customerName;
                        public string street;
                        public string street2;
                        public string city;
                        public string state;
                        public string zip;
                        public string country;
                    }
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
            public string sku;
            public string type;
            public string name;
            public string serial;
            public string computerName;
            public Model model;
            public Extension extension;
            public EmergencyServiceAddress emergencyServiceAddress;
            public PhoneLines phoneLines;
            public Shipping shipping;
            public int? boxBillingId;
        
            public class Model
            {
                public string id;
                public string name;
                public Addon[] addons;
        
                public class Addon
                {
                    public string id;
                    public int? count;
                }
            }
        
            public class Extension
            {
                public string id;
                public string uri;
                public string extensionNumber;
                public string partnerId;
            }
        
            public class EmergencyServiceAddress
            {
                public string customerName;
                public string street;
                public string street2;
                public string city;
                public string state;
                public string zip;
                public string country;
            }
        
            public class PhoneLines
            {
                public string lineType;
                public PhoneInfo phoneInfo;
        
                public class PhoneInfo
                {
                    public int? id;
                    public Country country;
                    public string location;
                    public string paymentType;
                    public string phoneNumber;
                    public string status;
                    public string type;
                    public string usageType;
        
                    public class Country
                    {
                        public string id;
                        public string uri;
                        public string name;
                    }
                }
            }
        
            public class Shipping
            {
                public string status;
                public string carrier;
                public string trackingNumber;
                public Method[] method;
                public Address[] address;
        
                public class Method
                {
                    public string id;
                    public string name;
                }
        
                public class Address
                {
                    public string customerName;
                    public string street;
                    public string street2;
                    public string city;
                    public string state;
                    public string zip;
                    public string country;
                }
            }
        }
        

    }
}