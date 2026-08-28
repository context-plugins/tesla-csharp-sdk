<!-- Generated file — do not edit; regenerated with the SDK. -->

# Partner — operations

Accessor: `client.Partner` · Source: `Api/Partner.cs` · 4 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### GetPublicKeyForADomain

- **Signature**: `GetPublicKeyForADomain(string domain, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Query params (wire ← C#)**: `domain` ← `domain`
- **Returns**: `PublicKeyResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `PublicKeyResponse` | `Models/PublicKeyResponse.cs` |

### GetRecentFleetTelemetryErrors

- **Signature**: `GetRecentFleetTelemetryErrors(RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `FleetTelemetryErrorsResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `FleetTelemetryErrorsResponse` | `Models/FleetTelemetryErrorsResponse.cs` |

### GetVinsWithFleetTelemetryErrors

- **Signature**: `GetVinsWithFleetTelemetryErrors(RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `BackupResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `BackupResponse` | `Models/BackupResponse.cs` |

### RegisterAPartnerAccount

- **Signature**: `RegisterAPartnerAccount(RegisterPartnerRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `RegisterPartnerResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `RegisterPartnerRequest` | `Models/RegisterPartnerRequest.cs` |
| `RegisterPartnerResponse` | `Models/RegisterPartnerResponse.cs` |

