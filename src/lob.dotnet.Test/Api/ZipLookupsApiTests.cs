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
    ///  Class for testing ZipLookupsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class ZipLookupsApiTests : IDisposable
    {
        private ZipLookupsApi instance;

        public ZipLookupsApiTests()
        {
            instance = new ZipLookupsApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of ZipLookupsApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' ZipLookupsApi
            //Assert.IsType<ZipLookupsApi>(instance);
        }

        /// <summary>
        /// Test ZipLookup
        /// </summary>
        [Fact]
        public void ZipLookupTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //ZipEditable zipEditable = null;
            //var response = instance.ZipLookup(zipEditable);
            //Assert.IsType<Zip>(response);
        }
    }
}
