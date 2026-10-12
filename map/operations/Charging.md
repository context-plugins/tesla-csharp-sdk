<!-- Generated file — do not edit; regenerated with the SDK. -->

# Charging — operations

Accessor: `client.Charging` · Source: `src/TeslaFleetManagementApi/Api/Charging.cs` · 3 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### GetChargingHistory

- **Auth**: `options.ThirdpartytokenAuthorizationCode` OR `options.ThirdpartytokenClientCredentials`
- **Signature**: `GetChargingHistory(RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Returns**: `ChargingHistoryResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ChargingHistoryResponse` | `src/TeslaFleetManagementApi/Models/ChargingHistoryResponse.cs` |

### GetChargingInvoice

- **Auth**: `options.ThirdpartytokenAuthorizationCode` OR `options.ThirdpartytokenClientCredentials`
- **Signature**: `GetChargingInvoice(GetChargingInvoiceRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`
- **Returns**: `void` (Task)
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `GetChargingInvoiceRequest` | `src/TeslaFleetManagementApi/Requests/Charging/GetChargingInvoiceRequest.cs` |

### GetChargingSessions

- **Auth**: `options.ThirdpartytokenAuthorizationCode` OR `options.ThirdpartytokenClientCredentials`
- **Signature**: `GetChargingSessions(RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Returns**: `ChargingSessionsResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ChargingSessionsResponse` | `src/TeslaFleetManagementApi/Models/ChargingSessionsResponse.cs` |

