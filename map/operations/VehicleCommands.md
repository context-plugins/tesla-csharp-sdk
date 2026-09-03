<!-- Generated file — do not edit; regenerated with the SDK. -->

# VehicleCommands — operations

Accessor: `client.VehicleCommands` · Source: `Api/VehicleCommands.cs` · 21 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### Actuatetrunk

- **Auth**: `options.ThirdpartytokenAuthorizationCode` OR `options.ThirdpartytokenClientCredentials`
- **Signature**: `Actuatetrunk(string vehicleTag, ActuateTrunkRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `CommandResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ActuateTrunkRequest` | `Models/ActuateTrunkRequest.cs` |
| `CommandResponse` | `Models/CommandResponse.cs` |

### Addchargeschedule

- **Auth**: `options.ThirdpartytokenAuthorizationCode` OR `options.ThirdpartytokenClientCredentials`
- **Signature**: `Addchargeschedule(string vehicleTag, AddChargeScheduleRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `CommandResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `AddChargeScheduleRequest` | `Models/AddChargeScheduleRequest.cs` |
| `CommandResponse` | `Models/CommandResponse.cs` |

### Addpreconditionschedule

- **Auth**: `options.ThirdpartytokenAuthorizationCode` OR `options.ThirdpartytokenClientCredentials`
- **Signature**: `Addpreconditionschedule(string vehicleTag, AddPreconditionScheduleRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `CommandResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `AddPreconditionScheduleRequest` | `Models/AddPreconditionScheduleRequest.cs` |
| `CommandResponse` | `Models/CommandResponse.cs` |

### Adjustmediavolume

- **Auth**: `options.ThirdpartytokenAuthorizationCode` OR `options.ThirdpartytokenClientCredentials`
- **Signature**: `Adjustmediavolume(string vehicleTag, AdjustVolumeRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `CommandResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `AdjustVolumeRequest` | `Models/AdjustVolumeRequest.cs` |
| `CommandResponse` | `Models/CommandResponse.cs` |

### Cancelsoftwareupdate

- **Auth**: `options.ThirdpartytokenAuthorizationCode` OR `options.ThirdpartytokenClientCredentials`
- **Signature**: `Cancelsoftwareupdate(string vehicleTag, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `CommandResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `CommandResponse` | `Models/CommandResponse.cs` |

### Chargemaxrange

- **Auth**: `options.ThirdpartytokenAuthorizationCode` OR `options.ThirdpartytokenClientCredentials`
- **Signature**: `Chargemaxrange(string vehicleTag, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `CommandResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `CommandResponse` | `Models/CommandResponse.cs` |

### Chargestandard

- **Auth**: `options.ThirdpartytokenAuthorizationCode` OR `options.ThirdpartytokenClientCredentials`
- **Signature**: `Chargestandard(string vehicleTag, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `CommandResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `CommandResponse` | `Models/CommandResponse.cs` |

### ClearPiNtoDriveAdmin

- **Auth**: `options.ThirdpartytokenAuthorizationCode` OR `options.ThirdpartytokenClientCredentials`
- **Signature**: `ClearPiNtoDriveAdmin(string vehicleTag, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `CommandResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `CommandResponse` | `Models/CommandResponse.cs` |

### Closechargeportdoor

- **Auth**: `options.ThirdpartytokenAuthorizationCode` OR `options.ThirdpartytokenClientCredentials`
- **Signature**: `Closechargeportdoor(string vehicleTag, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `CommandResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `CommandResponse` | `Models/CommandResponse.cs` |

### EnableordisableGuestMode

- **Auth**: `options.ThirdpartytokenAuthorizationCode` OR `options.ThirdpartytokenClientCredentials`
- **Signature**: `EnableordisableGuestMode(string vehicleTag, GuestModeRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `CommandResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `GuestModeRequest` | `Models/GuestModeRequest.cs` |
| `CommandResponse` | `Models/CommandResponse.cs` |

### Eraseuserdata

- **Auth**: `options.ThirdpartytokenAuthorizationCode` OR `options.ThirdpartytokenClientCredentials`
- **Signature**: `Eraseuserdata(string vehicleTag, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `CommandResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `CommandResponse` | `Models/CommandResponse.cs` |

### Flashlights

- **Auth**: `options.ThirdpartytokenAuthorizationCode` OR `options.ThirdpartytokenClientCredentials`
- **Signature**: `Flashlights(string vehicleTag, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `CommandResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `CommandResponse` | `Models/CommandResponse.cs` |

### Honkhorn

- **Auth**: `options.ThirdpartytokenAuthorizationCode` OR `options.ThirdpartytokenClientCredentials`
- **Signature**: `Honkhorn(string vehicleTag, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `CommandResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `CommandResponse` | `Models/CommandResponse.cs` |

### Lockdoors

- **Auth**: `options.ThirdpartytokenAuthorizationCode` OR `options.ThirdpartytokenClientCredentials`
- **Signature**: `Lockdoors(string vehicleTag, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `CommandResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `CommandResponse` | `Models/CommandResponse.cs` |

### Nextfavoritemediatrack

- **Auth**: `options.ThirdpartytokenAuthorizationCode` OR `options.ThirdpartytokenClientCredentials`
- **Signature**: `Nextfavoritemediatrack(string vehicleTag, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `CommandResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `CommandResponse` | `Models/CommandResponse.cs` |

### Openchargeportdoor

- **Auth**: `options.ThirdpartytokenAuthorizationCode` OR `options.ThirdpartytokenClientCredentials`
- **Signature**: `Openchargeportdoor(string vehicleTag, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `CommandResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `CommandResponse` | `Models/CommandResponse.cs` |

### Startcharging

- **Auth**: `options.ThirdpartytokenAuthorizationCode` OR `options.ThirdpartytokenClientCredentials`
- **Signature**: `Startcharging(string vehicleTag, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `CommandResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `CommandResponse` | `Models/CommandResponse.cs` |

### Startclimatepreconditioning

- **Auth**: `options.ThirdpartytokenAuthorizationCode` OR `options.ThirdpartytokenClientCredentials`
- **Signature**: `Startclimatepreconditioning(string vehicleTag, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `CommandResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `CommandResponse` | `Models/CommandResponse.cs` |

### Stopcharging

- **Auth**: `options.ThirdpartytokenAuthorizationCode` OR `options.ThirdpartytokenClientCredentials`
- **Signature**: `Stopcharging(string vehicleTag, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `CommandResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `CommandResponse` | `Models/CommandResponse.cs` |

### Stopclimatepreconditioning

- **Auth**: `options.ThirdpartytokenAuthorizationCode` OR `options.ThirdpartytokenClientCredentials`
- **Signature**: `Stopclimatepreconditioning(string vehicleTag, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `CommandResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `CommandResponse` | `Models/CommandResponse.cs` |

### Unlockdoors

- **Auth**: `options.ThirdpartytokenAuthorizationCode` OR `options.ThirdpartytokenClientCredentials`
- **Signature**: `Unlockdoors(string vehicleTag, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `CommandResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `CommandResponse` | `Models/CommandResponse.cs` |

