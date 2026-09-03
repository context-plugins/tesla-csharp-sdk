<!-- Generated file — do not edit; regenerated with the SDK. -->

# User — operations

Accessor: `client.User` · Source: `Api/User.cs` · 4 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### GetActiveOrdersForAUser

- **Auth**: `options.ThirdpartytokenAuthorizationCode` OR `options.ThirdpartytokenClientCredentials`
- **Signature**: `GetActiveOrdersForAUser(RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `OrdersResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `OrdersResponse` | `Models/OrdersResponse.cs` |

### GetCustomFeatureFlagsForAUser

- **Auth**: `options.ThirdpartytokenAuthorizationCode` OR `options.ThirdpartytokenClientCredentials`
- **Signature**: `GetCustomFeatureFlagsForAUser(RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `BackupResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `BackupResponse` | `Models/BackupResponse.cs` |

### GetSummaryOfAUserSAccount

- **Auth**: `options.ThirdpartytokenAuthorizationCode` OR `options.ThirdpartytokenClientCredentials`
- **Signature**: `GetSummaryOfAUserSAccount(RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `MeResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `MeResponse` | `Models/MeResponse.cs` |

### GetUserSRegionAndFleetApiBaseUrl

- **Auth**: `options.ThirdpartytokenAuthorizationCode` OR `options.ThirdpartytokenClientCredentials`
- **Signature**: `GetUserSRegionAndFleetApiBaseUrl(RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `RegionResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `RegionResponse` | `Models/RegionResponse.cs` |

