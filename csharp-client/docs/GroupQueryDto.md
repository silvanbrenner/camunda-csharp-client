# Camunda.OpenApi.Client.Model.GroupQueryDto
A group instance query which defines a list of group instances

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | Filter by the id of the group. | [optional] 
**IdIn** | **List&lt;string&gt;** | Filter by a JSON string array of group ids. | [optional] 
**Name** | **string** | Filter by the name of the group. | [optional] 
**NameLike** | **string** | Filter by the name that the parameter is a substring of. | [optional] 
**Type** | **string** | Filter by the type of the group. | [optional] 
**Member** | **string** | Only retrieve groups where the given user id is a member of. | [optional] 
**MemberOfTenant** | **string** | Only retrieve groups which are members of the given tenant. | [optional] 
**Sorting** | [**List&lt;GroupQueryDtoSorting&gt;**](GroupQueryDtoSorting.md) | Apply sorting of the result | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

