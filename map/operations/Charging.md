<!-- Generated file — do not edit; regenerated with the SDK. -->

# Charging — operations

Accessor: `client.Charging` · Source: `Api/Charging.cs` · 3 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### GetChargingHistory

- **Auth**: `options.ThirdpartytokenAuthorizationCode` OR `options.ThirdpartytokenClientCredentials`
- **Signature**: `GetChargingHistory(RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `ChargingHistoryResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ChargingHistoryResponse` | `Models/ChargingHistoryResponse.cs` |

### GetChargingInvoice

- **Auth**: `options.ThirdpartytokenAuthorizationCode` OR `options.ThirdpartytokenClientCredentials`
- **Signature**: `GetChargingInvoice(string id, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `void` (Task)
- **Error**: `SdkException<RawError>` — **Case B**

### GetChargingSessions

- **Auth**: `options.ThirdpartytokenAuthorizationCode` OR `options.ThirdpartytokenClientCredentials`
- **Signature**: `GetChargingSessions(RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `ChargingSessionsResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ChargingSessionsResponse` | `Models/ChargingSessionsResponse.cs` |

