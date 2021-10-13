# Camunda.OpenApi.Client.Api.IdentityApi

All URIs are relative to *http://localhost:8080/engine-rest*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CheckPassword**](IdentityApi.md#checkpassword) | **POST** /identity/password-policy | Validate Password
[**GetGroupInfo**](IdentityApi.md#getgroupinfo) | **GET** /identity/groups | Get a User&#39;s Groups
[**GetPasswordPolicy**](IdentityApi.md#getpasswordpolicy) | **GET** /identity/password-policy | Get Password Policy
[**VerifyUser**](IdentityApi.md#verifyuser) | **POST** /identity/verify | Verify User


<a name="checkpassword"></a>
# **CheckPassword**
> CheckPasswordPolicyResultDto CheckPassword (PasswordPolicyRequestDto passwordPolicyRequestDto = null)

Validate Password

A password policy consists of a list of rules that new passwords must follow to be policy compliant. A password can be checked for compliancy via this end point. More information on password policies in Camunda can be found in the password policy [user guide](https://docs.camunda.org/manual/7.16/user-guide/process-engine/password-policy/) and in the [security instructions](https://docs.camunda.org/manual/7.16/user-guide/security/).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Camunda.OpenApi.Client.Api;
using Camunda.OpenApi.Client.Client;
using Camunda.OpenApi.Client.Model;

namespace Example
{
    public class CheckPasswordExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/engine-rest";
            var apiInstance = new IdentityApi(config);
            var passwordPolicyRequestDto = new PasswordPolicyRequestDto(); // PasswordPolicyRequestDto |  (optional) 

            try
            {
                // Validate Password
                CheckPasswordPolicyResultDto result = apiInstance.CheckPassword(passwordPolicyRequestDto);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IdentityApi.CheckPassword: " + e.Message );
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
 **passwordPolicyRequestDto** | [**PasswordPolicyRequestDto**](PasswordPolicyRequestDto.md)|  | [optional] 

### Return type

[**CheckPasswordPolicyResultDto**](CheckPasswordPolicyResultDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Request successful. This example uses the built-in password policy that enforces a minimum password length, and some complexity rules. The checked password is myPassword which is not complex enough to match all of the policy rules. |  -  |
| **404** | No password policy was found to check the password against. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getgroupinfo"></a>
# **GetGroupInfo**
> IdentityServiceGroupInfoDto GetGroupInfo (string userId)

Get a User's Groups

Gets the groups of a user by id and includes all users that share a group with the given user.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Camunda.OpenApi.Client.Api;
using Camunda.OpenApi.Client.Client;
using Camunda.OpenApi.Client.Model;

namespace Example
{
    public class GetGroupInfoExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/engine-rest";
            var apiInstance = new IdentityApi(config);
            var userId = userId_example;  // string | The id of the user to get the groups for.

            try
            {
                // Get a User's Groups
                IdentityServiceGroupInfoDto result = apiInstance.GetGroupInfo(userId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IdentityApi.GetGroupInfo: " + e.Message );
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
 **userId** | **string**| The id of the user to get the groups for. | 

### Return type

[**IdentityServiceGroupInfoDto**](IdentityServiceGroupInfoDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Request successful. |  -  |
| **400** | If the &#x60;userId&#x60; query parameter is missing. See the [Introduction](https://docs.camunda.org/manual/7.16/reference/rest/overview/#error-handling) for the error response format. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpasswordpolicy"></a>
# **GetPasswordPolicy**
> PasswordPolicyDto GetPasswordPolicy ()

Get Password Policy

A password policy consists of a list of rules that new passwords must follow to be policy compliant. This end point returns a JSON representation of the list of policy rules. More information on password policies in Camunda can be found in the password policy [user guide](https://docs.camunda.org/manual/7.16/user-guide/process-engine/password-policy/) and in the [security instructions](https://docs.camunda.org/manual/7.16/user-guide/security/).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Camunda.OpenApi.Client.Api;
using Camunda.OpenApi.Client.Client;
using Camunda.OpenApi.Client.Model;

namespace Example
{
    public class GetPasswordPolicyExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/engine-rest";
            var apiInstance = new IdentityApi(config);

            try
            {
                // Get Password Policy
                PasswordPolicyDto result = apiInstance.GetPasswordPolicy();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IdentityApi.GetPasswordPolicy: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**PasswordPolicyDto**](PasswordPolicyDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Request successful. This example uses the built-in password policy that enforces a minimum password length, and some complexity rules. |  -  |
| **404** | No password policy was found. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="verifyuser"></a>
# **VerifyUser**
> AuthenticationResult VerifyUser (BasicUserCredentialsDto basicUserCredentialsDto = null)

Verify User

Verifies that user credentials are valid.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Camunda.OpenApi.Client.Api;
using Camunda.OpenApi.Client.Client;
using Camunda.OpenApi.Client.Model;

namespace Example
{
    public class VerifyUserExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/engine-rest";
            var apiInstance = new IdentityApi(config);
            var basicUserCredentialsDto = new BasicUserCredentialsDto(); // BasicUserCredentialsDto |  (optional) 

            try
            {
                // Verify User
                AuthenticationResult result = apiInstance.VerifyUser(basicUserCredentialsDto);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IdentityApi.VerifyUser: " + e.Message );
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
 **basicUserCredentialsDto** | [**BasicUserCredentialsDto**](BasicUserCredentialsDto.md)|  | [optional] 

### Return type

[**AuthenticationResult**](AuthenticationResult.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Request successful. |  -  |
| **400** | If body does not contain username or password. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

