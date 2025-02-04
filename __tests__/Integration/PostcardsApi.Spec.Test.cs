/*
 * Lob
 *
 * The Lob API is organized around REST. Our API is designed to have predictable, resource-oriented URLs and uses HTTP response codes to indicate any API errors. <p> Looking for our [previous documentation](https://lob.github.io/legacy-docs/)?
 *
 * The version of the OpenAPI document: 1.3.0
 * Contact: lob-openapi@lob.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using lob.dotnet.Client;
using lob.dotnet.Api;
using lob.dotnet.Model;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;

namespace __tests__.Integration {
    [TestFixture]
    [Category("Integration")]
    [Parallelizable(scope: ParallelScope.Children)]
    public class PostcardsApiTests : IDisposable
    {
        private PostcardsApi validApi;
        private PostcardsApi invalidApi;
        private PostcardEditable postcardEditable;
        private List<string> idsToDelete;

        private Address address;
        private AddressesApi validAddressesApi;

        public PostcardsApiTests()
        {
            Configuration config = new Configuration();
            Configuration invalidConfig = new Configuration();

            DotNetEnv.Env.TraversePath().Load();
            config.Username = Environment.GetEnvironmentVariable("LOB_API_TEST_KEY");
            invalidConfig.Username = "fake api key";

            validApi = new PostcardsApi(config);
            invalidApi = new PostcardsApi(invalidConfig);

            AddressEditable addressEditable = new AddressEditable(
                "1313 CEMETERY LN", // addressLine1
                null, // addressLine2
                "WESTFIELD", // addressCity
                "NJ", // addressState
                "07000", // addressZip
                CountryExtended.US, // addressCountry
                "test description", // description
                "Thing T. Thing", // name
                null, // company
                null, // phone
                null, // email
                null // metadata
            );

            validAddressesApi = new AddressesApi(config);
            address = validAddressesApi.create(addressEditable);
            var address2 = addressEditable.ToJson();

            postcardEditable = new PostcardEditable(
                address.Id, // to
                address2, // from
                default(PostcardSize), // size
                "C# integration test postcard", // description
                default(Dictionary<string, string>), // metadata
                default(MailType), // mailType
                default(Object), // mergeVariables
                default(DateTime), // sendDate
                "https://s3-us-west-2.amazonaws.com/public.lob.com/assets/templates/4x6_pc_template.pdf", // front
                "https://s3-us-west-2.amazonaws.com/public.lob.com/assets/templates/4x6_pc_template.pdf", // back
                default(string) // billingGroupId
            );
            postcardEditable.Metadata = new Dictionary<string, string>();
            postcardEditable.Metadata.Add("name", "Harry");

            idsToDelete = new List<string>();
        }

        public void Dispose()
        {
            validAddressesApi.delete(address.Id);
            idsToDelete.ForEach(id => validApi.cancel(id));
        }

        [Test]
        public void createTest() {
            Postcard response = validApi.create(postcardEditable);

            Assert.NotNull(response.Id);
            Assert.AreEqual(response.Metadata, postcardEditable.Metadata);
            idsToDelete.Add(response.Id);
        }

        [Test]
        public void createTestBadParameter() {
            try {
                Postcard response = validApi.create(null);
            }
            catch (Exception e) {
                Assert.IsInstanceOf<ApiException>(e);
                Assert.That(e.Message, Does.Contain("Missing required parameter 'postcardEditable'"));
            }
        }

        [Test]
        public void createTestBadUsername() {
            try {
                Postcard response = invalidApi.create(postcardEditable);
            }
            catch (Exception e) {
                Assert.IsInstanceOf<ApiException>(e);
                Assert.That(e.Message, Does.Contain("Your API key is not valid"));
            }
        }

        [Test]
        public void getTest() {
            Postcard createdPostcard = validApi.create(postcardEditable);
            idsToDelete.Add(createdPostcard.Id);

            Postcard retrievedPostcard = validApi.get(createdPostcard.Id);

            Assert.NotNull(retrievedPostcard.Id);
            Assert.AreEqual(retrievedPostcard.Id, createdPostcard.Id);
        }

        [Test]
        public void getTestBadParameter() {
            try {
                Postcard response = validApi.get(null);
            }
            catch (Exception e) {
                Assert.IsInstanceOf<ApiException>(e);
                Assert.That(e.Message, Does.Contain("Missing required parameter"));
            }
        }

        [Test]
        public void getTestBadUsername() {
            Postcard createdPostcard = validApi.create(postcardEditable);
            idsToDelete.Add(createdPostcard.Id);

            try {
                Postcard response = invalidApi.get(createdPostcard.Id);
            }
            catch (Exception e) {
                Assert.IsInstanceOf<ApiException>(e);
                Assert.That(e.Message, Does.Contain("Your API key is not valid"));
            }
        }

        [Test]
        public void PostcardListTest() {
            PostcardList response = validApi.list(null, null, null, null, null, null, null, null, null, null, null);

            Assert.Greater(response.Count, 0);
        }

        [Test]
        public void PostcardListTestWithLimitParameter() {
            int limit = 2;
            PostcardList response = validApi.list(limit, null, null, null, null, null, null, null, null, null, null);

            Assert.AreEqual(response.Count, 2);
        }

        [Test]
        public void PostcardListTestWithIncludeParameter() {
            List<string> includeList = new List<string>();
            includeList.Add("total_count");

            PostcardList response = validApi.list(null, null, null, includeList, null, null, null, null, null, null, null);
            Assert.Greater(response.Count, 0);
            Assert.NotNull(response.TotalCount);
        }

        [Test]
        public void PostcardListTestWithDateCreatedParameter() {
            Dictionary<String, DateTime> dateCreated = new Dictionary<String, DateTime>();
            DateTime lastMonth = DateTime.Today.AddMonths(-1);
            dateCreated.Add("lt", lastMonth);

            PostcardList response = validApi.list(null, null, null, null, dateCreated, null, null, null, null, null, null);
            Assert.Greater(response.Count, 0);
        }

        [Test]
        public void PostcardListTestWithMetadataParameter() {
            Postcard createdPostcard = validApi.create(postcardEditable);
            idsToDelete.Add(createdPostcard.Id);

            Dictionary<String, String> metadata = new Dictionary<String, String>();
            metadata.Add("name", "Harry");

            PostcardList response = validApi.list(null, null, null, null, null, metadata, null, null, null, null, null);
            Assert.Greater(response.Count, 0);
        }

        [Test]
        public void PostcardListTestWithSizeParameter() {
            List<PostcardSize> sizeArray = new List<PostcardSize>();
            sizeArray.Add(PostcardSize._4x6);

            PostcardList response = validApi.list(null, null, null, null, null, null, sizeArray);
            Assert.Greater(response.Count, 0);
        }

        [Test]
        public void PostcardListTestWithScheduledParameter() {
            Boolean scheduled = true;

            PostcardList response = validApi.list(null, null, null, null, null, null, null, scheduled);
            Assert.Greater(response.Count, 0);
        }

        [Test]
        public void PostcardListTestWithSendDateParameter() {
            Dictionary<String, String> sendDate = new Dictionary<String, String>();
            DateTime lastMonth = DateTime.Today.AddMonths(-1);
            sendDate.Add("lt", lastMonth.ToString("yyyy-MM-ddTHH\\:mm\\:ss.fffffffzzz"));

            PostcardList response = validApi.list(null, null, null, null, null, null, null, null, sendDate);
            Assert.Greater(response.Count, 0);
        }

        [Test]
        public void PostcardListTestWithMailTypeParameter() {
            MailType mailType = MailType.FirstClass;

            PostcardList response = validApi.list(null, null, null, null, null, null, null, null, null, mailType);
            Assert.GreaterOrEqual(response.Count, 0);
        }

        [Test]
        public void PostcardListTestWithSortByParameter() {
            SortBy3 sortBy = new SortBy3(null, SortBy3.SendDateEnum.Asc);

            PostcardList response = validApi.list(null, null, null, null, null, null, null, null, null, null, sortBy);
            Assert.Greater(response.Count, 0);
        }

        [Test]
        public void deleteTest() {
            Postcard createdPostcard = validApi.create(postcardEditable);

            PostcardDeletion deletedPostcard = validApi.cancel(createdPostcard.Id);
            Assert.True(deletedPostcard.Deleted);
        }

        [Test]
        public void deleteTestBadParameter() {
            try {
                PostcardDeletion deletedPostcard = validApi.cancel(null);
            }
            catch (Exception e) {
                Assert.IsInstanceOf<ApiException>(e);
                Assert.That(e.Message, Does.Contain("Missing required parameter"));
            }
        }

        [Test]
        public void deleteTestBadUsername() {
            Postcard createdPostcard = validApi.create(postcardEditable);
            idsToDelete.Add(createdPostcard.Id);

            try {
                PostcardDeletion deletedPostcard = invalidApi.cancel(createdPostcard.Id);
            } catch (Exception e) {
                Assert.IsInstanceOf<ApiException>(e);
                Assert.That(e.Message, Does.Contain("Your API key is not valid"));
            }
        }
    }
}