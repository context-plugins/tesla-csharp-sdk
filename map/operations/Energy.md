<!-- Generated file — do not edit; regenerated with the SDK. -->

# Energy — operations

Accessor: `client.Energy` · Source: `Api/Energy.cs` · 11 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### AdjustSiteSBackupReserve

- **Signature**: `AdjustSiteSBackupReserve(string energySiteId, BackupRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `BackupResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `BackupRequest` | `Models/BackupRequest.cs` |
| `BackupResponse` | `Models/BackupResponse.cs` |

### AdjustSiteSOffGridVehicleChargingReserve

- **Signature**: `AdjustSiteSOffGridVehicleChargingReserve(string energySiteId, OffGridVehicleChargingReserveRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `GenericUpdateResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `OffGridVehicleChargingReserveRequest` | `Models/OffGridVehicleChargingReserveRequest.cs` |
| `GenericUpdateResponse` | `Models/GenericUpdateResponse.cs` |

### AllowDisallowChargingFromTheGridAndExportingEnergyToTheGrid

- **Signature**: `AllowDisallowChargingFromTheGridAndExportingEnergyToTheGrid(string energySiteId, object? body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `body` — nullable, no default → **must pass explicitly**
- **Returns**: `GenericUpdateResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `GenericUpdateResponse` | `Models/GenericUpdateResponse.cs` |

### GetBackupOrEnergyHistory

- **Signature**: `GetBackupOrEnergyHistory(string energySiteId, Kind kind, DateTimeOffset startDate, DateTimeOffset endDate, string? period, string? timeZone, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `period` — nullable, no default → **must pass explicitly**
  - `timeZone` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `kind` ← `kind`, `start_date` ← `startDate`, `end_date` ← `endDate`, `period` ← `period`, `time_zone` ← `timeZone`
- **Returns**: `CalendarHistoryResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `Kind` | `Models/Enums/Kind.cs` |
| `CalendarHistoryResponse` | `Models/CalendarHistoryResponse.cs` |

### GetLiveSiteStatus

- **Signature**: `GetLiveSiteStatus(string energySiteId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `LiveStatusResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `LiveStatusResponse` | `Models/LiveStatusResponse.cs` |

### GetSiteInformationAssetsSettingsFeatures

- **Signature**: `GetSiteInformationAssetsSettingsFeatures(string energySiteId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `SiteInfoResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `SiteInfoResponse` | `Models/SiteInfoResponse.cs` |

### GetUserProductsVehiclesEnergySites

- **Signature**: `GetUserProductsVehiclesEnergySites(RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `ProductsResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ProductsResponse` | `Models/ProductsResponse.cs` |

### GetWallConnectorChargingHistory

- **Signature**: `GetWallConnectorChargingHistory(string energySiteId, KindGetWallConnectorChargingHistory kind, DateTimeOffset startDate, DateTimeOffset endDate, string? timeZone, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `timeZone` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `kind` ← `kind`, `start_date` ← `startDate`, `end_date` ← `endDate`, `time_zone` ← `timeZone`
- **Returns**: `ChargeHistoryResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `KindGetWallConnectorChargingHistory` | `Models/Enums/KindGetWallConnectorChargingHistory.cs` |
| `ChargeHistoryResponse` | `Models/ChargeHistoryResponse.cs` |

### SetSiteModeAutonomousOrSelfConsumption

- **Signature**: `SetSiteModeAutonomousOrSelfConsumption(string energySiteId, OperationRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `GenericUpdateResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `OperationRequest` | `Models/OperationRequest.cs` |
| `GenericUpdateResponse` | `Models/GenericUpdateResponse.cs` |

### UpdateStormWatchParticipation

- **Signature**: `UpdateStormWatchParticipation(string energySiteId, StormModeRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `GenericUpdateResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `StormModeRequest` | `Models/StormModeRequest.cs` |
| `GenericUpdateResponse` | `Models/GenericUpdateResponse.cs` |

### UpdateTimeOfUseTouSettings

- **Signature**: `UpdateTimeOfUseTouSettings(string energySiteId, TimeOfUseSettingsRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `GenericUpdateResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `TimeOfUseSettingsRequest` | `Models/TimeOfUseSettingsRequest.cs` |
| `GenericUpdateResponse` | `Models/GenericUpdateResponse.cs` |

