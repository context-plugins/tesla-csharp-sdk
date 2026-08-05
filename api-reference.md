# Reference

> Source: [TeslaFleetManagementApiClient](TeslaFleetManagementApiClient.cs)

## Charging

> Source: [Charging](Api/Charging.cs)

<details>
<summary><code>Task&lt;ChargingHistoryResponse&gt; GetChargingHistory(RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns the paginated charging history for the authenticated account.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Charging.GetChargingHistory();
    // TODO: Handle 'response' of type ChargingHistoryResponse
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ChargingHistoryResponse](Models/ChargingHistoryResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task GetChargingInvoice(string id, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns a charging invoice PDF for a charging session.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.Charging.GetChargingInvoice(id);
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>id</code> | <code>string</code> | Charging session invoice identifier |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ChargingSessionsResponse&gt; GetChargingSessions(RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns charging session information. Only available for business fleet owners.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Charging.GetChargingSessions();
    // TODO: Handle 'response' of type ChargingSessionsResponse
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ChargingSessionsResponse](Models/ChargingSessionsResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## Energy

> Source: [Energy](Api/Energy.cs)

<details>
<summary><code>Task&lt;BackupResponse&gt; AdjustSiteSbackupReserve(string energySiteId, BackupRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Energy.AdjustSiteSbackupReserve(energySiteId, body);
    // TODO: Handle 'response' of type BackupResponse
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>energySiteId</code> | <code>string</code> | - |
| <code>body</code> | <code>[BackupRequest](Models/BackupRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[BackupResponse](Models/BackupResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;GenericUpdateResponse&gt; AdjustSiteSoffGridVehicleChargingReserve(string energySiteId, OffGridVehicleChargingReserveRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Energy.AdjustSiteSoffGridVehicleChargingReserve(energySiteId, body);
    // TODO: Handle 'response' of type GenericUpdateResponse
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>energySiteId</code> | <code>string</code> | - |
| <code>body</code> | <code>[OffGridVehicleChargingReserveRequest](Models/OffGridVehicleChargingReserveRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[GenericUpdateResponse](Models/GenericUpdateResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;GenericUpdateResponse&gt; AllowDisallowChargingFromTheGridAndExportingEnergyToTheGrid(string energySiteId, object? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Energy.AllowDisallowChargingFromTheGridAndExportingEnergyToTheGrid(energySiteId, body);
    // TODO: Handle 'response' of type GenericUpdateResponse
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>energySiteId</code> | <code>string</code> | - |
| <code>body</code> | <code>object?</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[GenericUpdateResponse](Models/GenericUpdateResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;CalendarHistoryResponse&gt; GetBackupOrEnergyHistory(string energySiteId, Kind kind, DateTimeOffset startDate, DateTimeOffset endDate, string? period, string? timeZone, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Energy.GetBackupOrEnergyHistory(energySiteId,
        kind,
        startDate,
        endDate,
        period,
        timeZone);
    // TODO: Handle 'response' of type CalendarHistoryResponse
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>energySiteId</code> | <code>string</code> | - |
| <code>kind</code> | <code>[Kind](Models/Enums/Kind.cs)</code> | - |
| <code>startDate</code> | <code>DateTimeOffset</code> | - |
| <code>endDate</code> | <code>DateTimeOffset</code> | - |
| <code>period</code> | <code>string?</code> | - |
| <code>timeZone</code> | <code>string?</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[CalendarHistoryResponse](Models/CalendarHistoryResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;LiveStatusResponse&gt; GetLiveSiteStatus(string energySiteId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Energy.GetLiveSiteStatus(energySiteId);
    // TODO: Handle 'response' of type LiveStatusResponse
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>energySiteId</code> | <code>string</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[LiveStatusResponse](Models/LiveStatusResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SiteInfoResponse&gt; GetSiteInformationAssetsSettingsFeatures(string energySiteId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Energy.GetSiteInformationAssetsSettingsFeatures(energySiteId);
    // TODO: Handle 'response' of type SiteInfoResponse
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>energySiteId</code> | <code>string</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SiteInfoResponse](Models/SiteInfoResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ProductsResponse&gt; GetUserProductsVehiclesEnergySites(RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Energy.GetUserProductsVehiclesEnergySites();
    // TODO: Handle 'response' of type ProductsResponse
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ProductsResponse](Models/ProductsResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ChargeHistoryResponse&gt; GetWallConnectorChargingHistory(string energySiteId, KindGetWallConnectorChargingHistory kind, DateTimeOffset startDate, DateTimeOffset endDate, string? timeZone, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Energy.GetWallConnectorChargingHistory(energySiteId,
        kind,
        startDate,
        endDate,
        timeZone);
    // TODO: Handle 'response' of type ChargeHistoryResponse
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>energySiteId</code> | <code>string</code> | - |
| <code>kind</code> | <code>[KindGetWallConnectorChargingHistory](Models/Enums/KindGetWallConnectorChargingHistory.cs)</code> | - |
| <code>startDate</code> | <code>DateTimeOffset</code> | - |
| <code>endDate</code> | <code>DateTimeOffset</code> | - |
| <code>timeZone</code> | <code>string?</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ChargeHistoryResponse](Models/ChargeHistoryResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;GenericUpdateResponse&gt; SetSiteModeAutonomousOrSelfConsumption(string energySiteId, OperationRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Energy.SetSiteModeAutonomousOrSelfConsumption(energySiteId, body);
    // TODO: Handle 'response' of type GenericUpdateResponse
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>energySiteId</code> | <code>string</code> | - |
| <code>body</code> | <code>[OperationRequest](Models/OperationRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[GenericUpdateResponse](Models/GenericUpdateResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;GenericUpdateResponse&gt; UpdateStormWatchParticipation(string energySiteId, StormModeRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Energy.UpdateStormWatchParticipation(energySiteId, body);
    // TODO: Handle 'response' of type GenericUpdateResponse
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>energySiteId</code> | <code>string</code> | - |
| <code>body</code> | <code>[StormModeRequest](Models/StormModeRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[GenericUpdateResponse](Models/GenericUpdateResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;GenericUpdateResponse&gt; UpdateTimeOfUseTouSettings(string energySiteId, TimeOfUseSettingsRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Energy.UpdateTimeOfUseTouSettings(energySiteId, body);
    // TODO: Handle 'response' of type GenericUpdateResponse
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>energySiteId</code> | <code>string</code> | - |
| <code>body</code> | <code>[TimeOfUseSettingsRequest](Models/TimeOfUseSettingsRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[GenericUpdateResponse](Models/GenericUpdateResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## Partner

> Source: [Partner](Api/Partner.cs)

<details>
<summary><code>Task&lt;PublicKeyResponse&gt; GetPublicKeyForAdomain(string domain, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Partner.GetPublicKeyForAdomain(domain);
    // TODO: Handle 'response' of type PublicKeyResponse
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>domain</code> | <code>string</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[PublicKeyResponse](Models/PublicKeyResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;FleetTelemetryErrorsResponse&gt; GetRecentFleetTelemetryErrors(RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Partner.GetRecentFleetTelemetryErrors();
    // TODO: Handle 'response' of type FleetTelemetryErrorsResponse
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[FleetTelemetryErrorsResponse](Models/FleetTelemetryErrorsResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;BackupResponse&gt; GetVinsWithFleetTelemetryErrors(RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Partner.GetVinsWithFleetTelemetryErrors();
    // TODO: Handle 'response' of type BackupResponse
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[BackupResponse](Models/BackupResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;RegisterPartnerResponse&gt; RegisterApartnerAccount(RegisterPartnerRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Partner.RegisterApartnerAccount(body);
    // TODO: Handle 'response' of type RegisterPartnerResponse
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>body</code> | <code>[RegisterPartnerRequest](Models/RegisterPartnerRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[RegisterPartnerResponse](Models/RegisterPartnerResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## User

> Source: [User](Api/User.cs)

<details>
<summary><code>Task&lt;OrdersResponse&gt; GetActiveOrdersForAuser(RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.User.GetActiveOrdersForAuser();
    // TODO: Handle 'response' of type OrdersResponse
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[OrdersResponse](Models/OrdersResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;BackupResponse&gt; GetCustomFeatureFlagsForAuser(RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.User.GetCustomFeatureFlagsForAuser();
    // TODO: Handle 'response' of type BackupResponse
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[BackupResponse](Models/BackupResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;MeResponse&gt; GetSummaryOfAuserSaccount(RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.User.GetSummaryOfAuserSaccount();
    // TODO: Handle 'response' of type MeResponse
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[MeResponse](Models/MeResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;RegionResponse&gt; GetUserSregionAndFleetApiBaseUrl(RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.User.GetUserSregionAndFleetApiBaseUrl();
    // TODO: Handle 'response' of type RegionResponse
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[RegionResponse](Models/RegionResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## VehicleCommands

> Source: [VehicleCommands](Api/VehicleCommands.cs)

<details>
<summary><code>Task&lt;CommandResponse&gt; Actuatetrunk(string vehicleTag, ActuateTrunkRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Controls the front or rear trunk

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.VehicleCommands.Actuatetrunk(vehicleTag, body);
    // TODO: Handle 'response' of type CommandResponse
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>vehicleTag</code> | <code>string</code> | - |
| <code>body</code> | <code>[ActuateTrunkRequest](Models/ActuateTrunkRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[CommandResponse](Models/CommandResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;CommandResponse&gt; Addchargeschedule(string vehicleTag, AddChargeScheduleRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.VehicleCommands.Addchargeschedule(vehicleTag, body);
    // TODO: Handle 'response' of type CommandResponse
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>vehicleTag</code> | <code>string</code> | - |
| <code>body</code> | <code>[AddChargeScheduleRequest](Models/AddChargeScheduleRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[CommandResponse](Models/CommandResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;CommandResponse&gt; Addpreconditionschedule(string vehicleTag, AddPreconditionScheduleRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.VehicleCommands.Addpreconditionschedule(vehicleTag, body);
    // TODO: Handle 'response' of type CommandResponse
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>vehicleTag</code> | <code>string</code> | - |
| <code>body</code> | <code>[AddPreconditionScheduleRequest](Models/AddPreconditionScheduleRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[CommandResponse](Models/CommandResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;CommandResponse&gt; Adjustmediavolume(string vehicleTag, AdjustVolumeRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.VehicleCommands.Adjustmediavolume(vehicleTag, body);
    // TODO: Handle 'response' of type CommandResponse
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>vehicleTag</code> | <code>string</code> | - |
| <code>body</code> | <code>[AdjustVolumeRequest](Models/AdjustVolumeRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[CommandResponse](Models/CommandResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;CommandResponse&gt; Cancelsoftwareupdate(string vehicleTag, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.VehicleCommands.Cancelsoftwareupdate(vehicleTag);
    // TODO: Handle 'response' of type CommandResponse
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>vehicleTag</code> | <code>string</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[CommandResponse](Models/CommandResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;CommandResponse&gt; Chargemaxrange(string vehicleTag, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.VehicleCommands.Chargemaxrange(vehicleTag);
    // TODO: Handle 'response' of type CommandResponse
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>vehicleTag</code> | <code>string</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[CommandResponse](Models/CommandResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;CommandResponse&gt; Chargestandard(string vehicleTag, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.VehicleCommands.Chargestandard(vehicleTag);
    // TODO: Handle 'response' of type CommandResponse
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>vehicleTag</code> | <code>string</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[CommandResponse](Models/CommandResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;CommandResponse&gt; ClearPintoDriveAdmin(string vehicleTag, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Deactivates PIN to Drive and resets the associated PIN for supported firmware versions.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.VehicleCommands.ClearPintoDriveAdmin(vehicleTag);
    // TODO: Handle 'response' of type CommandResponse
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>vehicleTag</code> | <code>string</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[CommandResponse](Models/CommandResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;CommandResponse&gt; Closechargeportdoor(string vehicleTag, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.VehicleCommands.Closechargeportdoor(vehicleTag);
    // TODO: Handle 'response' of type CommandResponse
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>vehicleTag</code> | <code>string</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[CommandResponse](Models/CommandResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;CommandResponse&gt; EnableordisableGuestMode(string vehicleTag, GuestModeRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.VehicleCommands.EnableordisableGuestMode(vehicleTag, body);
    // TODO: Handle 'response' of type CommandResponse
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>vehicleTag</code> | <code>string</code> | - |
| <code>body</code> | <code>[GuestModeRequest](Models/GuestModeRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[CommandResponse](Models/CommandResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;CommandResponse&gt; Eraseuserdata(string vehicleTag, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Erases user data from the vehicle UI. Requires Guest Mode.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.VehicleCommands.Eraseuserdata(vehicleTag);
    // TODO: Handle 'response' of type CommandResponse
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>vehicleTag</code> | <code>string</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[CommandResponse](Models/CommandResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;CommandResponse&gt; Flashlights(string vehicleTag, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Briefly flashes vehicle headlights.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.VehicleCommands.Flashlights(vehicleTag);
    // TODO: Handle 'response' of type CommandResponse
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>vehicleTag</code> | <code>string</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[CommandResponse](Models/CommandResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;CommandResponse&gt; Honkhorn(string vehicleTag, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.VehicleCommands.Honkhorn(vehicleTag);
    // TODO: Handle 'response' of type CommandResponse
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>vehicleTag</code> | <code>string</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[CommandResponse](Models/CommandResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;CommandResponse&gt; Lockdoors(string vehicleTag, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.VehicleCommands.Lockdoors(vehicleTag);
    // TODO: Handle 'response' of type CommandResponse
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>vehicleTag</code> | <code>string</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[CommandResponse](Models/CommandResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;CommandResponse&gt; Nextfavoritemediatrack(string vehicleTag, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.VehicleCommands.Nextfavoritemediatrack(vehicleTag);
    // TODO: Handle 'response' of type CommandResponse
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>vehicleTag</code> | <code>string</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[CommandResponse](Models/CommandResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;CommandResponse&gt; Openchargeportdoor(string vehicleTag, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.VehicleCommands.Openchargeportdoor(vehicleTag);
    // TODO: Handle 'response' of type CommandResponse
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>vehicleTag</code> | <code>string</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[CommandResponse](Models/CommandResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;CommandResponse&gt; Startcharging(string vehicleTag, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.VehicleCommands.Startcharging(vehicleTag);
    // TODO: Handle 'response' of type CommandResponse
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>vehicleTag</code> | <code>string</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[CommandResponse](Models/CommandResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;CommandResponse&gt; Startclimatepreconditioning(string vehicleTag, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.VehicleCommands.Startclimatepreconditioning(vehicleTag);
    // TODO: Handle 'response' of type CommandResponse
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>vehicleTag</code> | <code>string</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[CommandResponse](Models/CommandResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;CommandResponse&gt; Stopcharging(string vehicleTag, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.VehicleCommands.Stopcharging(vehicleTag);
    // TODO: Handle 'response' of type CommandResponse
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>vehicleTag</code> | <code>string</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[CommandResponse](Models/CommandResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;CommandResponse&gt; Stopclimatepreconditioning(string vehicleTag, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.VehicleCommands.Stopclimatepreconditioning(vehicleTag);
    // TODO: Handle 'response' of type CommandResponse
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>vehicleTag</code> | <code>string</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[CommandResponse](Models/CommandResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;CommandResponse&gt; Unlockdoors(string vehicleTag, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.VehicleCommands.Unlockdoors(vehicleTag);
    // TODO: Handle 'response' of type CommandResponse
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>vehicleTag</code> | <code>string</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[CommandResponse](Models/CommandResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## Vehicles

> Source: [Vehicles](Api/Vehicles.cs)

<details>
<summary><code>Task&lt;object&gt; ConfigureFleetTelemetryUsingSignedJwsToken(FleetTelemetryJwsRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Vehicles.ConfigureFleetTelemetryUsingSignedJwsToken(body);
    // TODO: Handle 'response' of type object
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>body</code> | <code>[FleetTelemetryJwsRequest](Models/FleetTelemetryJwsRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>object</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;object&gt; CreateOrUpdateFleetTelemetryConfiguration(object body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Vehicles.CreateOrUpdateFleetTelemetryConfiguration(body);
    // TODO: Handle 'response' of type object
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>body</code> | <code>object</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>object</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;object&gt; DeleteFleetTelemetryConfiguration(string vehicleTag, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Vehicles.DeleteFleetTelemetryConfiguration(vehicleTag);
    // TODO: Handle 'response' of type object
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>vehicleTag</code> | <code>string</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>object</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;DriversResponse&gt; GetAllowedDriversForAvehicle(string vehicleTag, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Vehicles.GetAllowedDriversForAvehicle(vehicleTag);
    // TODO: Handle 'response' of type DriversResponse
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>vehicleTag</code> | <code>string</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[DriversResponse](Models/DriversResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SiteInfoResponse&gt; GetEligibleVehicleSubscriptions(string vin, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Vehicles.GetEligibleVehicleSubscriptions(vin);
    // TODO: Handle 'response' of type SiteInfoResponse
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>vin</code> | <code>string</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SiteInfoResponse](Models/SiteInfoResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SiteInfoResponse&gt; GetEligibleVehicleUpgrades(string vin, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Vehicles.GetEligibleVehicleUpgrades(vin);
    // TODO: Handle 'response' of type SiteInfoResponse
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>vin</code> | <code>string</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SiteInfoResponse](Models/SiteInfoResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;object&gt; GetEnterpriseRolesForAvehicle(string vin, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Vehicles.GetEnterpriseRolesForAvehicle(vin);
    // TODO: Handle 'response' of type object
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>vin</code> | <code>string</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>object</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;object&gt; GetFleetStatusForVehicles(FleetStatusRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Vehicles.GetFleetStatusForVehicles(body);
    // TODO: Handle 'response' of type object
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>body</code> | <code>[FleetStatusRequest](Models/FleetStatusRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>object</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;object&gt; GetFleetTelemetryConfiguration(string vehicleTag, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Vehicles.GetFleetTelemetryConfiguration(vehicleTag);
    // TODO: Handle 'response' of type object
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>vehicleTag</code> | <code>string</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>object</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;object&gt; GetFleetTelemetryErrorsForAvehicle(string vehicleTag, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Vehicles.GetFleetTelemetryErrorsForAvehicle(vehicleTag);
    // TODO: Handle 'response' of type object
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>vehicleTag</code> | <code>string</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>object</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Api1VehiclesResponseResponse200&gt; GetVehicle(string vehicleTag, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Vehicles.GetVehicle(vehicleTag);
    // TODO: Handle 'response' of type Api1VehiclesResponseResponse200
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>vehicleTag</code> | <code>string</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Api1VehiclesResponseResponse200](Models/Api1VehiclesResponseResponse200.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Api1VehiclesResponse&gt; ListVehicles(RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Vehicles.ListVehicles();
    // TODO: Handle 'response' of type Api1VehiclesResponse
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Api1VehiclesResponse](Models/Api1VehiclesResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Api1VehiclesMobileEnabledResponse&gt; MobileEnabled(string vehicleTag, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Vehicles.MobileEnabled(vehicleTag);
    // TODO: Handle 'response' of type Api1VehiclesMobileEnabledResponse
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>vehicleTag</code> | <code>string</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Api1VehiclesMobileEnabledResponse](Models/Api1VehiclesMobileEnabledResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Api1VehiclesNearbyChargingSitesResponse&gt; NearbyChargingSites(string vehicleTag, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Vehicles.NearbyChargingSites(vehicleTag);
    // TODO: Handle 'response' of type Api1VehiclesNearbyChargingSitesResponse
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>vehicleTag</code> | <code>string</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Api1VehiclesNearbyChargingSitesResponse](Models/Api1VehiclesNearbyChargingSitesResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SimpleOkResponse&gt; RemoveDriverAccessFromAvehicle(string vehicleTag, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Vehicles.RemoveDriverAccessFromAvehicle(vehicleTag);
    // TODO: Handle 'response' of type SimpleOkResponse
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>vehicleTag</code> | <code>string</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SimpleOkResponse](Models/SimpleOkResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task SetEnterprisePayerRoles(string vin, EnterprisePayerRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.Vehicles.SetEnterprisePayerRoles(vin, body);
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>vin</code> | <code>string</code> | - |
| <code>body</code> | <code>[EnterprisePayerRequest](Models/EnterprisePayerRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SiteInfoResponse&gt; VehicleLiveData(string vehicleTag, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Vehicles.VehicleLiveData(vehicleTag);
    // TODO: Handle 'response' of type SiteInfoResponse
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>vehicleTag</code> | <code>string</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SiteInfoResponse](Models/SiteInfoResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Api1DxVehiclesOptionsResponse&gt; VehicleOptions(string vin, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Vehicles.VehicleOptions(vin);
    // TODO: Handle 'response' of type Api1DxVehiclesOptionsResponse
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>vin</code> | <code>string</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Api1DxVehiclesOptionsResponse](Models/Api1DxVehiclesOptionsResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SiteInfoResponse&gt; VehicleSpecs(string vin, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Vehicles.VehicleSpecs(vin);
    // TODO: Handle 'response' of type SiteInfoResponse
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>vin</code> | <code>string</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SiteInfoResponse](Models/SiteInfoResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Api1VehiclesWakeUpResponse&gt; WakeUpVehicle(string vehicleTag, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Vehicles.WakeUpVehicle(vehicleTag);
    // TODO: Handle 'response' of type Api1VehiclesWakeUpResponse
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>vehicleTag</code> | <code>string</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Api1VehiclesWakeUpResponse](Models/Api1VehiclesWakeUpResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Api1DxWarrantyDetailsResponse&gt; WarrantyDetails(RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Vehicles.WarrantyDetails();
    // TODO: Handle 'response' of type Api1DxWarrantyDetailsResponse
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Api1DxWarrantyDetailsResponse](Models/Api1DxWarrantyDetailsResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

