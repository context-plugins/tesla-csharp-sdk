<!-- Generated file — do not edit; regenerated with the SDK. -->

# VehicleCommands — operations

Accessor: `client.VehicleCommands` · Source: `src/TeslaFleetManagementApi/Api/VehicleCommands.cs` · 21 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### Actuatetrunk

- **Auth**: `options.ThirdpartytokenAuthorizationCode` OR `options.ThirdpartytokenClientCredentials` (scopes: `openid`, `offline_access`, `user_data`, `vehicle_device_data`, `vehicle_location`, `vehicle_cmds`, `vehicle_charging_cmds`, `vehicle_specs`, `energy_device_data`, `energy_cmds`, `enterprise_management`)
- **Signature**: `Actuatetrunk(ActuatetrunkOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `VehicleTag`, `Body`
- **Returns**: `CommandResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ActuatetrunkOperationRequest` | `src/TeslaFleetManagementApi/Requests/VehicleCommands/ActuatetrunkOperationRequest.cs` |
| `ActuateTrunkRequest` | `src/TeslaFleetManagementApi/Models/ActuateTrunkRequest.cs` |
| `CommandResponse` | `src/TeslaFleetManagementApi/Models/CommandResponse.cs` |

### Addchargeschedule

- **Auth**: `options.ThirdpartytokenAuthorizationCode` OR `options.ThirdpartytokenClientCredentials` (scopes: `openid`, `offline_access`, `user_data`, `vehicle_device_data`, `vehicle_location`, `vehicle_cmds`, `vehicle_charging_cmds`, `vehicle_specs`, `energy_device_data`, `energy_cmds`, `enterprise_management`)
- **Signature**: `Addchargeschedule(AddchargescheduleOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `VehicleTag`, `Body`
- **Returns**: `CommandResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `AddchargescheduleOperationRequest` | `src/TeslaFleetManagementApi/Requests/VehicleCommands/AddchargescheduleOperationRequest.cs` |
| `AddChargeScheduleRequest` | `src/TeslaFleetManagementApi/Models/AddChargeScheduleRequest.cs` |
| `CommandResponse` | `src/TeslaFleetManagementApi/Models/CommandResponse.cs` |

### Addpreconditionschedule

- **Auth**: `options.ThirdpartytokenAuthorizationCode` OR `options.ThirdpartytokenClientCredentials` (scopes: `openid`, `offline_access`, `user_data`, `vehicle_device_data`, `vehicle_location`, `vehicle_cmds`, `vehicle_charging_cmds`, `vehicle_specs`, `energy_device_data`, `energy_cmds`, `enterprise_management`)
- **Signature**: `Addpreconditionschedule(AddpreconditionscheduleOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `VehicleTag`, `Body`
- **Returns**: `CommandResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `AddpreconditionscheduleOperationRequest` | `src/TeslaFleetManagementApi/Requests/VehicleCommands/AddpreconditionscheduleOperationRequest.cs` |
| `AddPreconditionScheduleRequest` | `src/TeslaFleetManagementApi/Models/AddPreconditionScheduleRequest.cs` |
| `CommandResponse` | `src/TeslaFleetManagementApi/Models/CommandResponse.cs` |

### Adjustmediavolume

- **Auth**: `options.ThirdpartytokenAuthorizationCode` OR `options.ThirdpartytokenClientCredentials` (scopes: `openid`, `offline_access`, `user_data`, `vehicle_device_data`, `vehicle_location`, `vehicle_cmds`, `vehicle_charging_cmds`, `vehicle_specs`, `energy_device_data`, `energy_cmds`, `enterprise_management`)
- **Signature**: `Adjustmediavolume(AdjustmediavolumeRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `VehicleTag`, `Body`
- **Returns**: `CommandResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `AdjustmediavolumeRequest` | `src/TeslaFleetManagementApi/Requests/VehicleCommands/AdjustmediavolumeRequest.cs` |
| `AdjustVolumeRequest` | `src/TeslaFleetManagementApi/Models/AdjustVolumeRequest.cs` |
| `CommandResponse` | `src/TeslaFleetManagementApi/Models/CommandResponse.cs` |

### Cancelsoftwareupdate

- **Auth**: `options.ThirdpartytokenAuthorizationCode` OR `options.ThirdpartytokenClientCredentials` (scopes: `openid`, `offline_access`, `user_data`, `vehicle_device_data`, `vehicle_location`, `vehicle_cmds`, `vehicle_charging_cmds`, `vehicle_specs`, `energy_device_data`, `energy_cmds`, `enterprise_management`)
- **Signature**: `Cancelsoftwareupdate(CancelsoftwareupdateRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `VehicleTag`
- **Returns**: `CommandResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `CancelsoftwareupdateRequest` | `src/TeslaFleetManagementApi/Requests/VehicleCommands/CancelsoftwareupdateRequest.cs` |
| `CommandResponse` | `src/TeslaFleetManagementApi/Models/CommandResponse.cs` |

### Chargemaxrange

- **Auth**: `options.ThirdpartytokenAuthorizationCode` OR `options.ThirdpartytokenClientCredentials` (scopes: `openid`, `offline_access`, `user_data`, `vehicle_device_data`, `vehicle_location`, `vehicle_cmds`, `vehicle_charging_cmds`, `vehicle_specs`, `energy_device_data`, `energy_cmds`, `enterprise_management`)
- **Signature**: `Chargemaxrange(ChargemaxrangeRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `VehicleTag`
- **Returns**: `CommandResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ChargemaxrangeRequest` | `src/TeslaFleetManagementApi/Requests/VehicleCommands/ChargemaxrangeRequest.cs` |
| `CommandResponse` | `src/TeslaFleetManagementApi/Models/CommandResponse.cs` |

### Chargestandard

- **Auth**: `options.ThirdpartytokenAuthorizationCode` OR `options.ThirdpartytokenClientCredentials` (scopes: `openid`, `offline_access`, `user_data`, `vehicle_device_data`, `vehicle_location`, `vehicle_cmds`, `vehicle_charging_cmds`, `vehicle_specs`, `energy_device_data`, `energy_cmds`, `enterprise_management`)
- **Signature**: `Chargestandard(ChargestandardRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `VehicleTag`
- **Returns**: `CommandResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ChargestandardRequest` | `src/TeslaFleetManagementApi/Requests/VehicleCommands/ChargestandardRequest.cs` |
| `CommandResponse` | `src/TeslaFleetManagementApi/Models/CommandResponse.cs` |

### ClearPiNtoDriveAdmin

- **Auth**: `options.ThirdpartytokenAuthorizationCode` OR `options.ThirdpartytokenClientCredentials` (scopes: `openid`, `offline_access`, `user_data`, `vehicle_device_data`, `vehicle_location`, `vehicle_cmds`, `vehicle_charging_cmds`, `vehicle_specs`, `energy_device_data`, `energy_cmds`, `enterprise_management`)
- **Signature**: `ClearPiNtoDriveAdmin(ClearPiNtoDriveAdminRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `VehicleTag`
- **Returns**: `CommandResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ClearPiNtoDriveAdminRequest` | `src/TeslaFleetManagementApi/Requests/VehicleCommands/ClearPiNtoDriveAdminRequest.cs` |
| `CommandResponse` | `src/TeslaFleetManagementApi/Models/CommandResponse.cs` |

### Closechargeportdoor

- **Auth**: `options.ThirdpartytokenAuthorizationCode` OR `options.ThirdpartytokenClientCredentials` (scopes: `openid`, `offline_access`, `user_data`, `vehicle_device_data`, `vehicle_location`, `vehicle_cmds`, `vehicle_charging_cmds`, `vehicle_specs`, `energy_device_data`, `energy_cmds`, `enterprise_management`)
- **Signature**: `Closechargeportdoor(ClosechargeportdoorRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `VehicleTag`
- **Returns**: `CommandResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ClosechargeportdoorRequest` | `src/TeslaFleetManagementApi/Requests/VehicleCommands/ClosechargeportdoorRequest.cs` |
| `CommandResponse` | `src/TeslaFleetManagementApi/Models/CommandResponse.cs` |

### EnableordisableGuestMode

- **Auth**: `options.ThirdpartytokenAuthorizationCode` OR `options.ThirdpartytokenClientCredentials` (scopes: `openid`, `offline_access`, `user_data`, `vehicle_device_data`, `vehicle_location`, `vehicle_cmds`, `vehicle_charging_cmds`, `vehicle_specs`, `energy_device_data`, `energy_cmds`, `enterprise_management`)
- **Signature**: `EnableordisableGuestMode(EnableordisableGuestModeRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `VehicleTag`, `Body`
- **Returns**: `CommandResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `EnableordisableGuestModeRequest` | `src/TeslaFleetManagementApi/Requests/VehicleCommands/EnableordisableGuestModeRequest.cs` |
| `GuestModeRequest` | `src/TeslaFleetManagementApi/Models/GuestModeRequest.cs` |
| `CommandResponse` | `src/TeslaFleetManagementApi/Models/CommandResponse.cs` |

### Eraseuserdata

- **Auth**: `options.ThirdpartytokenAuthorizationCode` OR `options.ThirdpartytokenClientCredentials` (scopes: `openid`, `offline_access`, `user_data`, `vehicle_device_data`, `vehicle_location`, `vehicle_cmds`, `vehicle_charging_cmds`, `vehicle_specs`, `energy_device_data`, `energy_cmds`, `enterprise_management`)
- **Signature**: `Eraseuserdata(EraseuserdataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `VehicleTag`
- **Returns**: `CommandResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `EraseuserdataRequest` | `src/TeslaFleetManagementApi/Requests/VehicleCommands/EraseuserdataRequest.cs` |
| `CommandResponse` | `src/TeslaFleetManagementApi/Models/CommandResponse.cs` |

### Flashlights

- **Auth**: `options.ThirdpartytokenAuthorizationCode` OR `options.ThirdpartytokenClientCredentials` (scopes: `openid`, `offline_access`, `user_data`, `vehicle_device_data`, `vehicle_location`, `vehicle_cmds`, `vehicle_charging_cmds`, `vehicle_specs`, `energy_device_data`, `energy_cmds`, `enterprise_management`)
- **Signature**: `Flashlights(FlashlightsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `VehicleTag`
- **Returns**: `CommandResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `FlashlightsRequest` | `src/TeslaFleetManagementApi/Requests/VehicleCommands/FlashlightsRequest.cs` |
| `CommandResponse` | `src/TeslaFleetManagementApi/Models/CommandResponse.cs` |

### Honkhorn

- **Auth**: `options.ThirdpartytokenAuthorizationCode` OR `options.ThirdpartytokenClientCredentials` (scopes: `openid`, `offline_access`, `user_data`, `vehicle_device_data`, `vehicle_location`, `vehicle_cmds`, `vehicle_charging_cmds`, `vehicle_specs`, `energy_device_data`, `energy_cmds`, `enterprise_management`)
- **Signature**: `Honkhorn(HonkhornRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `VehicleTag`
- **Returns**: `CommandResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `HonkhornRequest` | `src/TeslaFleetManagementApi/Requests/VehicleCommands/HonkhornRequest.cs` |
| `CommandResponse` | `src/TeslaFleetManagementApi/Models/CommandResponse.cs` |

### Lockdoors

- **Auth**: `options.ThirdpartytokenAuthorizationCode` OR `options.ThirdpartytokenClientCredentials` (scopes: `openid`, `offline_access`, `user_data`, `vehicle_device_data`, `vehicle_location`, `vehicle_cmds`, `vehicle_charging_cmds`, `vehicle_specs`, `energy_device_data`, `energy_cmds`, `enterprise_management`)
- **Signature**: `Lockdoors(LockdoorsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `VehicleTag`
- **Returns**: `CommandResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `LockdoorsRequest` | `src/TeslaFleetManagementApi/Requests/VehicleCommands/LockdoorsRequest.cs` |
| `CommandResponse` | `src/TeslaFleetManagementApi/Models/CommandResponse.cs` |

### Nextfavoritemediatrack

- **Auth**: `options.ThirdpartytokenAuthorizationCode` OR `options.ThirdpartytokenClientCredentials` (scopes: `openid`, `offline_access`, `user_data`, `vehicle_device_data`, `vehicle_location`, `vehicle_cmds`, `vehicle_charging_cmds`, `vehicle_specs`, `energy_device_data`, `energy_cmds`, `enterprise_management`)
- **Signature**: `Nextfavoritemediatrack(NextfavoritemediatrackRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `VehicleTag`
- **Returns**: `CommandResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `NextfavoritemediatrackRequest` | `src/TeslaFleetManagementApi/Requests/VehicleCommands/NextfavoritemediatrackRequest.cs` |
| `CommandResponse` | `src/TeslaFleetManagementApi/Models/CommandResponse.cs` |

### Openchargeportdoor

- **Auth**: `options.ThirdpartytokenAuthorizationCode` OR `options.ThirdpartytokenClientCredentials` (scopes: `openid`, `offline_access`, `user_data`, `vehicle_device_data`, `vehicle_location`, `vehicle_cmds`, `vehicle_charging_cmds`, `vehicle_specs`, `energy_device_data`, `energy_cmds`, `enterprise_management`)
- **Signature**: `Openchargeportdoor(OpenchargeportdoorRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `VehicleTag`
- **Returns**: `CommandResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `OpenchargeportdoorRequest` | `src/TeslaFleetManagementApi/Requests/VehicleCommands/OpenchargeportdoorRequest.cs` |
| `CommandResponse` | `src/TeslaFleetManagementApi/Models/CommandResponse.cs` |

### Startcharging

- **Auth**: `options.ThirdpartytokenAuthorizationCode` OR `options.ThirdpartytokenClientCredentials` (scopes: `openid`, `offline_access`, `user_data`, `vehicle_device_data`, `vehicle_location`, `vehicle_cmds`, `vehicle_charging_cmds`, `vehicle_specs`, `energy_device_data`, `energy_cmds`, `enterprise_management`)
- **Signature**: `Startcharging(StartchargingRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `VehicleTag`
- **Returns**: `CommandResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `StartchargingRequest` | `src/TeslaFleetManagementApi/Requests/VehicleCommands/StartchargingRequest.cs` |
| `CommandResponse` | `src/TeslaFleetManagementApi/Models/CommandResponse.cs` |

### Startclimatepreconditioning

- **Auth**: `options.ThirdpartytokenAuthorizationCode` OR `options.ThirdpartytokenClientCredentials` (scopes: `openid`, `offline_access`, `user_data`, `vehicle_device_data`, `vehicle_location`, `vehicle_cmds`, `vehicle_charging_cmds`, `vehicle_specs`, `energy_device_data`, `energy_cmds`, `enterprise_management`)
- **Signature**: `Startclimatepreconditioning(StartclimatepreconditioningRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `VehicleTag`
- **Returns**: `CommandResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `StartclimatepreconditioningRequest` | `src/TeslaFleetManagementApi/Requests/VehicleCommands/StartclimatepreconditioningRequest.cs` |
| `CommandResponse` | `src/TeslaFleetManagementApi/Models/CommandResponse.cs` |

### Stopcharging

- **Auth**: `options.ThirdpartytokenAuthorizationCode` OR `options.ThirdpartytokenClientCredentials` (scopes: `openid`, `offline_access`, `user_data`, `vehicle_device_data`, `vehicle_location`, `vehicle_cmds`, `vehicle_charging_cmds`, `vehicle_specs`, `energy_device_data`, `energy_cmds`, `enterprise_management`)
- **Signature**: `Stopcharging(StopchargingRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `VehicleTag`
- **Returns**: `CommandResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `StopchargingRequest` | `src/TeslaFleetManagementApi/Requests/VehicleCommands/StopchargingRequest.cs` |
| `CommandResponse` | `src/TeslaFleetManagementApi/Models/CommandResponse.cs` |

### Stopclimatepreconditioning

- **Auth**: `options.ThirdpartytokenAuthorizationCode` OR `options.ThirdpartytokenClientCredentials` (scopes: `openid`, `offline_access`, `user_data`, `vehicle_device_data`, `vehicle_location`, `vehicle_cmds`, `vehicle_charging_cmds`, `vehicle_specs`, `energy_device_data`, `energy_cmds`, `enterprise_management`)
- **Signature**: `Stopclimatepreconditioning(StopclimatepreconditioningRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `VehicleTag`
- **Returns**: `CommandResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `StopclimatepreconditioningRequest` | `src/TeslaFleetManagementApi/Requests/VehicleCommands/StopclimatepreconditioningRequest.cs` |
| `CommandResponse` | `src/TeslaFleetManagementApi/Models/CommandResponse.cs` |

### Unlockdoors

- **Auth**: `options.ThirdpartytokenAuthorizationCode` OR `options.ThirdpartytokenClientCredentials` (scopes: `openid`, `offline_access`, `user_data`, `vehicle_device_data`, `vehicle_location`, `vehicle_cmds`, `vehicle_charging_cmds`, `vehicle_specs`, `energy_device_data`, `energy_cmds`, `enterprise_management`)
- **Signature**: `Unlockdoors(UnlockdoorsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `VehicleTag`
- **Returns**: `CommandResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `UnlockdoorsRequest` | `src/TeslaFleetManagementApi/Requests/VehicleCommands/UnlockdoorsRequest.cs` |
| `CommandResponse` | `src/TeslaFleetManagementApi/Models/CommandResponse.cs` |

