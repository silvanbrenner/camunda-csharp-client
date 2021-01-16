# Camunda.OpenApi.Client.Api.SchemaLogApi

All URIs are relative to *http://localhost:8080/engine-rest*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetSchemaLog**](SchemaLogApi.md#getschemalog) | **GET** /schema/log | 
[**QuerySchemaLog**](SchemaLogApi.md#queryschemalog) | **POST** /schema/log | 


<a name="getschemalog"></a>
# **GetSchemaLog**
> List&lt;SchemaLogEntryDto&gt; GetSchemaLog (string version = null, int? firstResult = null, int? maxResults = null)



Queries for schema log entries that fulfill given parameters.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Camunda.OpenApi.Client.Api;
using Camunda.OpenApi.Client.Client;
using Camunda.OpenApi.Client.Model;

namespace Example
{
    public class GetSchemaLogExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/engine-rest";
            var apiInstance = new SchemaLogApi(config);
            var version = version_example;  // string | Only return schema log entries with a specific version. (optional) 
            var firstResult = 56;  // int? | Pagination of results. Specifies the index of the first result to return. (optional) 
            var maxResults = 56;  // int? | Pagination of results. Specifies the maximum number of results to return. Will return less results if there are no more results left. (optional) 

            try
            {
                List<SchemaLogEntryDto> result = apiInstance.GetSchemaLog(version, firstResult, maxResults);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SchemaLogApi.GetSchemaLog: " + e.Message );
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
 **version** | **string**| Only return schema log entries with a specific version. | [optional] 
 **firstResult** | **int?**| Pagination of results. Specifies the index of the first result to return. | [optional] 
 **maxResults** | **int?**| Pagination of results. Specifies the maximum number of results to return. Will return less results if there are no more results left. | [optional] 

### Return type

[**List&lt;SchemaLogEntryDto&gt;**](SchemaLogEntryDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Request successful. **Note**: In order to get any results a user of group &#x60;camunda-admin&#x60; must be authenticated. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="queryschemalog"></a>
# **QuerySchemaLog**
> List&lt;SchemaLogEntryDto&gt; QuerySchemaLog (int? firstResult = null, int? maxResults = null, SchemaLogQueryDto schemaLogQueryDto = null)



Queries for schema log entries that fulfill given parameters.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Camunda.OpenApi.Client.Api;
using Camunda.OpenApi.Client.Client;
using Camunda.OpenApi.Client.Model;

namespace Example
{
    public class QuerySchemaLogExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/engine-rest";
            var apiInstance = new SchemaLogApi(config);
            var firstResult = 56;  // int? | Pagination of results. Specifies the index of the first result to return. (optional) 
            var maxResults = 56;  // int? | Pagination of results. Specifies the maximum number of results to return. Will return less results if there are no more results left. (optional) 
            var schemaLogQueryDto = new SchemaLogQueryDto(); // SchemaLogQueryDto |  (optional) 

            try
            {
                List<SchemaLogEntryDto> result = apiInstance.QuerySchemaLog(firstResult, maxResults, schemaLogQueryDto);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SchemaLogApi.QuerySchemaLog: " + e.Message );
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
 **firstResult** | **int?**| Pagination of results. Specifies the index of the first result to return. | [optional] 
 **maxResults** | **int?**| Pagination of results. Specifies the maximum number of results to return. Will return less results if there are no more results left. | [optional] 
 **schemaLogQueryDto** | [**SchemaLogQueryDto**](SchemaLogQueryDto.md)|  | [optional] 

### Return type

[**List&lt;SchemaLogEntryDto&gt;**](SchemaLogEntryDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Request successful. **Note**: In order to get any results a user of group camunda-admin must be authenticated. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

