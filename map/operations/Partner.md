<!-- Generated file — do not edit; regenerated with the SDK. -->

# Partner — operations

Accessor: `client.Partner` · Source: `src/TeslaFleetManagementApi/Api/Partner.cs` · 4 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### GetPublicKeyForADomain

- **Auth**: `options.ThirdpartytokenAuthorizationCode` OR `options.ThirdpartytokenClientCredentials`
- **Signature**: `GetPublicKeyForADomain(GetPublicKeyForADomainRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Domain`
- **Query params (wire ← C#)**: `domain` ← `Domain`
- **Returns**: `PublicKeyResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `GetPublicKeyForADomainRequest` | `src/TeslaFleetManagementApi/Requests/Partner/GetPublicKeyForADomainRequest.cs` |
| `PublicKeyResponse` | `src/TeslaFleetManagementApi/Models/PublicKeyResponse.cs` |

### GetRecentFleetTelemetryErrors

- **Auth**: `options.ThirdpartytokenAuthorizationCode` OR `options.ThirdpartytokenClientCredentials`
- **Signature**: `GetRecentFleetTelemetryErrors(RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Returns**: `FleetTelemetryErrorsResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `FleetTelemetryErrorsResponse` | `src/TeslaFleetManagementApi/Models/FleetTelemetryErrorsResponse.cs` |

### GetVinsWithFleetTelemetryErrors

- **Auth**: `options.ThirdpartytokenAuthorizationCode` OR `options.ThirdpartytokenClientCredentials`
- **Signature**: `GetVinsWithFleetTelemetryErrors(RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Returns**: `BackupResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `BackupResponse` | `src/TeslaFleetManagementApi/Models/BackupResponse.cs` |

### RegisterAPartnerAccount

- **Auth**: `options.ThirdpartytokenAuthorizationCode` OR `options.ThirdpartytokenClientCredentials`
- **Signature**: `RegisterAPartnerAccount(RegisterAPartnerAccountRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `RegisterPartnerResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `RegisterAPartnerAccountRequest` | `src/TeslaFleetManagementApi/Requests/Partner/RegisterAPartnerAccountRequest.cs` |
| `RegisterPartnerRequest` | `src/TeslaFleetManagementApi/Models/RegisterPartnerRequest.cs` |
| `RegisterPartnerResponse` | `src/TeslaFleetManagementApi/Models/RegisterPartnerResponse.cs` |

