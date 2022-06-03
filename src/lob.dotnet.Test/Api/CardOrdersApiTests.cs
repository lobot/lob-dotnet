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
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using Xunit;

using lob.dotnet.Client;
using lob.dotnet.Api;
// uncomment below to import models
//using lob.dotnet.Model;

namespace lob.dotnet.Test.Api
{
    /// <summary>
    ///  Class for testing CardOrdersApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class CardOrdersApiTests : IDisposable
    {
        private CardOrdersApi instance;

        public CardOrdersApiTests()
        {
            instance = new CardOrdersApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of CardOrdersApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' CardOrdersApi
            //Assert.IsType<CardOrdersApi>(instance);
        }

        /// <summary>
        /// Test CardOrderCreate
        /// </summary>
        [Fact]
        public void CardOrderCreateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string cardId = null;
            //CardOrderEditable cardOrderEditable = null;
            //var response = instance.CardOrderCreate(cardId, cardOrderEditable);
            //Assert.IsType<CardOrder>(response);
        }

        /// <summary>
        /// Test CardOrdersRetrieve
        /// </summary>
        [Fact]
        public void CardOrdersRetrieveTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string cardId = null;
            //int? limit = null;
            //int? offset = null;
            //var response = instance.CardOrdersRetrieve(cardId, limit, offset);
            //Assert.IsType<CardOrderList>(response);
        }
    }
}
