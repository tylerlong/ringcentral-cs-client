using Xunit;

namespace RingCentral.Test
{
    [Collection("RestClient collection")]
    public class ContactTest
    {
        private RestClient rc;
        public ContactTest(RestClientFixture fixture)
        {
            rc = fixture.rc;
        }

        [Fact]
        public void ContactActions()
        {
            const string phoneNumber = "+15889546648";
            var addressBook = rc.Restapi().Account().Extension().AddressBook();

            // list
            var list = addressBook.Contact().List().Result;
            Assert.NotNull(list);
            Assert.Equal(1, list.paging.page);
            var total = list.paging.totalElements;

            // create
            var contact = addressBook.Contact().Post(new Contact.PostRequest
            {
                firstName = "Tyler",
                lastName = "Long",
                homePhone = phoneNumber
            }).Result;
            Assert.NotNull(contact);
            Assert.Equal("Long", contact.lastName);

            // list again
            list = addressBook.Contact().List().Result;
            Assert.Equal(total + 1, list.paging.totalElements);

            // search
            list = addressBook.Contact().List(new Contact.ListQueryParams { phoneNumber = phoneNumber }).Result;
            Assert.Equal(1, list.paging.totalElements);
            var contactId = list.records[0].id;

            // delete
            var response = addressBook.Contact(contactId.ToString()).Delete().Result;

            // search again
            list = addressBook.Contact().List(new Contact.ListQueryParams { phoneNumber = phoneNumber }).Result;
            Assert.Equal(0, list.paging.totalElements);
        }
    }
}