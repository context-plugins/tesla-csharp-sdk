# Reference

Every operation below is shown in its throwing form. On an error status it throws `ApiException<TError>` — the status code, headers, content type and the operation's error type, `RawError` (the raw body) when the spec declares none — and where an operation offers an `…AsResult` sibling, that sibling returns `ApiResult<TResponse, TError>` instead. A request that produces no usable response surfaces as `SdkConnectionException` or `SdkTimeoutException`, a body that does not match the documented response type as `ResponseDeserializationException`, and a credential that cannot be applied as `AuthSchemeException`; all of them derive from `SdkException` and name the failed call. See [README → Error Handling](README.md#error-handling).

> Source: [TeslaFleetManagementApiClient](src/TeslaFleetManagementApi/TeslaFleetManagementApiClient.cs)

## Charging

> Source: [Charging](src/TeslaFleetManagementApi/Api/Charging.cs)

<details>
<summary><code>Task&lt;ChargingHistoryResponse&gt; GetChargingHistory(RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ChargingHistoryResponse](src/TeslaFleetManagementApi/Models/ChargingHistoryResponse.cs)</code>

**OnError**: <code>[ApiException](src/TeslaFleetManagementApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/TeslaFleetManagementApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task GetChargingInvoice(GetChargingInvoiceRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    await client.Charging.GetChargingInvoice(new GetChargingInvoiceRequest { Id = "some example string" });
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetChargingInvoiceRequest](src/TeslaFleetManagementApi/Requests/Charging/GetChargingInvoiceRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[ApiException](src/TeslaFleetManagementApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/TeslaFleetManagementApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ChargingSessionsResponse&gt; GetChargingSessions(RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ChargingSessionsResponse](src/TeslaFleetManagementApi/Models/ChargingSessionsResponse.cs)</code>

**OnError**: <code>[ApiException](src/TeslaFleetManagementApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/TeslaFleetManagementApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## Energy

> Source: [Energy](src/TeslaFleetManagementApi/Api/Energy.cs)

<details>
<summary><code>Task&lt;BackupResponse&gt; AdjustSiteSBackupReserve(AdjustSiteSBackupReserveRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Energy.AdjustSiteSBackupReserve(new AdjustSiteSBackupReserveRequest
    {
        EnergySiteId = "some example string",
        Body = new BackupRequest { BackupReservePercent = 1 },
    });
    // TODO: Handle 'response' of type BackupResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[AdjustSiteSBackupReserveRequest](src/TeslaFleetManagementApi/Requests/Energy/AdjustSiteSBackupReserveRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[BackupResponse](src/TeslaFleetManagementApi/Models/BackupResponse.cs)</code>

**OnError**: <code>[ApiException](src/TeslaFleetManagementApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/TeslaFleetManagementApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;GenericUpdateResponse&gt; AdjustSiteSOffGridVehicleChargingReserve(AdjustSiteSOffGridVehicleChargingReserveRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Energy.AdjustSiteSOffGridVehicleChargingReserve(
        new AdjustSiteSOffGridVehicleChargingReserveRequest
        {
            EnergySiteId = "some example string",
            Body = new OffGridVehicleChargingReserveRequest { OffGridVehicleChargingReservePercent = 1 },
        });
    // TODO: Handle 'response' of type GenericUpdateResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[AdjustSiteSOffGridVehicleChargingReserveRequest](src/TeslaFleetManagementApi/Requests/Energy/AdjustSiteSOffGridVehicleChargingReserveRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[GenericUpdateResponse](src/TeslaFleetManagementApi/Models/GenericUpdateResponse.cs)</code>

**OnError**: <code>[ApiException](src/TeslaFleetManagementApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/TeslaFleetManagementApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;GenericUpdateResponse&gt; AllowDisallowChargingFromTheGridAndExportingEnergyToTheGrid(AllowDisallowChargingFromTheGridAndExportingEnergyToTheGridRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Energy.AllowDisallowChargingFromTheGridAndExportingEnergyToTheGrid(
        new AllowDisallowChargingFromTheGridAndExportingEnergyToTheGridRequest
        {
            EnergySiteId = "some example string",
        });
    // TODO: Handle 'response' of type GenericUpdateResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[AllowDisallowChargingFromTheGridAndExportingEnergyToTheGridRequest](src/TeslaFleetManagementApi/Requests/Energy/AllowDisallowChargingFromTheGridAndExportingEnergyToTheGridRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[GenericUpdateResponse](src/TeslaFleetManagementApi/Models/GenericUpdateResponse.cs)</code>

**OnError**: <code>[ApiException](src/TeslaFleetManagementApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/TeslaFleetManagementApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;CalendarHistoryResponse&gt; GetBackupOrEnergyHistory(GetBackupOrEnergyHistoryRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Energy.GetBackupOrEnergyHistory(new GetBackupOrEnergyHistoryRequest
    {
        EnergySiteId = "some example string",
        Kind = Kind.Backup,
        StartDate = DateTimeOffset.Parse("2024-01-15T09:30:00Z"),
        EndDate = DateTimeOffset.Parse("2024-01-15T09:30:00Z"),
    });
    // TODO: Handle 'response' of type CalendarHistoryResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetBackupOrEnergyHistoryRequest](src/TeslaFleetManagementApi/Requests/Energy/GetBackupOrEnergyHistoryRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[CalendarHistoryResponse](src/TeslaFleetManagementApi/Models/CalendarHistoryResponse.cs)</code>

**OnError**: <code>[ApiException](src/TeslaFleetManagementApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/TeslaFleetManagementApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;LiveStatusResponse&gt; GetLiveSiteStatus(GetLiveSiteStatusRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Energy.GetLiveSiteStatus(new GetLiveSiteStatusRequest
    {
        EnergySiteId = "some example string",
    });
    // TODO: Handle 'response' of type LiveStatusResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetLiveSiteStatusRequest](src/TeslaFleetManagementApi/Requests/Energy/GetLiveSiteStatusRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[LiveStatusResponse](src/TeslaFleetManagementApi/Models/LiveStatusResponse.cs)</code>

**OnError**: <code>[ApiException](src/TeslaFleetManagementApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/TeslaFleetManagementApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SiteInfoResponse&gt; GetSiteInformationAssetsSettingsFeatures(GetSiteInformationAssetsSettingsFeaturesRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Energy.GetSiteInformationAssetsSettingsFeatures(
        new GetSiteInformationAssetsSettingsFeaturesRequest { EnergySiteId = "some example string" });
    // TODO: Handle 'response' of type SiteInfoResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetSiteInformationAssetsSettingsFeaturesRequest](src/TeslaFleetManagementApi/Requests/Energy/GetSiteInformationAssetsSettingsFeaturesRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SiteInfoResponse](src/TeslaFleetManagementApi/Models/SiteInfoResponse.cs)</code>

**OnError**: <code>[ApiException](src/TeslaFleetManagementApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/TeslaFleetManagementApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ProductsResponse&gt; GetUserProductsVehiclesEnergySites(RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ProductsResponse](src/TeslaFleetManagementApi/Models/ProductsResponse.cs)</code>

**OnError**: <code>[ApiException](src/TeslaFleetManagementApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/TeslaFleetManagementApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ChargeHistoryResponse&gt; GetWallConnectorChargingHistory(GetWallConnectorChargingHistoryRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Energy.GetWallConnectorChargingHistory(new GetWallConnectorChargingHistoryRequest
    {
        EnergySiteId = "some example string",
        Kind = KindGetWallConnectorChargingHistory.Charge,
        StartDate = DateTimeOffset.Parse("2024-01-15T09:30:00Z"),
        EndDate = DateTimeOffset.Parse("2024-01-15T09:30:00Z"),
    });
    // TODO: Handle 'response' of type ChargeHistoryResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetWallConnectorChargingHistoryRequest](src/TeslaFleetManagementApi/Requests/Energy/GetWallConnectorChargingHistoryRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ChargeHistoryResponse](src/TeslaFleetManagementApi/Models/ChargeHistoryResponse.cs)</code>

**OnError**: <code>[ApiException](src/TeslaFleetManagementApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/TeslaFleetManagementApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;GenericUpdateResponse&gt; SetSiteModeAutonomousOrSelfConsumption(SetSiteModeAutonomousOrSelfConsumptionRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Energy.SetSiteModeAutonomousOrSelfConsumption(
        new SetSiteModeAutonomousOrSelfConsumptionRequest
        {
            EnergySiteId = "some example string",
            Body = new OperationRequest { DefaultRealMode = DefaultRealMode.Autonomous },
        });
    // TODO: Handle 'response' of type GenericUpdateResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[SetSiteModeAutonomousOrSelfConsumptionRequest](src/TeslaFleetManagementApi/Requests/Energy/SetSiteModeAutonomousOrSelfConsumptionRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[GenericUpdateResponse](src/TeslaFleetManagementApi/Models/GenericUpdateResponse.cs)</code>

**OnError**: <code>[ApiException](src/TeslaFleetManagementApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/TeslaFleetManagementApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;GenericUpdateResponse&gt; UpdateStormWatchParticipation(UpdateStormWatchParticipationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Energy.UpdateStormWatchParticipation(new UpdateStormWatchParticipationRequest
    {
        EnergySiteId = "some example string",
        Body = new StormModeRequest { Enabled = true },
    });
    // TODO: Handle 'response' of type GenericUpdateResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[UpdateStormWatchParticipationRequest](src/TeslaFleetManagementApi/Requests/Energy/UpdateStormWatchParticipationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[GenericUpdateResponse](src/TeslaFleetManagementApi/Models/GenericUpdateResponse.cs)</code>

**OnError**: <code>[ApiException](src/TeslaFleetManagementApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/TeslaFleetManagementApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;GenericUpdateResponse&gt; UpdateTimeOfUseTouSettings(UpdateTimeOfUseTouSettingsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Energy.UpdateTimeOfUseTouSettings(new UpdateTimeOfUseTouSettingsRequest
    {
        EnergySiteId = "some example string",
        Body = new TimeOfUseSettingsRequest { TouSettings = new TouSettings() },
    });
    // TODO: Handle 'response' of type GenericUpdateResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[UpdateTimeOfUseTouSettingsRequest](src/TeslaFleetManagementApi/Requests/Energy/UpdateTimeOfUseTouSettingsRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[GenericUpdateResponse](src/TeslaFleetManagementApi/Models/GenericUpdateResponse.cs)</code>

**OnError**: <code>[ApiException](src/TeslaFleetManagementApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/TeslaFleetManagementApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## Partner

> Source: [Partner](src/TeslaFleetManagementApi/Api/Partner.cs)

<details>
<summary><code>Task&lt;PublicKeyResponse&gt; GetPublicKeyForADomain(GetPublicKeyForADomainRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Partner.GetPublicKeyForADomain(new GetPublicKeyForADomainRequest
    {
        Domain = "some example string",
    });
    // TODO: Handle 'response' of type PublicKeyResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetPublicKeyForADomainRequest](src/TeslaFleetManagementApi/Requests/Partner/GetPublicKeyForADomainRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[PublicKeyResponse](src/TeslaFleetManagementApi/Models/PublicKeyResponse.cs)</code>

**OnError**: <code>[ApiException](src/TeslaFleetManagementApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/TeslaFleetManagementApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;FleetTelemetryErrorsResponse&gt; GetRecentFleetTelemetryErrors(RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[FleetTelemetryErrorsResponse](src/TeslaFleetManagementApi/Models/FleetTelemetryErrorsResponse.cs)</code>

**OnError**: <code>[ApiException](src/TeslaFleetManagementApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/TeslaFleetManagementApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;BackupResponse&gt; GetVinsWithFleetTelemetryErrors(RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[BackupResponse](src/TeslaFleetManagementApi/Models/BackupResponse.cs)</code>

**OnError**: <code>[ApiException](src/TeslaFleetManagementApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/TeslaFleetManagementApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;RegisterPartnerResponse&gt; RegisterAPartnerAccount(RegisterAPartnerAccountRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Partner.RegisterAPartnerAccount(new RegisterAPartnerAccountRequest
    {
        Body = new RegisterPartnerRequest { Domain = "some example string" },
    });
    // TODO: Handle 'response' of type RegisterPartnerResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[RegisterAPartnerAccountRequest](src/TeslaFleetManagementApi/Requests/Partner/RegisterAPartnerAccountRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[RegisterPartnerResponse](src/TeslaFleetManagementApi/Models/RegisterPartnerResponse.cs)</code>

**OnError**: <code>[ApiException](src/TeslaFleetManagementApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/TeslaFleetManagementApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## User

> Source: [User](src/TeslaFleetManagementApi/Api/User.cs)

<details>
<summary><code>Task&lt;OrdersResponse&gt; GetActiveOrdersForAUser(RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.User.GetActiveOrdersForAUser();
    // TODO: Handle 'response' of type OrdersResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[OrdersResponse](src/TeslaFleetManagementApi/Models/OrdersResponse.cs)</code>

**OnError**: <code>[ApiException](src/TeslaFleetManagementApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/TeslaFleetManagementApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;BackupResponse&gt; GetCustomFeatureFlagsForAUser(RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.User.GetCustomFeatureFlagsForAUser();
    // TODO: Handle 'response' of type BackupResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[BackupResponse](src/TeslaFleetManagementApi/Models/BackupResponse.cs)</code>

**OnError**: <code>[ApiException](src/TeslaFleetManagementApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/TeslaFleetManagementApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;MeResponse&gt; GetSummaryOfAUserSAccount(RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.User.GetSummaryOfAUserSAccount();
    // TODO: Handle 'response' of type MeResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[MeResponse](src/TeslaFleetManagementApi/Models/MeResponse.cs)</code>

**OnError**: <code>[ApiException](src/TeslaFleetManagementApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/TeslaFleetManagementApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;RegionResponse&gt; GetUserSRegionAndFleetApiBaseUrl(RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.User.GetUserSRegionAndFleetApiBaseUrl();
    // TODO: Handle 'response' of type RegionResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[RegionResponse](src/TeslaFleetManagementApi/Models/RegionResponse.cs)</code>

**OnError**: <code>[ApiException](src/TeslaFleetManagementApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/TeslaFleetManagementApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## VehicleCommands

> Source: [VehicleCommands](src/TeslaFleetManagementApi/Api/VehicleCommands.cs)

<details>
<summary><code>Task&lt;CommandResponse&gt; Actuatetrunk(ActuatetrunkOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.VehicleCommands.Actuatetrunk(new ActuatetrunkOperationRequest
    {
        VehicleTag = "some example string",
        Body = new ActuateTrunkRequest { WhichTrunk = WhichTrunk.Front },
    });
    // TODO: Handle 'response' of type CommandResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[ActuatetrunkOperationRequest](src/TeslaFleetManagementApi/Requests/VehicleCommands/ActuatetrunkOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[CommandResponse](src/TeslaFleetManagementApi/Models/CommandResponse.cs)</code>

**OnError**: <code>[ApiException](src/TeslaFleetManagementApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/TeslaFleetManagementApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;CommandResponse&gt; Addchargeschedule(AddchargescheduleOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.VehicleCommands.Addchargeschedule(new AddchargescheduleOperationRequest
    {
        VehicleTag = "some example string",
        Body = new AddChargeScheduleRequest { Lat = 1.5d, Lon = 1.5d, Id = 1, Enabled = true },
    });
    // TODO: Handle 'response' of type CommandResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[AddchargescheduleOperationRequest](src/TeslaFleetManagementApi/Requests/VehicleCommands/AddchargescheduleOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[CommandResponse](src/TeslaFleetManagementApi/Models/CommandResponse.cs)</code>

**OnError**: <code>[ApiException](src/TeslaFleetManagementApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/TeslaFleetManagementApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;CommandResponse&gt; Addpreconditionschedule(AddpreconditionscheduleOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.VehicleCommands.Addpreconditionschedule(new AddpreconditionscheduleOperationRequest
    {
        VehicleTag = "some example string",
        Body = new AddPreconditionScheduleRequest { Lat = 1.5d, Lon = 1.5d, Id = 1, Enabled = true },
    });
    // TODO: Handle 'response' of type CommandResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[AddpreconditionscheduleOperationRequest](src/TeslaFleetManagementApi/Requests/VehicleCommands/AddpreconditionscheduleOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[CommandResponse](src/TeslaFleetManagementApi/Models/CommandResponse.cs)</code>

**OnError**: <code>[ApiException](src/TeslaFleetManagementApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/TeslaFleetManagementApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;CommandResponse&gt; Adjustmediavolume(AdjustmediavolumeRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.VehicleCommands.Adjustmediavolume(new AdjustmediavolumeRequest
    {
        VehicleTag = "some example string",
        Body = new AdjustVolumeRequest { Volume = 1 },
    });
    // TODO: Handle 'response' of type CommandResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[AdjustmediavolumeRequest](src/TeslaFleetManagementApi/Requests/VehicleCommands/AdjustmediavolumeRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[CommandResponse](src/TeslaFleetManagementApi/Models/CommandResponse.cs)</code>

**OnError**: <code>[ApiException](src/TeslaFleetManagementApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/TeslaFleetManagementApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;CommandResponse&gt; Cancelsoftwareupdate(CancelsoftwareupdateRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.VehicleCommands.Cancelsoftwareupdate(new CancelsoftwareupdateRequest
    {
        VehicleTag = "some example string",
    });
    // TODO: Handle 'response' of type CommandResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[CancelsoftwareupdateRequest](src/TeslaFleetManagementApi/Requests/VehicleCommands/CancelsoftwareupdateRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[CommandResponse](src/TeslaFleetManagementApi/Models/CommandResponse.cs)</code>

**OnError**: <code>[ApiException](src/TeslaFleetManagementApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/TeslaFleetManagementApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;CommandResponse&gt; Chargemaxrange(ChargemaxrangeRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.VehicleCommands.Chargemaxrange(new ChargemaxrangeRequest
    {
        VehicleTag = "some example string",
    });
    // TODO: Handle 'response' of type CommandResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[ChargemaxrangeRequest](src/TeslaFleetManagementApi/Requests/VehicleCommands/ChargemaxrangeRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[CommandResponse](src/TeslaFleetManagementApi/Models/CommandResponse.cs)</code>

**OnError**: <code>[ApiException](src/TeslaFleetManagementApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/TeslaFleetManagementApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;CommandResponse&gt; Chargestandard(ChargestandardRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.VehicleCommands.Chargestandard(new ChargestandardRequest
    {
        VehicleTag = "some example string",
    });
    // TODO: Handle 'response' of type CommandResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[ChargestandardRequest](src/TeslaFleetManagementApi/Requests/VehicleCommands/ChargestandardRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[CommandResponse](src/TeslaFleetManagementApi/Models/CommandResponse.cs)</code>

**OnError**: <code>[ApiException](src/TeslaFleetManagementApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/TeslaFleetManagementApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;CommandResponse&gt; ClearPiNtoDriveAdmin(ClearPiNtoDriveAdminRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.VehicleCommands.ClearPiNtoDriveAdmin(new ClearPiNtoDriveAdminRequest
    {
        VehicleTag = "some example string",
    });
    // TODO: Handle 'response' of type CommandResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[ClearPiNtoDriveAdminRequest](src/TeslaFleetManagementApi/Requests/VehicleCommands/ClearPiNtoDriveAdminRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[CommandResponse](src/TeslaFleetManagementApi/Models/CommandResponse.cs)</code>

**OnError**: <code>[ApiException](src/TeslaFleetManagementApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/TeslaFleetManagementApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;CommandResponse&gt; Closechargeportdoor(ClosechargeportdoorRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.VehicleCommands.Closechargeportdoor(new ClosechargeportdoorRequest
    {
        VehicleTag = "some example string",
    });
    // TODO: Handle 'response' of type CommandResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[ClosechargeportdoorRequest](src/TeslaFleetManagementApi/Requests/VehicleCommands/ClosechargeportdoorRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[CommandResponse](src/TeslaFleetManagementApi/Models/CommandResponse.cs)</code>

**OnError**: <code>[ApiException](src/TeslaFleetManagementApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/TeslaFleetManagementApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;CommandResponse&gt; EnableordisableGuestMode(EnableordisableGuestModeRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.VehicleCommands.EnableordisableGuestMode(new EnableordisableGuestModeRequest
    {
        VehicleTag = "some example string",
        Body = new GuestModeRequest { Enable = true },
    });
    // TODO: Handle 'response' of type CommandResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[EnableordisableGuestModeRequest](src/TeslaFleetManagementApi/Requests/VehicleCommands/EnableordisableGuestModeRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[CommandResponse](src/TeslaFleetManagementApi/Models/CommandResponse.cs)</code>

**OnError**: <code>[ApiException](src/TeslaFleetManagementApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/TeslaFleetManagementApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;CommandResponse&gt; Eraseuserdata(EraseuserdataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.VehicleCommands.Eraseuserdata(new EraseuserdataRequest
    {
        VehicleTag = "some example string",
    });
    // TODO: Handle 'response' of type CommandResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[EraseuserdataRequest](src/TeslaFleetManagementApi/Requests/VehicleCommands/EraseuserdataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[CommandResponse](src/TeslaFleetManagementApi/Models/CommandResponse.cs)</code>

**OnError**: <code>[ApiException](src/TeslaFleetManagementApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/TeslaFleetManagementApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;CommandResponse&gt; Flashlights(FlashlightsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.VehicleCommands.Flashlights(new FlashlightsRequest
    {
        VehicleTag = "some example string",
    });
    // TODO: Handle 'response' of type CommandResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[FlashlightsRequest](src/TeslaFleetManagementApi/Requests/VehicleCommands/FlashlightsRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[CommandResponse](src/TeslaFleetManagementApi/Models/CommandResponse.cs)</code>

**OnError**: <code>[ApiException](src/TeslaFleetManagementApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/TeslaFleetManagementApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;CommandResponse&gt; Honkhorn(HonkhornRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.VehicleCommands.Honkhorn(new HonkhornRequest { VehicleTag = "some example string" });
    // TODO: Handle 'response' of type CommandResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[HonkhornRequest](src/TeslaFleetManagementApi/Requests/VehicleCommands/HonkhornRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[CommandResponse](src/TeslaFleetManagementApi/Models/CommandResponse.cs)</code>

**OnError**: <code>[ApiException](src/TeslaFleetManagementApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/TeslaFleetManagementApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;CommandResponse&gt; Lockdoors(LockdoorsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.VehicleCommands.Lockdoors(new LockdoorsRequest { VehicleTag = "some example string" });
    // TODO: Handle 'response' of type CommandResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[LockdoorsRequest](src/TeslaFleetManagementApi/Requests/VehicleCommands/LockdoorsRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[CommandResponse](src/TeslaFleetManagementApi/Models/CommandResponse.cs)</code>

**OnError**: <code>[ApiException](src/TeslaFleetManagementApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/TeslaFleetManagementApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;CommandResponse&gt; Nextfavoritemediatrack(NextfavoritemediatrackRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.VehicleCommands.Nextfavoritemediatrack(new NextfavoritemediatrackRequest
    {
        VehicleTag = "some example string",
    });
    // TODO: Handle 'response' of type CommandResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[NextfavoritemediatrackRequest](src/TeslaFleetManagementApi/Requests/VehicleCommands/NextfavoritemediatrackRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[CommandResponse](src/TeslaFleetManagementApi/Models/CommandResponse.cs)</code>

**OnError**: <code>[ApiException](src/TeslaFleetManagementApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/TeslaFleetManagementApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;CommandResponse&gt; Openchargeportdoor(OpenchargeportdoorRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.VehicleCommands.Openchargeportdoor(new OpenchargeportdoorRequest
    {
        VehicleTag = "some example string",
    });
    // TODO: Handle 'response' of type CommandResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[OpenchargeportdoorRequest](src/TeslaFleetManagementApi/Requests/VehicleCommands/OpenchargeportdoorRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[CommandResponse](src/TeslaFleetManagementApi/Models/CommandResponse.cs)</code>

**OnError**: <code>[ApiException](src/TeslaFleetManagementApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/TeslaFleetManagementApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;CommandResponse&gt; Startcharging(StartchargingRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.VehicleCommands.Startcharging(new StartchargingRequest
    {
        VehicleTag = "some example string",
    });
    // TODO: Handle 'response' of type CommandResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[StartchargingRequest](src/TeslaFleetManagementApi/Requests/VehicleCommands/StartchargingRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[CommandResponse](src/TeslaFleetManagementApi/Models/CommandResponse.cs)</code>

**OnError**: <code>[ApiException](src/TeslaFleetManagementApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/TeslaFleetManagementApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;CommandResponse&gt; Startclimatepreconditioning(StartclimatepreconditioningRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.VehicleCommands.Startclimatepreconditioning(new StartclimatepreconditioningRequest
    {
        VehicleTag = "some example string",
    });
    // TODO: Handle 'response' of type CommandResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[StartclimatepreconditioningRequest](src/TeslaFleetManagementApi/Requests/VehicleCommands/StartclimatepreconditioningRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[CommandResponse](src/TeslaFleetManagementApi/Models/CommandResponse.cs)</code>

**OnError**: <code>[ApiException](src/TeslaFleetManagementApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/TeslaFleetManagementApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;CommandResponse&gt; Stopcharging(StopchargingRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.VehicleCommands.Stopcharging(new StopchargingRequest
    {
        VehicleTag = "some example string",
    });
    // TODO: Handle 'response' of type CommandResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[StopchargingRequest](src/TeslaFleetManagementApi/Requests/VehicleCommands/StopchargingRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[CommandResponse](src/TeslaFleetManagementApi/Models/CommandResponse.cs)</code>

**OnError**: <code>[ApiException](src/TeslaFleetManagementApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/TeslaFleetManagementApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;CommandResponse&gt; Stopclimatepreconditioning(StopclimatepreconditioningRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.VehicleCommands.Stopclimatepreconditioning(new StopclimatepreconditioningRequest
    {
        VehicleTag = "some example string",
    });
    // TODO: Handle 'response' of type CommandResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[StopclimatepreconditioningRequest](src/TeslaFleetManagementApi/Requests/VehicleCommands/StopclimatepreconditioningRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[CommandResponse](src/TeslaFleetManagementApi/Models/CommandResponse.cs)</code>

**OnError**: <code>[ApiException](src/TeslaFleetManagementApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/TeslaFleetManagementApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;CommandResponse&gt; Unlockdoors(UnlockdoorsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.VehicleCommands.Unlockdoors(new UnlockdoorsRequest
    {
        VehicleTag = "some example string",
    });
    // TODO: Handle 'response' of type CommandResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[UnlockdoorsRequest](src/TeslaFleetManagementApi/Requests/VehicleCommands/UnlockdoorsRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[CommandResponse](src/TeslaFleetManagementApi/Models/CommandResponse.cs)</code>

**OnError**: <code>[ApiException](src/TeslaFleetManagementApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/TeslaFleetManagementApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## Vehicles

> Source: [Vehicles](src/TeslaFleetManagementApi/Api/Vehicles.cs)

<details>
<summary><code>Task&lt;object&gt; ConfigureFleetTelemetryUsingSignedJwsToken(ConfigureFleetTelemetryUsingSignedJwsTokenRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Vehicles.ConfigureFleetTelemetryUsingSignedJwsToken(
        new ConfigureFleetTelemetryUsingSignedJwsTokenRequest { Body = new FleetTelemetryJwsRequest() });
    // TODO: Handle 'response' of type object
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[ConfigureFleetTelemetryUsingSignedJwsTokenRequest](src/TeslaFleetManagementApi/Requests/Vehicles/ConfigureFleetTelemetryUsingSignedJwsTokenRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>object</code>

**OnError**: <code>[ApiException](src/TeslaFleetManagementApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/TeslaFleetManagementApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;object&gt; CreateOrUpdateFleetTelemetryConfiguration(CreateOrUpdateFleetTelemetryConfigurationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Vehicles.CreateOrUpdateFleetTelemetryConfiguration(
        new CreateOrUpdateFleetTelemetryConfigurationRequest { Body = body });
    // TODO: Handle 'response' of type object
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[CreateOrUpdateFleetTelemetryConfigurationRequest](src/TeslaFleetManagementApi/Requests/Vehicles/CreateOrUpdateFleetTelemetryConfigurationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>object</code>

**OnError**: <code>[ApiException](src/TeslaFleetManagementApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/TeslaFleetManagementApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;object&gt; DeleteFleetTelemetryConfiguration(DeleteFleetTelemetryConfigurationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Vehicles.DeleteFleetTelemetryConfiguration(new DeleteFleetTelemetryConfigurationRequest
    {
        VehicleTag = "some example string",
    });
    // TODO: Handle 'response' of type object
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[DeleteFleetTelemetryConfigurationRequest](src/TeslaFleetManagementApi/Requests/Vehicles/DeleteFleetTelemetryConfigurationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>object</code>

**OnError**: <code>[ApiException](src/TeslaFleetManagementApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/TeslaFleetManagementApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;DriversResponse&gt; GetAllowedDriversForAVehicle(GetAllowedDriversForAVehicleRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Vehicles.GetAllowedDriversForAVehicle(new GetAllowedDriversForAVehicleRequest
    {
        VehicleTag = "some example string",
    });
    // TODO: Handle 'response' of type DriversResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetAllowedDriversForAVehicleRequest](src/TeslaFleetManagementApi/Requests/Vehicles/GetAllowedDriversForAVehicleRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[DriversResponse](src/TeslaFleetManagementApi/Models/DriversResponse.cs)</code>

**OnError**: <code>[ApiException](src/TeslaFleetManagementApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/TeslaFleetManagementApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SiteInfoResponse&gt; GetEligibleVehicleSubscriptions(GetEligibleVehicleSubscriptionsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Vehicles.GetEligibleVehicleSubscriptions(new GetEligibleVehicleSubscriptionsRequest
    {
        Vin = "some example string",
    });
    // TODO: Handle 'response' of type SiteInfoResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetEligibleVehicleSubscriptionsRequest](src/TeslaFleetManagementApi/Requests/Vehicles/GetEligibleVehicleSubscriptionsRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SiteInfoResponse](src/TeslaFleetManagementApi/Models/SiteInfoResponse.cs)</code>

**OnError**: <code>[ApiException](src/TeslaFleetManagementApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/TeslaFleetManagementApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SiteInfoResponse&gt; GetEligibleVehicleUpgrades(GetEligibleVehicleUpgradesRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Vehicles.GetEligibleVehicleUpgrades(new GetEligibleVehicleUpgradesRequest
    {
        Vin = "some example string",
    });
    // TODO: Handle 'response' of type SiteInfoResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetEligibleVehicleUpgradesRequest](src/TeslaFleetManagementApi/Requests/Vehicles/GetEligibleVehicleUpgradesRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SiteInfoResponse](src/TeslaFleetManagementApi/Models/SiteInfoResponse.cs)</code>

**OnError**: <code>[ApiException](src/TeslaFleetManagementApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/TeslaFleetManagementApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;object&gt; GetEnterpriseRolesForAVehicle(GetEnterpriseRolesForAVehicleRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Vehicles.GetEnterpriseRolesForAVehicle(new GetEnterpriseRolesForAVehicleRequest
    {
        Vin = "some example string",
    });
    // TODO: Handle 'response' of type object
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetEnterpriseRolesForAVehicleRequest](src/TeslaFleetManagementApi/Requests/Vehicles/GetEnterpriseRolesForAVehicleRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>object</code>

**OnError**: <code>[ApiException](src/TeslaFleetManagementApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/TeslaFleetManagementApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;object&gt; GetFleetStatusForVehicles(GetFleetStatusForVehiclesRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Vehicles.GetFleetStatusForVehicles(new GetFleetStatusForVehiclesRequest
    {
        Body = new FleetStatusRequest(),
    });
    // TODO: Handle 'response' of type object
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetFleetStatusForVehiclesRequest](src/TeslaFleetManagementApi/Requests/Vehicles/GetFleetStatusForVehiclesRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>object</code>

**OnError**: <code>[ApiException](src/TeslaFleetManagementApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/TeslaFleetManagementApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;object&gt; GetFleetTelemetryConfiguration(GetFleetTelemetryConfigurationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Vehicles.GetFleetTelemetryConfiguration(new GetFleetTelemetryConfigurationRequest
    {
        VehicleTag = "some example string",
    });
    // TODO: Handle 'response' of type object
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetFleetTelemetryConfigurationRequest](src/TeslaFleetManagementApi/Requests/Vehicles/GetFleetTelemetryConfigurationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>object</code>

**OnError**: <code>[ApiException](src/TeslaFleetManagementApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/TeslaFleetManagementApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;object&gt; GetFleetTelemetryErrorsForAVehicle(GetFleetTelemetryErrorsForAVehicleRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Vehicles.GetFleetTelemetryErrorsForAVehicle(
        new GetFleetTelemetryErrorsForAVehicleRequest { VehicleTag = "some example string" });
    // TODO: Handle 'response' of type object
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetFleetTelemetryErrorsForAVehicleRequest](src/TeslaFleetManagementApi/Requests/Vehicles/GetFleetTelemetryErrorsForAVehicleRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>object</code>

**OnError**: <code>[ApiException](src/TeslaFleetManagementApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/TeslaFleetManagementApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Api1VehiclesResponseResponse200&gt; GetVehicle(GetVehicleRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Vehicles.GetVehicle(new GetVehicleRequest { VehicleTag = "some example string" });
    // TODO: Handle 'response' of type Api1VehiclesResponseResponse200
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetVehicleRequest](src/TeslaFleetManagementApi/Requests/Vehicles/GetVehicleRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Api1VehiclesResponseResponse200](src/TeslaFleetManagementApi/Models/Api1VehiclesResponseResponse200.cs)</code>

**OnError**: <code>[ApiException](src/TeslaFleetManagementApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/TeslaFleetManagementApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Api1VehiclesResponse&gt; ListVehicles(RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Api1VehiclesResponse](src/TeslaFleetManagementApi/Models/Api1VehiclesResponse.cs)</code>

**OnError**: <code>[ApiException](src/TeslaFleetManagementApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/TeslaFleetManagementApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Api1VehiclesMobileEnabledResponse&gt; MobileEnabled(MobileEnabledRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Vehicles.MobileEnabled(new MobileEnabledRequest { VehicleTag = "some example string" });
    // TODO: Handle 'response' of type Api1VehiclesMobileEnabledResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[MobileEnabledRequest](src/TeslaFleetManagementApi/Requests/Vehicles/MobileEnabledRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Api1VehiclesMobileEnabledResponse](src/TeslaFleetManagementApi/Models/Api1VehiclesMobileEnabledResponse.cs)</code>

**OnError**: <code>[ApiException](src/TeslaFleetManagementApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/TeslaFleetManagementApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Api1VehiclesNearbyChargingSitesResponse&gt; NearbyChargingSites(NearbyChargingSitesRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Vehicles.NearbyChargingSites(new NearbyChargingSitesRequest
    {
        VehicleTag = "some example string",
    });
    // TODO: Handle 'response' of type Api1VehiclesNearbyChargingSitesResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[NearbyChargingSitesRequest](src/TeslaFleetManagementApi/Requests/Vehicles/NearbyChargingSitesRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Api1VehiclesNearbyChargingSitesResponse](src/TeslaFleetManagementApi/Models/Api1VehiclesNearbyChargingSitesResponse.cs)</code>

**OnError**: <code>[ApiException](src/TeslaFleetManagementApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/TeslaFleetManagementApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SimpleOkResponse&gt; RemoveDriverAccessFromAVehicle(RemoveDriverAccessFromAVehicleRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Vehicles.RemoveDriverAccessFromAVehicle(new RemoveDriverAccessFromAVehicleRequest
    {
        VehicleTag = "some example string",
    });
    // TODO: Handle 'response' of type SimpleOkResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[RemoveDriverAccessFromAVehicleRequest](src/TeslaFleetManagementApi/Requests/Vehicles/RemoveDriverAccessFromAVehicleRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SimpleOkResponse](src/TeslaFleetManagementApi/Models/SimpleOkResponse.cs)</code>

**OnError**: <code>[ApiException](src/TeslaFleetManagementApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/TeslaFleetManagementApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task SetEnterprisePayerRoles(SetEnterprisePayerRolesRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.Vehicles.SetEnterprisePayerRoles(new SetEnterprisePayerRolesRequest
    {
        Vin = "some example string",
        Body = new EnterprisePayerRequest { Role = "some example string" },
    });
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[SetEnterprisePayerRolesRequest](src/TeslaFleetManagementApi/Requests/Vehicles/SetEnterprisePayerRolesRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[ApiException](src/TeslaFleetManagementApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/TeslaFleetManagementApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SiteInfoResponse&gt; VehicleLiveData(VehicleLiveDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Vehicles.VehicleLiveData(new VehicleLiveDataRequest
    {
        VehicleTag = "some example string",
    });
    // TODO: Handle 'response' of type SiteInfoResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[VehicleLiveDataRequest](src/TeslaFleetManagementApi/Requests/Vehicles/VehicleLiveDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SiteInfoResponse](src/TeslaFleetManagementApi/Models/SiteInfoResponse.cs)</code>

**OnError**: <code>[ApiException](src/TeslaFleetManagementApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/TeslaFleetManagementApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Api1DxVehiclesOptionsResponse&gt; VehicleOptions(VehicleOptionsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Vehicles.VehicleOptions(new VehicleOptionsRequest { Vin = "some example string" });
    // TODO: Handle 'response' of type Api1DxVehiclesOptionsResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[VehicleOptionsRequest](src/TeslaFleetManagementApi/Requests/Vehicles/VehicleOptionsRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Api1DxVehiclesOptionsResponse](src/TeslaFleetManagementApi/Models/Api1DxVehiclesOptionsResponse.cs)</code>

**OnError**: <code>[ApiException](src/TeslaFleetManagementApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/TeslaFleetManagementApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SiteInfoResponse&gt; VehicleSpecs(VehicleSpecsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Vehicles.VehicleSpecs(new VehicleSpecsRequest { Vin = "some example string" });
    // TODO: Handle 'response' of type SiteInfoResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[VehicleSpecsRequest](src/TeslaFleetManagementApi/Requests/Vehicles/VehicleSpecsRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SiteInfoResponse](src/TeslaFleetManagementApi/Models/SiteInfoResponse.cs)</code>

**OnError**: <code>[ApiException](src/TeslaFleetManagementApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/TeslaFleetManagementApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Api1VehiclesWakeUpResponse&gt; WakeUpVehicle(WakeUpVehicleRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Vehicles.WakeUpVehicle(new WakeUpVehicleRequest { VehicleTag = "some example string" });
    // TODO: Handle 'response' of type Api1VehiclesWakeUpResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[WakeUpVehicleRequest](src/TeslaFleetManagementApi/Requests/Vehicles/WakeUpVehicleRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Api1VehiclesWakeUpResponse](src/TeslaFleetManagementApi/Models/Api1VehiclesWakeUpResponse.cs)</code>

**OnError**: <code>[ApiException](src/TeslaFleetManagementApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/TeslaFleetManagementApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Api1DxWarrantyDetailsResponse&gt; WarrantyDetails(RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Api1DxWarrantyDetailsResponse](src/TeslaFleetManagementApi/Models/Api1DxWarrantyDetailsResponse.cs)</code>

**OnError**: <code>[ApiException](src/TeslaFleetManagementApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/TeslaFleetManagementApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

