/*
 * Camunda BPM REST API
 *
 * OpenApi Spec for Camunda BPM REST API.
 *
 * The version of the OpenAPI document: 7.14.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using Xunit;

using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using CamundaClient.Api;
using CamundaClient.Model;
using CamundaClient.Client;
using System.Reflection;
using Newtonsoft.Json;

namespace CamundaClient.Test.Model
{
    /// <summary>
    ///  Class for testing ProcessInstanceQueryDto
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class ProcessInstanceQueryDtoTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for ProcessInstanceQueryDto
        //private ProcessInstanceQueryDto instance;

        public ProcessInstanceQueryDtoTests()
        {
            // TODO uncomment below to create an instance of ProcessInstanceQueryDto
            //instance = new ProcessInstanceQueryDto();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of ProcessInstanceQueryDto
        /// </summary>
        [Fact]
        public void ProcessInstanceQueryDtoInstanceTest()
        {
            // TODO uncomment below to test "IsType" ProcessInstanceQueryDto
            //Assert.IsType<ProcessInstanceQueryDto>(instance);
        }


        /// <summary>
        /// Test the property 'DeploymentId'
        /// </summary>
        [Fact]
        public void DeploymentIdTest()
        {
            // TODO unit test for the property 'DeploymentId'
        }
        /// <summary>
        /// Test the property 'ProcessDefinitionId'
        /// </summary>
        [Fact]
        public void ProcessDefinitionIdTest()
        {
            // TODO unit test for the property 'ProcessDefinitionId'
        }
        /// <summary>
        /// Test the property 'ProcessDefinitionKey'
        /// </summary>
        [Fact]
        public void ProcessDefinitionKeyTest()
        {
            // TODO unit test for the property 'ProcessDefinitionKey'
        }
        /// <summary>
        /// Test the property 'ProcessDefinitionKeyIn'
        /// </summary>
        [Fact]
        public void ProcessDefinitionKeyInTest()
        {
            // TODO unit test for the property 'ProcessDefinitionKeyIn'
        }
        /// <summary>
        /// Test the property 'ProcessDefinitionKeyNotIn'
        /// </summary>
        [Fact]
        public void ProcessDefinitionKeyNotInTest()
        {
            // TODO unit test for the property 'ProcessDefinitionKeyNotIn'
        }
        /// <summary>
        /// Test the property 'BusinessKey'
        /// </summary>
        [Fact]
        public void BusinessKeyTest()
        {
            // TODO unit test for the property 'BusinessKey'
        }
        /// <summary>
        /// Test the property 'BusinessKeyLike'
        /// </summary>
        [Fact]
        public void BusinessKeyLikeTest()
        {
            // TODO unit test for the property 'BusinessKeyLike'
        }
        /// <summary>
        /// Test the property 'CaseInstanceId'
        /// </summary>
        [Fact]
        public void CaseInstanceIdTest()
        {
            // TODO unit test for the property 'CaseInstanceId'
        }
        /// <summary>
        /// Test the property 'SuperProcessInstance'
        /// </summary>
        [Fact]
        public void SuperProcessInstanceTest()
        {
            // TODO unit test for the property 'SuperProcessInstance'
        }
        /// <summary>
        /// Test the property 'SubProcessInstance'
        /// </summary>
        [Fact]
        public void SubProcessInstanceTest()
        {
            // TODO unit test for the property 'SubProcessInstance'
        }
        /// <summary>
        /// Test the property 'SuperCaseInstance'
        /// </summary>
        [Fact]
        public void SuperCaseInstanceTest()
        {
            // TODO unit test for the property 'SuperCaseInstance'
        }
        /// <summary>
        /// Test the property 'SubCaseInstance'
        /// </summary>
        [Fact]
        public void SubCaseInstanceTest()
        {
            // TODO unit test for the property 'SubCaseInstance'
        }
        /// <summary>
        /// Test the property 'Active'
        /// </summary>
        [Fact]
        public void ActiveTest()
        {
            // TODO unit test for the property 'Active'
        }
        /// <summary>
        /// Test the property 'Suspended'
        /// </summary>
        [Fact]
        public void SuspendedTest()
        {
            // TODO unit test for the property 'Suspended'
        }
        /// <summary>
        /// Test the property 'ProcessInstanceIds'
        /// </summary>
        [Fact]
        public void ProcessInstanceIdsTest()
        {
            // TODO unit test for the property 'ProcessInstanceIds'
        }
        /// <summary>
        /// Test the property 'WithIncident'
        /// </summary>
        [Fact]
        public void WithIncidentTest()
        {
            // TODO unit test for the property 'WithIncident'
        }
        /// <summary>
        /// Test the property 'IncidentId'
        /// </summary>
        [Fact]
        public void IncidentIdTest()
        {
            // TODO unit test for the property 'IncidentId'
        }
        /// <summary>
        /// Test the property 'IncidentType'
        /// </summary>
        [Fact]
        public void IncidentTypeTest()
        {
            // TODO unit test for the property 'IncidentType'
        }
        /// <summary>
        /// Test the property 'IncidentMessage'
        /// </summary>
        [Fact]
        public void IncidentMessageTest()
        {
            // TODO unit test for the property 'IncidentMessage'
        }
        /// <summary>
        /// Test the property 'IncidentMessageLike'
        /// </summary>
        [Fact]
        public void IncidentMessageLikeTest()
        {
            // TODO unit test for the property 'IncidentMessageLike'
        }
        /// <summary>
        /// Test the property 'TenantIdIn'
        /// </summary>
        [Fact]
        public void TenantIdInTest()
        {
            // TODO unit test for the property 'TenantIdIn'
        }
        /// <summary>
        /// Test the property 'WithoutTenantId'
        /// </summary>
        [Fact]
        public void WithoutTenantIdTest()
        {
            // TODO unit test for the property 'WithoutTenantId'
        }
        /// <summary>
        /// Test the property 'ProcessDefinitionWithoutTenantId'
        /// </summary>
        [Fact]
        public void ProcessDefinitionWithoutTenantIdTest()
        {
            // TODO unit test for the property 'ProcessDefinitionWithoutTenantId'
        }
        /// <summary>
        /// Test the property 'ActivityIdIn'
        /// </summary>
        [Fact]
        public void ActivityIdInTest()
        {
            // TODO unit test for the property 'ActivityIdIn'
        }
        /// <summary>
        /// Test the property 'RootProcessInstances'
        /// </summary>
        [Fact]
        public void RootProcessInstancesTest()
        {
            // TODO unit test for the property 'RootProcessInstances'
        }
        /// <summary>
        /// Test the property 'LeafProcessInstances'
        /// </summary>
        [Fact]
        public void LeafProcessInstancesTest()
        {
            // TODO unit test for the property 'LeafProcessInstances'
        }
        /// <summary>
        /// Test the property 'Variables'
        /// </summary>
        [Fact]
        public void VariablesTest()
        {
            // TODO unit test for the property 'Variables'
        }
        /// <summary>
        /// Test the property 'VariableNamesIgnoreCase'
        /// </summary>
        [Fact]
        public void VariableNamesIgnoreCaseTest()
        {
            // TODO unit test for the property 'VariableNamesIgnoreCase'
        }
        /// <summary>
        /// Test the property 'VariableValuesIgnoreCase'
        /// </summary>
        [Fact]
        public void VariableValuesIgnoreCaseTest()
        {
            // TODO unit test for the property 'VariableValuesIgnoreCase'
        }
        /// <summary>
        /// Test the property 'OrQueries'
        /// </summary>
        [Fact]
        public void OrQueriesTest()
        {
            // TODO unit test for the property 'OrQueries'
        }
        /// <summary>
        /// Test the property 'Sorting'
        /// </summary>
        [Fact]
        public void SortingTest()
        {
            // TODO unit test for the property 'Sorting'
        }

    }

}