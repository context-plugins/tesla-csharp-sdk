<!-- Generated file — do not edit; regenerated with the SDK. -->

# Vehicles — operations

Accessor: `client.Vehicles` · Source: `Api/Vehicles.cs` · 21 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### ConfigureFleetTelemetryUsingSignedJwsToken

- **Auth**: `options.ThirdpartytokenAuthorizationCode` OR `options.ThirdpartytokenClientCredentials`
- **Signature**: `ConfigureFleetTelemetryUsingSignedJwsToken(FleetTelemetryJwsRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `object`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `FleetTelemetryJwsRequest` | `Models/FleetTelemetryJwsRequest.cs` |

### CreateOrUpdateFleetTelemetryConfiguration

- **Auth**: `options.ThirdpartytokenAuthorizationCode` OR `options.ThirdpartytokenClientCredentials`
- **Signature**: `CreateOrUpdateFleetTelemetryConfiguration(object body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `object`
- **Error**: `SdkException<RawError>` — **Case B**

### DeleteFleetTelemetryConfiguration

- **Auth**: `options.ThirdpartytokenAuthorizationCode` OR `options.ThirdpartytokenClientCredentials`
- **Signature**: `DeleteFleetTelemetryConfiguration(string vehicleTag, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `object`
- **Error**: `SdkException<RawError>` — **Case B**

### GetAllowedDriversForAVehicle

- **Auth**: `options.ThirdpartytokenAuthorizationCode` OR `options.ThirdpartytokenClientCredentials`
- **Signature**: `GetAllowedDriversForAVehicle(string vehicleTag, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `DriversResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `DriversResponse` | `Models/DriversResponse.cs` |

### GetEligibleVehicleSubscriptions

- **Auth**: `options.ThirdpartytokenAuthorizationCode` OR `options.ThirdpartytokenClientCredentials`
- **Signature**: `GetEligibleVehicleSubscriptions(string vin, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Query params (wire ← C#)**: `vin` ← `vin`
- **Returns**: `SiteInfoResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `SiteInfoResponse` | `Models/SiteInfoResponse.cs` |

### GetEligibleVehicleUpgrades

- **Auth**: `options.ThirdpartytokenAuthorizationCode` OR `options.ThirdpartytokenClientCredentials`
- **Signature**: `GetEligibleVehicleUpgrades(string vin, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Query params (wire ← C#)**: `vin` ← `vin`
- **Returns**: `SiteInfoResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `SiteInfoResponse` | `Models/SiteInfoResponse.cs` |

### GetEnterpriseRolesForAVehicle

- **Auth**: `options.ThirdpartytokenAuthorizationCode` OR `options.ThirdpartytokenClientCredentials`
- **Signature**: `GetEnterpriseRolesForAVehicle(string vin, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `object`
- **Error**: `SdkException<RawError>` — **Case B**

### GetFleetStatusForVehicles

- **Auth**: `options.ThirdpartytokenAuthorizationCode` OR `options.ThirdpartytokenClientCredentials`
- **Signature**: `GetFleetStatusForVehicles(FleetStatusRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `object`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `FleetStatusRequest` | `Models/FleetStatusRequest.cs` |

### GetFleetTelemetryConfiguration

- **Auth**: `options.ThirdpartytokenAuthorizationCode` OR `options.ThirdpartytokenClientCredentials`
- **Signature**: `GetFleetTelemetryConfiguration(string vehicleTag, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `object`
- **Error**: `SdkException<RawError>` — **Case B**

### GetFleetTelemetryErrorsForAVehicle

- **Auth**: `options.ThirdpartytokenAuthorizationCode` OR `options.ThirdpartytokenClientCredentials`
- **Signature**: `GetFleetTelemetryErrorsForAVehicle(string vehicleTag, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `object`
- **Error**: `SdkException<RawError>` — **Case B**

### GetVehicle

- **Auth**: `options.ThirdpartytokenAuthorizationCode` OR `options.ThirdpartytokenClientCredentials`
- **Signature**: `GetVehicle(string vehicleTag, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `Api1VehiclesResponseResponse200`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `Api1VehiclesResponseResponse200` | `Models/Api1VehiclesResponseResponse200.cs` |

### ListVehicles

- **Auth**: `options.ThirdpartytokenAuthorizationCode` OR `options.ThirdpartytokenClientCredentials`
- **Signature**: `ListVehicles(RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `Api1VehiclesResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `Api1VehiclesResponse` | `Models/Api1VehiclesResponse.cs` |

### MobileEnabled

- **Auth**: `options.ThirdpartytokenAuthorizationCode` OR `options.ThirdpartytokenClientCredentials`
- **Signature**: `MobileEnabled(string vehicleTag, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `Api1VehiclesMobileEnabledResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `Api1VehiclesMobileEnabledResponse` | `Models/Api1VehiclesMobileEnabledResponse.cs` |

### NearbyChargingSites

- **Auth**: `options.ThirdpartytokenAuthorizationCode` OR `options.ThirdpartytokenClientCredentials`
- **Signature**: `NearbyChargingSites(string vehicleTag, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `Api1VehiclesNearbyChargingSitesResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `Api1VehiclesNearbyChargingSitesResponse` | `Models/Api1VehiclesNearbyChargingSitesResponse.cs` |

### RemoveDriverAccessFromAVehicle

- **Auth**: `options.ThirdpartytokenAuthorizationCode` OR `options.ThirdpartytokenClientCredentials`
- **Signature**: `RemoveDriverAccessFromAVehicle(string vehicleTag, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `SimpleOkResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `SimpleOkResponse` | `Models/SimpleOkResponse.cs` |

### SetEnterprisePayerRoles

- **Auth**: `options.ThirdpartytokenAuthorizationCode` OR `options.ThirdpartytokenClientCredentials`
- **Signature**: `SetEnterprisePayerRoles(string vin, EnterprisePayerRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `void` (Task)
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `EnterprisePayerRequest` | `Models/EnterprisePayerRequest.cs` |

### VehicleLiveData

- **Auth**: `options.ThirdpartytokenAuthorizationCode` OR `options.ThirdpartytokenClientCredentials`
- **Signature**: `VehicleLiveData(string vehicleTag, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `SiteInfoResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `SiteInfoResponse` | `Models/SiteInfoResponse.cs` |

### VehicleOptions

- **Auth**: `options.ThirdpartytokenAuthorizationCode` OR `options.ThirdpartytokenClientCredentials`
- **Signature**: `VehicleOptions(string vin, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Query params (wire ← C#)**: `vin` ← `vin`
- **Returns**: `Api1DxVehiclesOptionsResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `Api1DxVehiclesOptionsResponse` | `Models/Api1DxVehiclesOptionsResponse.cs` |

### VehicleSpecs

- **Auth**: `options.ThirdpartytokenAuthorizationCode` OR `options.ThirdpartytokenClientCredentials`
- **Signature**: `VehicleSpecs(string vin, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `SiteInfoResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `SiteInfoResponse` | `Models/SiteInfoResponse.cs` |

### WakeUpVehicle

- **Auth**: `options.ThirdpartytokenAuthorizationCode` OR `options.ThirdpartytokenClientCredentials`
- **Signature**: `WakeUpVehicle(string vehicleTag, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `Api1VehiclesWakeUpResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `Api1VehiclesWakeUpResponse` | `Models/Api1VehiclesWakeUpResponse.cs` |

### WarrantyDetails

- **Auth**: `options.ThirdpartytokenAuthorizationCode` OR `options.ThirdpartytokenClientCredentials`
- **Signature**: `WarrantyDetails(RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `Api1DxWarrantyDetailsResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `Api1DxWarrantyDetailsResponse` | `Models/Api1DxWarrantyDetailsResponse.cs` |

