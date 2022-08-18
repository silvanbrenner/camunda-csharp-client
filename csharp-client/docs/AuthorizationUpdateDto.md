# Camunda.OpenApi.Client.Model.AuthorizationUpdateDto

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Permissions** | **List&lt;string&gt;** | An array of Strings holding the permissions provided by this authorization. | [optional] 
**UserId** | **string** | The id of the user this authorization has been created for. The value &#x60;*&#x60; represents a global authorization ranging over all users. | [optional] 
**GroupId** | **string** | The id of the group this authorization has been created for. | [optional] 
**ResourceType** | **int?** | An integer representing the resource type. See the [User Guide](https://docs.camunda.org/manual/7.17/user-guide/process-engine/authorization-service/#resources) for a list of integer representations of resource types. | [optional] 
**ResourceId** | **string** | The resource Id. The value &#x60;*&#x60; represents an authorization ranging over all instances of a resource. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

