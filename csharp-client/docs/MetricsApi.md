# Camunda.OpenApi.Client.Api.MetricsApi

All URIs are relative to *http://localhost:8080/engine-rest*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetMetrics**](MetricsApi.md#getmetrics) | **GET** /metrics/{metrics-name}/sum | 
[**Interval**](MetricsApi.md#interval) | **GET** /metrics | 


<a name="getmetrics"></a>
# **GetMetrics**
> MetricsResultDto GetMetrics (string metricsName, DateTime? startDate = null, DateTime? endDate = null)



Retrieves the `sum` (count) for a given metric.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Camunda.OpenApi.Client.Api;
using Camunda.OpenApi.Client.Client;
using Camunda.OpenApi.Client.Model;

namespace Example
{
    public class GetMetricsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/engine-rest";
            var apiInstance = new MetricsApi(config);
            var metricsName = metricsName_example;  // string | The name of the metric.
            var startDate = 2013-10-20T19:20:30+01:00;  // DateTime? | The start date (inclusive). (optional) 
            var endDate = 2013-10-20T19:20:30+01:00;  // DateTime? | The end date (exclusive). (optional) 

            try
            {
                MetricsResultDto result = apiInstance.GetMetrics(metricsName, startDate, endDate);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MetricsApi.GetMetrics: " + e.Message );
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
 **metricsName** | **string**| The name of the metric. | 
 **startDate** | **DateTime?**| The start date (inclusive). | [optional] 
 **endDate** | **DateTime?**| The end date (exclusive). | [optional] 

### Return type

[**MetricsResultDto**](MetricsResultDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Request successful. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="interval"></a>
# **Interval**
> List&lt;MetricsIntervalResultDto&gt; Interval (string name = null, string reporter = null, DateTime? startDate = null, DateTime? endDate = null, int? firstResult = null, int? maxResults = null, string interval = null, string aggregateByReporter = null)



Retrieves a list of metrics, aggregated for a given interval.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Camunda.OpenApi.Client.Api;
using Camunda.OpenApi.Client.Client;
using Camunda.OpenApi.Client.Model;

namespace Example
{
    public class IntervalExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/engine-rest";
            var apiInstance = new MetricsApi(config);
            var name = name_example;  // string | The name of the metric. (optional) 
            var reporter = reporter_example;  // string | The name of the reporter (host), on which the metrics was logged. This will have value provided by the [hostname configuration property](https://docs.camunda.org/manual/7.14/reference/deployment-descriptors/tags/process-engine/#hostname). (optional) 
            var startDate = 2013-10-20T19:20:30+01:00;  // DateTime? | The start date (inclusive). (optional) 
            var endDate = 2013-10-20T19:20:30+01:00;  // DateTime? | The end date (exclusive). (optional) 
            var firstResult = 56;  // int? | Pagination of results. Specifies the index of the first result to return. (optional) 
            var maxResults = 56;  // int? | Pagination of results. Specifies the maximum number of results to return. Will return less results if there are no more results left. (optional) 
            var interval = interval_example;  // string | The interval for which the metrics should be aggregated. Time unit is seconds. Default: The interval is set to 15 minutes (900 seconds). (optional)  (default to "900")
            var aggregateByReporter = aggregateByReporter_example;  // string | Aggregate metrics by reporter. (optional) 

            try
            {
                List<MetricsIntervalResultDto> result = apiInstance.Interval(name, reporter, startDate, endDate, firstResult, maxResults, interval, aggregateByReporter);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MetricsApi.Interval: " + e.Message );
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
 **name** | **string**| The name of the metric. | [optional] 
 **reporter** | **string**| The name of the reporter (host), on which the metrics was logged. This will have value provided by the [hostname configuration property](https://docs.camunda.org/manual/7.14/reference/deployment-descriptors/tags/process-engine/#hostname). | [optional] 
 **startDate** | **DateTime?**| The start date (inclusive). | [optional] 
 **endDate** | **DateTime?**| The end date (exclusive). | [optional] 
 **firstResult** | **int?**| Pagination of results. Specifies the index of the first result to return. | [optional] 
 **maxResults** | **int?**| Pagination of results. Specifies the maximum number of results to return. Will return less results if there are no more results left. | [optional] 
 **interval** | **string**| The interval for which the metrics should be aggregated. Time unit is seconds. Default: The interval is set to 15 minutes (900 seconds). | [optional] [default to &quot;900&quot;]
 **aggregateByReporter** | **string**| Aggregate metrics by reporter. | [optional] 

### Return type

[**List&lt;MetricsIntervalResultDto&gt;**](MetricsIntervalResultDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Request successful. |  -  |
| **400** | Returned if some of the query parameters are invalid. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

