# Camunda.OpenApi.Client.Api.ProcessDefinitionApi

All URIs are relative to *http://localhost:8080/engine-rest*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeleteProcessDefinition**](ProcessDefinitionApi.md#deleteprocessdefinition) | **DELETE** /process-definition/{id} | Delete
[**DeleteProcessDefinitionsByKey**](ProcessDefinitionApi.md#deleteprocessdefinitionsbykey) | **DELETE** /process-definition/key/{key} | Delete By Key
[**DeleteProcessDefinitionsByKeyAndTenantId**](ProcessDefinitionApi.md#deleteprocessdefinitionsbykeyandtenantid) | **DELETE** /process-definition/key/{key}/tenant-id/{tenant-id} | Delete By Key
[**GetActivityStatistics**](ProcessDefinitionApi.md#getactivitystatistics) | **GET** /process-definition/{id}/statistics | Get Activity Instance Statistics
[**GetActivityStatisticsByProcessDefinitionKey**](ProcessDefinitionApi.md#getactivitystatisticsbyprocessdefinitionkey) | **GET** /process-definition/key/{key}/statistics | Get Activity Instance Statistics
[**GetActivityStatisticsByProcessDefinitionKeyAndTenantId**](ProcessDefinitionApi.md#getactivitystatisticsbyprocessdefinitionkeyandtenantid) | **GET** /process-definition/key/{key}/tenant-id/{tenant-id}/statistics | Get Activity Instance Statistics
[**GetDeployedStartForm**](ProcessDefinitionApi.md#getdeployedstartform) | **GET** /process-definition/{id}/deployed-start-form | Get Deployed Start Form
[**GetDeployedStartFormByKey**](ProcessDefinitionApi.md#getdeployedstartformbykey) | **GET** /process-definition/key/{key}/deployed-start-form | Get Deployed Start Form
[**GetDeployedStartFormByKeyAndTenantId**](ProcessDefinitionApi.md#getdeployedstartformbykeyandtenantid) | **GET** /process-definition/key/{key}/tenant-id/{tenant-id}/deployed-start-form | Get Deployed Start Form
[**GetLatestProcessDefinitionByTenantId**](ProcessDefinitionApi.md#getlatestprocessdefinitionbytenantid) | **GET** /process-definition/key/{key}/tenant-id/{tenant-id} | Get
[**GetProcessDefinition**](ProcessDefinitionApi.md#getprocessdefinition) | **GET** /process-definition/{id} | Get
[**GetProcessDefinitionBpmn20Xml**](ProcessDefinitionApi.md#getprocessdefinitionbpmn20xml) | **GET** /process-definition/{id}/xml | Get XML
[**GetProcessDefinitionBpmn20XmlByKey**](ProcessDefinitionApi.md#getprocessdefinitionbpmn20xmlbykey) | **GET** /process-definition/key/{key}/xml | Get XML
[**GetProcessDefinitionBpmn20XmlByKeyAndTenantId**](ProcessDefinitionApi.md#getprocessdefinitionbpmn20xmlbykeyandtenantid) | **GET** /process-definition/key/{key}/tenant-id/{tenant-id}/xml | Get XML
[**GetProcessDefinitionByKey**](ProcessDefinitionApi.md#getprocessdefinitionbykey) | **GET** /process-definition/key/{key} | Get
[**GetProcessDefinitionDiagram**](ProcessDefinitionApi.md#getprocessdefinitiondiagram) | **GET** /process-definition/{id}/diagram | Get Diagram
[**GetProcessDefinitionDiagramByKey**](ProcessDefinitionApi.md#getprocessdefinitiondiagrambykey) | **GET** /process-definition/key/{key}/diagram | Get Diagram
[**GetProcessDefinitionDiagramByKeyAndTenantId**](ProcessDefinitionApi.md#getprocessdefinitiondiagrambykeyandtenantid) | **GET** /process-definition/key/{key}/tenant-id/{tenant-id}/diagram | Get Diagram
[**GetProcessDefinitionStatistics**](ProcessDefinitionApi.md#getprocessdefinitionstatistics) | **GET** /process-definition/statistics | Get Process Instance Statistics
[**GetProcessDefinitions**](ProcessDefinitionApi.md#getprocessdefinitions) | **GET** /process-definition | Get List
[**GetProcessDefinitionsCount**](ProcessDefinitionApi.md#getprocessdefinitionscount) | **GET** /process-definition/count | Get List Count
[**GetRenderedStartForm**](ProcessDefinitionApi.md#getrenderedstartform) | **GET** /process-definition/{id}/rendered-form | Get Rendered Start Form
[**GetRenderedStartFormByKey**](ProcessDefinitionApi.md#getrenderedstartformbykey) | **GET** /process-definition/key/{key}/rendered-form | Get Rendered Start Form
[**GetRenderedStartFormByKeyAndTenantId**](ProcessDefinitionApi.md#getrenderedstartformbykeyandtenantid) | **GET** /process-definition/key/{key}/tenant-id/{tenant-id}/rendered-form | Get Rendered Start Form
[**GetStartForm**](ProcessDefinitionApi.md#getstartform) | **GET** /process-definition/{id}/startForm | Get Start Form Key
[**GetStartFormByKey**](ProcessDefinitionApi.md#getstartformbykey) | **GET** /process-definition/key/{key}/startForm | Get Start Form Key
[**GetStartFormByKeyAndTenantId**](ProcessDefinitionApi.md#getstartformbykeyandtenantid) | **GET** /process-definition/key/{key}/tenant-id/{tenant-id}/startForm | Get Start Form Key
[**GetStartFormVariables**](ProcessDefinitionApi.md#getstartformvariables) | **GET** /process-definition/{id}/form-variables | Get Start Form Variables
[**GetStartFormVariablesByKey**](ProcessDefinitionApi.md#getstartformvariablesbykey) | **GET** /process-definition/key/{key}/form-variables | Get Start Form Variables
[**GetStartFormVariablesByKeyAndTenantId**](ProcessDefinitionApi.md#getstartformvariablesbykeyandtenantid) | **GET** /process-definition/key/{key}/tenant-id/{tenant-id}/form-variables | Get Start Form Variables
[**RestartProcessInstance**](ProcessDefinitionApi.md#restartprocessinstance) | **POST** /process-definition/{id}/restart | Restart Process Instance
[**RestartProcessInstanceAsyncOperation**](ProcessDefinitionApi.md#restartprocessinstanceasyncoperation) | **POST** /process-definition/{id}/restart-async | Restart Process Instance Async
[**StartProcessInstance**](ProcessDefinitionApi.md#startprocessinstance) | **POST** /process-definition/{id}/start | Start Instance
[**StartProcessInstanceByKey**](ProcessDefinitionApi.md#startprocessinstancebykey) | **POST** /process-definition/key/{key}/start | Start Instance
[**StartProcessInstanceByKeyAndTenantId**](ProcessDefinitionApi.md#startprocessinstancebykeyandtenantid) | **POST** /process-definition/key/{key}/tenant-id/{tenant-id}/start | Start Instance
[**SubmitForm**](ProcessDefinitionApi.md#submitform) | **POST** /process-definition/{id}/submit-form | Submit Start Form
[**SubmitFormByKey**](ProcessDefinitionApi.md#submitformbykey) | **POST** /process-definition/key/{key}/submit-form | Submit Start Form
[**SubmitFormByKeyAndTenantId**](ProcessDefinitionApi.md#submitformbykeyandtenantid) | **POST** /process-definition/key/{key}/tenant-id/{tenant-id}/submit-form | Submit Start Form
[**UpdateHistoryTimeToLiveByProcessDefinitionId**](ProcessDefinitionApi.md#updatehistorytimetolivebyprocessdefinitionid) | **PUT** /process-definition/{id}/history-time-to-live | Update History Time to Live
[**UpdateHistoryTimeToLiveByProcessDefinitionKey**](ProcessDefinitionApi.md#updatehistorytimetolivebyprocessdefinitionkey) | **PUT** /process-definition/key/{key}/history-time-to-live | Update History Time to Live
[**UpdateHistoryTimeToLiveByProcessDefinitionKeyAndTenantId**](ProcessDefinitionApi.md#updatehistorytimetolivebyprocessdefinitionkeyandtenantid) | **PUT** /process-definition/key/{key}/tenant-id/{tenant-id}/history-time-to-live | Update History Time to Live
[**UpdateProcessDefinitionSuspensionState**](ProcessDefinitionApi.md#updateprocessdefinitionsuspensionstate) | **PUT** /process-definition/suspended | Activate/Suspend By Key
[**UpdateProcessDefinitionSuspensionStateById**](ProcessDefinitionApi.md#updateprocessdefinitionsuspensionstatebyid) | **PUT** /process-definition/{id}/suspended | Activate/Suspend By Id
[**UpdateProcessDefinitionSuspensionStateByKey**](ProcessDefinitionApi.md#updateprocessdefinitionsuspensionstatebykey) | **PUT** /process-definition/key/{key}/suspended | Activate/Suspend by Id
[**UpdateProcessDefinitionSuspensionStateByKeyAndTenantId**](ProcessDefinitionApi.md#updateprocessdefinitionsuspensionstatebykeyandtenantid) | **PUT** /process-definition/key/{key}/tenant-id/{tenant-id}/suspended | Activate/Suspend by Id


<a name="deleteprocessdefinition"></a>
# **DeleteProcessDefinition**
> void DeleteProcessDefinition (string id, bool? cascade = null, bool? skipCustomListeners = null, bool? skipIoMappings = null)

Delete

Deletes a running process instance by id.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Camunda.OpenApi.Client.Api;
using Camunda.OpenApi.Client.Client;
using Camunda.OpenApi.Client.Model;

namespace Example
{
    public class DeleteProcessDefinitionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/engine-rest";
            var apiInstance = new ProcessDefinitionApi(config);
            var id = id_example;  // string | The id of the process definition to be deleted.
            var cascade = true;  // bool? | `true`, if all process instances, historic process instances and jobs for this process definition should be deleted. (optional) 
            var skipCustomListeners = true;  // bool? | `true`, if only the built-in ExecutionListeners should be notified with the end event. (optional)  (default to false)
            var skipIoMappings = true;  // bool? | A boolean value to control whether input/output mappings should be executed during deletion. `true`, if input/output mappings should not be invoked. (optional)  (default to false)

            try
            {
                // Delete
                apiInstance.DeleteProcessDefinition(id, cascade, skipCustomListeners, skipIoMappings);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProcessDefinitionApi.DeleteProcessDefinition: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The id of the process definition to be deleted. | 
 **cascade** | **bool?**| &#x60;true&#x60;, if all process instances, historic process instances and jobs for this process definition should be deleted. | [optional] 
 **skipCustomListeners** | **bool?**| &#x60;true&#x60;, if only the built-in ExecutionListeners should be notified with the end event. | [optional] [default to false]
 **skipIoMappings** | **bool?**| A boolean value to control whether input/output mappings should be executed during deletion. &#x60;true&#x60;, if input/output mappings should not be invoked. | [optional] [default to false]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | Request successful. |  -  |
| **404** | Not found Process definition with given id does not exist. See the [Introduction](https://docs.camunda.org/manual/7.15/reference/rest/overview/#error-handling) for the error response format. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteprocessdefinitionsbykey"></a>
# **DeleteProcessDefinitionsByKey**
> void DeleteProcessDefinitionsByKey (string key, bool? cascade = null, bool? skipCustomListeners = null, bool? skipIoMappings = null)

Delete By Key

Deletes process definitions by a given key which belong to no tenant id.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Camunda.OpenApi.Client.Api;
using Camunda.OpenApi.Client.Client;
using Camunda.OpenApi.Client.Model;

namespace Example
{
    public class DeleteProcessDefinitionsByKeyExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/engine-rest";
            var apiInstance = new ProcessDefinitionApi(config);
            var key = key_example;  // string | The key of the process definitions to be deleted.
            var cascade = true;  // bool? | `true`, if all process instances, historic process instances and jobs for this process definition should be deleted. (optional) 
            var skipCustomListeners = true;  // bool? | `true`, if only the built-in ExecutionListeners should be notified with the end event. (optional)  (default to false)
            var skipIoMappings = true;  // bool? | A boolean value to control whether input/output mappings should be executed during deletion. `true`, if input/output mappings should not be invoked. (optional)  (default to false)

            try
            {
                // Delete By Key
                apiInstance.DeleteProcessDefinitionsByKey(key, cascade, skipCustomListeners, skipIoMappings);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProcessDefinitionApi.DeleteProcessDefinitionsByKey: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **key** | **string**| The key of the process definitions to be deleted. | 
 **cascade** | **bool?**| &#x60;true&#x60;, if all process instances, historic process instances and jobs for this process definition should be deleted. | [optional] 
 **skipCustomListeners** | **bool?**| &#x60;true&#x60;, if only the built-in ExecutionListeners should be notified with the end event. | [optional] [default to false]
 **skipIoMappings** | **bool?**| A boolean value to control whether input/output mappings should be executed during deletion. &#x60;true&#x60;, if input/output mappings should not be invoked. | [optional] [default to false]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | Request successful. |  -  |
| **403** | Forbidden The process definitions with the given &#x60;key&#x60; cannot be deleted due to missing permissions. See the [Introduction](https://docs.camunda.org/manual/7.15/reference/rest/overview/#error-handling) for the error response format. |  -  |
| **404** | Not found Process definition with given &#x60;key&#x60; does not exist. See the [Introduction](https://docs.camunda.org/manual/7.15/reference/rest/overview/#error-handling) for the error response format. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteprocessdefinitionsbykeyandtenantid"></a>
# **DeleteProcessDefinitionsByKeyAndTenantId**
> void DeleteProcessDefinitionsByKeyAndTenantId (string key, string tenantId, bool? cascade = null, bool? skipCustomListeners = null, bool? skipIoMappings = null)

Delete By Key

Deletes process definitions by a given key and which belong to a tenant id.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Camunda.OpenApi.Client.Api;
using Camunda.OpenApi.Client.Client;
using Camunda.OpenApi.Client.Model;

namespace Example
{
    public class DeleteProcessDefinitionsByKeyAndTenantIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/engine-rest";
            var apiInstance = new ProcessDefinitionApi(config);
            var key = key_example;  // string | The key of the process definitions to be deleted.
            var tenantId = tenantId_example;  // string | The id of the tenant the process definitions belong to.
            var cascade = true;  // bool? | `true`, if all process instances, historic process instances and jobs for this process definition should be deleted. (optional) 
            var skipCustomListeners = true;  // bool? | `true`, if only the built-in ExecutionListeners should be notified with the end event. (optional)  (default to false)
            var skipIoMappings = true;  // bool? | A boolean value to control whether input/output mappings should be executed during deletion. `true`, if input/output mappings should not be invoked. (optional)  (default to false)

            try
            {
                // Delete By Key
                apiInstance.DeleteProcessDefinitionsByKeyAndTenantId(key, tenantId, cascade, skipCustomListeners, skipIoMappings);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProcessDefinitionApi.DeleteProcessDefinitionsByKeyAndTenantId: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **key** | **string**| The key of the process definitions to be deleted. | 
 **tenantId** | **string**| The id of the tenant the process definitions belong to. | 
 **cascade** | **bool?**| &#x60;true&#x60;, if all process instances, historic process instances and jobs for this process definition should be deleted. | [optional] 
 **skipCustomListeners** | **bool?**| &#x60;true&#x60;, if only the built-in ExecutionListeners should be notified with the end event. | [optional] [default to false]
 **skipIoMappings** | **bool?**| A boolean value to control whether input/output mappings should be executed during deletion. &#x60;true&#x60;, if input/output mappings should not be invoked. | [optional] [default to false]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | Request successful. |  -  |
| **403** | Forbidden The process definitions with the given &#x60;key&#x60; cannot be deleted due to missing permissions. See the [Introduction](https://docs.camunda.org/manual/7.15/reference/rest/overview/#error-handling) for the error response format. |  -  |
| **404** | Not found Process definition with given key does not exist. See the [Introduction](https://docs.camunda.org/manual/7.15/reference/rest/overview/#error-handling) for the error response format. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getactivitystatistics"></a>
# **GetActivityStatistics**
> List&lt;ActivityStatisticsResultDto&gt; GetActivityStatistics (string id, bool? failedJobs = null, bool? incidents = null, string incidentsForType = null)

Get Activity Instance Statistics

Retrieves runtime statistics of a given process definition, grouped by activities. These statistics include the number of running activity instances, optionally the number of failed jobs and also optionally the number of incidents either grouped by incident types or for a specific incident type. **Note**: This does not include historic data.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Camunda.OpenApi.Client.Api;
using Camunda.OpenApi.Client.Client;
using Camunda.OpenApi.Client.Model;

namespace Example
{
    public class GetActivityStatisticsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/engine-rest";
            var apiInstance = new ProcessDefinitionApi(config);
            var id = id_example;  // string | The id of the process definition.
            var failedJobs = true;  // bool? | Whether to include the number of failed jobs in the result or not. Valid values are `true` or `false`. (optional) 
            var incidents = true;  // bool? | Valid values for this property are `true` or `false`. If this property has been set to `true` the result will include the corresponding number of incidents for each occurred incident type. If it is set to `false`, the incidents will not be included in the result. Cannot be used in combination with `incidentsForType`. (optional) 
            var incidentsForType = incidentsForType_example;  // string | If this property has been set with any incident type (i.e., a string value) the result will only include the number of incidents for the assigned incident type. Cannot be used in combination with `incidents`. See the [User Guide](https://docs.camunda.org/manual/7.15/user-guide/process-engine/incidents/#incident-types) for a list of incident types. (optional) 

            try
            {
                // Get Activity Instance Statistics
                List<ActivityStatisticsResultDto> result = apiInstance.GetActivityStatistics(id, failedJobs, incidents, incidentsForType);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProcessDefinitionApi.GetActivityStatistics: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The id of the process definition. | 
 **failedJobs** | **bool?**| Whether to include the number of failed jobs in the result or not. Valid values are &#x60;true&#x60; or &#x60;false&#x60;. | [optional] 
 **incidents** | **bool?**| Valid values for this property are &#x60;true&#x60; or &#x60;false&#x60;. If this property has been set to &#x60;true&#x60; the result will include the corresponding number of incidents for each occurred incident type. If it is set to &#x60;false&#x60;, the incidents will not be included in the result. Cannot be used in combination with &#x60;incidentsForType&#x60;. | [optional] 
 **incidentsForType** | **string**| If this property has been set with any incident type (i.e., a string value) the result will only include the number of incidents for the assigned incident type. Cannot be used in combination with &#x60;incidents&#x60;. See the [User Guide](https://docs.camunda.org/manual/7.15/user-guide/process-engine/incidents/#incident-types) for a list of incident types. | [optional] 

### Return type

[**List&lt;ActivityStatisticsResultDto&gt;**](ActivityStatisticsResultDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Request successful. |  -  |
| **400** | Returned if some of the query parameters are invalid. See the [Introduction](https://docs.camunda.org/manual/7.15/reference/rest/overview/#error-handling) for the error response format. |  -  |
| **404** | Process definition with given key does not exist. See the [Introduction](https://docs.camunda.org/manual/7.15/reference/rest/overview/#error-handling) for the error response format. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getactivitystatisticsbyprocessdefinitionkey"></a>
# **GetActivityStatisticsByProcessDefinitionKey**
> List&lt;ActivityStatisticsResultDto&gt; GetActivityStatisticsByProcessDefinitionKey (string key, bool? failedJobs = null, bool? incidents = null, string incidentsForType = null)

Get Activity Instance Statistics

Retrieves runtime statistics of the latest version of the given process definition which belongs to no tenant, grouped by activities. These statistics include the number of running activity instances, optionally the number of failed jobs and also optionally the number of incidents either grouped by incident types or for a specific incident type. **Note**: This does not include historic data.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Camunda.OpenApi.Client.Api;
using Camunda.OpenApi.Client.Client;
using Camunda.OpenApi.Client.Model;

namespace Example
{
    public class GetActivityStatisticsByProcessDefinitionKeyExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/engine-rest";
            var apiInstance = new ProcessDefinitionApi(config);
            var key = key_example;  // string | The key of the process definition (the latest version thereof) to be retrieved.
            var failedJobs = true;  // bool? | Whether to include the number of failed jobs in the result or not. Valid values are `true` or `false`. (optional) 
            var incidents = true;  // bool? | Valid values for this property are `true` or `false`. If this property has been set to `true` the result will include the corresponding number of incidents for each occurred incident type. If it is set to `false`, the incidents will not be included in the result. Cannot be used in combination with `incidentsForType`. (optional) 
            var incidentsForType = incidentsForType_example;  // string | If this property has been set with any incident type (i.e., a string value) the result will only include the number of incidents for the assigned incident type. Cannot be used in combination with `incidents`. See the [User Guide](https://docs.camunda.org/manual/7.15/user-guide/process-engine/incidents/#incident-types) for a list of incident types. (optional) 

            try
            {
                // Get Activity Instance Statistics
                List<ActivityStatisticsResultDto> result = apiInstance.GetActivityStatisticsByProcessDefinitionKey(key, failedJobs, incidents, incidentsForType);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProcessDefinitionApi.GetActivityStatisticsByProcessDefinitionKey: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **key** | **string**| The key of the process definition (the latest version thereof) to be retrieved. | 
 **failedJobs** | **bool?**| Whether to include the number of failed jobs in the result or not. Valid values are &#x60;true&#x60; or &#x60;false&#x60;. | [optional] 
 **incidents** | **bool?**| Valid values for this property are &#x60;true&#x60; or &#x60;false&#x60;. If this property has been set to &#x60;true&#x60; the result will include the corresponding number of incidents for each occurred incident type. If it is set to &#x60;false&#x60;, the incidents will not be included in the result. Cannot be used in combination with &#x60;incidentsForType&#x60;. | [optional] 
 **incidentsForType** | **string**| If this property has been set with any incident type (i.e., a string value) the result will only include the number of incidents for the assigned incident type. Cannot be used in combination with &#x60;incidents&#x60;. See the [User Guide](https://docs.camunda.org/manual/7.15/user-guide/process-engine/incidents/#incident-types) for a list of incident types. | [optional] 

### Return type

[**List&lt;ActivityStatisticsResultDto&gt;**](ActivityStatisticsResultDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Request successful. |  -  |
| **400** | Returned if some of the query parameters are invalid. See the [Introduction](https://docs.camunda.org/manual/7.15/reference/rest/overview/#error-handling) for the error response format. |  -  |
| **404** | Process definition with given key does not exist. See the [Introduction](https://docs.camunda.org/manual/7.15/reference/rest/overview/#error-handling) for the error response format. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getactivitystatisticsbyprocessdefinitionkeyandtenantid"></a>
# **GetActivityStatisticsByProcessDefinitionKeyAndTenantId**
> List&lt;ActivityStatisticsResultDto&gt; GetActivityStatisticsByProcessDefinitionKeyAndTenantId (string key, string tenantId, bool? failedJobs = null, bool? incidents = null, string incidentsForType = null)

Get Activity Instance Statistics

Retrieves runtime statistics of the latest version of the given process definition for a tenant, grouped by activities. These statistics include the number of running activity instances, optionally the number of failed jobs and also optionally the number of incidents either grouped by incident types or for a specific incident type. **Note**: This does not include historic data.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Camunda.OpenApi.Client.Api;
using Camunda.OpenApi.Client.Client;
using Camunda.OpenApi.Client.Model;

namespace Example
{
    public class GetActivityStatisticsByProcessDefinitionKeyAndTenantIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/engine-rest";
            var apiInstance = new ProcessDefinitionApi(config);
            var key = key_example;  // string | The key of the process definition (the latest version thereof) to be retrieved.
            var tenantId = tenantId_example;  // string | The id of the tenant the process definition belongs to.
            var failedJobs = true;  // bool? | Whether to include the number of failed jobs in the result or not. Valid values are `true` or `false`. (optional) 
            var incidents = true;  // bool? | Valid values for this property are `true` or `false`. If this property has been set to `true` the result will include the corresponding number of incidents for each occurred incident type. If it is set to `false`, the incidents will not be included in the result. Cannot be used in combination with `incidentsForType`. (optional) 
            var incidentsForType = incidentsForType_example;  // string | If this property has been set with any incident type (i.e., a string value) the result will only include the number of incidents for the assigned incident type. Cannot be used in combination with `incidents`. See the [User Guide](https://docs.camunda.org/manual/7.15/user-guide/process-engine/incidents/#incident-types) for a list of incident types. (optional) 

            try
            {
                // Get Activity Instance Statistics
                List<ActivityStatisticsResultDto> result = apiInstance.GetActivityStatisticsByProcessDefinitionKeyAndTenantId(key, tenantId, failedJobs, incidents, incidentsForType);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProcessDefinitionApi.GetActivityStatisticsByProcessDefinitionKeyAndTenantId: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **key** | **string**| The key of the process definition (the latest version thereof) to be retrieved. | 
 **tenantId** | **string**| The id of the tenant the process definition belongs to. | 
 **failedJobs** | **bool?**| Whether to include the number of failed jobs in the result or not. Valid values are &#x60;true&#x60; or &#x60;false&#x60;. | [optional] 
 **incidents** | **bool?**| Valid values for this property are &#x60;true&#x60; or &#x60;false&#x60;. If this property has been set to &#x60;true&#x60; the result will include the corresponding number of incidents for each occurred incident type. If it is set to &#x60;false&#x60;, the incidents will not be included in the result. Cannot be used in combination with &#x60;incidentsForType&#x60;. | [optional] 
 **incidentsForType** | **string**| If this property has been set with any incident type (i.e., a string value) the result will only include the number of incidents for the assigned incident type. Cannot be used in combination with &#x60;incidents&#x60;. See the [User Guide](https://docs.camunda.org/manual/7.15/user-guide/process-engine/incidents/#incident-types) for a list of incident types. | [optional] 

### Return type

[**List&lt;ActivityStatisticsResultDto&gt;**](ActivityStatisticsResultDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Request successful. |  -  |
| **400** | Returned if some of the query parameters are invalid. See the [Introduction](https://docs.camunda.org/manual/7.15/reference/rest/overview/#error-handling) for the error response format. |  -  |
| **404** | Process definition with given key does not exist. See the [Introduction](https://docs.camunda.org/manual/7.15/reference/rest/overview/#error-handling) for the error response format. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getdeployedstartform"></a>
# **GetDeployedStartForm**
> System.IO.Stream GetDeployedStartForm (string id)

Get Deployed Start Form

Retrieves the deployed form that can be referenced from a start event. For further information please refer to [User Guide](https://docs.camunda.org/manual/7.15/user-guide/task-forms/#embedded-task-forms).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Camunda.OpenApi.Client.Api;
using Camunda.OpenApi.Client.Client;
using Camunda.OpenApi.Client.Model;

namespace Example
{
    public class GetDeployedStartFormExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/engine-rest";
            var apiInstance = new ProcessDefinitionApi(config);
            var id = id_example;  // string | The id of the process definition to get the deployed start form for.

            try
            {
                // Get Deployed Start Form
                System.IO.Stream result = apiInstance.GetDeployedStartForm(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProcessDefinitionApi.GetDeployedStartForm: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The id of the process definition to get the deployed start form for. | 

### Return type

**System.IO.Stream**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/xhtml+xml, application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Request successful. |  -  |
| **400** | The form key has wrong format.  See the [Introduction](https://docs.camunda.org/manual/7.15/reference/rest/overview/#error-handling) for the error response format. |  -  |
| **403** | The deployed start form cannot be retrieved due to missing permissions on process definition resource. See the [Introduction](https://docs.camunda.org/manual/7.15/reference/rest/overview/#error-handling) for the error response format. |  -  |
| **404** | No deployed start form for a given process definition exists. See the [Introduction](https://docs.camunda.org/manual/7.15/reference/rest/overview/#error-handling) for the error response format. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getdeployedstartformbykey"></a>
# **GetDeployedStartFormByKey**
> System.IO.Stream GetDeployedStartFormByKey (string key)

Get Deployed Start Form

Retrieves the deployed form that can be referenced from a start event. For further information please refer to [User Guide](https://docs.camunda.org/manual/7.15/user-guide/task-forms/#embedded-task-forms).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Camunda.OpenApi.Client.Api;
using Camunda.OpenApi.Client.Client;
using Camunda.OpenApi.Client.Model;

namespace Example
{
    public class GetDeployedStartFormByKeyExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/engine-rest";
            var apiInstance = new ProcessDefinitionApi(config);
            var key = key_example;  // string | The key of the process definition (the latest version thereof) to be retrieved.

            try
            {
                // Get Deployed Start Form
                System.IO.Stream result = apiInstance.GetDeployedStartFormByKey(key);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProcessDefinitionApi.GetDeployedStartFormByKey: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **key** | **string**| The key of the process definition (the latest version thereof) to be retrieved. | 

### Return type

**System.IO.Stream**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/xhtml+xml, application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Request successful. |  -  |
| **400** | The form key has wrong format.  See the [Introduction](https://docs.camunda.org/manual/7.15/reference/rest/overview/#error-handling) for the error response format. |  -  |
| **403** | The deployed start form cannot be retrieved due to missing permissions on process definition resource. See the [Introduction](https://docs.camunda.org/manual/7.15/reference/rest/overview/#error-handling) for the error response format. |  -  |
| **404** | No deployed start form for a given process definition exists. See the [Introduction](https://docs.camunda.org/manual/7.15/reference/rest/overview/#error-handling) for the error response format. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getdeployedstartformbykeyandtenantid"></a>
# **GetDeployedStartFormByKeyAndTenantId**
> System.IO.Stream GetDeployedStartFormByKeyAndTenantId (string key, string tenantId)

Get Deployed Start Form

Retrieves the deployed form that can be referenced from a start event. For further information please refer to [User Guide](https://docs.camunda.org/manual/7.15/user-guide/task-forms/#embedded-task-forms).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Camunda.OpenApi.Client.Api;
using Camunda.OpenApi.Client.Client;
using Camunda.OpenApi.Client.Model;

namespace Example
{
    public class GetDeployedStartFormByKeyAndTenantIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/engine-rest";
            var apiInstance = new ProcessDefinitionApi(config);
            var key = key_example;  // string | The key of the process definition (the latest version thereof) to be retrieved.
            var tenantId = tenantId_example;  // string | The id of the tenant the process definitions belong to.

            try
            {
                // Get Deployed Start Form
                System.IO.Stream result = apiInstance.GetDeployedStartFormByKeyAndTenantId(key, tenantId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProcessDefinitionApi.GetDeployedStartFormByKeyAndTenantId: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **key** | **string**| The key of the process definition (the latest version thereof) to be retrieved. | 
 **tenantId** | **string**| The id of the tenant the process definitions belong to. | 

### Return type

**System.IO.Stream**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/xhtml+xml, application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Request successful. |  -  |
| **400** | The form key has wrong format.  See the [Introduction](https://docs.camunda.org/manual/7.15/reference/rest/overview/#error-handling) for the error response format. |  -  |
| **403** | The deployed start form cannot be retrieved due to missing permissions on process definition resource. See the [Introduction](https://docs.camunda.org/manual/7.15/reference/rest/overview/#error-handling) for the error response format. |  -  |
| **404** | No deployed start form for a given process definition exists. See the [Introduction](https://docs.camunda.org/manual/7.15/reference/rest/overview/#error-handling) for the error response format. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getlatestprocessdefinitionbytenantid"></a>
# **GetLatestProcessDefinitionByTenantId**
> ProcessDefinitionDto GetLatestProcessDefinitionByTenantId (string key, string tenantId)

Get

Retrieves the latest version of the process definition for tenant according to the `ProcessDefinition` interface in the engine.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Camunda.OpenApi.Client.Api;
using Camunda.OpenApi.Client.Client;
using Camunda.OpenApi.Client.Model;

namespace Example
{
    public class GetLatestProcessDefinitionByTenantIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/engine-rest";
            var apiInstance = new ProcessDefinitionApi(config);
            var key = key_example;  // string | The key of the process definition (the latest version thereof) to be retrieved.
            var tenantId = tenantId_example;  // string | The id of the tenant the process definition belongs to.

            try
            {
                // Get
                ProcessDefinitionDto result = apiInstance.GetLatestProcessDefinitionByTenantId(key, tenantId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProcessDefinitionApi.GetLatestProcessDefinitionByTenantId: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **key** | **string**| The key of the process definition (the latest version thereof) to be retrieved. | 
 **tenantId** | **string**| The id of the tenant the process definition belongs to. | 

### Return type

[**ProcessDefinitionDto**](ProcessDefinitionDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Request successful. |  -  |
| **400** | Process definition with given &#x60;key&#x60; does not exist. See the [Introduction](https://docs.camunda.org/manual/7.15/reference/rest/overview/#error-handling) for the error response format. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getprocessdefinition"></a>
# **GetProcessDefinition**
> ProcessDefinitionDto GetProcessDefinition (string id)

Get

Retrieves a process definition according to the `ProcessDefinition` interface in the engine.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Camunda.OpenApi.Client.Api;
using Camunda.OpenApi.Client.Client;
using Camunda.OpenApi.Client.Model;

namespace Example
{
    public class GetProcessDefinitionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/engine-rest";
            var apiInstance = new ProcessDefinitionApi(config);
            var id = id_example;  // string | The id of the process definition to be retrieved.

            try
            {
                // Get
                ProcessDefinitionDto result = apiInstance.GetProcessDefinition(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProcessDefinitionApi.GetProcessDefinition: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The id of the process definition to be retrieved. | 

### Return type

[**ProcessDefinitionDto**](ProcessDefinitionDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Request successful. |  -  |
| **400** | Process definition with given &#x60;id&#x60; does not exist. See the [Introduction](https://docs.camunda.org/manual/7.15/reference/rest/overview/#error-handling) for the error response format. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getprocessdefinitionbpmn20xml"></a>
# **GetProcessDefinitionBpmn20Xml**
> ProcessDefinitionDiagramDto GetProcessDefinitionBpmn20Xml (string id)

Get XML

Retrieves the BPMN 2.0 XML of a process definition.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Camunda.OpenApi.Client.Api;
using Camunda.OpenApi.Client.Client;
using Camunda.OpenApi.Client.Model;

namespace Example
{
    public class GetProcessDefinitionBpmn20XmlExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/engine-rest";
            var apiInstance = new ProcessDefinitionApi(config);
            var id = id_example;  // string | The id of the process definition.

            try
            {
                // Get XML
                ProcessDefinitionDiagramDto result = apiInstance.GetProcessDefinitionBpmn20Xml(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProcessDefinitionApi.GetProcessDefinitionBpmn20Xml: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The id of the process definition. | 

### Return type

[**ProcessDefinitionDiagramDto**](ProcessDefinitionDiagramDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Request successful. |  -  |
| **400** | Returned if some of the query parameters are invalid. See the [Introduction](https://docs.camunda.org/manual/7.15/reference/rest/overview/#error-handling) for the error response format. |  -  |
| **403** | The Process Definition xml cannot be retrieved due to missing permissions on the Process Definition resource. See the [Introduction](https://docs.camunda.org/manual/7.15/reference/rest/overview/#error-handling) for the error response format. |  -  |
| **404** | Process definition with given id does not exist. See the [Introduction](https://docs.camunda.org/manual/7.15/reference/rest/overview/#error-handling) for the error response format. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getprocessdefinitionbpmn20xmlbykey"></a>
# **GetProcessDefinitionBpmn20XmlByKey**
> ProcessDefinitionDiagramDto GetProcessDefinitionBpmn20XmlByKey (string key)

Get XML

Retrieves latest version the BPMN 2.0 XML of a process definition.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Camunda.OpenApi.Client.Api;
using Camunda.OpenApi.Client.Client;
using Camunda.OpenApi.Client.Model;

namespace Example
{
    public class GetProcessDefinitionBpmn20XmlByKeyExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/engine-rest";
            var apiInstance = new ProcessDefinitionApi(config);
            var key = key_example;  // string | The key of the process definition (the latest version thereof) whose XML should be retrieved.

            try
            {
                // Get XML
                ProcessDefinitionDiagramDto result = apiInstance.GetProcessDefinitionBpmn20XmlByKey(key);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProcessDefinitionApi.GetProcessDefinitionBpmn20XmlByKey: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **key** | **string**| The key of the process definition (the latest version thereof) whose XML should be retrieved. | 

### Return type

[**ProcessDefinitionDiagramDto**](ProcessDefinitionDiagramDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Request successful. |  -  |
| **403** | The Process Definition xml cannot be retrieved due to missing permissions on the Process Definition resource. See the [Introduction](https://docs.camunda.org/manual/7.15/reference/rest/overview/#error-handling) for the error response format. |  -  |
| **404** | Process definition with given id does not exist. See the [Introduction](https://docs.camunda.org/manual/7.15/reference/rest/overview/#error-handling) for the error response format. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getprocessdefinitionbpmn20xmlbykeyandtenantid"></a>
# **GetProcessDefinitionBpmn20XmlByKeyAndTenantId**
> ProcessDefinitionDiagramDto GetProcessDefinitionBpmn20XmlByKeyAndTenantId (string key, string tenantId)

Get XML

Retrieves latest version the BPMN 2.0 XML of a process definition. Returns the XML for the latest version of the process definition for tenant.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Camunda.OpenApi.Client.Api;
using Camunda.OpenApi.Client.Client;
using Camunda.OpenApi.Client.Model;

namespace Example
{
    public class GetProcessDefinitionBpmn20XmlByKeyAndTenantIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/engine-rest";
            var apiInstance = new ProcessDefinitionApi(config);
            var key = key_example;  // string | The key of the process definition (the latest version thereof) whose XML should be retrieved.
            var tenantId = tenantId_example;  // string | The id of the tenant the process definition belongs to.

            try
            {
                // Get XML
                ProcessDefinitionDiagramDto result = apiInstance.GetProcessDefinitionBpmn20XmlByKeyAndTenantId(key, tenantId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProcessDefinitionApi.GetProcessDefinitionBpmn20XmlByKeyAndTenantId: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **key** | **string**| The key of the process definition (the latest version thereof) whose XML should be retrieved. | 
 **tenantId** | **string**| The id of the tenant the process definition belongs to. | 

### Return type

[**ProcessDefinitionDiagramDto**](ProcessDefinitionDiagramDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Request successful. |  -  |
| **403** | The Process Definition xml cannot be retrieved due to missing permissions on the Process Definition resource. See the [Introduction](https://docs.camunda.org/manual/7.15/reference/rest/overview/#error-handling) for the error response format. |  -  |
| **404** | Process definition with given id does not exist. See the [Introduction](https://docs.camunda.org/manual/7.15/reference/rest/overview/#error-handling) for the error response format. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getprocessdefinitionbykey"></a>
# **GetProcessDefinitionByKey**
> ProcessDefinitionDto GetProcessDefinitionByKey (string key)

Get

Retrieves the latest version of the process definition which belongs to no tenant according to the `ProcessDefinition` interface in the engine.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Camunda.OpenApi.Client.Api;
using Camunda.OpenApi.Client.Client;
using Camunda.OpenApi.Client.Model;

namespace Example
{
    public class GetProcessDefinitionByKeyExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/engine-rest";
            var apiInstance = new ProcessDefinitionApi(config);
            var key = key_example;  // string | The key of the process definition (the latest version thereof) to be retrieved.

            try
            {
                // Get
                ProcessDefinitionDto result = apiInstance.GetProcessDefinitionByKey(key);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProcessDefinitionApi.GetProcessDefinitionByKey: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **key** | **string**| The key of the process definition (the latest version thereof) to be retrieved. | 

### Return type

[**ProcessDefinitionDto**](ProcessDefinitionDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Request successful. |  -  |
| **400** | Process definition with given &#x60;key&#x60; does not exist. See the [Introduction](https://docs.camunda.org/manual/7.15/reference/rest/overview/#error-handling) for the error response format. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getprocessdefinitiondiagram"></a>
# **GetProcessDefinitionDiagram**
> System.IO.Stream GetProcessDefinitionDiagram (string id)

Get Diagram

Retrieves the diagram of a process definition.  If the process definition's deployment contains an image resource with the same file name as the process definition, the deployed image will be returned by the Get Diagram endpoint. Example: `someProcess.bpmn` and `someProcess.png`. Supported file extentions for the image are: `svg`, `png`, `jpg`, and `gif`.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Camunda.OpenApi.Client.Api;
using Camunda.OpenApi.Client.Client;
using Camunda.OpenApi.Client.Model;

namespace Example
{
    public class GetProcessDefinitionDiagramExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/engine-rest";
            var apiInstance = new ProcessDefinitionApi(config);
            var id = id_example;  // string | The id of the process definition.

            try
            {
                // Get Diagram
                System.IO.Stream result = apiInstance.GetProcessDefinitionDiagram(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProcessDefinitionApi.GetProcessDefinitionDiagram: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The id of the process definition. | 

### Return type

**System.IO.Stream**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/octet-stream, */*, application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Request successful. The image diagram of this process. |  -  |
| **204** | The process definition doesn&#39;t have an associated diagram. |  -  |
| **404** | Process definition with given id does not exist. See the [Introduction](https://docs.camunda.org/manual/7.15/reference/rest/overview/#error-handling) for the error response format. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getprocessdefinitiondiagrambykey"></a>
# **GetProcessDefinitionDiagramByKey**
> System.IO.Stream GetProcessDefinitionDiagramByKey (string key)

Get Diagram

Retrieves the diagram for the latest version of the process definition which belongs to no tenant.  If the process definition's deployment contains an image resource with the same file name as the process definition, the deployed image will be returned by the Get Diagram endpoint. Example: `someProcess.bpmn` and `someProcess.png`. Supported file extentions for the image are: `svg`, `png`, `jpg`, and `gif`.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Camunda.OpenApi.Client.Api;
using Camunda.OpenApi.Client.Client;
using Camunda.OpenApi.Client.Model;

namespace Example
{
    public class GetProcessDefinitionDiagramByKeyExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/engine-rest";
            var apiInstance = new ProcessDefinitionApi(config);
            var key = key_example;  // string | The key of the process definition.

            try
            {
                // Get Diagram
                System.IO.Stream result = apiInstance.GetProcessDefinitionDiagramByKey(key);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProcessDefinitionApi.GetProcessDefinitionDiagramByKey: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **key** | **string**| The key of the process definition. | 

### Return type

**System.IO.Stream**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/octet-stream, */*, application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Request successful. The image diagram of this process. |  -  |
| **204** | The process definition doesn&#39;t have an associated diagram. |  -  |
| **404** | Process definition with given id does not exist. See the [Introduction](https://docs.camunda.org/manual/7.15/reference/rest/overview/#error-handling) for the error response format. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getprocessdefinitiondiagrambykeyandtenantid"></a>
# **GetProcessDefinitionDiagramByKeyAndTenantId**
> System.IO.Stream GetProcessDefinitionDiagramByKeyAndTenantId (string key, string tenantId)

Get Diagram

Retrieves the diagram for the latest version of the process definition for tenant.  If the process definition's deployment contains an image resource with the same file name as the process definition, the deployed image will be returned by the Get Diagram endpoint. Example: `someProcess.bpmn` and `someProcess.png`. Supported file extentions for the image are: `svg`, `png`, `jpg`, and `gif`.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Camunda.OpenApi.Client.Api;
using Camunda.OpenApi.Client.Client;
using Camunda.OpenApi.Client.Model;

namespace Example
{
    public class GetProcessDefinitionDiagramByKeyAndTenantIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/engine-rest";
            var apiInstance = new ProcessDefinitionApi(config);
            var key = key_example;  // string | The key of the process definition.
            var tenantId = tenantId_example;  // string | The id of the tenant the process definition belongs to.

            try
            {
                // Get Diagram
                System.IO.Stream result = apiInstance.GetProcessDefinitionDiagramByKeyAndTenantId(key, tenantId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProcessDefinitionApi.GetProcessDefinitionDiagramByKeyAndTenantId: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **key** | **string**| The key of the process definition. | 
 **tenantId** | **string**| The id of the tenant the process definition belongs to. | 

### Return type

**System.IO.Stream**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/octet-stream, */*, application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Request successful. The image diagram of this process. |  -  |
| **204** | The process definition doesn&#39;t have an associated diagram. |  -  |
| **404** | Process definition with given id does not exist. See the [Introduction](https://docs.camunda.org/manual/7.15/reference/rest/overview/#error-handling) for the error response format. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getprocessdefinitionstatistics"></a>
# **GetProcessDefinitionStatistics**
> List&lt;ProcessDefinitionStatisticsResultDto&gt; GetProcessDefinitionStatistics (bool? failedJobs = null, bool? incidents = null, string incidentsForType = null, bool? rootIncidents = null)

Get Process Instance Statistics

Retrieves runtime statistics of the process engine, grouped by process definitions. These statistics include the number of running process instances, optionally the number of failed jobs and also optionally the number of incidents either grouped by incident types or for a specific incident type. **Note**: This does not include historic data.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Camunda.OpenApi.Client.Api;
using Camunda.OpenApi.Client.Client;
using Camunda.OpenApi.Client.Model;

namespace Example
{
    public class GetProcessDefinitionStatisticsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/engine-rest";
            var apiInstance = new ProcessDefinitionApi(config);
            var failedJobs = true;  // bool? | Whether to include the number of failed jobs in the result or not. Valid values are `true` or `false`. (optional) 
            var incidents = true;  // bool? | Valid values for this property are `true` or `false`. If this property has been set to `true` the result will include the corresponding number of incidents for each occurred incident type. If it is set to `false`, the incidents will not be included in the result. Cannot be used in combination with `incidentsForType`. (optional) 
            var incidentsForType = incidentsForType_example;  // string | If this property has been set with any incident type (i.e., a string value) the result will only include the number of incidents for the assigned incident type. Cannot be used in combination with `incidents`. See the [User Guide](https://docs.camunda.org/manual/7.15/user-guide/process-engine/incidents/#incident-types) for a list of incident types. (optional) 
            var rootIncidents = true;  // bool? | Valid values for this property are `true` or `false`. If this property has been set to `true` the result will include the corresponding number of root incidents for each occurred incident type. If it is set to `false`, the incidents will not be included in the result. Cannot be used in combination with `incidentsForType` or `incidents`. (optional) 

            try
            {
                // Get Process Instance Statistics
                List<ProcessDefinitionStatisticsResultDto> result = apiInstance.GetProcessDefinitionStatistics(failedJobs, incidents, incidentsForType, rootIncidents);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProcessDefinitionApi.GetProcessDefinitionStatistics: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **failedJobs** | **bool?**| Whether to include the number of failed jobs in the result or not. Valid values are &#x60;true&#x60; or &#x60;false&#x60;. | [optional] 
 **incidents** | **bool?**| Valid values for this property are &#x60;true&#x60; or &#x60;false&#x60;. If this property has been set to &#x60;true&#x60; the result will include the corresponding number of incidents for each occurred incident type. If it is set to &#x60;false&#x60;, the incidents will not be included in the result. Cannot be used in combination with &#x60;incidentsForType&#x60;. | [optional] 
 **incidentsForType** | **string**| If this property has been set with any incident type (i.e., a string value) the result will only include the number of incidents for the assigned incident type. Cannot be used in combination with &#x60;incidents&#x60;. See the [User Guide](https://docs.camunda.org/manual/7.15/user-guide/process-engine/incidents/#incident-types) for a list of incident types. | [optional] 
 **rootIncidents** | **bool?**| Valid values for this property are &#x60;true&#x60; or &#x60;false&#x60;. If this property has been set to &#x60;true&#x60; the result will include the corresponding number of root incidents for each occurred incident type. If it is set to &#x60;false&#x60;, the incidents will not be included in the result. Cannot be used in combination with &#x60;incidentsForType&#x60; or &#x60;incidents&#x60;. | [optional] 

### Return type

[**List&lt;ProcessDefinitionStatisticsResultDto&gt;**](ProcessDefinitionStatisticsResultDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Request successful. |  -  |
| **400** | Returned if some of the query parameters are invalid. See the [Introduction](https://docs.camunda.org/manual/7.15/reference/rest/overview/#error-handling) for the error response format. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getprocessdefinitions"></a>
# **GetProcessDefinitions**
> List&lt;ProcessDefinitionDto&gt; GetProcessDefinitions (string processDefinitionId = null, string processDefinitionIdIn = null, string name = null, string nameLike = null, string deploymentId = null, DateTime? deployedAfter = null, DateTime? deployedAt = null, string key = null, string keysIn = null, string keyLike = null, string category = null, string categoryLike = null, int? version = null, bool? latestVersion = null, string resourceName = null, string resourceNameLike = null, string startableBy = null, bool? active = null, bool? suspended = null, string incidentId = null, string incidentType = null, string incidentMessage = null, string incidentMessageLike = null, string tenantIdIn = null, bool? withoutTenantId = null, bool? includeProcessDefinitionsWithoutTenantId = null, string versionTag = null, string versionTagLike = null, bool? withoutVersionTag = null, bool? startableInTasklist = null, bool? notStartableInTasklist = null, bool? startablePermissionCheck = null, string sortBy = null, string sortOrder = null, int? firstResult = null, int? maxResults = null)

Get List

Queries for process definitions that fulfill given parameters. Parameters may be the properties of  process definitions, such as the name, key or version. The size of the result set can be retrieved by using the [Get Definition Count](https://docs.camunda.org/manual/7.15/reference/rest/process-definition/get-query-count/) method.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Camunda.OpenApi.Client.Api;
using Camunda.OpenApi.Client.Client;
using Camunda.OpenApi.Client.Model;

namespace Example
{
    public class GetProcessDefinitionsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/engine-rest";
            var apiInstance = new ProcessDefinitionApi(config);
            var processDefinitionId = processDefinitionId_example;  // string | Filter by process definition id. (optional) 
            var processDefinitionIdIn = processDefinitionIdIn_example;  // string | Filter by a comma-separated list of process definition ids. (optional) 
            var name = name_example;  // string | Filter by process definition name. (optional) 
            var nameLike = nameLike_example;  // string | Filter by process definition names that the parameter is a substring of. (optional) 
            var deploymentId = deploymentId_example;  // string | Filter by the deployment the id belongs to. (optional) 
            var deployedAfter = 2013-10-20T19:20:30+01:00;  // DateTime? | Filter by the deploy time of the deployment the process definition belongs to. Only selects process definitions that have been deployed after (exclusive) a specific time. By [default](https://docs.camunda.org/manual/7.15/reference/rest/overview/date-format/), the date must have the format `yyyy-MM-dd'T'HH:mm:ss.SSSZ`, e.g., `2013-01-23T14:42:45.546+0200`. (optional) 
            var deployedAt = 2013-10-20T19:20:30+01:00;  // DateTime? | Filter by the deploy time of the deployment the process definition belongs to. Only selects process definitions that have been deployed at a specific time (exact match). By [default](https://docs.camunda.org/manual/7.15/reference/rest/overview/date-format/), the date must have the format `yyyy-MM-dd'T'HH:mm:ss.SSSZ`, e.g., `2013-01-23T14:42:45.546+0200`. (optional) 
            var key = key_example;  // string | Filter by process definition key, i.e., the id in the BPMN 2.0 XML. Exact match. (optional) 
            var keysIn = keysIn_example;  // string | Filter by a comma-separated list of process definition keys. (optional) 
            var keyLike = keyLike_example;  // string | Filter by process definition keys that the parameter is a substring of. (optional) 
            var category = category_example;  // string | Filter by process definition category. Exact match. (optional) 
            var categoryLike = categoryLike_example;  // string | Filter by process definition categories that the parameter is a substring of. (optional) 
            var version = 56;  // int? | Filter by process definition version. (optional) 
            var latestVersion = true;  // bool? | Only include those process definitions that are latest versions. Value may only be `true`, as `false` is the default behavior. (optional) 
            var resourceName = resourceName_example;  // string | Filter by the name of the process definition resource. Exact match. (optional) 
            var resourceNameLike = resourceNameLike_example;  // string | Filter by names of those process definition resources that the parameter is a substring of. (optional) 
            var startableBy = startableBy_example;  // string | Filter by a user name who is allowed to start the process. (optional) 
            var active = true;  // bool? | Only include active process definitions. Value may only be `true`, as `false` is the default behavior. (optional) 
            var suspended = true;  // bool? | Only include suspended process definitions. Value may only be `true`, as `false` is the default behavior. (optional) 
            var incidentId = incidentId_example;  // string | Filter by the incident id. (optional) 
            var incidentType = incidentType_example;  // string | Filter by the incident type. See the [User Guide](https://docs.camunda.org/manual/7.15/user-guide/process-engine/incidents/#incident-types) for a list of incident types. (optional) 
            var incidentMessage = incidentMessage_example;  // string | Filter by the incident message. Exact match. (optional) 
            var incidentMessageLike = incidentMessageLike_example;  // string | Filter by the incident message that the parameter is a substring of. (optional) 
            var tenantIdIn = tenantIdIn_example;  // string | Filter by a comma-separated list of tenant ids. A process definition must have one of the given tenant ids. (optional) 
            var withoutTenantId = true;  // bool? | Only include process definitions which belong to no tenant. Value may only be true, as false is the default behavior. (optional) 
            var includeProcessDefinitionsWithoutTenantId = true;  // bool? | Include process definitions which belong to no tenant. Can be used in combination with `tenantIdIn`. Value may only be `true`, as `false` is the default behavior. (optional) 
            var versionTag = versionTag_example;  // string | Filter by the version tag. (optional) 
            var versionTagLike = versionTagLike_example;  // string | Filter by the version tag that the parameter is a substring of. (optional) 
            var withoutVersionTag = true;  // bool? | Only include process definitions without a `versionTag`. (optional) 
            var startableInTasklist = true;  // bool? | Filter by process definitions which are startable in Tasklist.. (optional) 
            var notStartableInTasklist = true;  // bool? | Filter by process definitions which are not startable in Tasklist. (optional) 
            var startablePermissionCheck = true;  // bool? | Filter by process definitions which the user is allowed to start in Tasklist. If the user doesn't have these permissions the result will be empty list. The permissions are: * `CREATE` permission for all Process instances * `CREATE_INSTANCE` and `READ` permission on Process definition level (optional) 
            var sortBy = sortBy_example;  // string | Sort the results lexicographically by a given criterion. Must be used in conjunction with the sortOrder parameter. (optional) 
            var sortOrder = sortOrder_example;  // string | Sort the results in a given order. Values may be asc for ascending order or desc for descending order. Must be used in conjunction with the sortBy parameter. (optional) 
            var firstResult = 56;  // int? | Pagination of results. Specifies the index of the first result to return. (optional) 
            var maxResults = 56;  // int? | Pagination of results. Specifies the maximum number of results to return. Will return less results if there are no more results left. (optional) 

            try
            {
                // Get List
                List<ProcessDefinitionDto> result = apiInstance.GetProcessDefinitions(processDefinitionId, processDefinitionIdIn, name, nameLike, deploymentId, deployedAfter, deployedAt, key, keysIn, keyLike, category, categoryLike, version, latestVersion, resourceName, resourceNameLike, startableBy, active, suspended, incidentId, incidentType, incidentMessage, incidentMessageLike, tenantIdIn, withoutTenantId, includeProcessDefinitionsWithoutTenantId, versionTag, versionTagLike, withoutVersionTag, startableInTasklist, notStartableInTasklist, startablePermissionCheck, sortBy, sortOrder, firstResult, maxResults);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProcessDefinitionApi.GetProcessDefinitions: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **processDefinitionId** | **string**| Filter by process definition id. | [optional] 
 **processDefinitionIdIn** | **string**| Filter by a comma-separated list of process definition ids. | [optional] 
 **name** | **string**| Filter by process definition name. | [optional] 
 **nameLike** | **string**| Filter by process definition names that the parameter is a substring of. | [optional] 
 **deploymentId** | **string**| Filter by the deployment the id belongs to. | [optional] 
 **deployedAfter** | **DateTime?**| Filter by the deploy time of the deployment the process definition belongs to. Only selects process definitions that have been deployed after (exclusive) a specific time. By [default](https://docs.camunda.org/manual/7.15/reference/rest/overview/date-format/), the date must have the format &#x60;yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ&#x60;, e.g., &#x60;2013-01-23T14:42:45.546+0200&#x60;. | [optional] 
 **deployedAt** | **DateTime?**| Filter by the deploy time of the deployment the process definition belongs to. Only selects process definitions that have been deployed at a specific time (exact match). By [default](https://docs.camunda.org/manual/7.15/reference/rest/overview/date-format/), the date must have the format &#x60;yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ&#x60;, e.g., &#x60;2013-01-23T14:42:45.546+0200&#x60;. | [optional] 
 **key** | **string**| Filter by process definition key, i.e., the id in the BPMN 2.0 XML. Exact match. | [optional] 
 **keysIn** | **string**| Filter by a comma-separated list of process definition keys. | [optional] 
 **keyLike** | **string**| Filter by process definition keys that the parameter is a substring of. | [optional] 
 **category** | **string**| Filter by process definition category. Exact match. | [optional] 
 **categoryLike** | **string**| Filter by process definition categories that the parameter is a substring of. | [optional] 
 **version** | **int?**| Filter by process definition version. | [optional] 
 **latestVersion** | **bool?**| Only include those process definitions that are latest versions. Value may only be &#x60;true&#x60;, as &#x60;false&#x60; is the default behavior. | [optional] 
 **resourceName** | **string**| Filter by the name of the process definition resource. Exact match. | [optional] 
 **resourceNameLike** | **string**| Filter by names of those process definition resources that the parameter is a substring of. | [optional] 
 **startableBy** | **string**| Filter by a user name who is allowed to start the process. | [optional] 
 **active** | **bool?**| Only include active process definitions. Value may only be &#x60;true&#x60;, as &#x60;false&#x60; is the default behavior. | [optional] 
 **suspended** | **bool?**| Only include suspended process definitions. Value may only be &#x60;true&#x60;, as &#x60;false&#x60; is the default behavior. | [optional] 
 **incidentId** | **string**| Filter by the incident id. | [optional] 
 **incidentType** | **string**| Filter by the incident type. See the [User Guide](https://docs.camunda.org/manual/7.15/user-guide/process-engine/incidents/#incident-types) for a list of incident types. | [optional] 
 **incidentMessage** | **string**| Filter by the incident message. Exact match. | [optional] 
 **incidentMessageLike** | **string**| Filter by the incident message that the parameter is a substring of. | [optional] 
 **tenantIdIn** | **string**| Filter by a comma-separated list of tenant ids. A process definition must have one of the given tenant ids. | [optional] 
 **withoutTenantId** | **bool?**| Only include process definitions which belong to no tenant. Value may only be true, as false is the default behavior. | [optional] 
 **includeProcessDefinitionsWithoutTenantId** | **bool?**| Include process definitions which belong to no tenant. Can be used in combination with &#x60;tenantIdIn&#x60;. Value may only be &#x60;true&#x60;, as &#x60;false&#x60; is the default behavior. | [optional] 
 **versionTag** | **string**| Filter by the version tag. | [optional] 
 **versionTagLike** | **string**| Filter by the version tag that the parameter is a substring of. | [optional] 
 **withoutVersionTag** | **bool?**| Only include process definitions without a &#x60;versionTag&#x60;. | [optional] 
 **startableInTasklist** | **bool?**| Filter by process definitions which are startable in Tasklist.. | [optional] 
 **notStartableInTasklist** | **bool?**| Filter by process definitions which are not startable in Tasklist. | [optional] 
 **startablePermissionCheck** | **bool?**| Filter by process definitions which the user is allowed to start in Tasklist. If the user doesn&#39;t have these permissions the result will be empty list. The permissions are: * &#x60;CREATE&#x60; permission for all Process instances * &#x60;CREATE_INSTANCE&#x60; and &#x60;READ&#x60; permission on Process definition level | [optional] 
 **sortBy** | **string**| Sort the results lexicographically by a given criterion. Must be used in conjunction with the sortOrder parameter. | [optional] 
 **sortOrder** | **string**| Sort the results in a given order. Values may be asc for ascending order or desc for descending order. Must be used in conjunction with the sortBy parameter. | [optional] 
 **firstResult** | **int?**| Pagination of results. Specifies the index of the first result to return. | [optional] 
 **maxResults** | **int?**| Pagination of results. Specifies the maximum number of results to return. Will return less results if there are no more results left. | [optional] 

### Return type

[**List&lt;ProcessDefinitionDto&gt;**](ProcessDefinitionDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Request successful. |  -  |
| **400** | Returned if some of the query parameters are invalid, for example if a &#x60;sortOrder&#x60; parameter is supplied, but no &#x60;sortBy&#x60;. See the [Introduction](https://docs.camunda.org/manual/7.15/reference/rest/overview/#error-handling) for the error response format. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getprocessdefinitionscount"></a>
# **GetProcessDefinitionsCount**
> CountResultDto GetProcessDefinitionsCount (string processDefinitionId = null, string processDefinitionIdIn = null, string name = null, string nameLike = null, string deploymentId = null, DateTime? deployedAfter = null, DateTime? deployedAt = null, string key = null, string keysIn = null, string keyLike = null, string category = null, string categoryLike = null, int? version = null, bool? latestVersion = null, string resourceName = null, string resourceNameLike = null, string startableBy = null, bool? active = null, bool? suspended = null, string incidentId = null, string incidentType = null, string incidentMessage = null, string incidentMessageLike = null, string tenantIdIn = null, bool? withoutTenantId = null, bool? includeProcessDefinitionsWithoutTenantId = null, string versionTag = null, string versionTagLike = null, bool? withoutVersionTag = null, bool? startableInTasklist = null, bool? notStartableInTasklist = null, bool? startablePermissionCheck = null)

Get List Count

Requests the number of process definitions that fulfill the query criteria. Takes the same filtering parameters as the [Get Definitions](https://docs.camunda.org/manual/7.15/reference/rest/process-definition/get-query/) method.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Camunda.OpenApi.Client.Api;
using Camunda.OpenApi.Client.Client;
using Camunda.OpenApi.Client.Model;

namespace Example
{
    public class GetProcessDefinitionsCountExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/engine-rest";
            var apiInstance = new ProcessDefinitionApi(config);
            var processDefinitionId = processDefinitionId_example;  // string | Filter by process definition id. (optional) 
            var processDefinitionIdIn = processDefinitionIdIn_example;  // string | Filter by a comma-separated list of process definition ids. (optional) 
            var name = name_example;  // string | Filter by process definition name. (optional) 
            var nameLike = nameLike_example;  // string | Filter by process definition names that the parameter is a substring of. (optional) 
            var deploymentId = deploymentId_example;  // string | Filter by the deployment the id belongs to. (optional) 
            var deployedAfter = 2013-10-20T19:20:30+01:00;  // DateTime? | Filter by the deploy time of the deployment the process definition belongs to. Only selects process definitions that have been deployed after (exclusive) a specific time. By [default](https://docs.camunda.org/manual/7.15/reference/rest/overview/date-format/), the date must have the format `yyyy-MM-dd'T'HH:mm:ss.SSSZ`, e.g., `2013-01-23T14:42:45.546+0200`. (optional) 
            var deployedAt = 2013-10-20T19:20:30+01:00;  // DateTime? | Filter by the deploy time of the deployment the process definition belongs to. Only selects process definitions that have been deployed at a specific time (exact match). By [default](https://docs.camunda.org/manual/7.15/reference/rest/overview/date-format/), the date must have the format `yyyy-MM-dd'T'HH:mm:ss.SSSZ`, e.g., `2013-01-23T14:42:45.546+0200`. (optional) 
            var key = key_example;  // string | Filter by process definition key, i.e., the id in the BPMN 2.0 XML. Exact match. (optional) 
            var keysIn = keysIn_example;  // string | Filter by a comma-separated list of process definition keys. (optional) 
            var keyLike = keyLike_example;  // string | Filter by process definition keys that the parameter is a substring of. (optional) 
            var category = category_example;  // string | Filter by process definition category. Exact match. (optional) 
            var categoryLike = categoryLike_example;  // string | Filter by process definition categories that the parameter is a substring of. (optional) 
            var version = 56;  // int? | Filter by process definition version. (optional) 
            var latestVersion = true;  // bool? | Only include those process definitions that are latest versions. Value may only be `true`, as `false` is the default behavior. (optional) 
            var resourceName = resourceName_example;  // string | Filter by the name of the process definition resource. Exact match. (optional) 
            var resourceNameLike = resourceNameLike_example;  // string | Filter by names of those process definition resources that the parameter is a substring of. (optional) 
            var startableBy = startableBy_example;  // string | Filter by a user name who is allowed to start the process. (optional) 
            var active = true;  // bool? | Only include active process definitions. Value may only be `true`, as `false` is the default behavior. (optional) 
            var suspended = true;  // bool? | Only include suspended process definitions. Value may only be `true`, as `false` is the default behavior. (optional) 
            var incidentId = incidentId_example;  // string | Filter by the incident id. (optional) 
            var incidentType = incidentType_example;  // string | Filter by the incident type. See the [User Guide](https://docs.camunda.org/manual/7.15/user-guide/process-engine/incidents/#incident-types) for a list of incident types. (optional) 
            var incidentMessage = incidentMessage_example;  // string | Filter by the incident message. Exact match. (optional) 
            var incidentMessageLike = incidentMessageLike_example;  // string | Filter by the incident message that the parameter is a substring of. (optional) 
            var tenantIdIn = tenantIdIn_example;  // string | Filter by a comma-separated list of tenant ids. A process definition must have one of the given tenant ids. (optional) 
            var withoutTenantId = true;  // bool? | Only include process definitions which belong to no tenant. Value may only be true, as false is the default behavior. (optional) 
            var includeProcessDefinitionsWithoutTenantId = true;  // bool? | Include process definitions which belong to no tenant. Can be used in combination with `tenantIdIn`. Value may only be `true`, as `false` is the default behavior. (optional) 
            var versionTag = versionTag_example;  // string | Filter by the version tag. (optional) 
            var versionTagLike = versionTagLike_example;  // string | Filter by the version tag that the parameter is a substring of. (optional) 
            var withoutVersionTag = true;  // bool? | Only include process definitions without a `versionTag`. (optional) 
            var startableInTasklist = true;  // bool? | Filter by process definitions which are startable in Tasklist.. (optional) 
            var notStartableInTasklist = true;  // bool? | Filter by process definitions which are not startable in Tasklist. (optional) 
            var startablePermissionCheck = true;  // bool? | Filter by process definitions which the user is allowed to start in Tasklist. If the user doesn't have these permissions the result will be empty list. The permissions are: * `CREATE` permission for all Process instances * `CREATE_INSTANCE` and `READ` permission on Process definition level (optional) 

            try
            {
                // Get List Count
                CountResultDto result = apiInstance.GetProcessDefinitionsCount(processDefinitionId, processDefinitionIdIn, name, nameLike, deploymentId, deployedAfter, deployedAt, key, keysIn, keyLike, category, categoryLike, version, latestVersion, resourceName, resourceNameLike, startableBy, active, suspended, incidentId, incidentType, incidentMessage, incidentMessageLike, tenantIdIn, withoutTenantId, includeProcessDefinitionsWithoutTenantId, versionTag, versionTagLike, withoutVersionTag, startableInTasklist, notStartableInTasklist, startablePermissionCheck);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProcessDefinitionApi.GetProcessDefinitionsCount: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **processDefinitionId** | **string**| Filter by process definition id. | [optional] 
 **processDefinitionIdIn** | **string**| Filter by a comma-separated list of process definition ids. | [optional] 
 **name** | **string**| Filter by process definition name. | [optional] 
 **nameLike** | **string**| Filter by process definition names that the parameter is a substring of. | [optional] 
 **deploymentId** | **string**| Filter by the deployment the id belongs to. | [optional] 
 **deployedAfter** | **DateTime?**| Filter by the deploy time of the deployment the process definition belongs to. Only selects process definitions that have been deployed after (exclusive) a specific time. By [default](https://docs.camunda.org/manual/7.15/reference/rest/overview/date-format/), the date must have the format &#x60;yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ&#x60;, e.g., &#x60;2013-01-23T14:42:45.546+0200&#x60;. | [optional] 
 **deployedAt** | **DateTime?**| Filter by the deploy time of the deployment the process definition belongs to. Only selects process definitions that have been deployed at a specific time (exact match). By [default](https://docs.camunda.org/manual/7.15/reference/rest/overview/date-format/), the date must have the format &#x60;yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ&#x60;, e.g., &#x60;2013-01-23T14:42:45.546+0200&#x60;. | [optional] 
 **key** | **string**| Filter by process definition key, i.e., the id in the BPMN 2.0 XML. Exact match. | [optional] 
 **keysIn** | **string**| Filter by a comma-separated list of process definition keys. | [optional] 
 **keyLike** | **string**| Filter by process definition keys that the parameter is a substring of. | [optional] 
 **category** | **string**| Filter by process definition category. Exact match. | [optional] 
 **categoryLike** | **string**| Filter by process definition categories that the parameter is a substring of. | [optional] 
 **version** | **int?**| Filter by process definition version. | [optional] 
 **latestVersion** | **bool?**| Only include those process definitions that are latest versions. Value may only be &#x60;true&#x60;, as &#x60;false&#x60; is the default behavior. | [optional] 
 **resourceName** | **string**| Filter by the name of the process definition resource. Exact match. | [optional] 
 **resourceNameLike** | **string**| Filter by names of those process definition resources that the parameter is a substring of. | [optional] 
 **startableBy** | **string**| Filter by a user name who is allowed to start the process. | [optional] 
 **active** | **bool?**| Only include active process definitions. Value may only be &#x60;true&#x60;, as &#x60;false&#x60; is the default behavior. | [optional] 
 **suspended** | **bool?**| Only include suspended process definitions. Value may only be &#x60;true&#x60;, as &#x60;false&#x60; is the default behavior. | [optional] 
 **incidentId** | **string**| Filter by the incident id. | [optional] 
 **incidentType** | **string**| Filter by the incident type. See the [User Guide](https://docs.camunda.org/manual/7.15/user-guide/process-engine/incidents/#incident-types) for a list of incident types. | [optional] 
 **incidentMessage** | **string**| Filter by the incident message. Exact match. | [optional] 
 **incidentMessageLike** | **string**| Filter by the incident message that the parameter is a substring of. | [optional] 
 **tenantIdIn** | **string**| Filter by a comma-separated list of tenant ids. A process definition must have one of the given tenant ids. | [optional] 
 **withoutTenantId** | **bool?**| Only include process definitions which belong to no tenant. Value may only be true, as false is the default behavior. | [optional] 
 **includeProcessDefinitionsWithoutTenantId** | **bool?**| Include process definitions which belong to no tenant. Can be used in combination with &#x60;tenantIdIn&#x60;. Value may only be &#x60;true&#x60;, as &#x60;false&#x60; is the default behavior. | [optional] 
 **versionTag** | **string**| Filter by the version tag. | [optional] 
 **versionTagLike** | **string**| Filter by the version tag that the parameter is a substring of. | [optional] 
 **withoutVersionTag** | **bool?**| Only include process definitions without a &#x60;versionTag&#x60;. | [optional] 
 **startableInTasklist** | **bool?**| Filter by process definitions which are startable in Tasklist.. | [optional] 
 **notStartableInTasklist** | **bool?**| Filter by process definitions which are not startable in Tasklist. | [optional] 
 **startablePermissionCheck** | **bool?**| Filter by process definitions which the user is allowed to start in Tasklist. If the user doesn&#39;t have these permissions the result will be empty list. The permissions are: * &#x60;CREATE&#x60; permission for all Process instances * &#x60;CREATE_INSTANCE&#x60; and &#x60;READ&#x60; permission on Process definition level | [optional] 

### Return type

[**CountResultDto**](CountResultDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Request successful. |  -  |
| **400** | Returned if some of the query parameters are invalid. See the [Introduction](https://docs.camunda.org/manual/7.15/reference/rest/overview/#error-handling) for the error response format. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getrenderedstartform"></a>
# **GetRenderedStartForm**
> System.IO.Stream GetRenderedStartForm (string id)

Get Rendered Start Form

Retrieves the rendered form for a process definition. This method can be used to get the HTML rendering of a [Generated Task Form](https://docs.camunda.org/manual/7.15/user-guide/task-forms/#generated-task-forms).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Camunda.OpenApi.Client.Api;
using Camunda.OpenApi.Client.Client;
using Camunda.OpenApi.Client.Model;

namespace Example
{
    public class GetRenderedStartFormExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/engine-rest";
            var apiInstance = new ProcessDefinitionApi(config);
            var id = id_example;  // string | The id of the process definition to get the rendered start form for.

            try
            {
                // Get Rendered Start Form
                System.IO.Stream result = apiInstance.GetRenderedStartForm(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProcessDefinitionApi.GetRenderedStartForm: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The id of the process definition to get the rendered start form for. | 

### Return type

**System.IO.Stream**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/xhtml+xml, application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Request successful. |  -  |
| **400** | Process definition has no form field metadata defined. See the [Introduction](https://docs.camunda.org/manual/7.15/reference/rest/overview/#error-handling) for the error response format. |  -  |
| **404** | Process definition with given id does not exist.  See the [Introduction](https://docs.camunda.org/manual/7.15/reference/rest/overview/#error-handling) for the error response format. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getrenderedstartformbykey"></a>
# **GetRenderedStartFormByKey**
> System.IO.Stream GetRenderedStartFormByKey (string key)

Get Rendered Start Form

Retrieves  the rendered form for the latest version of the process definition which belongs to no tenant. This method can be used to get the HTML rendering of a [Generated Task Form](https://docs.camunda.org/manual/7.15/user-guide/task-forms/#generated-task-forms).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Camunda.OpenApi.Client.Api;
using Camunda.OpenApi.Client.Client;
using Camunda.OpenApi.Client.Model;

namespace Example
{
    public class GetRenderedStartFormByKeyExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/engine-rest";
            var apiInstance = new ProcessDefinitionApi(config);
            var key = key_example;  // string | The key of the process definition (the latest version thereof) to be retrieved.

            try
            {
                // Get Rendered Start Form
                System.IO.Stream result = apiInstance.GetRenderedStartFormByKey(key);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProcessDefinitionApi.GetRenderedStartFormByKey: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **key** | **string**| The key of the process definition (the latest version thereof) to be retrieved. | 

### Return type

**System.IO.Stream**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/xhtml+xml, application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Request successful. |  -  |
| **400** | Process definition has no form field metadata defined. See the [Introduction](https://docs.camunda.org/manual/7.15/reference/rest/overview/#error-handling) for the error response format. |  -  |
| **404** | Process definition with given key does not exist.  See the [Introduction](https://docs.camunda.org/manual/7.15/reference/rest/overview/#error-handling) for the error response format. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getrenderedstartformbykeyandtenantid"></a>
# **GetRenderedStartFormByKeyAndTenantId**
> System.IO.Stream GetRenderedStartFormByKeyAndTenantId (string key, string tenantId)

Get Rendered Start Form

Retrieves  the rendered form for the latest version of the process definition for a tenant. This method can be used to get the HTML rendering of a [Generated Task Form](https://docs.camunda.org/manual/7.15/user-guide/task-forms/#generated-task-forms).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Camunda.OpenApi.Client.Api;
using Camunda.OpenApi.Client.Client;
using Camunda.OpenApi.Client.Model;

namespace Example
{
    public class GetRenderedStartFormByKeyAndTenantIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/engine-rest";
            var apiInstance = new ProcessDefinitionApi(config);
            var key = key_example;  // string | The key of the process definition (the latest version thereof) to be retrieved.
            var tenantId = tenantId_example;  // string | The id of the tenant the process definition belongs to.

            try
            {
                // Get Rendered Start Form
                System.IO.Stream result = apiInstance.GetRenderedStartFormByKeyAndTenantId(key, tenantId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProcessDefinitionApi.GetRenderedStartFormByKeyAndTenantId: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **key** | **string**| The key of the process definition (the latest version thereof) to be retrieved. | 
 **tenantId** | **string**| The id of the tenant the process definition belongs to. | 

### Return type

**System.IO.Stream**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/xhtml+xml, application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Request successful. |  -  |
| **400** | Process definition has no form field metadata defined. See the [Introduction](https://docs.camunda.org/manual/7.15/reference/rest/overview/#error-handling) for the error response format. |  -  |
| **404** | Process definition with given key does not exist.  See the [Introduction](https://docs.camunda.org/manual/7.15/reference/rest/overview/#error-handling) for the error response format. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getstartform"></a>
# **GetStartForm**
> FormDto GetStartForm (string id)

Get Start Form Key

Retrieves the key of the start form for a process definition. The form key corresponds to the `FormData#formKey` property in the engine.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Camunda.OpenApi.Client.Api;
using Camunda.OpenApi.Client.Client;
using Camunda.OpenApi.Client.Model;

namespace Example
{
    public class GetStartFormExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/engine-rest";
            var apiInstance = new ProcessDefinitionApi(config);
            var id = id_example;  // string | The id of the process definition to get the start form key for.

            try
            {
                // Get Start Form Key
                FormDto result = apiInstance.GetStartForm(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProcessDefinitionApi.GetStartForm: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The id of the process definition to get the start form key for. | 

### Return type

[**FormDto**](FormDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Request successful. |  -  |
| **400** | Process definition has no start form defined. See the [Introduction](https://docs.camunda.org/manual/7.15/reference/rest/overview/#error-handling) for the error response format. |  -  |
| **404** | Process definition with given id does not exist.  See the [Introduction](https://docs.camunda.org/manual/7.15/reference/rest/overview/#error-handling) for the error response format. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getstartformbykey"></a>
# **GetStartFormByKey**
> FormDto GetStartFormByKey (string key)

Get Start Form Key

Retrieves the key of the start form for the latest version of the process definition which belongs to no tenant. The form key corresponds to the `FormData#formKey` property in the engine.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Camunda.OpenApi.Client.Api;
using Camunda.OpenApi.Client.Client;
using Camunda.OpenApi.Client.Model;

namespace Example
{
    public class GetStartFormByKeyExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/engine-rest";
            var apiInstance = new ProcessDefinitionApi(config);
            var key = key_example;  // string | The key of the process definition (the latest version thereof) for which the form key is to be retrieved.

            try
            {
                // Get Start Form Key
                FormDto result = apiInstance.GetStartFormByKey(key);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProcessDefinitionApi.GetStartFormByKey: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **key** | **string**| The key of the process definition (the latest version thereof) for which the form key is to be retrieved. | 

### Return type

[**FormDto**](FormDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Request successful. |  -  |
| **400** | Process definition has no start form defined. See the [Introduction](https://docs.camunda.org/manual/7.15/reference/rest/overview/#error-handling) for the error response format. |  -  |
| **404** | Process definition with given key does not exist. See the [Introduction](https://docs.camunda.org/manual/7.15/reference/rest/overview/#error-handling) for the error response format. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getstartformbykeyandtenantid"></a>
# **GetStartFormByKeyAndTenantId**
> FormDto GetStartFormByKeyAndTenantId (string key, string tenantId)

Get Start Form Key

Retrieves the key of the start form for the latest version of the process definition for a tenant. The form key corresponds to the `FormData#formKey` property in the engine.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Camunda.OpenApi.Client.Api;
using Camunda.OpenApi.Client.Client;
using Camunda.OpenApi.Client.Model;

namespace Example
{
    public class GetStartFormByKeyAndTenantIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/engine-rest";
            var apiInstance = new ProcessDefinitionApi(config);
            var key = key_example;  // string | The key of the process definition (the latest version thereof) for which the form key is to be retrieved.
            var tenantId = tenantId_example;  // string | The id of the tenant the process definition belongs to.

            try
            {
                // Get Start Form Key
                FormDto result = apiInstance.GetStartFormByKeyAndTenantId(key, tenantId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProcessDefinitionApi.GetStartFormByKeyAndTenantId: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **key** | **string**| The key of the process definition (the latest version thereof) for which the form key is to be retrieved. | 
 **tenantId** | **string**| The id of the tenant the process definition belongs to. | 

### Return type

[**FormDto**](FormDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Request successful. |  -  |
| **400** | Process definition has no start form defined. See the [Introduction](https://docs.camunda.org/manual/7.15/reference/rest/overview/#error-handling) for the error response format. |  -  |
| **404** | Process definition with given key does not exist. See the [Introduction](https://docs.camunda.org/manual/7.15/reference/rest/overview/#error-handling) for the error response format. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getstartformvariables"></a>
# **GetStartFormVariables**
> Dictionary&lt;string, VariableValueDto&gt; GetStartFormVariables (string id, string variableNames = null, bool? deserializeValues = null)

Get Start Form Variables

Retrieves the start form variables for a process definition (only if they are defined via the  [Generated Task Form](https://docs.camunda.org/manual/7.15/user-guide/task-forms/#generated-task-forms) approach). The start form variables take form data specified on the start event into account. If form fields are defined, the variable types and default values of the form fields are taken into account.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Camunda.OpenApi.Client.Api;
using Camunda.OpenApi.Client.Client;
using Camunda.OpenApi.Client.Model;

namespace Example
{
    public class GetStartFormVariablesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/engine-rest";
            var apiInstance = new ProcessDefinitionApi(config);
            var id = id_example;  // string | The id of the process definition to retrieve the variables for.
            var variableNames = variableNames_example;  // string | A comma-separated list of variable names. Allows restricting the list of requested variables to the variable names in the list. It is best practice to restrict the list of variables to the variables actually required by the form in order to minimize fetching of data. If the query parameter is ommitted all variables are fetched. If the query parameter contains non-existent variable names, the variable names are ignored. (optional) 
            var deserializeValues = true;  // bool? | Determines whether serializable variable values (typically variables that store custom Java objects) should be deserialized on server side (default true).  If set to true, a serializable variable will be deserialized on server side and transformed to JSON using [Jackson's](http://jackson.codehaus.org/) POJO/bean property introspection feature. Note that this requires the Java classes of the variable value to be on the REST API's classpath.  If set to false, a serializable variable will be returned in its serialized format. For example, a variable that is serialized as XML will be returned as a JSON string containing XML.  **Note**: While true is the default value for reasons of backward compatibility, we recommend setting this parameter to false when developing web applications that are independent of the Java process applications deployed to the engine. (optional)  (default to true)

            try
            {
                // Get Start Form Variables
                Dictionary<string, VariableValueDto> result = apiInstance.GetStartFormVariables(id, variableNames, deserializeValues);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProcessDefinitionApi.GetStartFormVariables: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The id of the process definition to retrieve the variables for. | 
 **variableNames** | **string**| A comma-separated list of variable names. Allows restricting the list of requested variables to the variable names in the list. It is best practice to restrict the list of variables to the variables actually required by the form in order to minimize fetching of data. If the query parameter is ommitted all variables are fetched. If the query parameter contains non-existent variable names, the variable names are ignored. | [optional] 
 **deserializeValues** | **bool?**| Determines whether serializable variable values (typically variables that store custom Java objects) should be deserialized on server side (default true).  If set to true, a serializable variable will be deserialized on server side and transformed to JSON using [Jackson&#39;s](http://jackson.codehaus.org/) POJO/bean property introspection feature. Note that this requires the Java classes of the variable value to be on the REST API&#39;s classpath.  If set to false, a serializable variable will be returned in its serialized format. For example, a variable that is serialized as XML will be returned as a JSON string containing XML.  **Note**: While true is the default value for reasons of backward compatibility, we recommend setting this parameter to false when developing web applications that are independent of the Java process applications deployed to the engine. | [optional] [default to true]

### Return type

[**Dictionary&lt;string, VariableValueDto&gt;**](VariableValueDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Request successful. A JSON object containing a property for each variable returned. |  -  |
| **404** | The id is null or does not exist. See the [Introduction](https://docs.camunda.org/manual/7.15/reference/rest/overview/#error-handling) for the error response format. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getstartformvariablesbykey"></a>
# **GetStartFormVariablesByKey**
> Dictionary&lt;string, VariableValueDto&gt; GetStartFormVariablesByKey (string key, string variableNames = null, bool? deserializeValues = null)

Get Start Form Variables

Retrieves the start form variables for the latest process definition which belongs to no tenant (only if they are defined via the  [Generated Task Form](https://docs.camunda.org/manual/7.15/user-guide/task-forms/#generated-task-forms) approach). The start form variables take form data specified on the start event into account. If form fields are defined, the variable types and default values of the form fields are taken into account.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Camunda.OpenApi.Client.Api;
using Camunda.OpenApi.Client.Client;
using Camunda.OpenApi.Client.Model;

namespace Example
{
    public class GetStartFormVariablesByKeyExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/engine-rest";
            var apiInstance = new ProcessDefinitionApi(config);
            var key = key_example;  // string | The key of the process definition (the latest version thereof) to be retrieved.
            var variableNames = variableNames_example;  // string | A comma-separated list of variable names. Allows restricting the list of requested variables to the variable names in the list. It is best practice to restrict the list of variables to the variables actually required by the form in order to minimize fetching of data. If the query parameter is ommitted all variables are fetched. If the query parameter contains non-existent variable names, the variable names are ignored. (optional) 
            var deserializeValues = true;  // bool? | Determines whether serializable variable values (typically variables that store custom Java objects) should be deserialized on server side (default true).  If set to true, a serializable variable will be deserialized on server side and transformed to JSON using [Jackson's](http://jackson.codehaus.org/) POJO/bean property introspection feature. Note that this requires the Java classes of the variable value to be on the REST API's classpath.  If set to false, a serializable variable will be returned in its serialized format. For example, a variable that is serialized as XML will be returned as a JSON string containing XML.  **Note**: While true is the default value for reasons of backward compatibility, we recommend setting this parameter to false when developing web applications that are independent of the Java process applications deployed to the engine. (optional)  (default to true)

            try
            {
                // Get Start Form Variables
                Dictionary<string, VariableValueDto> result = apiInstance.GetStartFormVariablesByKey(key, variableNames, deserializeValues);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProcessDefinitionApi.GetStartFormVariablesByKey: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **key** | **string**| The key of the process definition (the latest version thereof) to be retrieved. | 
 **variableNames** | **string**| A comma-separated list of variable names. Allows restricting the list of requested variables to the variable names in the list. It is best practice to restrict the list of variables to the variables actually required by the form in order to minimize fetching of data. If the query parameter is ommitted all variables are fetched. If the query parameter contains non-existent variable names, the variable names are ignored. | [optional] 
 **deserializeValues** | **bool?**| Determines whether serializable variable values (typically variables that store custom Java objects) should be deserialized on server side (default true).  If set to true, a serializable variable will be deserialized on server side and transformed to JSON using [Jackson&#39;s](http://jackson.codehaus.org/) POJO/bean property introspection feature. Note that this requires the Java classes of the variable value to be on the REST API&#39;s classpath.  If set to false, a serializable variable will be returned in its serialized format. For example, a variable that is serialized as XML will be returned as a JSON string containing XML.  **Note**: While true is the default value for reasons of backward compatibility, we recommend setting this parameter to false when developing web applications that are independent of the Java process applications deployed to the engine. | [optional] [default to true]

### Return type

[**Dictionary&lt;string, VariableValueDto&gt;**](VariableValueDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Request successful. A JSON object containing a property for each variable returned. |  -  |
| **404** | The key is null or does not exist. See the [Introduction](https://docs.camunda.org/manual/7.15/reference/rest/overview/#error-handling) for the error response format. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getstartformvariablesbykeyandtenantid"></a>
# **GetStartFormVariablesByKeyAndTenantId**
> Dictionary&lt;string, VariableValueDto&gt; GetStartFormVariablesByKeyAndTenantId (string key, string tenantId, string variableNames = null, bool? deserializeValues = null)

Get Start Form Variables

Retrieves the start form variables for the latest process definition for a tenant (only if they are defined via the  [Generated Task Form](https://docs.camunda.org/manual/7.15/user-guide/task-forms/#generated-task-forms) approach). The start form variables take form data specified on the start event into account. If form fields are defined, the variable types and default values of the form fields are taken into account.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Camunda.OpenApi.Client.Api;
using Camunda.OpenApi.Client.Client;
using Camunda.OpenApi.Client.Model;

namespace Example
{
    public class GetStartFormVariablesByKeyAndTenantIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/engine-rest";
            var apiInstance = new ProcessDefinitionApi(config);
            var key = key_example;  // string | The key of the process definition (the latest version thereof) to be retrieved.
            var tenantId = tenantId_example;  // string | The id of the tenant the process definition belongs to.
            var variableNames = variableNames_example;  // string | A comma-separated list of variable names. Allows restricting the list of requested variables to the variable names in the list. It is best practice to restrict the list of variables to the variables actually required by the form in order to minimize fetching of data. If the query parameter is ommitted all variables are fetched. If the query parameter contains non-existent variable names, the variable names are ignored. (optional) 
            var deserializeValues = true;  // bool? | Determines whether serializable variable values (typically variables that store custom Java objects) should be deserialized on server side (default true).  If set to true, a serializable variable will be deserialized on server side and transformed to JSON using [Jackson's](http://jackson.codehaus.org/) POJO/bean property introspection feature. Note that this requires the Java classes of the variable value to be on the REST API's classpath.  If set to false, a serializable variable will be returned in its serialized format. For example, a variable that is serialized as XML will be returned as a JSON string containing XML.  **Note**: While true is the default value for reasons of backward compatibility, we recommend setting this parameter to false when developing web applications that are independent of the Java process applications deployed to the engine. (optional)  (default to true)

            try
            {
                // Get Start Form Variables
                Dictionary<string, VariableValueDto> result = apiInstance.GetStartFormVariablesByKeyAndTenantId(key, tenantId, variableNames, deserializeValues);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProcessDefinitionApi.GetStartFormVariablesByKeyAndTenantId: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **key** | **string**| The key of the process definition (the latest version thereof) to be retrieved. | 
 **tenantId** | **string**| The id of the tenant the process definition belongs to. | 
 **variableNames** | **string**| A comma-separated list of variable names. Allows restricting the list of requested variables to the variable names in the list. It is best practice to restrict the list of variables to the variables actually required by the form in order to minimize fetching of data. If the query parameter is ommitted all variables are fetched. If the query parameter contains non-existent variable names, the variable names are ignored. | [optional] 
 **deserializeValues** | **bool?**| Determines whether serializable variable values (typically variables that store custom Java objects) should be deserialized on server side (default true).  If set to true, a serializable variable will be deserialized on server side and transformed to JSON using [Jackson&#39;s](http://jackson.codehaus.org/) POJO/bean property introspection feature. Note that this requires the Java classes of the variable value to be on the REST API&#39;s classpath.  If set to false, a serializable variable will be returned in its serialized format. For example, a variable that is serialized as XML will be returned as a JSON string containing XML.  **Note**: While true is the default value for reasons of backward compatibility, we recommend setting this parameter to false when developing web applications that are independent of the Java process applications deployed to the engine. | [optional] [default to true]

### Return type

[**Dictionary&lt;string, VariableValueDto&gt;**](VariableValueDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Request successful. A JSON object containing a property for each variable returned. |  -  |
| **404** | The key is null or does not exist. See the [Introduction](https://docs.camunda.org/manual/7.15/reference/rest/overview/#error-handling) for the error response format. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="restartprocessinstance"></a>
# **RestartProcessInstance**
> void RestartProcessInstance (string id, RestartProcessInstanceDto restartProcessInstanceDto = null)

Restart Process Instance

Restarts process instances that were canceled or terminated synchronously. Can also restart completed process instances. It will create a new instance using the original instance information. To execute the restart asynchronously, use the [Restart Process Instance Async](https://docs.camunda.org/manual/7.15/reference/rest/process-definition/post-restart-process-instance-async/) method.  For more information about the difference between synchronous and asynchronous execution, please refer to the related section of the [User Guide](https://docs.camunda.org/manual/7.15/user-guide/process-engine/process-instance-restart/#execution).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Camunda.OpenApi.Client.Api;
using Camunda.OpenApi.Client.Client;
using Camunda.OpenApi.Client.Model;

namespace Example
{
    public class RestartProcessInstanceExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/engine-rest";
            var apiInstance = new ProcessDefinitionApi(config);
            var id = id_example;  // string | The id of the process definition of the process instances to restart.
            var restartProcessInstanceDto = new RestartProcessInstanceDto(); // RestartProcessInstanceDto |  (optional) 

            try
            {
                // Restart Process Instance
                apiInstance.RestartProcessInstance(id, restartProcessInstanceDto);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProcessDefinitionApi.RestartProcessInstance: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The id of the process definition of the process instances to restart. | 
 **restartProcessInstanceDto** | [**RestartProcessInstanceDto**](RestartProcessInstanceDto.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | Request successful. |  -  |
| **400** | In case following parameters are missing: &#x60;instructions&#x60;, &#x60;activityId&#x60; or &#x60;transitionId&#x60;, &#x60;processInstanceIds&#x60; or &#x60;historicProcessInstanceQuery&#x60;, an exception of type &#x60;InvalidRequestException&#x60; is returned.  See the [Introduction](https://docs.camunda.org/manual/7.15/reference/rest/overview/#error-handling) for the error response format. |  -  |
| **404** | Process definition with given id does not exist. See the [Introduction](https://docs.camunda.org/manual/7.15/reference/rest/overview/#error-handling) for the error response format. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="restartprocessinstanceasyncoperation"></a>
# **RestartProcessInstanceAsyncOperation**
> BatchDto RestartProcessInstanceAsyncOperation (string id, RestartProcessInstanceDto restartProcessInstanceDto = null)

Restart Process Instance Async

Restarts process instances that were canceled or terminated asynchronously. Can also restart completed process instances. It will create a new instance using the original instance information. To execute the restart asynchronously, use the [Restart Process Instance](https://docs.camunda.org/manual/7.15/reference/rest/process-definition/post-restart-process-instance-sync/) method.  For more information about the difference between synchronous and asynchronous execution, please refer to the related section of the [User Guide](https://docs.camunda.org/manual/7.15/user-guide/process-engine/process-instance-restart/#execution).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Camunda.OpenApi.Client.Api;
using Camunda.OpenApi.Client.Client;
using Camunda.OpenApi.Client.Model;

namespace Example
{
    public class RestartProcessInstanceAsyncOperationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/engine-rest";
            var apiInstance = new ProcessDefinitionApi(config);
            var id = id_example;  // string | The id of the process definition of the process instances to restart.
            var restartProcessInstanceDto = new RestartProcessInstanceDto(); // RestartProcessInstanceDto |  (optional) 

            try
            {
                // Restart Process Instance Async
                BatchDto result = apiInstance.RestartProcessInstanceAsyncOperation(id, restartProcessInstanceDto);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProcessDefinitionApi.RestartProcessInstanceAsyncOperation: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The id of the process definition of the process instances to restart. | 
 **restartProcessInstanceDto** | [**RestartProcessInstanceDto**](RestartProcessInstanceDto.md)|  | [optional] 

### Return type

[**BatchDto**](BatchDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Request successful. |  -  |
| **400** | In case following parameters are missing: &#x60;instructions&#x60;, &#x60;activityId&#x60; or &#x60;transitionId&#x60;, &#x60;processInstanceIds&#x60; or &#x60;historicProcessInstanceQuery&#x60;, an exception of type &#x60;InvalidRequestException&#x60; is returned.  See the [Introduction](https://docs.camunda.org/manual/7.15/reference/rest/overview/#error-handling) for the error response format. |  -  |
| **404** | Process definition with given id does not exist. See the [Introduction](https://docs.camunda.org/manual/7.15/reference/rest/overview/#error-handling) for the error response format. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="startprocessinstance"></a>
# **StartProcessInstance**
> ProcessInstanceWithVariablesDto StartProcessInstance (string id, StartProcessInstanceDto startProcessInstanceDto = null)

Start Instance

Instantiates a given process definition. Process variables and business key may be supplied in the request body.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Camunda.OpenApi.Client.Api;
using Camunda.OpenApi.Client.Client;
using Camunda.OpenApi.Client.Model;

namespace Example
{
    public class StartProcessInstanceExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/engine-rest";
            var apiInstance = new ProcessDefinitionApi(config);
            var id = id_example;  // string | The id of the process definition to be retrieved.
            var startProcessInstanceDto = new StartProcessInstanceDto(); // StartProcessInstanceDto |  (optional) 

            try
            {
                // Start Instance
                ProcessInstanceWithVariablesDto result = apiInstance.StartProcessInstance(id, startProcessInstanceDto);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProcessDefinitionApi.StartProcessInstance: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The id of the process definition to be retrieved. | 
 **startProcessInstanceDto** | [**StartProcessInstanceDto**](StartProcessInstanceDto.md)|  | [optional] 

### Return type

[**ProcessInstanceWithVariablesDto**](ProcessInstanceWithVariablesDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Request successful. |  -  |
| **400** | The instance could not be created due to an invalid variable value, for example if the value could not be parsed to an &#x60;Integer&#x60; value or the passed variable type is not supported. See the [Introduction](https://docs.camunda.org/manual/7.15/reference/rest/overview/#error-handling) for the error response format. |  -  |
| **500** | The instance could not be created successfully. See the [Introduction](https://docs.camunda.org/manual/7.15/reference/rest/overview/#error-handling) for the error response format. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="startprocessinstancebykey"></a>
# **StartProcessInstanceByKey**
> ProcessInstanceWithVariablesDto StartProcessInstanceByKey (string key, StartProcessInstanceDto startProcessInstanceDto = null)

Start Instance

Instantiates a given process definition, starts the latest version of the process definition which belongs to no tenant. Process variables and business key may be supplied in the request body.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Camunda.OpenApi.Client.Api;
using Camunda.OpenApi.Client.Client;
using Camunda.OpenApi.Client.Model;

namespace Example
{
    public class StartProcessInstanceByKeyExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/engine-rest";
            var apiInstance = new ProcessDefinitionApi(config);
            var key = key_example;  // string | The key of the process definition (the latest version thereof) to be retrieved.
            var startProcessInstanceDto = new StartProcessInstanceDto(); // StartProcessInstanceDto |  (optional) 

            try
            {
                // Start Instance
                ProcessInstanceWithVariablesDto result = apiInstance.StartProcessInstanceByKey(key, startProcessInstanceDto);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProcessDefinitionApi.StartProcessInstanceByKey: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **key** | **string**| The key of the process definition (the latest version thereof) to be retrieved. | 
 **startProcessInstanceDto** | [**StartProcessInstanceDto**](StartProcessInstanceDto.md)|  | [optional] 

### Return type

[**ProcessInstanceWithVariablesDto**](ProcessInstanceWithVariablesDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Request successful. |  -  |
| **400** | The instance could not be created due to an invalid variable value, for example if the value could not be parsed to an &#x60;Integer&#x60; value or the passed variable type is not supported. See the [Introduction](https://docs.camunda.org/manual/7.15/reference/rest/overview/#error-handling) for the error response format. |  -  |
| **500** | The instance could not be created successfully. See the [Introduction](https://docs.camunda.org/manual/7.15/reference/rest/overview/#error-handling) for the error response format. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="startprocessinstancebykeyandtenantid"></a>
# **StartProcessInstanceByKeyAndTenantId**
> ProcessInstanceWithVariablesDto StartProcessInstanceByKeyAndTenantId (string key, string tenantId, StartProcessInstanceDto startProcessInstanceDto = null)

Start Instance

Instantiates a given process definition, starts the latest version of the process definition for tenant. Process variables and business key may be supplied in the request body.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Camunda.OpenApi.Client.Api;
using Camunda.OpenApi.Client.Client;
using Camunda.OpenApi.Client.Model;

namespace Example
{
    public class StartProcessInstanceByKeyAndTenantIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/engine-rest";
            var apiInstance = new ProcessDefinitionApi(config);
            var key = key_example;  // string | The key of the process definition (the latest version thereof) to be retrieved.
            var tenantId = tenantId_example;  // string | The id of the tenant the process definition belongs to.
            var startProcessInstanceDto = new StartProcessInstanceDto(); // StartProcessInstanceDto |  (optional) 

            try
            {
                // Start Instance
                ProcessInstanceWithVariablesDto result = apiInstance.StartProcessInstanceByKeyAndTenantId(key, tenantId, startProcessInstanceDto);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProcessDefinitionApi.StartProcessInstanceByKeyAndTenantId: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **key** | **string**| The key of the process definition (the latest version thereof) to be retrieved. | 
 **tenantId** | **string**| The id of the tenant the process definition belongs to. | 
 **startProcessInstanceDto** | [**StartProcessInstanceDto**](StartProcessInstanceDto.md)|  | [optional] 

### Return type

[**ProcessInstanceWithVariablesDto**](ProcessInstanceWithVariablesDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Request successful. |  -  |
| **400** | The instance could not be created due to an invalid variable value, for example if the value could not be parsed to an &#x60;Integer&#x60; value or the passed variable type is not supported. See the [Introduction](https://docs.camunda.org/manual/7.15/reference/rest/overview/#error-handling) for the error response format. |  -  |
| **500** | The instance could not be created successfully. See the [Introduction](https://docs.camunda.org/manual/7.15/reference/rest/overview/#error-handling) for the error response format. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="submitform"></a>
# **SubmitForm**
> ProcessInstanceDto SubmitForm (string id, StartProcessInstanceFormDto startProcessInstanceFormDto = null)

Submit Start Form

Starts a process instance using a set of process variables and the business key. If the start event has Form Field Metadata defined, the process engine will perform backend validation for any form fields which have validators defined. See [Documentation on Generated Task Forms](https://docs.camunda.org/manual/7.15/user-guide/task-forms/#generated-task-forms).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Camunda.OpenApi.Client.Api;
using Camunda.OpenApi.Client.Client;
using Camunda.OpenApi.Client.Model;

namespace Example
{
    public class SubmitFormExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/engine-rest";
            var apiInstance = new ProcessDefinitionApi(config);
            var id = id_example;  // string | The id of the process definition to submit the form for.
            var startProcessInstanceFormDto = new StartProcessInstanceFormDto(); // StartProcessInstanceFormDto |  (optional) 

            try
            {
                // Submit Start Form
                ProcessInstanceDto result = apiInstance.SubmitForm(id, startProcessInstanceFormDto);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProcessDefinitionApi.SubmitForm: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The id of the process definition to submit the form for. | 
 **startProcessInstanceFormDto** | [**StartProcessInstanceFormDto**](StartProcessInstanceFormDto.md)|  | [optional] 

### Return type

[**ProcessInstanceDto**](ProcessInstanceDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Request successful. |  -  |
| **400** | The instance could not be created due to an invalid variable value, for example if the value could not be parsed to an &#x60;Integer&#x60; value or the passed variable type is not supported. See the [Introduction](https://docs.camunda.org/manual/7.15/reference/rest/overview/#error-handling) for the error response format. |  -  |
| **404** | Process definition with given id does not exist. See the [Introduction](https://docs.camunda.org/manual/7.15/reference/rest/overview/#error-handling) for the error response format. |  -  |
| **500** | The instance could not be created successfully. See the [Introduction](https://docs.camunda.org/manual/7.15/reference/rest/overview/#error-handling) for the error response format. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="submitformbykey"></a>
# **SubmitFormByKey**
> ProcessInstanceDto SubmitFormByKey (string key, StartProcessInstanceFormDto startProcessInstanceFormDto = null)

Submit Start Form

Starts the latest version of the process definition which belongs to no tenant using a set of process variables and the business key. If the start event has Form Field Metadata defined, the process engine will perform backend validation for any form fields which have validators defined. See [Documentation on Generated Task Forms](https://docs.camunda.org/manual/7.15/user-guide/task-forms/#generated-task-forms).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Camunda.OpenApi.Client.Api;
using Camunda.OpenApi.Client.Client;
using Camunda.OpenApi.Client.Model;

namespace Example
{
    public class SubmitFormByKeyExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/engine-rest";
            var apiInstance = new ProcessDefinitionApi(config);
            var key = key_example;  // string | The key of the process definition to submit the form for.
            var startProcessInstanceFormDto = new StartProcessInstanceFormDto(); // StartProcessInstanceFormDto |  (optional) 

            try
            {
                // Submit Start Form
                ProcessInstanceDto result = apiInstance.SubmitFormByKey(key, startProcessInstanceFormDto);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProcessDefinitionApi.SubmitFormByKey: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **key** | **string**| The key of the process definition to submit the form for. | 
 **startProcessInstanceFormDto** | [**StartProcessInstanceFormDto**](StartProcessInstanceFormDto.md)|  | [optional] 

### Return type

[**ProcessInstanceDto**](ProcessInstanceDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Request successful. |  -  |
| **400** | The instance could not be created due to an invalid variable value, for example if the value could not be parsed to an &#x60;Integer&#x60; value or the passed variable type is not supported. See the [Introduction](https://docs.camunda.org/manual/7.15/reference/rest/overview/#error-handling) for the error response format. |  -  |
| **404** | Process definition with given key does not exist. See the [Introduction](https://docs.camunda.org/manual/7.15/reference/rest/overview/#error-handling) for the error response format. |  -  |
| **500** | The instance could not be created successfully. See the [Introduction](https://docs.camunda.org/manual/7.15/reference/rest/overview/#error-handling) for the error response format. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="submitformbykeyandtenantid"></a>
# **SubmitFormByKeyAndTenantId**
> ProcessInstanceDto SubmitFormByKeyAndTenantId (string key, string tenantId, StartProcessInstanceFormDto startProcessInstanceFormDto = null)

Submit Start Form

Starts the latest version of the process definition for a tenant using a set of process variables and the business key. If the start event has Form Field Metadata defined, the process engine will perform backend validation for any form fields which have validators defined. See [Documentation on Generated Task Forms](https://docs.camunda.org/manual/7.15/user-guide/task-forms/#generated-task-forms).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Camunda.OpenApi.Client.Api;
using Camunda.OpenApi.Client.Client;
using Camunda.OpenApi.Client.Model;

namespace Example
{
    public class SubmitFormByKeyAndTenantIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/engine-rest";
            var apiInstance = new ProcessDefinitionApi(config);
            var key = key_example;  // string | The key of the process definition to submit the form for.
            var tenantId = tenantId_example;  // string | The id of the tenant the process definition belongs to.
            var startProcessInstanceFormDto = new StartProcessInstanceFormDto(); // StartProcessInstanceFormDto |  (optional) 

            try
            {
                // Submit Start Form
                ProcessInstanceDto result = apiInstance.SubmitFormByKeyAndTenantId(key, tenantId, startProcessInstanceFormDto);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProcessDefinitionApi.SubmitFormByKeyAndTenantId: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **key** | **string**| The key of the process definition to submit the form for. | 
 **tenantId** | **string**| The id of the tenant the process definition belongs to. | 
 **startProcessInstanceFormDto** | [**StartProcessInstanceFormDto**](StartProcessInstanceFormDto.md)|  | [optional] 

### Return type

[**ProcessInstanceDto**](ProcessInstanceDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Request successful. |  -  |
| **400** | The instance could not be created due to an invalid variable value, for example if the value could not be parsed to an &#x60;Integer&#x60; value or the passed variable type is not supported. See the [Introduction](https://docs.camunda.org/manual/7.15/reference/rest/overview/#error-handling) for the error response format. |  -  |
| **404** | Process definition with given key does not exist. See the [Introduction](https://docs.camunda.org/manual/7.15/reference/rest/overview/#error-handling) for the error response format. |  -  |
| **500** | The instance could not be created successfully. See the [Introduction](https://docs.camunda.org/manual/7.15/reference/rest/overview/#error-handling) for the error response format. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatehistorytimetolivebyprocessdefinitionid"></a>
# **UpdateHistoryTimeToLiveByProcessDefinitionId**
> void UpdateHistoryTimeToLiveByProcessDefinitionId (string id, HistoryTimeToLiveDto historyTimeToLiveDto = null)

Update History Time to Live

Updates history time to live for process definition. The field is used within [History cleanup](https://docs.camunda.org/manual/7.15/user-guide/process-engine/history/#history-cleanup).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Camunda.OpenApi.Client.Api;
using Camunda.OpenApi.Client.Client;
using Camunda.OpenApi.Client.Model;

namespace Example
{
    public class UpdateHistoryTimeToLiveByProcessDefinitionIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/engine-rest";
            var apiInstance = new ProcessDefinitionApi(config);
            var id = id_example;  // string | The id of the process definition to change history time to live.
            var historyTimeToLiveDto = new HistoryTimeToLiveDto(); // HistoryTimeToLiveDto |  (optional) 

            try
            {
                // Update History Time to Live
                apiInstance.UpdateHistoryTimeToLiveByProcessDefinitionId(id, historyTimeToLiveDto);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProcessDefinitionApi.UpdateHistoryTimeToLiveByProcessDefinitionId: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The id of the process definition to change history time to live. | 
 **historyTimeToLiveDto** | [**HistoryTimeToLiveDto**](HistoryTimeToLiveDto.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | Request successful. |  -  |
| **400** | Returned if some of the request parameters are invalid. See the [Introduction](https://docs.camunda.org/manual/7.15/reference/rest/overview/#error-handling) for the error response format. |  -  |
| **404** | Process definition with given id does not exist. See the [Introduction](https://docs.camunda.org/manual/7.15/reference/rest/overview/#error-handling) for the error response format. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatehistorytimetolivebyprocessdefinitionkey"></a>
# **UpdateHistoryTimeToLiveByProcessDefinitionKey**
> void UpdateHistoryTimeToLiveByProcessDefinitionKey (string key, HistoryTimeToLiveDto historyTimeToLiveDto = null)

Update History Time to Live

Updates history time to live for the latest version of the process definition which belongs to no tenant. The field is used within [History cleanup](https://docs.camunda.org/manual/7.15/user-guide/process-engine/history/#history-cleanup).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Camunda.OpenApi.Client.Api;
using Camunda.OpenApi.Client.Client;
using Camunda.OpenApi.Client.Model;

namespace Example
{
    public class UpdateHistoryTimeToLiveByProcessDefinitionKeyExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/engine-rest";
            var apiInstance = new ProcessDefinitionApi(config);
            var key = key_example;  // string | The key of the process definition to change history time to live.
            var historyTimeToLiveDto = new HistoryTimeToLiveDto(); // HistoryTimeToLiveDto |  (optional) 

            try
            {
                // Update History Time to Live
                apiInstance.UpdateHistoryTimeToLiveByProcessDefinitionKey(key, historyTimeToLiveDto);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProcessDefinitionApi.UpdateHistoryTimeToLiveByProcessDefinitionKey: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **key** | **string**| The key of the process definition to change history time to live. | 
 **historyTimeToLiveDto** | [**HistoryTimeToLiveDto**](HistoryTimeToLiveDto.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | Request successful. |  -  |
| **400** | Returned if some of the request parameters are invalid. See the [Introduction](https://docs.camunda.org/manual/7.15/reference/rest/overview/#error-handling) for the error response format. |  -  |
| **404** | Process definition with given id does not exist. See the [Introduction](https://docs.camunda.org/manual/7.15/reference/rest/overview/#error-handling) for the error response format. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatehistorytimetolivebyprocessdefinitionkeyandtenantid"></a>
# **UpdateHistoryTimeToLiveByProcessDefinitionKeyAndTenantId**
> void UpdateHistoryTimeToLiveByProcessDefinitionKeyAndTenantId (string key, string tenantId, HistoryTimeToLiveDto historyTimeToLiveDto = null)

Update History Time to Live

Updates history time to live for the latest version of the process definition for a tenant. The field is used within [History cleanup](https://docs.camunda.org/manual/7.15/user-guide/process-engine/history/#history-cleanup).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Camunda.OpenApi.Client.Api;
using Camunda.OpenApi.Client.Client;
using Camunda.OpenApi.Client.Model;

namespace Example
{
    public class UpdateHistoryTimeToLiveByProcessDefinitionKeyAndTenantIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/engine-rest";
            var apiInstance = new ProcessDefinitionApi(config);
            var key = key_example;  // string | The key of the process definition to change history time to live.
            var tenantId = tenantId_example;  // string | The id of the tenant the process definition belongs to.
            var historyTimeToLiveDto = new HistoryTimeToLiveDto(); // HistoryTimeToLiveDto |  (optional) 

            try
            {
                // Update History Time to Live
                apiInstance.UpdateHistoryTimeToLiveByProcessDefinitionKeyAndTenantId(key, tenantId, historyTimeToLiveDto);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProcessDefinitionApi.UpdateHistoryTimeToLiveByProcessDefinitionKeyAndTenantId: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **key** | **string**| The key of the process definition to change history time to live. | 
 **tenantId** | **string**| The id of the tenant the process definition belongs to. | 
 **historyTimeToLiveDto** | [**HistoryTimeToLiveDto**](HistoryTimeToLiveDto.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | Request successful. |  -  |
| **400** | Returned if some of the request parameters are invalid. See the [Introduction](https://docs.camunda.org/manual/7.15/reference/rest/overview/#error-handling) for the error response format. |  -  |
| **404** | Process definition with given id does not exist. See the [Introduction](https://docs.camunda.org/manual/7.15/reference/rest/overview/#error-handling) for the error response format. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateprocessdefinitionsuspensionstate"></a>
# **UpdateProcessDefinitionSuspensionState**
> void UpdateProcessDefinitionSuspensionState (ProcessDefinitionSuspensionStateDto processDefinitionSuspensionStateDto = null)

Activate/Suspend By Key

Activates or suspends process definitions with the given process definition key.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Camunda.OpenApi.Client.Api;
using Camunda.OpenApi.Client.Client;
using Camunda.OpenApi.Client.Model;

namespace Example
{
    public class UpdateProcessDefinitionSuspensionStateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/engine-rest";
            var apiInstance = new ProcessDefinitionApi(config);
            var processDefinitionSuspensionStateDto = new ProcessDefinitionSuspensionStateDto(); // ProcessDefinitionSuspensionStateDto | **Note**: Unallowed property is `processDefinitionId`. (optional) 

            try
            {
                // Activate/Suspend By Key
                apiInstance.UpdateProcessDefinitionSuspensionState(processDefinitionSuspensionStateDto);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProcessDefinitionApi.UpdateProcessDefinitionSuspensionState: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **processDefinitionSuspensionStateDto** | [**ProcessDefinitionSuspensionStateDto**](ProcessDefinitionSuspensionStateDto.md)| **Note**: Unallowed property is &#x60;processDefinitionId&#x60;. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | Request successful. |  -  |
| **400** | Returned if some of the query parameters are invalid, for example if the provided &#x60;executionDate&#x60; parameter doesn&#39;t have the expected format or if the &#x60;processDefinitionKey&#x60; parameter is &#x60;null&#x60;. See the [Introduction](https://docs.camunda.org/manual/7.15/reference/rest/overview/#error-handling) for the error response format. |  -  |
| **404** | Process definition with given key does not exist. See the [Introduction](https://docs.camunda.org/manual/7.15/reference/rest/overview/#error-handling) for the error response format. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateprocessdefinitionsuspensionstatebyid"></a>
# **UpdateProcessDefinitionSuspensionStateById**
> void UpdateProcessDefinitionSuspensionStateById (string id, ProcessDefinitionSuspensionStateDto processDefinitionSuspensionStateDto = null)

Activate/Suspend By Id

Activates or suspends a given process definition by id.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Camunda.OpenApi.Client.Api;
using Camunda.OpenApi.Client.Client;
using Camunda.OpenApi.Client.Model;

namespace Example
{
    public class UpdateProcessDefinitionSuspensionStateByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/engine-rest";
            var apiInstance = new ProcessDefinitionApi(config);
            var id = id_example;  // string | The id of the process definition to activate or suspend.
            var processDefinitionSuspensionStateDto = new ProcessDefinitionSuspensionStateDto(); // ProcessDefinitionSuspensionStateDto | **Note**: Unallowed properties are `processDefinitionId` and `processDefinitionKey`. (optional) 

            try
            {
                // Activate/Suspend By Id
                apiInstance.UpdateProcessDefinitionSuspensionStateById(id, processDefinitionSuspensionStateDto);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProcessDefinitionApi.UpdateProcessDefinitionSuspensionStateById: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The id of the process definition to activate or suspend. | 
 **processDefinitionSuspensionStateDto** | [**ProcessDefinitionSuspensionStateDto**](ProcessDefinitionSuspensionStateDto.md)| **Note**: Unallowed properties are &#x60;processDefinitionId&#x60; and &#x60;processDefinitionKey&#x60;. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | Request successful. |  -  |
| **400** | Returned if some of the query parameters are invalid, for example if the provided &#x60;executionDate&#x60; parameter doesn&#39;t have the expected format or if the &#x60;processDefinitionKey&#x60; parameter is &#x60;null&#x60;. See the [Introduction](https://docs.camunda.org/manual/7.15/reference/rest/overview/#error-handling) for the error response format. |  -  |
| **404** | Process definition with given key does not exist. See the [Introduction](https://docs.camunda.org/manual/7.15/reference/rest/overview/#error-handling) for the error response format. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateprocessdefinitionsuspensionstatebykey"></a>
# **UpdateProcessDefinitionSuspensionStateByKey**
> void UpdateProcessDefinitionSuspensionStateByKey (string key, ProcessDefinitionSuspensionStateDto processDefinitionSuspensionStateDto = null)

Activate/Suspend by Id

Activates or suspends a given process definition by latest version of process definition key which belongs to no tenant.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Camunda.OpenApi.Client.Api;
using Camunda.OpenApi.Client.Client;
using Camunda.OpenApi.Client.Model;

namespace Example
{
    public class UpdateProcessDefinitionSuspensionStateByKeyExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/engine-rest";
            var apiInstance = new ProcessDefinitionApi(config);
            var key = key_example;  // string | The key of the process definition (the latest version thereof) to be activated/suspended.
            var processDefinitionSuspensionStateDto = new ProcessDefinitionSuspensionStateDto(); // ProcessDefinitionSuspensionStateDto | **Note**: Unallowed properties are `processDefinitionId` and `processDefinitionKey`. (optional) 

            try
            {
                // Activate/Suspend by Id
                apiInstance.UpdateProcessDefinitionSuspensionStateByKey(key, processDefinitionSuspensionStateDto);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProcessDefinitionApi.UpdateProcessDefinitionSuspensionStateByKey: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **key** | **string**| The key of the process definition (the latest version thereof) to be activated/suspended. | 
 **processDefinitionSuspensionStateDto** | [**ProcessDefinitionSuspensionStateDto**](ProcessDefinitionSuspensionStateDto.md)| **Note**: Unallowed properties are &#x60;processDefinitionId&#x60; and &#x60;processDefinitionKey&#x60;. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | Request successful. |  -  |
| **400** | Returned if some of the query parameters are invalid, for example if the provided &#x60;executionDate&#x60; parameter doesn&#39;t have the expected format or if the &#x60;processDefinitionKey&#x60; parameter is &#x60;null&#x60;. See the [Introduction](https://docs.camunda.org/manual/7.15/reference/rest/overview/#error-handling) for the error response format. |  -  |
| **404** | Process definition with given key does not exist. See the [Introduction](https://docs.camunda.org/manual/7.15/reference/rest/overview/#error-handling) for the error response format. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateprocessdefinitionsuspensionstatebykeyandtenantid"></a>
# **UpdateProcessDefinitionSuspensionStateByKeyAndTenantId**
> void UpdateProcessDefinitionSuspensionStateByKeyAndTenantId (string key, string tenantId, ProcessDefinitionSuspensionStateDto processDefinitionSuspensionStateDto = null)

Activate/Suspend by Id

Activates or suspends a given process definition by the latest version of the process definition for tenant.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Camunda.OpenApi.Client.Api;
using Camunda.OpenApi.Client.Client;
using Camunda.OpenApi.Client.Model;

namespace Example
{
    public class UpdateProcessDefinitionSuspensionStateByKeyAndTenantIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/engine-rest";
            var apiInstance = new ProcessDefinitionApi(config);
            var key = key_example;  // string | The key of the process definition (the latest version thereof) to be activated/suspended.
            var tenantId = tenantId_example;  // string | The id of the tenant the process definition belongs to.
            var processDefinitionSuspensionStateDto = new ProcessDefinitionSuspensionStateDto(); // ProcessDefinitionSuspensionStateDto | **Note**: Unallowed properties are `processDefinitionId` and `processDefinitionKey`. (optional) 

            try
            {
                // Activate/Suspend by Id
                apiInstance.UpdateProcessDefinitionSuspensionStateByKeyAndTenantId(key, tenantId, processDefinitionSuspensionStateDto);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProcessDefinitionApi.UpdateProcessDefinitionSuspensionStateByKeyAndTenantId: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **key** | **string**| The key of the process definition (the latest version thereof) to be activated/suspended. | 
 **tenantId** | **string**| The id of the tenant the process definition belongs to. | 
 **processDefinitionSuspensionStateDto** | [**ProcessDefinitionSuspensionStateDto**](ProcessDefinitionSuspensionStateDto.md)| **Note**: Unallowed properties are &#x60;processDefinitionId&#x60; and &#x60;processDefinitionKey&#x60;. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | Request successful. |  -  |
| **400** | Returned if some of the query parameters are invalid, for example if the provided &#x60;executionDate&#x60; parameter doesn&#39;t have the expected format or if the &#x60;processDefinitionKey&#x60; parameter is &#x60;null&#x60;. See the [Introduction](https://docs.camunda.org/manual/7.15/reference/rest/overview/#error-handling) for the error response format. |  -  |
| **404** | Process definition with given key does not exist. See the [Introduction](https://docs.camunda.org/manual/7.15/reference/rest/overview/#error-handling) for the error response format. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

