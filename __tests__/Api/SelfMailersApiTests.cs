/*
 * Lob
 *
 * The Lob API is organized around REST. Our API is designed to have predictable, resource-oriented URLs and uses HTTP response codes to indicate any API errors. <p> Looking for our [previous documentation](https://lob.github.io/legacy-docs/)?
 *
 * The version of the OpenAPI document: 1.3.0
 * Contact: lob-openapi@lob.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.Collections.Generic;
using NUnit.Framework;

using Moq;

using lob.dotnet.Client;
using lob.dotnet.Api;
using lob.dotnet.Model;

namespace __tests__.Api
{
    /// <summary>
    ///  Class for testing SelfMailersApi
    /// </summary>
    [TestFixture]
    [Parallelizable(scope: ParallelScope.Self)]
    public class SelfMailersApiTests : IDisposable
    {
        private Mock<ISelfMailersApi> SelfMailersApiMock;
        private SelfMailerList fakeSelfMailerList;
        private SelfMailer fakeSelfMailer;

        public SelfMailersApiTests()
        {
            SelfMailersApiMock = new Mock<ISelfMailersApi>();
            fakeSelfMailer = new SelfMailer(
                "sfm_fakeId", // id
                new Address(), // to
                default(AddressDomesticExpanded), // from
                default(SelfMailerSize), // size
                default(string), // description
                default(Dictionary<string, string>), // metadata
                default(MailType), // mailType
                default(Object), // mergeVariables
                default(DateTime), // sendDate
                default(string), // outsideTemplateId
                default(string), // insideTemplateId
                default(string), // outsideTemplateVersionId
                default(string), // insideTemplateVersionId
                SelfMailer.ObjectEnum.SelfMailer, // _object
                default(List<TrackingEventCertified>), // trackingEvents
                "fake url" // url
            );

            List<SelfMailer> listOfSelfMailers = new List<SelfMailer>();
            SelfMailer data1 = new SelfMailer(
                "sfm_fakeId1", // id
                new Address(), // to
                default(AddressDomesticExpanded), // from
                default(SelfMailerSize), // size
                default(string), // description
                default(Dictionary<string, string>), // metadata
                default(MailType), // mailType
                default(Object), // mergeVariables
                default(DateTime), // sendDate
                default(string), // outsideTemplateId
                default(string), // insideTemplateId
                default(string), // outsideTemplateVersionId
                default(string), // insideTemplateVersionId
                SelfMailer.ObjectEnum.SelfMailer, // _object
                default(List<TrackingEventCertified>), // trackingEvents
                "fake url" // url
            );
            SelfMailer data2 = new SelfMailer(
                "sfm_fakeId2", // id
                new Address(), // to
                default(AddressDomesticExpanded), // from
                default(SelfMailerSize), // size
                default(string), // description
                default(Dictionary<string, string>), // metadata
                default(MailType), // mailType
                default(Object), // mergeVariables
                default(DateTime), // sendDate
                default(string), // outsideTemplateId
                default(string), // insideTemplateId
                default(string), // outsideTemplateVersionId
                default(string), // insideTemplateVersionId
                SelfMailer.ObjectEnum.SelfMailer, // _object
                default(List<TrackingEventCertified>), // trackingEvents
                "fake url" // url
            );

            listOfSelfMailers.Add(data1);
            listOfSelfMailers.Add(data2);

            fakeSelfMailerList = new SelfMailerList();

            fakeSelfMailerList.Data = listOfSelfMailers;
            fakeSelfMailerList.Object = "list";
            fakeSelfMailerList.Count = listOfSelfMailers.Count;
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test create
        /// </summary>
        [Test]
        public void createTest()
        {
            SelfMailerEditable selfMailerEditable = new SelfMailerEditable(
                "adr_fakeId", // to
                "adr_fakeId", // from
                default(SelfMailerSize), // size
                "C# unit test selfMailer", // description
                default(Dictionary<string, string>), // metadata
                default(MailType), // mailType
                default(Object), // mergeVariables
                default(DateTime), // sendDate
                "https://s3-us-west-2.amazonaws.com/public.lob.com/assets/templates/4x6_pc_template.pdf", // front
                "https://s3-us-west-2.amazonaws.com/public.lob.com/assets/templates/4x6_pc_template.pdf", // back
                default(string) // billingGroupId
            );

            SelfMailersApiMock.Setup(x => x.create(selfMailerEditable, null, It.IsAny<int>())).Returns(fakeSelfMailer);
            SelfMailer response = SelfMailersApiMock.Object.create(selfMailerEditable);

            Assert.IsInstanceOf<SelfMailer>(response);
            Assert.AreEqual(response.Id, "sfm_fakeId");
        }

        /// <summary>
        /// Test createHandlesException
        /// </summary>
        [Test]
        public void createTestHandlesException()
        {
            ApiException fakeException = new ApiException(
                402,
                "This is an error"
            );

            SelfMailersApiMock.Setup(x => x.create(null, null, It.IsAny<int>())).Throws(fakeException);
            try {
                SelfMailer response = SelfMailersApiMock.Object.create(null, null);
            }
            catch (Exception e) {
                Assert.IsInstanceOf<ApiException>(e);
                Assert.AreEqual(e.Message, fakeException.Message);
            }
        }

        /// <summary>
        /// Test delete
        /// </summary>
        [Test]
        public void deleteTest()
        {
            SelfMailerDeletion fakeSelfMailer = new SelfMailerDeletion();

            fakeSelfMailer.Id = "sfm_fakeId";
            fakeSelfMailer.Deleted = true;

            SelfMailersApiMock.Setup(x => x.delete(fakeSelfMailer.Id, It.IsAny<int>())).Returns(fakeSelfMailer);

            var response = SelfMailersApiMock.Object.delete(fakeSelfMailer.Id);

            Assert.IsInstanceOf<SelfMailerDeletion>(response);
            Assert.AreEqual(response.Deleted, fakeSelfMailer.Deleted);
            Assert.AreEqual(response.Id, fakeSelfMailer.Id);
        }

        /// <summary>
        /// Test deleteHandlesException
        /// </summary>
        [Test]
        public void deleteHandlesException()
        {
            ApiException fakeException = new ApiException(
                402,
                "This is an error"
            );

            SelfMailersApiMock.Setup(x => x.delete(null, It.IsAny<int>())).Throws(fakeException);
            try {
                var response = SelfMailersApiMock.Object.delete(null);
            }
            catch (Exception e) {
                Assert.IsInstanceOf<ApiException>(e);
                Assert.AreEqual(e.Message, fakeException.Message);
            }
        }

        /// <summary>
        /// Test get
        /// </summary>
        [Test]
        public void getTest()
        {
            SelfMailersApiMock.Setup(x => x.get(fakeSelfMailer.Id, It.IsAny<int>())).Returns(fakeSelfMailer);
            SelfMailer response = SelfMailersApiMock.Object.get(fakeSelfMailer.Id);

            Assert.IsInstanceOf<SelfMailer>(response);
            Assert.AreEqual(response.Id, fakeSelfMailer.Id);
        }

        /// <summary>
        /// Test getHandlesException
        /// </summary>
        [Test]
        public void getTestHandlesException()
        {
            ApiException fakeException = new ApiException(
                402,
                "This is an error"
            );
            SelfMailersApiMock.Setup(x => x.get(null, It.IsAny<int>())).Throws(fakeException);

            try {
                var response = SelfMailersApiMock.Object.get(null);
            }
            catch (Exception e) {
                Assert.IsInstanceOf<ApiException>(e);
                Assert.AreEqual(e.Message, fakeException.Message);
            }
        }

        /// <summary>
        /// Test SelfMailerList
        /// </summary>
        [Test]
        public void SelfMailerListTest()
        {
            SelfMailersApiMock.Setup(x => x.list(null, null, null, null, null, null, null, null, null, null, null, It.IsAny<int>())).Returns(fakeSelfMailerList);

            var response = SelfMailersApiMock.Object.list(null, null, null, null, null, null, null, null, null, null, null);

            Assert.IsInstanceOf<SelfMailerList>(response);
            Assert.AreEqual(response.Count, fakeSelfMailerList.Count);
        }

        /// <summary>
        /// Test SelfMailerListHandlesException
        /// </summary>
        [Test]
        public void SelfMailerListTestHandlesException()
        {
            ApiException fakeException = new ApiException(
                402,
                "This is an error"
            );
            SelfMailersApiMock.Setup(x => x.list(null, null, null, null, null, null, null, null, null, null, null, It.IsAny<int>())).Throws(fakeException);

            try {
                var response = SelfMailersApiMock.Object.list(null, null, null, null, null, null, null, null, null, null, null);
            }
            catch (Exception e) {
                Assert.IsInstanceOf<ApiException>(e);
                Assert.AreEqual(e.Message, fakeException.Message);
            }
        }

        /// <summary>
        /// Test SelfMailerListWithLimitParam
        /// </summary>
        [Test]
        public void SelfMailerListTestWithLimitParam()
        {
            int limit = 2;

            SelfMailersApiMock.Setup(x => x.list(limit, null, null, null, null, null, null, null, null, null, null, It.IsAny<int>())).Returns(fakeSelfMailerList);

            var response = SelfMailersApiMock.Object.list(limit, null, null, null, null, null, null, null, null, null, null);

            Assert.IsInstanceOf<SelfMailerList>(response);
            Assert.AreEqual(response.Count, fakeSelfMailerList.Count);
        }

        /// <summary>
        /// Test SelfMailerListWithBeforeParam
        /// </summary>
        [Test]
        public void SelfMailerListTestWithBeforeParam()
        {
            string before = "before";

            SelfMailersApiMock.Setup(x => x.list(null, before, null, null, null, null, null, null, null, null, null, It.IsAny<int>())).Returns(fakeSelfMailerList);

            var response = SelfMailersApiMock.Object.list(null, before, null, null, null, null, null, null, null, null, null);

            Assert.IsInstanceOf<SelfMailerList>(response);
            Assert.AreEqual(response.Count, fakeSelfMailerList.Count);
        }

        /// <summary>
        /// Test SelfMailerListWithAfterParam
        /// </summary>
        [Test]
        public void SelfMailerListTestWithAfterParam()
        {
            string after = "after";

            SelfMailersApiMock.Setup(x => x.list(null, null, after, null, null, null, null, null, null, null, null, It.IsAny<int>())).Returns(fakeSelfMailerList);

            var response = SelfMailersApiMock.Object.list(null, null, after, null, null, null, null, null, null, null, null);

            Assert.IsInstanceOf<SelfMailerList>(response);
            Assert.AreEqual(response.Count, fakeSelfMailerList.Count);
        }

        /// <summary>
        /// Test SelfMailerListWithIncludeParam
        /// </summary>
        [Test]
        public void SelfMailerListTestWithIncludeParam()
        {
            List<string> include = new List<string>();
            include.Add("total_count");

            SelfMailersApiMock.Setup(x => x.list(null, null, null, include, null, null, null, null, null, null, null, It.IsAny<int>())).Returns(fakeSelfMailerList);

            var response = SelfMailersApiMock.Object.list(null, null, null, include, null, null, null, null, null, null, null);

            Assert.IsInstanceOf<SelfMailerList>(response);
            Assert.AreEqual(response.Count, fakeSelfMailerList.Count);
        }

        /// <summary>
        /// Test SelfMailerListWithDateCreatedParam
        /// </summary>
        [Test]
        public void SelfMailerListTestWithDateCreatedParam()
        {
            Dictionary<String, DateTime> dateCreated = new Dictionary<String, DateTime>();
            dateCreated.Add("gt", DateTime.Now);
            dateCreated.Add("lt", DateTime.Now);

            SelfMailersApiMock.Setup(x => x.list(null, null, null, null, dateCreated, null, null, null, null, null, null, It.IsAny<int>())).Returns(fakeSelfMailerList);

            var response = SelfMailersApiMock.Object.list(null, null, null, null, dateCreated, null, null, null, null, null, null);

            Assert.IsInstanceOf<SelfMailerList>(response);
            Assert.AreEqual(response.Count, fakeSelfMailerList.Count);
        }

        /// <summary>
        /// Test SelfMailerListWithMetadataParam
        /// </summary>
        [Test]
        public void SelfMailerListTestWithMetadataParam()
        {
            Dictionary<String, String> metadata = new Dictionary<String, String>();
            metadata.Add("name", "Harry");

            SelfMailersApiMock.Setup(x => x.list(null, null, null, null, null, metadata, null, null, null, null, null, It.IsAny<int>())).Returns(fakeSelfMailerList);

            var response = SelfMailersApiMock.Object.list(null, null, null, null, null, metadata, null, null, null, null, null);

            Assert.IsInstanceOf<SelfMailerList>(response);
            Assert.AreEqual(response.Count, fakeSelfMailerList.Count);
        }

        /// <summary>
        /// Test SelfMailerListWithSizeParam
        /// </summary>
        [Test]
        public void SelfMailerListTestWithSizeParam()
        {
            List<SelfMailerSize> size = new List<SelfMailerSize>{SelfMailerSize._6x18Bifold};

            SelfMailersApiMock.Setup(x => x.list(null, null, null, null, null, null, size, null, null, null, null, It.IsAny<int>())).Returns(fakeSelfMailerList);

            var response = SelfMailersApiMock.Object.list(null, null, null, null, null, null, size, null, null, null, null);

            Assert.IsInstanceOf<SelfMailerList>(response);
            Assert.AreEqual(response.Count, fakeSelfMailerList.Count);
        }

        /// <summary>
        /// Test SelfMailerListWithScheduledParam
        /// </summary>
        [Test]
        public void SelfMailerListTestWithScheduledParam()
        {
            Boolean scheduled = true;

            SelfMailersApiMock.Setup(x => x.list(null, null, null, null, null, null, null, scheduled, null, null, null, It.IsAny<int>())).Returns(fakeSelfMailerList);

            var response = SelfMailersApiMock.Object.list(null, null, null, null, null, null, null, scheduled, null, null, null);

            Assert.IsInstanceOf<SelfMailerList>(response);
            Assert.AreEqual(response.Count, fakeSelfMailerList.Count);
        }

        /// <summary>
        /// Test SelfMailerListWithSendDateParam
        /// </summary>
        [Test]
        public void SelfMailerListTestWithSendDateParam()
        {
            Dictionary<String, String> sendDate = new Dictionary<String, String>();
            sendDate.Add("gt", "2020-01-01");
            sendDate.Add("lt", "2020-01-31T12");

            SelfMailersApiMock.Setup(x => x.list(null, null, null, null, null, null, null, null, sendDate, null, null, It.IsAny<int>())).Returns(fakeSelfMailerList);

            var response = SelfMailersApiMock.Object.list(null, null, null, null, null, null, null, null, sendDate, null, null);

            Assert.IsInstanceOf<SelfMailerList>(response);
            Assert.AreEqual(response.Count, fakeSelfMailerList.Count);
        }

        /// <summary>
        /// Test SelfMailerListWithMailTypeParam
        /// </summary>
        [Test]
        public void SelfMailerListTestWithMailTypeParam()
        {
            MailType mailType = MailType.FirstClass;

            SelfMailersApiMock.Setup(x => x.list(null, null, null, null, null, null, null, null, null, mailType, null, It.IsAny<int>())).Returns(fakeSelfMailerList);

            var response = SelfMailersApiMock.Object.list(null, null, null, null, null, null, null, null, null, mailType, null);

            Assert.IsInstanceOf<SelfMailerList>(response);
            Assert.AreEqual(response.Count, fakeSelfMailerList.Count);
        }

        /// <summary>
        /// Test SelfMailerListWithSortByParam
        /// </summary>
        [Test]
        public void SelfMailerListTestWithSortByParam()
        {
            SortBy3 sortBy = new SortBy3(null, SortBy3.SendDateEnum.Asc);

            SelfMailersApiMock.Setup(x => x.list(null, null, null, null, null, null, null, null, null, null, sortBy, It.IsAny<int>())).Returns(fakeSelfMailerList);

            var response = SelfMailersApiMock.Object.list(null, null, null, null, null, null, null, null, null, null, sortBy);

            Assert.IsInstanceOf<SelfMailerList>(response);
            Assert.AreEqual(response.Count, fakeSelfMailerList.Count);
        }
    }
}
