<!-- Generated file — do not edit; regenerated with the SDK. -->

# Energy — operations

Accessor: `client.Energy` · Source: `src/TeslaFleetManagementApi/Api/Energy.cs` · 11 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### AdjustSiteSBackupReserve

- **Auth**: `options.ThirdpartytokenAuthorizationCode` OR `options.ThirdpartytokenClientCredentials`
- **Signature**: `AdjustSiteSBackupReserve(AdjustSiteSBackupReserveRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `EnergySiteId`, `Body`
- **Returns**: `BackupResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `AdjustSiteSBackupReserveRequest` | `src/TeslaFleetManagementApi/Requests/Energy/AdjustSiteSBackupReserveRequest.cs` |
| `BackupRequest` | `src/TeslaFleetManagementApi/Models/BackupRequest.cs` |
| `BackupResponse` | `src/TeslaFleetManagementApi/Models/BackupResponse.cs` |

### AdjustSiteSOffGridVehicleChargingReserve

- **Auth**: `options.ThirdpartytokenAuthorizationCode` OR `options.ThirdpartytokenClientCredentials`
- **Signature**: `AdjustSiteSOffGridVehicleChargingReserve(AdjustSiteSOffGridVehicleChargingReserveRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `EnergySiteId`, `Body`
- **Returns**: `GenericUpdateResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `AdjustSiteSOffGridVehicleChargingReserveRequest` | `src/TeslaFleetManagementApi/Requests/Energy/AdjustSiteSOffGridVehicleChargingReserveRequest.cs` |
| `OffGridVehicleChargingReserveRequest` | `src/TeslaFleetManagementApi/Models/OffGridVehicleChargingReserveRequest.cs` |
| `GenericUpdateResponse` | `src/TeslaFleetManagementApi/Models/GenericUpdateResponse.cs` |

### AllowDisallowChargingFromTheGridAndExportingEnergyToTheGrid

- **Auth**: `options.ThirdpartytokenAuthorizationCode` OR `options.ThirdpartytokenClientCredentials`
- **Signature**: `AllowDisallowChargingFromTheGridAndExportingEnergyToTheGrid(AllowDisallowChargingFromTheGridAndExportingEnergyToTheGridRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `EnergySiteId`
- **Returns**: `GenericUpdateResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `AllowDisallowChargingFromTheGridAndExportingEnergyToTheGridRequest` | `src/TeslaFleetManagementApi/Requests/Energy/AllowDisallowChargingFromTheGridAndExportingEnergyToTheGridRequest.cs` |
| `GenericUpdateResponse` | `src/TeslaFleetManagementApi/Models/GenericUpdateResponse.cs` |

### GetBackupOrEnergyHistory

- **Auth**: `options.ThirdpartytokenAuthorizationCode` OR `options.ThirdpartytokenClientCredentials`
- **Signature**: `GetBackupOrEnergyHistory(GetBackupOrEnergyHistoryRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `EnergySiteId`, `Kind`, `StartDate`, `EndDate`
- **Query params (wire ← C#)**: `kind` ← `Kind`, `start_date` ← `StartDate`, `end_date` ← `EndDate`, `period` ← `Period`, `time_zone` ← `TimeZone`
- **Returns**: `CalendarHistoryResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `GetBackupOrEnergyHistoryRequest` | `src/TeslaFleetManagementApi/Requests/Energy/GetBackupOrEnergyHistoryRequest.cs` |
| `Kind` | `src/TeslaFleetManagementApi/Models/Enums/Kind.cs` |
| `CalendarHistoryResponse` | `src/TeslaFleetManagementApi/Models/CalendarHistoryResponse.cs` |

### GetLiveSiteStatus

- **Auth**: `options.ThirdpartytokenAuthorizationCode` OR `options.ThirdpartytokenClientCredentials`
- **Signature**: `GetLiveSiteStatus(GetLiveSiteStatusRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `EnergySiteId`
- **Returns**: `LiveStatusResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `GetLiveSiteStatusRequest` | `src/TeslaFleetManagementApi/Requests/Energy/GetLiveSiteStatusRequest.cs` |
| `LiveStatusResponse` | `src/TeslaFleetManagementApi/Models/LiveStatusResponse.cs` |

### GetSiteInformationAssetsSettingsFeatures

- **Auth**: `options.ThirdpartytokenAuthorizationCode` OR `options.ThirdpartytokenClientCredentials`
- **Signature**: `GetSiteInformationAssetsSettingsFeatures(GetSiteInformationAssetsSettingsFeaturesRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `EnergySiteId`
- **Returns**: `SiteInfoResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `GetSiteInformationAssetsSettingsFeaturesRequest` | `src/TeslaFleetManagementApi/Requests/Energy/GetSiteInformationAssetsSettingsFeaturesRequest.cs` |
| `SiteInfoResponse` | `src/TeslaFleetManagementApi/Models/SiteInfoResponse.cs` |

### GetUserProductsVehiclesEnergySites

- **Auth**: `options.ThirdpartytokenAuthorizationCode` OR `options.ThirdpartytokenClientCredentials`
- **Signature**: `GetUserProductsVehiclesEnergySites(RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Returns**: `ProductsResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ProductsResponse` | `src/TeslaFleetManagementApi/Models/ProductsResponse.cs` |

### GetWallConnectorChargingHistory

- **Auth**: `options.ThirdpartytokenAuthorizationCode` OR `options.ThirdpartytokenClientCredentials`
- **Signature**: `GetWallConnectorChargingHistory(GetWallConnectorChargingHistoryRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `EnergySiteId`, `Kind`, `StartDate`, `EndDate`
- **Query params (wire ← C#)**: `kind` ← `Kind`, `start_date` ← `StartDate`, `end_date` ← `EndDate`, `time_zone` ← `TimeZone`
- **Returns**: `ChargeHistoryResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `GetWallConnectorChargingHistoryRequest` | `src/TeslaFleetManagementApi/Requests/Energy/GetWallConnectorChargingHistoryRequest.cs` |
| `KindGetWallConnectorChargingHistory` | `src/TeslaFleetManagementApi/Models/Enums/KindGetWallConnectorChargingHistory.cs` |
| `ChargeHistoryResponse` | `src/TeslaFleetManagementApi/Models/ChargeHistoryResponse.cs` |

### SetSiteModeAutonomousOrSelfConsumption

- **Auth**: `options.ThirdpartytokenAuthorizationCode` OR `options.ThirdpartytokenClientCredentials`
- **Signature**: `SetSiteModeAutonomousOrSelfConsumption(SetSiteModeAutonomousOrSelfConsumptionRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `EnergySiteId`, `Body`
- **Returns**: `GenericUpdateResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `SetSiteModeAutonomousOrSelfConsumptionRequest` | `src/TeslaFleetManagementApi/Requests/Energy/SetSiteModeAutonomousOrSelfConsumptionRequest.cs` |
| `OperationRequest` | `src/TeslaFleetManagementApi/Models/OperationRequest.cs` |
| `GenericUpdateResponse` | `src/TeslaFleetManagementApi/Models/GenericUpdateResponse.cs` |

### UpdateStormWatchParticipation

- **Auth**: `options.ThirdpartytokenAuthorizationCode` OR `options.ThirdpartytokenClientCredentials`
- **Signature**: `UpdateStormWatchParticipation(UpdateStormWatchParticipationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `EnergySiteId`, `Body`
- **Returns**: `GenericUpdateResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `UpdateStormWatchParticipationRequest` | `src/TeslaFleetManagementApi/Requests/Energy/UpdateStormWatchParticipationRequest.cs` |
| `StormModeRequest` | `src/TeslaFleetManagementApi/Models/StormModeRequest.cs` |
| `GenericUpdateResponse` | `src/TeslaFleetManagementApi/Models/GenericUpdateResponse.cs` |

### UpdateTimeOfUseTouSettings

- **Auth**: `options.ThirdpartytokenAuthorizationCode` OR `options.ThirdpartytokenClientCredentials`
- **Signature**: `UpdateTimeOfUseTouSettings(UpdateTimeOfUseTouSettingsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `EnergySiteId`, `Body`
- **Returns**: `GenericUpdateResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `UpdateTimeOfUseTouSettingsRequest` | `src/TeslaFleetManagementApi/Requests/Energy/UpdateTimeOfUseTouSettingsRequest.cs` |
| `TimeOfUseSettingsRequest` | `src/TeslaFleetManagementApi/Models/TimeOfUseSettingsRequest.cs` |
| `GenericUpdateResponse` | `src/TeslaFleetManagementApi/Models/GenericUpdateResponse.cs` |

