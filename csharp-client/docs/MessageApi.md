# CamundaClient.Api.MessageApi

All URIs are relative to *http://localhost:8080/engine-rest*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeliverMessage**](MessageApi.md#delivermessage) | **POST** /message | 


<a name="delivermessage"></a>
# **DeliverMessage**
> List&lt;MessageCorrelationResultWithVariableDto&gt; DeliverMessage (CorrelationMessageDto correlationMessageDto = null)



Correlates a message to the process engine to either trigger a message start event or an intermediate message  catching event. Internally this maps to the engine's message correlation builder methods `MessageCorrelationBuilder#correlateWithResult()` and `MessageCorrelationBuilder#correlateAllWithResult()`. For more information about the correlation behavior, see the [Message Events](https://docs.camunda.org/manual/7.14/bpmn20/events/message-events/) section of the [BPMN 2.0 Implementation Reference](https://docs.camunda.org/manual/7.14/reference/bpmn20/).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using CamundaClient.Api;
using CamundaClient.Client;
using CamundaClient.Model;

namespace Example
{
    public class DeliverMessageExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/engine-rest";
            var apiInstance = new MessageApi(config);
            var correlationMessageDto = new CorrelationMessageDto(); // CorrelationMessageDto |  (optional) 

            try
            {
                List<MessageCorrelationResultWithVariableDto> result = apiInstance.DeliverMessage(correlationMessageDto);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MessageApi.DeliverMessage: " + e.Message );
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
 **correlationMessageDto** | [**CorrelationMessageDto**](CorrelationMessageDto.md)|  | [optional] 

### Return type

[**List&lt;MessageCorrelationResultWithVariableDto&gt;**](MessageCorrelationResultWithVariableDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Request successful. The property &#x60;resultEnabled&#x60; in the request body was &#x60;true&#x60;. The &#x60;variables&#x60; property is only returned, if the property variablesInResultEnable&#x60; was set to &#x60;true&#x60; in the request. |  -  |
| **204** | Request successful. The property &#x60;resultEnabled&#x60; in the request body was &#x60;false&#x60; (Default). |  -  |
| **400** | Returned if: * no &#x60;messageName&#x60; was supplied * both &#x60;tenantId&#x60; and &#x60;withoutTenantId&#x60; are supplied * the message has not been correlated to exactly one entity (execution or process definition) * the variable value or type is invalid, for example if the value could not be parsed to an Integer value or the passed variable type is not supported.  See the [Introduction](https://docs.camunda.org/manual/7.14/reference/rest/overview/#error-handling) for the error response format. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

