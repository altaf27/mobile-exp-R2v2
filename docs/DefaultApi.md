# Cbd.MobileExperienceApi.Api.DefaultApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetDDAEnquiryDetailsPost**](DefaultApi.md#getddaenquirydetailspost) | **POST** /getDDAEnquiryDetails |  |
| [**GetStandingOrdersInquiryPost**](DefaultApi.md#getstandingordersinquirypost) | **POST** /getStandingOrdersInquiry |  |
| [**ManagementInquiryPost**](DefaultApi.md#managementinquirypost) | **POST** /management/inquiry |  |
| [**ServicesCCIBServicesGetRimInfoPost**](DefaultApi.md#servicesccibservicesgetriminfopost) | **POST** /Services/CCIBServices/getRimInfo |  |
| [**ServicesCurrentAccountAcctAcctTrnInqPost**](DefaultApi.md#servicescurrentaccountacctaccttrninqpost) | **POST** /Services/CurrentAccount/AcctAcctTrnInq |  |
| [**ServicesCurrentAccountXferXferAddPost**](DefaultApi.md#servicescurrentaccountxferxferaddpost) | **POST** /Services/CurrentAccount/Xfer/XferAdd |  |
| [**ServicesCustomerProfilePartyAcctRelInqPost**](DefaultApi.md#servicescustomerprofilepartyacctrelinqpost) | **POST** /Services/CustomerProfile/PartyAcctRelInq |  |
| [**ServicesCustomerProfilePartyInqPost**](DefaultApi.md#servicescustomerprofilepartyinqpost) | **POST** /Services/CustomerProfile/PartyInq |  |
| [**ServicesGenericAPIExecuteServicePost**](DefaultApi.md#servicesgenericapiexecuteservicepost) | **POST** /Services/GenericAPIExecuteService |  |
| [**ServicesRemittanceRemitAddPost**](DefaultApi.md#servicesremittanceremitaddpost) | **POST** /Services/Remittance/RemitAdd |  |
| [**ServicesRemittanceRemitStatInqPost**](DefaultApi.md#servicesremittanceremitstatinqpost) | **POST** /Services/Remittance/RemitStatInq |  |
| [**ServicesValidateIbanDetailsPost**](DefaultApi.md#servicesvalidateibandetailspost) | **POST** /Services/validateIbanDetails |  |

<a id="getddaenquirydetailspost"></a>
# **GetDDAEnquiryDetailsPost**
> DdaEnquirydetailsResponse GetDDAEnquiryDetailsPost (string? xCorrelationId = null, string? xSourceId = null, DdaEnquirydetailsRequest? generated = null)



Error Structure for CBD Mobile Services

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Cbd.MobileExperienceApi.Api;
using Cbd.MobileExperienceApi.Client;
using Cbd.MobileExperienceApi.Model;

namespace Example
{
    public class GetDDAEnquiryDetailsPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new DefaultApi(httpClient, config, httpClientHandler);
            var xCorrelationId = "xCorrelationId_example";  // string? | Transaction ID. A unique identifier value that is attached to requests and messages that allow reference to a particular transaction or event chain. (optional) 
            var xSourceId = "xSourceId_example";  // string? | Source ID. A unique identifier value that is attached to requests and messages that allow reference to a particular transaction or specific for a channel. (optional) 
            var generated = new DdaEnquirydetailsRequest?(); // DdaEnquirydetailsRequest? |  (optional) 

            try
            {
                DdaEnquirydetailsResponse result = apiInstance.GetDDAEnquiryDetailsPost(xCorrelationId, xSourceId, generated);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.GetDDAEnquiryDetailsPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetDDAEnquiryDetailsPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<DdaEnquirydetailsResponse> response = apiInstance.GetDDAEnquiryDetailsPostWithHttpInfo(xCorrelationId, xSourceId, generated);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.GetDDAEnquiryDetailsPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xCorrelationId** | **string?** | Transaction ID. A unique identifier value that is attached to requests and messages that allow reference to a particular transaction or event chain. | [optional]  |
| **xSourceId** | **string?** | Source ID. A unique identifier value that is attached to requests and messages that allow reference to a particular transaction or specific for a channel. | [optional]  |
| **generated** | [**DdaEnquirydetailsRequest?**](DdaEnquirydetailsRequest?.md) |  | [optional]  |

### Return type

[**DdaEnquirydetailsResponse**](DdaEnquirydetailsResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** |  |  * x-event-msg - A request status description <br>  * x-event-id - Process level transaction ID can be used for tracing <br>  * x-event-code - Http status code <br>  |
| **400** |  |  -  |
| **500** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getstandingordersinquirypost"></a>
# **GetStandingOrdersInquiryPost**
> StandingordersinquiryResponse GetStandingOrdersInquiryPost (string? xCorrelationId = null, string? xSourceId = null, StandingordersinquiryRequest? generated = null)



Error Structure for CBD Mobile Services

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Cbd.MobileExperienceApi.Api;
using Cbd.MobileExperienceApi.Client;
using Cbd.MobileExperienceApi.Model;

namespace Example
{
    public class GetStandingOrdersInquiryPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new DefaultApi(httpClient, config, httpClientHandler);
            var xCorrelationId = "xCorrelationId_example";  // string? | Transaction ID. A unique identifier value that is attached to requests and messages that allow reference to a particular transaction or event chain. (optional) 
            var xSourceId = "xSourceId_example";  // string? | Source ID. A unique identifier value that is attached to requests and messages that allow reference to a particular transaction or specific for a channel. (optional) 
            var generated = new StandingordersinquiryRequest?(); // StandingordersinquiryRequest? |  (optional) 

            try
            {
                StandingordersinquiryResponse result = apiInstance.GetStandingOrdersInquiryPost(xCorrelationId, xSourceId, generated);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.GetStandingOrdersInquiryPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetStandingOrdersInquiryPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<StandingordersinquiryResponse> response = apiInstance.GetStandingOrdersInquiryPostWithHttpInfo(xCorrelationId, xSourceId, generated);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.GetStandingOrdersInquiryPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xCorrelationId** | **string?** | Transaction ID. A unique identifier value that is attached to requests and messages that allow reference to a particular transaction or event chain. | [optional]  |
| **xSourceId** | **string?** | Source ID. A unique identifier value that is attached to requests and messages that allow reference to a particular transaction or specific for a channel. | [optional]  |
| **generated** | [**StandingordersinquiryRequest?**](StandingordersinquiryRequest?.md) |  | [optional]  |

### Return type

[**StandingordersinquiryResponse**](StandingordersinquiryResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** |  |  * x-event-msg - A request status description <br>  * x-event-id - Process level transaction ID can be used for tracing <br>  * x-event-code - Http status code <br>  |
| **400** |  |  -  |
| **500** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="managementinquirypost"></a>
# **ManagementInquiryPost**
> PayloadResponseBeneficiaryUpdate ManagementInquiryPost (string? xCorrelationId = null, string? xSourceId = null, BeneficiaryInquiryRequest? generated = null)



Error Structure for CBD Mobile Services

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Cbd.MobileExperienceApi.Api;
using Cbd.MobileExperienceApi.Client;
using Cbd.MobileExperienceApi.Model;

namespace Example
{
    public class ManagementInquiryPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new DefaultApi(httpClient, config, httpClientHandler);
            var xCorrelationId = "xCorrelationId_example";  // string? | Transaction ID. A unique identifier value that is attached to requests and messages that allow reference to a particular transaction or event chain. (optional) 
            var xSourceId = "xSourceId_example";  // string? | Source ID. A unique identifier value that is attached to requests and messages that allow reference to a particular transaction or specific for a channel. (optional) 
            var generated = new BeneficiaryInquiryRequest?(); // BeneficiaryInquiryRequest? |  (optional) 

            try
            {
                PayloadResponseBeneficiaryUpdate result = apiInstance.ManagementInquiryPost(xCorrelationId, xSourceId, generated);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.ManagementInquiryPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ManagementInquiryPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<PayloadResponseBeneficiaryUpdate> response = apiInstance.ManagementInquiryPostWithHttpInfo(xCorrelationId, xSourceId, generated);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.ManagementInquiryPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xCorrelationId** | **string?** | Transaction ID. A unique identifier value that is attached to requests and messages that allow reference to a particular transaction or event chain. | [optional]  |
| **xSourceId** | **string?** | Source ID. A unique identifier value that is attached to requests and messages that allow reference to a particular transaction or specific for a channel. | [optional]  |
| **generated** | [**BeneficiaryInquiryRequest?**](BeneficiaryInquiryRequest?.md) |  | [optional]  |

### Return type

[**PayloadResponseBeneficiaryUpdate**](PayloadResponseBeneficiaryUpdate.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Bad Request |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="servicesccibservicesgetriminfopost"></a>
# **ServicesCCIBServicesGetRimInfoPost**
> GetRimInfoResponse ServicesCCIBServicesGetRimInfoPost (string? xCorrelationId = null, string? xSourceId = null, GetRimInfoRequest? generated = null)



Servicename used for getRimInfo

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Cbd.MobileExperienceApi.Api;
using Cbd.MobileExperienceApi.Client;
using Cbd.MobileExperienceApi.Model;

namespace Example
{
    public class ServicesCCIBServicesGetRimInfoPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new DefaultApi(httpClient, config, httpClientHandler);
            var xCorrelationId = "xCorrelationId_example";  // string? | Transaction ID. A unique identifier value that is attached to requests and messages that allow reference to a particular transaction or event chain. (optional) 
            var xSourceId = "xSourceId_example";  // string? | Source ID. A unique identifier value that is attached to requests and messages that allow reference to a particular transaction or specific for a channel. (optional) 
            var generated = new GetRimInfoRequest?(); // GetRimInfoRequest? |  (optional) 

            try
            {
                GetRimInfoResponse result = apiInstance.ServicesCCIBServicesGetRimInfoPost(xCorrelationId, xSourceId, generated);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.ServicesCCIBServicesGetRimInfoPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ServicesCCIBServicesGetRimInfoPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<GetRimInfoResponse> response = apiInstance.ServicesCCIBServicesGetRimInfoPostWithHttpInfo(xCorrelationId, xSourceId, generated);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.ServicesCCIBServicesGetRimInfoPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xCorrelationId** | **string?** | Transaction ID. A unique identifier value that is attached to requests and messages that allow reference to a particular transaction or event chain. | [optional]  |
| **xSourceId** | **string?** | Source ID. A unique identifier value that is attached to requests and messages that allow reference to a particular transaction or specific for a channel. | [optional]  |
| **generated** | [**GetRimInfoRequest?**](GetRimInfoRequest?.md) |  | [optional]  |

### Return type

[**GetRimInfoResponse**](GetRimInfoResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** |  |  * x-event-msg - A request status description <br>  * x-event-id - Process level transaction ID can be used for tracing <br>  * x-event-code - Http status code <br>  |
| **400** |  |  -  |
| **401** |  |  -  |
| **404** |  |  -  |
| **500** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="servicescurrentaccountacctaccttrninqpost"></a>
# **ServicesCurrentAccountAcctAcctTrnInqPost**
> AcctAcctTrnInqResponse ServicesCurrentAccountAcctAcctTrnInqPost (string? xCorrelationId = null, string? xSourceId = null, AcctAcctTrnInqRequest? generated = null)



operation for AcctAcctTrnInq services

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Cbd.MobileExperienceApi.Api;
using Cbd.MobileExperienceApi.Client;
using Cbd.MobileExperienceApi.Model;

namespace Example
{
    public class ServicesCurrentAccountAcctAcctTrnInqPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new DefaultApi(httpClient, config, httpClientHandler);
            var xCorrelationId = "xCorrelationId_example";  // string? | Transaction ID. A unique identifier value that is attached to requests and messages that allow reference to a particular transaction or event chain. (optional) 
            var xSourceId = "xSourceId_example";  // string? | Source ID. A unique identifier value that is attached to requests and messages that allow reference to a particular transaction or specific for a channel. (optional) 
            var generated = new AcctAcctTrnInqRequest?(); // AcctAcctTrnInqRequest? |  (optional) 

            try
            {
                AcctAcctTrnInqResponse result = apiInstance.ServicesCurrentAccountAcctAcctTrnInqPost(xCorrelationId, xSourceId, generated);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.ServicesCurrentAccountAcctAcctTrnInqPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ServicesCurrentAccountAcctAcctTrnInqPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<AcctAcctTrnInqResponse> response = apiInstance.ServicesCurrentAccountAcctAcctTrnInqPostWithHttpInfo(xCorrelationId, xSourceId, generated);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.ServicesCurrentAccountAcctAcctTrnInqPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xCorrelationId** | **string?** | Transaction ID. A unique identifier value that is attached to requests and messages that allow reference to a particular transaction or event chain. | [optional]  |
| **xSourceId** | **string?** | Source ID. A unique identifier value that is attached to requests and messages that allow reference to a particular transaction or specific for a channel. | [optional]  |
| **generated** | [**AcctAcctTrnInqRequest?**](AcctAcctTrnInqRequest?.md) |  | [optional]  |

### Return type

[**AcctAcctTrnInqResponse**](AcctAcctTrnInqResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** |  |  * x-event-msg - A request status description <br>  * x-event-id - Process level transaction ID can be used for tracing <br>  * x-event-code - Http status code <br>  |
| **400** |  |  -  |
| **500** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="servicescurrentaccountxferxferaddpost"></a>
# **ServicesCurrentAccountXferXferAddPost**
> XferAddResponse ServicesCurrentAccountXferXferAddPost (string? xCorrelationId = null, string? xSourceId = null, XferAddRequest? generated = null)



operation for AcctAcctTrnInq services

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Cbd.MobileExperienceApi.Api;
using Cbd.MobileExperienceApi.Client;
using Cbd.MobileExperienceApi.Model;

namespace Example
{
    public class ServicesCurrentAccountXferXferAddPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new DefaultApi(httpClient, config, httpClientHandler);
            var xCorrelationId = "xCorrelationId_example";  // string? | Transaction ID. A unique identifier value that is attached to requests and messages that allow reference to a particular transaction or event chain. (optional) 
            var xSourceId = "xSourceId_example";  // string? | Source ID. A unique identifier value that is attached to requests and messages that allow reference to a particular transaction or specific for a channel. (optional) 
            var generated = new XferAddRequest?(); // XferAddRequest? |  (optional) 

            try
            {
                XferAddResponse result = apiInstance.ServicesCurrentAccountXferXferAddPost(xCorrelationId, xSourceId, generated);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.ServicesCurrentAccountXferXferAddPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ServicesCurrentAccountXferXferAddPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<XferAddResponse> response = apiInstance.ServicesCurrentAccountXferXferAddPostWithHttpInfo(xCorrelationId, xSourceId, generated);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.ServicesCurrentAccountXferXferAddPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xCorrelationId** | **string?** | Transaction ID. A unique identifier value that is attached to requests and messages that allow reference to a particular transaction or event chain. | [optional]  |
| **xSourceId** | **string?** | Source ID. A unique identifier value that is attached to requests and messages that allow reference to a particular transaction or specific for a channel. | [optional]  |
| **generated** | [**XferAddRequest?**](XferAddRequest?.md) |  | [optional]  |

### Return type

[**XferAddResponse**](XferAddResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** |  |  * x-event-msg - A request status description <br>  * x-event-id - Process level transaction ID can be used for tracing <br>  * x-event-code - Http status code <br>  |
| **400** |  |  -  |
| **500** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="servicescustomerprofilepartyacctrelinqpost"></a>
# **ServicesCustomerProfilePartyAcctRelInqPost**
> PartyAcctRelInqResponse ServicesCustomerProfilePartyAcctRelInqPost (string? xCorrelationId = null, string? xSourceId = null, PartyAcctRelInqRequest? generated = null)



Get float balance

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Cbd.MobileExperienceApi.Api;
using Cbd.MobileExperienceApi.Client;
using Cbd.MobileExperienceApi.Model;

namespace Example
{
    public class ServicesCustomerProfilePartyAcctRelInqPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new DefaultApi(httpClient, config, httpClientHandler);
            var xCorrelationId = "xCorrelationId_example";  // string? | Transaction ID. A unique identifier value that is attached to requests and messages that allow reference to a particular transaction or event chain. (optional) 
            var xSourceId = "xSourceId_example";  // string? | Source ID. A unique identifier value that is attached to requests and messages that allow reference to a particular transaction or specific for a channel. (optional) 
            var generated = new PartyAcctRelInqRequest?(); // PartyAcctRelInqRequest? |  (optional) 

            try
            {
                PartyAcctRelInqResponse result = apiInstance.ServicesCustomerProfilePartyAcctRelInqPost(xCorrelationId, xSourceId, generated);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.ServicesCustomerProfilePartyAcctRelInqPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ServicesCustomerProfilePartyAcctRelInqPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<PartyAcctRelInqResponse> response = apiInstance.ServicesCustomerProfilePartyAcctRelInqPostWithHttpInfo(xCorrelationId, xSourceId, generated);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.ServicesCustomerProfilePartyAcctRelInqPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xCorrelationId** | **string?** | Transaction ID. A unique identifier value that is attached to requests and messages that allow reference to a particular transaction or event chain. | [optional]  |
| **xSourceId** | **string?** | Source ID. A unique identifier value that is attached to requests and messages that allow reference to a particular transaction or specific for a channel. | [optional]  |
| **generated** | [**PartyAcctRelInqRequest?**](PartyAcctRelInqRequest?.md) |  | [optional]  |

### Return type

[**PartyAcctRelInqResponse**](PartyAcctRelInqResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** |  |  * x-event-msg - A request status description <br>  * x-event-id - Process level transaction ID can be used for tracing <br>  * x-event-code - Http status code <br>  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="servicescustomerprofilepartyinqpost"></a>
# **ServicesCustomerProfilePartyInqPost**
> PartyInqResponse ServicesCustomerProfilePartyInqPost (string? xCorrelationId = null, string? xSourceId = null, PartyInqRequest? generated = null)



operation for PartyInq services

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Cbd.MobileExperienceApi.Api;
using Cbd.MobileExperienceApi.Client;
using Cbd.MobileExperienceApi.Model;

namespace Example
{
    public class ServicesCustomerProfilePartyInqPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new DefaultApi(httpClient, config, httpClientHandler);
            var xCorrelationId = "xCorrelationId_example";  // string? | Transaction ID. A unique identifier value that is attached to requests and messages that allow reference to a particular transaction or event chain. (optional) 
            var xSourceId = "xSourceId_example";  // string? | Source ID. A unique identifier value that is attached to requests and messages that allow reference to a particular transaction or specific for a channel. (optional) 
            var generated = new PartyInqRequest?(); // PartyInqRequest? |  (optional) 

            try
            {
                PartyInqResponse result = apiInstance.ServicesCustomerProfilePartyInqPost(xCorrelationId, xSourceId, generated);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.ServicesCustomerProfilePartyInqPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ServicesCustomerProfilePartyInqPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<PartyInqResponse> response = apiInstance.ServicesCustomerProfilePartyInqPostWithHttpInfo(xCorrelationId, xSourceId, generated);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.ServicesCustomerProfilePartyInqPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xCorrelationId** | **string?** | Transaction ID. A unique identifier value that is attached to requests and messages that allow reference to a particular transaction or event chain. | [optional]  |
| **xSourceId** | **string?** | Source ID. A unique identifier value that is attached to requests and messages that allow reference to a particular transaction or specific for a channel. | [optional]  |
| **generated** | [**PartyInqRequest?**](PartyInqRequest?.md) |  | [optional]  |

### Return type

[**PartyInqResponse**](PartyInqResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** |  |  * x-event-msg - A request status description <br>  * x-event-id - Process level transaction ID can be used for tracing <br>  * x-event-code - Http status code <br>  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="servicesgenericapiexecuteservicepost"></a>
# **ServicesGenericAPIExecuteServicePost**
> Type18 ServicesGenericAPIExecuteServicePost (string? xCorrelationId = null, string? xSourceId = null, string? contentType = null, Type17? generated = null)



Contains base request headers

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Cbd.MobileExperienceApi.Api;
using Cbd.MobileExperienceApi.Client;
using Cbd.MobileExperienceApi.Model;

namespace Example
{
    public class ServicesGenericAPIExecuteServicePostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new DefaultApi(httpClient, config, httpClientHandler);
            var xCorrelationId = "xCorrelationId_example";  // string? | Transaction ID. A unique identifier value that is attached to requests and messages that allow reference to a particular transaction or event chain. (optional) 
            var xSourceId = "xSourceId_example";  // string? | Source ID. A unique identifier value that is attached to requests and messages that allow reference to a particular transaction or specific for a channel. (optional) 
            var contentType = "contentType_example";  // string? | Content type of the request (optional) 
            var generated = new Type17?(); // Type17? |  (optional) 

            try
            {
                Type18 result = apiInstance.ServicesGenericAPIExecuteServicePost(xCorrelationId, xSourceId, contentType, generated);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.ServicesGenericAPIExecuteServicePost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ServicesGenericAPIExecuteServicePostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<Type18> response = apiInstance.ServicesGenericAPIExecuteServicePostWithHttpInfo(xCorrelationId, xSourceId, contentType, generated);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.ServicesGenericAPIExecuteServicePostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xCorrelationId** | **string?** | Transaction ID. A unique identifier value that is attached to requests and messages that allow reference to a particular transaction or event chain. | [optional]  |
| **xSourceId** | **string?** | Source ID. A unique identifier value that is attached to requests and messages that allow reference to a particular transaction or specific for a channel. | [optional]  |
| **contentType** | **string?** | Content type of the request | [optional]  |
| **generated** | [**Type17?**](Type17?.md) |  | [optional]  |

### Return type

[**Type18**](Type18.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="servicesremittanceremitaddpost"></a>
# **ServicesRemittanceRemitAddPost**
> RemitAddResponse ServicesRemittanceRemitAddPost (string? xCorrelationId = null, string? xSourceId = null, RemitAddRequest? generated = null)



Error Structure for CBD Mobile Services

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Cbd.MobileExperienceApi.Api;
using Cbd.MobileExperienceApi.Client;
using Cbd.MobileExperienceApi.Model;

namespace Example
{
    public class ServicesRemittanceRemitAddPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new DefaultApi(httpClient, config, httpClientHandler);
            var xCorrelationId = "xCorrelationId_example";  // string? | Transaction ID. A unique identifier value that is attached to requests and messages that allow reference to a particular transaction or event chain. (optional) 
            var xSourceId = "xSourceId_example";  // string? | Source ID. A unique identifier value that is attached to requests and messages that allow reference to a particular transaction or specific for a channel. (optional) 
            var generated = new RemitAddRequest?(); // RemitAddRequest? |  (optional) 

            try
            {
                RemitAddResponse result = apiInstance.ServicesRemittanceRemitAddPost(xCorrelationId, xSourceId, generated);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.ServicesRemittanceRemitAddPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ServicesRemittanceRemitAddPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<RemitAddResponse> response = apiInstance.ServicesRemittanceRemitAddPostWithHttpInfo(xCorrelationId, xSourceId, generated);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.ServicesRemittanceRemitAddPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xCorrelationId** | **string?** | Transaction ID. A unique identifier value that is attached to requests and messages that allow reference to a particular transaction or event chain. | [optional]  |
| **xSourceId** | **string?** | Source ID. A unique identifier value that is attached to requests and messages that allow reference to a particular transaction or specific for a channel. | [optional]  |
| **generated** | [**RemitAddRequest?**](RemitAddRequest?.md) |  | [optional]  |

### Return type

[**RemitAddResponse**](RemitAddResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** |  |  * x-event-msg - A request status description <br>  * x-event-id - Process level transaction ID can be used for tracing <br>  * x-event-code - Http status code <br>  |
| **400** |  |  -  |
| **500** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="servicesremittanceremitstatinqpost"></a>
# **ServicesRemittanceRemitStatInqPost**
> RemitStatInqRs ServicesRemittanceRemitStatInqPost (string? xCorrelationId = null, string? xSourceId = null, RemitStatInqRq? generated = null)



Error Structure for CBD Mobile Services

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Cbd.MobileExperienceApi.Api;
using Cbd.MobileExperienceApi.Client;
using Cbd.MobileExperienceApi.Model;

namespace Example
{
    public class ServicesRemittanceRemitStatInqPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new DefaultApi(httpClient, config, httpClientHandler);
            var xCorrelationId = "xCorrelationId_example";  // string? | Transaction ID. A unique identifier value that is attached to requests and messages that allow reference to a particular transaction or event chain. (optional) 
            var xSourceId = "xSourceId_example";  // string? | Source ID. A unique identifier value that is attached to requests and messages that allow reference to a particular transaction or specific for a channel. (optional) 
            var generated = new RemitStatInqRq?(); // RemitStatInqRq? |  (optional) 

            try
            {
                RemitStatInqRs result = apiInstance.ServicesRemittanceRemitStatInqPost(xCorrelationId, xSourceId, generated);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.ServicesRemittanceRemitStatInqPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ServicesRemittanceRemitStatInqPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<RemitStatInqRs> response = apiInstance.ServicesRemittanceRemitStatInqPostWithHttpInfo(xCorrelationId, xSourceId, generated);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.ServicesRemittanceRemitStatInqPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xCorrelationId** | **string?** | Transaction ID. A unique identifier value that is attached to requests and messages that allow reference to a particular transaction or event chain. | [optional]  |
| **xSourceId** | **string?** | Source ID. A unique identifier value that is attached to requests and messages that allow reference to a particular transaction or specific for a channel. | [optional]  |
| **generated** | [**RemitStatInqRq?**](RemitStatInqRq?.md) |  | [optional]  |

### Return type

[**RemitStatInqRs**](RemitStatInqRs.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** |  |  * x-event-msg - A request status description <br>  * x-event-id - Process level transaction ID can be used for tracing <br>  * x-event-code - Http status code <br>  |
| **400** |  |  -  |
| **500** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="servicesvalidateibandetailspost"></a>
# **ServicesValidateIbanDetailsPost**
> ValidateIbanDetailsResponse ServicesValidateIbanDetailsPost (string? xCorrelationId = null, string? xSourceId = null, ValidateIbanDetailsRequest? generated = null)



Error Structure for CBD Mobile Services

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Cbd.MobileExperienceApi.Api;
using Cbd.MobileExperienceApi.Client;
using Cbd.MobileExperienceApi.Model;

namespace Example
{
    public class ServicesValidateIbanDetailsPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new DefaultApi(httpClient, config, httpClientHandler);
            var xCorrelationId = "xCorrelationId_example";  // string? | Transaction ID. A unique identifier value that is attached to requests and messages that allow reference to a particular transaction or event chain. (optional) 
            var xSourceId = "xSourceId_example";  // string? | Source ID. A unique identifier value that is attached to requests and messages that allow reference to a particular transaction or specific for a channel. (optional) 
            var generated = new ValidateIbanDetailsRequest?(); // ValidateIbanDetailsRequest? |  (optional) 

            try
            {
                ValidateIbanDetailsResponse result = apiInstance.ServicesValidateIbanDetailsPost(xCorrelationId, xSourceId, generated);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.ServicesValidateIbanDetailsPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ServicesValidateIbanDetailsPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ValidateIbanDetailsResponse> response = apiInstance.ServicesValidateIbanDetailsPostWithHttpInfo(xCorrelationId, xSourceId, generated);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.ServicesValidateIbanDetailsPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xCorrelationId** | **string?** | Transaction ID. A unique identifier value that is attached to requests and messages that allow reference to a particular transaction or event chain. | [optional]  |
| **xSourceId** | **string?** | Source ID. A unique identifier value that is attached to requests and messages that allow reference to a particular transaction or specific for a channel. | [optional]  |
| **generated** | [**ValidateIbanDetailsRequest?**](ValidateIbanDetailsRequest?.md) |  | [optional]  |

### Return type

[**ValidateIbanDetailsResponse**](ValidateIbanDetailsResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** |  |  * x-event-msg - A request status description <br>  * x-event-id - Process level transaction ID can be used for tracing <br>  * x-event-code - Http status code <br>  |
| **400** |  |  -  |
| **500** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

