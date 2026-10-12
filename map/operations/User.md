<!-- Generated file — do not edit; regenerated with the SDK. -->

# User — operations

Accessor: `client.User` · Source: `src/TeslaFleetManagementApi/Api/User.cs` · 4 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### GetActiveOrdersForAUser

- **Auth**: `options.ThirdpartytokenAuthorizationCode` OR `options.ThirdpartytokenClientCredentials`
- **Signature**: `GetActiveOrdersForAUser(RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Returns**: `OrdersResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `OrdersResponse` | `src/TeslaFleetManagementApi/Models/OrdersResponse.cs` |

### GetCustomFeatureFlagsForAUser

- **Auth**: `options.ThirdpartytokenAuthorizationCode` OR `options.ThirdpartytokenClientCredentials`
- **Signature**: `GetCustomFeatureFlagsForAUser(RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Returns**: `BackupResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `BackupResponse` | `src/TeslaFleetManagementApi/Models/BackupResponse.cs` |

### GetSummaryOfAUserSAccount

- **Auth**: `options.ThirdpartytokenAuthorizationCode` OR `options.ThirdpartytokenClientCredentials`
- **Signature**: `GetSummaryOfAUserSAccount(RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Returns**: `MeResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `MeResponse` | `src/TeslaFleetManagementApi/Models/MeResponse.cs` |

### GetUserSRegionAndFleetApiBaseUrl

- **Auth**: `options.ThirdpartytokenAuthorizationCode` OR `options.ThirdpartytokenClientCredentials`
- **Signature**: `GetUserSRegionAndFleetApiBaseUrl(RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Returns**: `RegionResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `RegionResponse` | `src/TeslaFleetManagementApi/Models/RegionResponse.cs` |

