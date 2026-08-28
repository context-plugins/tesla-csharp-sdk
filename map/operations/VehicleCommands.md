<!-- Generated file — do not edit; regenerated with the SDK. -->

# VehicleCommands — operations

Accessor: `client.VehicleCommands` · Source: `Api/VehicleCommands.cs` · 21 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### Actuatetrunk

- **Signature**: `Actuatetrunk(string vehicleTag, ActuateTrunkRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `CommandResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ActuateTrunkRequest` | `Models/ActuateTrunkRequest.cs` |
| `CommandResponse` | `Models/CommandResponse.cs` |

### Addchargeschedule

- **Signature**: `Addchargeschedule(string vehicleTag, AddChargeScheduleRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `CommandResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `AddChargeScheduleRequest` | `Models/AddChargeScheduleRequest.cs` |
| `CommandResponse` | `Models/CommandResponse.cs` |

### Addpreconditionschedule

- **Signature**: `Addpreconditionschedule(string vehicleTag, AddPreconditionScheduleRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `CommandResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `AddPreconditionScheduleRequest` | `Models/AddPreconditionScheduleRequest.cs` |
| `CommandResponse` | `Models/CommandResponse.cs` |

### Adjustmediavolume

- **Signature**: `Adjustmediavolume(string vehicleTag, AdjustVolumeRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `CommandResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `AdjustVolumeRequest` | `Models/AdjustVolumeRequest.cs` |
| `CommandResponse` | `Models/CommandResponse.cs` |

### Cancelsoftwareupdate

- **Signature**: `Cancelsoftwareupdate(string vehicleTag, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `CommandResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `CommandResponse` | `Models/CommandResponse.cs` |

### Chargemaxrange

- **Signature**: `Chargemaxrange(string vehicleTag, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `CommandResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `CommandResponse` | `Models/CommandResponse.cs` |

### Chargestandard

- **Signature**: `Chargestandard(string vehicleTag, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `CommandResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `CommandResponse` | `Models/CommandResponse.cs` |

### ClearPiNtoDriveAdmin

- **Signature**: `ClearPiNtoDriveAdmin(string vehicleTag, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `CommandResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `CommandResponse` | `Models/CommandResponse.cs` |

### Closechargeportdoor

- **Signature**: `Closechargeportdoor(string vehicleTag, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `CommandResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `CommandResponse` | `Models/CommandResponse.cs` |

### EnableordisableGuestMode

- **Signature**: `EnableordisableGuestMode(string vehicleTag, GuestModeRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `CommandResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `GuestModeRequest` | `Models/GuestModeRequest.cs` |
| `CommandResponse` | `Models/CommandResponse.cs` |

### Eraseuserdata

- **Signature**: `Eraseuserdata(string vehicleTag, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `CommandResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `CommandResponse` | `Models/CommandResponse.cs` |

### Flashlights

- **Signature**: `Flashlights(string vehicleTag, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `CommandResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `CommandResponse` | `Models/CommandResponse.cs` |

### Honkhorn

- **Signature**: `Honkhorn(string vehicleTag, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `CommandResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `CommandResponse` | `Models/CommandResponse.cs` |

### Lockdoors

- **Signature**: `Lockdoors(string vehicleTag, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `CommandResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `CommandResponse` | `Models/CommandResponse.cs` |

### Nextfavoritemediatrack

- **Signature**: `Nextfavoritemediatrack(string vehicleTag, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `CommandResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `CommandResponse` | `Models/CommandResponse.cs` |

### Openchargeportdoor

- **Signature**: `Openchargeportdoor(string vehicleTag, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `CommandResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `CommandResponse` | `Models/CommandResponse.cs` |

### Startcharging

- **Signature**: `Startcharging(string vehicleTag, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `CommandResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `CommandResponse` | `Models/CommandResponse.cs` |

### Startclimatepreconditioning

- **Signature**: `Startclimatepreconditioning(string vehicleTag, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `CommandResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `CommandResponse` | `Models/CommandResponse.cs` |

### Stopcharging

- **Signature**: `Stopcharging(string vehicleTag, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `CommandResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `CommandResponse` | `Models/CommandResponse.cs` |

### Stopclimatepreconditioning

- **Signature**: `Stopclimatepreconditioning(string vehicleTag, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `CommandResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `CommandResponse` | `Models/CommandResponse.cs` |

### Unlockdoors

- **Signature**: `Unlockdoors(string vehicleTag, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `CommandResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `CommandResponse` | `Models/CommandResponse.cs` |

