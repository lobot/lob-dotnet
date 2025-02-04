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
    ///  Class for testing AddressesApi
    /// </summary>
    [TestFixture]
    [Category("Unit")]
    [Parallelizable(scope: ParallelScope.All)]
    public class AddressesApiTests : IDisposable
    {
        private Mock<IAddressesApi> addressesApiMock;

        public AddressesApiTests()
        {
            addressesApiMock = new Mock<IAddressesApi>();
            // addressEditableMock = new Mock<AddressEditable>();
            // addressMock = new Mock<Address>();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of AddressesApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // Assert.IsInstanceOf<Mock<AddressesApi>>(addressApiMock);
        }

        /// <summary>
        /// Test create
        /// </summary>
        [Test]
        public void createTest()
        {
            Address fakeAddress = new Address();
            AddressEditable addressEditable = new AddressEditable();

            fakeAddress.Id = "adr_fakeid";
            addressesApiMock.Setup(x => x.create(addressEditable, It.IsAny<int>())).Returns(fakeAddress);
            Address response = addressesApiMock.Object.create(addressEditable);

            Assert.IsInstanceOf<Address>(response);
            Assert.AreEqual(response.Id, "adr_fakeid");
        }

        /// <summary>
        /// Test createHandlesException
        /// </summary>
        [Test]
        public void createTestHandlesException()
        {
            Address fakeAddress = new Address();
            ApiException fakeException = new ApiException(
                402,
                "This is an error"
            );

            addressesApiMock.Setup(x => x.create(null, It.IsAny<int>())).Throws(fakeException);
            try {
                Address response = addressesApiMock.Object.create(null);
            }
            catch (Exception e) {
                Assert.IsInstanceOf<ApiException>(e);
                Assert.AreEqual(e.Message, "This is an error");
            }
        }

        /// <summary>
        /// Test delete
        /// </summary>
        [Test]
        public void deleteTest()
        {
            AddressDeletion fakeAddress = new AddressDeletion();

            fakeAddress.Id = "adr_fakeid";
            fakeAddress.Deleted = true;

            addressesApiMock.Setup(x => x.delete(fakeAddress.Id, It.IsAny<int>())).Returns(fakeAddress);

            var response = addressesApiMock.Object.delete(fakeAddress.Id);

            Assert.IsInstanceOf<AddressDeletion>(response);
            Assert.AreEqual(response.Deleted, fakeAddress.Deleted);
            Assert.AreEqual(response.Id, fakeAddress.Id);
        }


        /// <summary>
        /// Test deleteHandlesException
        /// </summary>
        [Test]
        public void deleteTestHandlesException()
        {
            ApiException fakeException = new ApiException(
                402,
                "This is an error"
            );
            addressesApiMock.Setup(x => x.delete(null, It.IsAny<int>())).Throws(fakeException);

            try {
                var response = addressesApiMock.Object.delete(null);
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
            Address fakeAddress = new Address();
            AddressEditable addressEditable = new AddressEditable();

            fakeAddress.Id = "adr_fakeid";
            fakeAddress.AddressLine1 = "607 Blue Spring Dr";
            addressesApiMock.Setup(x => x.get(fakeAddress.Id, It.IsAny<int>())).Returns(fakeAddress);
            Address response = addressesApiMock.Object.get(fakeAddress.Id);

            Assert.IsInstanceOf<Address>(response);
            Assert.AreEqual(response.AddressLine1, fakeAddress.AddressLine1);
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
            addressesApiMock.Setup(x => x.get("adr_fakeId", It.IsAny<int>())).Throws(fakeException);

            try {
                var response = addressesApiMock.Object.get("adr_fakeId");
            }
            catch (Exception e) {
                Assert.IsInstanceOf<ApiException>(e);
                Assert.AreEqual(e.Message, fakeException.Message);
            }
        }

        /// <summary>
        /// Test list
        /// </summary>
        [Test]
        public void listTest()
        {
            int limit = 2;
            string before = null;
            string after = null;
            List<string> include = null;
            Dictionary<String, DateTime> dateCreated = null;
            Dictionary<String, String> metadata = null;
            AddressList fakeAddress = new AddressList();
            List<Address> data = new List<Address>();
            Address data1 = new Address();
            Address data2 = new Address();

            data1.Id = "adr_id";
            data2.Id = "adr_Id2";
            data.Add(data1);
            data.Add(data2);
            fakeAddress.Data = data;
            fakeAddress.Object = "list";
            fakeAddress.Count = data.Count;

            addressesApiMock.Setup(x => x.list(limit, before, after, include, dateCreated, metadata, It.IsAny<int>())).Returns(fakeAddress);

            var response = addressesApiMock.Object.list(limit, before, after, include, dateCreated, metadata);

            Assert.IsInstanceOf<AddressList>(response);
            Assert.AreEqual(response.Count, fakeAddress.Count);
        }

        /// <summary>
        /// Test AddressListHandlesException
        /// </summary>
        [Test]
        public void AddressListTestHandlesException()
        {
            ApiException fakeException = new ApiException(
                402,
                "This is an error"
            );
            addressesApiMock.Setup(x => x.list(null, null, null, null, null, null, It.IsAny<int>())).Throws(fakeException);

            try {
                var response = addressesApiMock.Object.list(null);
            }
            catch (Exception e) {
                Assert.IsInstanceOf<ApiException>(e);
                Assert.AreEqual(e.Message, fakeException.Message);
            }
        }
    }
}

