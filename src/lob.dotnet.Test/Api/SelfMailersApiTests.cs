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
    ///  Class for testing SelfMailersApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class SelfMailersApiTests : IDisposable
    {
        private SelfMailersApi instance;

        public SelfMailersApiTests()
        {
            instance = new SelfMailersApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of SelfMailersApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' SelfMailersApi
            //Assert.IsType<SelfMailersApi>(instance);
        }

        /// <summary>
        /// Test SelfMailerCreate
        /// </summary>
        [Fact]
        public void SelfMailerCreateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //SelfMailerEditable selfMailerEditable = null;
            //string idempotencyKey = null;
            //var response = instance.SelfMailerCreate(selfMailerEditable, idempotencyKey);
            //Assert.IsType<SelfMailer>(response);
        }

        /// <summary>
        /// Test SelfMailerDelete
        /// </summary>
        [Fact]
        public void SelfMailerDeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string sfmId = null;
            //var response = instance.SelfMailerDelete(sfmId);
            //Assert.IsType<SelfMailerDeletion>(response);
        }

        /// <summary>
        /// Test SelfMailerRetrieve
        /// </summary>
        [Fact]
        public void SelfMailerRetrieveTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string sfmId = null;
            //var response = instance.SelfMailerRetrieve(sfmId);
            //Assert.IsType<SelfMailer>(response);
        }

        /// <summary>
        /// Test SelfMailersList
        /// </summary>
        [Fact]
        public void SelfMailersListTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? limit = null;
            //string before = null;
            //string after = null;
            //List<string> include = null;
            //Dictionary<string, string> dateCreated = null;
            //Dictionary<string, string> metadata = null;
            //SelfMailerSize? size = null;
            //bool? scheduled = null;
            //Dictionary<string, string> sendDate = null;
            //MailType? mailType = null;
            //SortBy5 sortBy = null;
            //var response = instance.SelfMailersList(limit, before, after, include, dateCreated, metadata, size, scheduled, sendDate, mailType, sortBy);
            //Assert.IsType<SelfMailerList>(response);
        }
    }
}
