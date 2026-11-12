<!-- Generated file — do not edit; regenerated with the SDK. -->

# Vehicles — operations

Accessor: `client.Vehicles` · Source: `src/TeslaFleetManagementApi/Api/Vehicles.cs` · 21 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### ConfigureFleetTelemetryUsingSignedJwsToken

- **Auth**: `options.ThirdpartytokenAuthorizationCode` OR `options.ThirdpartytokenClientCredentials` (scopes: `openid`, `offline_access`, `user_data`, `vehicle_device_data`, `vehicle_location`, `vehicle_cmds`, `vehicle_charging_cmds`, `vehicle_specs`, `energy_device_data`, `energy_cmds`, `enterprise_management`)
- **Signature**: `ConfigureFleetTelemetryUsingSignedJwsToken(ConfigureFleetTelemetryUsingSignedJwsTokenRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `object`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ConfigureFleetTelemetryUsingSignedJwsTokenRequest` | `src/TeslaFleetManagementApi/Requests/Vehicles/ConfigureFleetTelemetryUsingSignedJwsTokenRequest.cs` |
| `FleetTelemetryJwsRequest` | `src/TeslaFleetManagementApi/Models/FleetTelemetryJwsRequest.cs` |

### CreateOrUpdateFleetTelemetryConfiguration

- **Auth**: `options.ThirdpartytokenAuthorizationCode` OR `options.ThirdpartytokenClientCredentials` (scopes: `openid`, `offline_access`, `user_data`, `vehicle_device_data`, `vehicle_location`, `vehicle_cmds`, `vehicle_charging_cmds`, `vehicle_specs`, `energy_device_data`, `energy_cmds`, `enterprise_management`)
- **Signature**: `CreateOrUpdateFleetTelemetryConfiguration(CreateOrUpdateFleetTelemetryConfigurationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `object`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `CreateOrUpdateFleetTelemetryConfigurationRequest` | `src/TeslaFleetManagementApi/Requests/Vehicles/CreateOrUpdateFleetTelemetryConfigurationRequest.cs` |

### DeleteFleetTelemetryConfiguration

- **Auth**: `options.ThirdpartytokenAuthorizationCode` OR `options.ThirdpartytokenClientCredentials` (scopes: `openid`, `offline_access`, `user_data`, `vehicle_device_data`, `vehicle_location`, `vehicle_cmds`, `vehicle_charging_cmds`, `vehicle_specs`, `energy_device_data`, `energy_cmds`, `enterprise_management`)
- **Signature**: `DeleteFleetTelemetryConfiguration(DeleteFleetTelemetryConfigurationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `VehicleTag`
- **Returns**: `object`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `DeleteFleetTelemetryConfigurationRequest` | `src/TeslaFleetManagementApi/Requests/Vehicles/DeleteFleetTelemetryConfigurationRequest.cs` |

### GetAllowedDriversForAVehicle

- **Auth**: `options.ThirdpartytokenAuthorizationCode` OR `options.ThirdpartytokenClientCredentials` (scopes: `openid`, `offline_access`, `user_data`, `vehicle_device_data`, `vehicle_location`, `vehicle_cmds`, `vehicle_charging_cmds`, `vehicle_specs`, `energy_device_data`, `energy_cmds`, `enterprise_management`)
- **Signature**: `GetAllowedDriversForAVehicle(GetAllowedDriversForAVehicleRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `VehicleTag`
- **Returns**: `DriversResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `GetAllowedDriversForAVehicleRequest` | `src/TeslaFleetManagementApi/Requests/Vehicles/GetAllowedDriversForAVehicleRequest.cs` |
| `DriversResponse` | `src/TeslaFleetManagementApi/Models/DriversResponse.cs` |

### GetEligibleVehicleSubscriptions

- **Auth**: `options.ThirdpartytokenAuthorizationCode` OR `options.ThirdpartytokenClientCredentials` (scopes: `openid`, `offline_access`, `user_data`, `vehicle_device_data`, `vehicle_location`, `vehicle_cmds`, `vehicle_charging_cmds`, `vehicle_specs`, `energy_device_data`, `energy_cmds`, `enterprise_management`)
- **Signature**: `GetEligibleVehicleSubscriptions(GetEligibleVehicleSubscriptionsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Vin`
- **Query params (wire ← C#)**: `vin` ← `Vin`
- **Returns**: `SiteInfoResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `GetEligibleVehicleSubscriptionsRequest` | `src/TeslaFleetManagementApi/Requests/Vehicles/GetEligibleVehicleSubscriptionsRequest.cs` |
| `SiteInfoResponse` | `src/TeslaFleetManagementApi/Models/SiteInfoResponse.cs` |

### GetEligibleVehicleUpgrades

- **Auth**: `options.ThirdpartytokenAuthorizationCode` OR `options.ThirdpartytokenClientCredentials` (scopes: `openid`, `offline_access`, `user_data`, `vehicle_device_data`, `vehicle_location`, `vehicle_cmds`, `vehicle_charging_cmds`, `vehicle_specs`, `energy_device_data`, `energy_cmds`, `enterprise_management`)
- **Signature**: `GetEligibleVehicleUpgrades(GetEligibleVehicleUpgradesRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Vin`
- **Query params (wire ← C#)**: `vin` ← `Vin`
- **Returns**: `SiteInfoResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `GetEligibleVehicleUpgradesRequest` | `src/TeslaFleetManagementApi/Requests/Vehicles/GetEligibleVehicleUpgradesRequest.cs` |
| `SiteInfoResponse` | `src/TeslaFleetManagementApi/Models/SiteInfoResponse.cs` |

### GetEnterpriseRolesForAVehicle

- **Auth**: `options.ThirdpartytokenAuthorizationCode` OR `options.ThirdpartytokenClientCredentials` (scopes: `openid`, `offline_access`, `user_data`, `vehicle_device_data`, `vehicle_location`, `vehicle_cmds`, `vehicle_charging_cmds`, `vehicle_specs`, `energy_device_data`, `energy_cmds`, `enterprise_management`)
- **Signature**: `GetEnterpriseRolesForAVehicle(GetEnterpriseRolesForAVehicleRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Vin`
- **Returns**: `object`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `GetEnterpriseRolesForAVehicleRequest` | `src/TeslaFleetManagementApi/Requests/Vehicles/GetEnterpriseRolesForAVehicleRequest.cs` |

### GetFleetStatusForVehicles

- **Auth**: `options.ThirdpartytokenAuthorizationCode` OR `options.ThirdpartytokenClientCredentials` (scopes: `openid`, `offline_access`, `user_data`, `vehicle_device_data`, `vehicle_location`, `vehicle_cmds`, `vehicle_charging_cmds`, `vehicle_specs`, `energy_device_data`, `energy_cmds`, `enterprise_management`)
- **Signature**: `GetFleetStatusForVehicles(GetFleetStatusForVehiclesRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `object`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `GetFleetStatusForVehiclesRequest` | `src/TeslaFleetManagementApi/Requests/Vehicles/GetFleetStatusForVehiclesRequest.cs` |
| `FleetStatusRequest` | `src/TeslaFleetManagementApi/Models/FleetStatusRequest.cs` |

### GetFleetTelemetryConfiguration

- **Auth**: `options.ThirdpartytokenAuthorizationCode` OR `options.ThirdpartytokenClientCredentials` (scopes: `openid`, `offline_access`, `user_data`, `vehicle_device_data`, `vehicle_location`, `vehicle_cmds`, `vehicle_charging_cmds`, `vehicle_specs`, `energy_device_data`, `energy_cmds`, `enterprise_management`)
- **Signature**: `GetFleetTelemetryConfiguration(GetFleetTelemetryConfigurationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `VehicleTag`
- **Returns**: `object`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `GetFleetTelemetryConfigurationRequest` | `src/TeslaFleetManagementApi/Requests/Vehicles/GetFleetTelemetryConfigurationRequest.cs` |

### GetFleetTelemetryErrorsForAVehicle

- **Auth**: `options.ThirdpartytokenAuthorizationCode` OR `options.ThirdpartytokenClientCredentials` (scopes: `openid`, `offline_access`, `user_data`, `vehicle_device_data`, `vehicle_location`, `vehicle_cmds`, `vehicle_charging_cmds`, `vehicle_specs`, `energy_device_data`, `energy_cmds`, `enterprise_management`)
- **Signature**: `GetFleetTelemetryErrorsForAVehicle(GetFleetTelemetryErrorsForAVehicleRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `VehicleTag`
- **Returns**: `object`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `GetFleetTelemetryErrorsForAVehicleRequest` | `src/TeslaFleetManagementApi/Requests/Vehicles/GetFleetTelemetryErrorsForAVehicleRequest.cs` |

### GetVehicle

- **Auth**: `options.ThirdpartytokenAuthorizationCode` OR `options.ThirdpartytokenClientCredentials` (scopes: `openid`, `offline_access`, `user_data`, `vehicle_device_data`, `vehicle_location`, `vehicle_cmds`, `vehicle_charging_cmds`, `vehicle_specs`, `energy_device_data`, `energy_cmds`, `enterprise_management`)
- **Signature**: `GetVehicle(GetVehicleRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `VehicleTag`
- **Returns**: `Api1VehiclesResponseResponse200`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `GetVehicleRequest` | `src/TeslaFleetManagementApi/Requests/Vehicles/GetVehicleRequest.cs` |
| `Api1VehiclesResponseResponse200` | `src/TeslaFleetManagementApi/Models/Api1VehiclesResponseResponse200.cs` |

### ListVehicles

- **Auth**: `options.ThirdpartytokenAuthorizationCode` OR `options.ThirdpartytokenClientCredentials` (scopes: `openid`, `offline_access`, `user_data`, `vehicle_device_data`, `vehicle_location`, `vehicle_cmds`, `vehicle_charging_cmds`, `vehicle_specs`, `energy_device_data`, `energy_cmds`, `enterprise_management`)
- **Signature**: `ListVehicles(RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Returns**: `Api1VehiclesResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `Api1VehiclesResponse` | `src/TeslaFleetManagementApi/Models/Api1VehiclesResponse.cs` |

### MobileEnabled

- **Auth**: `options.ThirdpartytokenAuthorizationCode` OR `options.ThirdpartytokenClientCredentials` (scopes: `openid`, `offline_access`, `user_data`, `vehicle_device_data`, `vehicle_location`, `vehicle_cmds`, `vehicle_charging_cmds`, `vehicle_specs`, `energy_device_data`, `energy_cmds`, `enterprise_management`)
- **Signature**: `MobileEnabled(MobileEnabledRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `VehicleTag`
- **Returns**: `Api1VehiclesMobileEnabledResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `MobileEnabledRequest` | `src/TeslaFleetManagementApi/Requests/Vehicles/MobileEnabledRequest.cs` |
| `Api1VehiclesMobileEnabledResponse` | `src/TeslaFleetManagementApi/Models/Api1VehiclesMobileEnabledResponse.cs` |

### NearbyChargingSites

- **Auth**: `options.ThirdpartytokenAuthorizationCode` OR `options.ThirdpartytokenClientCredentials` (scopes: `openid`, `offline_access`, `user_data`, `vehicle_device_data`, `vehicle_location`, `vehicle_cmds`, `vehicle_charging_cmds`, `vehicle_specs`, `energy_device_data`, `energy_cmds`, `enterprise_management`)
- **Signature**: `NearbyChargingSites(NearbyChargingSitesRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `VehicleTag`
- **Returns**: `Api1VehiclesNearbyChargingSitesResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `NearbyChargingSitesRequest` | `src/TeslaFleetManagementApi/Requests/Vehicles/NearbyChargingSitesRequest.cs` |
| `Api1VehiclesNearbyChargingSitesResponse` | `src/TeslaFleetManagementApi/Models/Api1VehiclesNearbyChargingSitesResponse.cs` |

### RemoveDriverAccessFromAVehicle

- **Auth**: `options.ThirdpartytokenAuthorizationCode` OR `options.ThirdpartytokenClientCredentials` (scopes: `openid`, `offline_access`, `user_data`, `vehicle_device_data`, `vehicle_location`, `vehicle_cmds`, `vehicle_charging_cmds`, `vehicle_specs`, `energy_device_data`, `energy_cmds`, `enterprise_management`)
- **Signature**: `RemoveDriverAccessFromAVehicle(RemoveDriverAccessFromAVehicleRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `VehicleTag`
- **Returns**: `SimpleOkResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `RemoveDriverAccessFromAVehicleRequest` | `src/TeslaFleetManagementApi/Requests/Vehicles/RemoveDriverAccessFromAVehicleRequest.cs` |
| `SimpleOkResponse` | `src/TeslaFleetManagementApi/Models/SimpleOkResponse.cs` |

### SetEnterprisePayerRoles

- **Auth**: `options.ThirdpartytokenAuthorizationCode` OR `options.ThirdpartytokenClientCredentials` (scopes: `openid`, `offline_access`, `user_data`, `vehicle_device_data`, `vehicle_location`, `vehicle_cmds`, `vehicle_charging_cmds`, `vehicle_specs`, `energy_device_data`, `energy_cmds`, `enterprise_management`)
- **Signature**: `SetEnterprisePayerRoles(SetEnterprisePayerRolesRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Vin`, `Body`
- **Returns**: `void` (Task)
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `SetEnterprisePayerRolesRequest` | `src/TeslaFleetManagementApi/Requests/Vehicles/SetEnterprisePayerRolesRequest.cs` |
| `EnterprisePayerRequest` | `src/TeslaFleetManagementApi/Models/EnterprisePayerRequest.cs` |

### VehicleLiveData

- **Auth**: `options.ThirdpartytokenAuthorizationCode` OR `options.ThirdpartytokenClientCredentials` (scopes: `openid`, `offline_access`, `user_data`, `vehicle_device_data`, `vehicle_location`, `vehicle_cmds`, `vehicle_charging_cmds`, `vehicle_specs`, `energy_device_data`, `energy_cmds`, `enterprise_management`)
- **Signature**: `VehicleLiveData(VehicleLiveDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `VehicleTag`
- **Returns**: `SiteInfoResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `VehicleLiveDataRequest` | `src/TeslaFleetManagementApi/Requests/Vehicles/VehicleLiveDataRequest.cs` |
| `SiteInfoResponse` | `src/TeslaFleetManagementApi/Models/SiteInfoResponse.cs` |

### VehicleOptions

- **Auth**: `options.ThirdpartytokenAuthorizationCode` OR `options.ThirdpartytokenClientCredentials` (scopes: `openid`, `offline_access`, `user_data`, `vehicle_device_data`, `vehicle_location`, `vehicle_cmds`, `vehicle_charging_cmds`, `vehicle_specs`, `energy_device_data`, `energy_cmds`, `enterprise_management`)
- **Signature**: `VehicleOptions(VehicleOptionsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Vin`
- **Query params (wire ← C#)**: `vin` ← `Vin`
- **Returns**: `Api1DxVehiclesOptionsResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `VehicleOptionsRequest` | `src/TeslaFleetManagementApi/Requests/Vehicles/VehicleOptionsRequest.cs` |
| `Api1DxVehiclesOptionsResponse` | `src/TeslaFleetManagementApi/Models/Api1DxVehiclesOptionsResponse.cs` |

### VehicleSpecs

- **Auth**: `options.ThirdpartytokenAuthorizationCode` OR `options.ThirdpartytokenClientCredentials` (scopes: `openid`, `offline_access`, `user_data`, `vehicle_device_data`, `vehicle_location`, `vehicle_cmds`, `vehicle_charging_cmds`, `vehicle_specs`, `energy_device_data`, `energy_cmds`, `enterprise_management`)
- **Signature**: `VehicleSpecs(VehicleSpecsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Vin`
- **Returns**: `SiteInfoResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `VehicleSpecsRequest` | `src/TeslaFleetManagementApi/Requests/Vehicles/VehicleSpecsRequest.cs` |
| `SiteInfoResponse` | `src/TeslaFleetManagementApi/Models/SiteInfoResponse.cs` |

### WakeUpVehicle

- **Auth**: `options.ThirdpartytokenAuthorizationCode` OR `options.ThirdpartytokenClientCredentials` (scopes: `openid`, `offline_access`, `user_data`, `vehicle_device_data`, `vehicle_location`, `vehicle_cmds`, `vehicle_charging_cmds`, `vehicle_specs`, `energy_device_data`, `energy_cmds`, `enterprise_management`)
- **Signature**: `WakeUpVehicle(WakeUpVehicleRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `VehicleTag`
- **Returns**: `Api1VehiclesWakeUpResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `WakeUpVehicleRequest` | `src/TeslaFleetManagementApi/Requests/Vehicles/WakeUpVehicleRequest.cs` |
| `Api1VehiclesWakeUpResponse` | `src/TeslaFleetManagementApi/Models/Api1VehiclesWakeUpResponse.cs` |

### WarrantyDetails

- **Auth**: `options.ThirdpartytokenAuthorizationCode` OR `options.ThirdpartytokenClientCredentials` (scopes: `openid`, `offline_access`, `user_data`, `vehicle_device_data`, `vehicle_location`, `vehicle_cmds`, `vehicle_charging_cmds`, `vehicle_specs`, `energy_device_data`, `energy_cmds`, `enterprise_management`)
- **Signature**: `WarrantyDetails(RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Returns**: `Api1DxWarrantyDetailsResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `Api1DxWarrantyDetailsResponse` | `src/TeslaFleetManagementApi/Models/Api1DxWarrantyDetailsResponse.cs` |

