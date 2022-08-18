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
    [Parallelizable(scope: ParallelScope.Self)]
    public class CardsApiTests : IDisposable
    {
        private CardsApi validApi;
        private CardsApi invalidApi;
        private CardEditable cardEditable;
        private CardUpdatable cardUpdatable;
        private List<string> idsToDelete;

        public CardsApiTests()
        {
            Configuration config = new Configuration();
            Configuration invalidConfig = new Configuration();

            DotNetEnv.Env.TraversePath().Load();
            config.Username = System.Environment.GetEnvironmentVariable("LOB_API_TEST_KEY");
            invalidConfig.Username = "fake api key";

            validApi = new CardsApi(config);
            invalidApi = new CardsApi(invalidConfig);

            cardEditable = new CardEditable();
            cardEditable.setFront("https://s3-us-west-2.amazonaws.com/public.lob.com/assets/card_horizontal.pdf");
            cardEditable.setBack("https://s3-us-west-2.amazonaws.com/public.lob.com/assets/card_horizontal.pdf");
            cardEditable.setSize(CardEditable.SizeEnum._2125x3375);
            cardEditable.setDescription("C# integration test card");

            cardUpdatable = new CardUpdatable();
            cardUpdatable.setDescription("Updated card");

            idsToDelete = new List<string>();
        }

        public void Dispose()
        {
            idsToDelete.ForEach(id => validApi.CardDelete(id));
        }

        [Test]
        public void CardCreateTest() {
            Card response = validApi.CardCreate(cardEditable);

            Assert.NotNull(response.getId());
            idsToDelete.Add(response.getId());
            Assert.AreEqual(response.getDescription(), cardEditable.getDescription());
        }

        [Test]
        public void CardCreateTestBadParameter() {
            try {
                Card response = validApi.CardCreate(null);
            }
            catch (Exception e) {
                Assert.IsInstanceOf<ApiException>(e);
                Assert.That(e.Message, Does.Contain("Missing required parameter 'cardEditable'"));
            }
        }

        [Test]
        public void CardCreateTestBadUsername() {
            try {
                Card response = invalidApi.CardCreate(cardEditable);
            }
            catch (Exception e) {
                Assert.IsInstanceOf<ApiException>(e);
                Assert.That(e.Message, Does.Contain("Your API key is not valid"));
            }
        }

        [Test]
        public void CardRetrieveTest() {
            Card card = validApi.CardCreate(cardEditable);
            idsToDelete.Add(card.getId());

            Card response = validApi.CardRetrieve(card.getId());

            Assert.NotNull(response.getId());
            Assert.AreEqual(response.getId(), card.getId());
        }

        [Test]
        public void CardRetrieveTestBadParameter() {
            try {
                Card response = validApi.CardRetrieve(null);
            }
            catch (Exception e) {
                Assert.IsInstanceOf<ApiException>(e);
                Assert.That(e.Message, Does.Contain("Missing required parameter 'cardId'"));
            }
        }

        [Test]
        public void CardRetrieveTestBadUsername() {
            Card card = validApi.CardCreate(cardEditable);
            idsToDelete.Add(card.getId());

            try {
                Card response = invalidApi.CardRetrieve(card.getId());
            }
            catch (Exception e) {
                Assert.IsInstanceOf<ApiException>(e);
                Assert.That(e.Message, Does.Contain("Your API key is not valid"));
            }
        }

        [Test]
        public void CardListTest() {
            CardList response = validApi.CardsList(null, null, null, null);

            Assert.Greater(response.getCount(), 0);
        }

        [Test]
        public void CardListTestWithLimitParameter() {
            int limit = 2;
            CardList response = validApi.CardsList(limit, null, null, null);

            Assert.AreEqual(response.getCount(), 2);
        }

        [Test]
        [Ignore("Ignore until API fixed or docs updated")]
        public void CardListTestWithSortByParameter() {
            SortBy5 sortBy = new SortBy5();
            sortBy.setSendDate(SortBy5.SendDateEnum.Asc);
            CardList response = validApi.CardsList(null, null, null, sortBy);
            Assert.Greater(response.getCount(), 0);
        }

        [Test]
        public void CardUpdateTest() {
            Card card = validApi.CardCreate(cardEditable);
            idsToDelete.Add(card.getId());

            Card response = validApi.CardUpdate(card.getId(), cardUpdatable);

            Assert.NotNull(response);
            Assert.AreEqual(response.getId(), card.getId());
            Assert.AreEqual(response.getDescription(), cardUpdatable.getDescription());
        }

        [Test]
        public void CardUpdateTestBadParameter() {
            try {
                Card response = validApi.CardUpdate(null, null);
            }
            catch (Exception e) {
                Assert.IsInstanceOf<ApiException>(e);
                Assert.That(e.Message, Does.Contain("Missing required parameter 'cardId'"));
            }
        }

        [Test]
        public void CardUpdateTestBadUsername() {
            Card card = validApi.CardCreate(cardEditable);
            idsToDelete.Add(card.getId());

            try {
                Card response = invalidApi.CardUpdate(card.getId(), cardUpdatable);
            }
            catch (Exception e) {
                Assert.IsInstanceOf<ApiException>(e);
                Assert.That(e.Message, Does.Contain("Your API key is not valid"));
            }
        }
    }
}