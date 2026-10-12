using System;
using System.Text.Json.Serialization;
using TeslaFleetManagementApi.Core.Enum;

namespace TeslaFleetManagementApi.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<KindGetWallConnectorChargingHistory>))]
public sealed record KindGetWallConnectorChargingHistory : OpenStringEnum<KindGetWallConnectorChargingHistory>
{
    private KindGetWallConnectorChargingHistory(string value) : base(value)
    {
    }

    public static readonly KindGetWallConnectorChargingHistory Charge = new("charge");

    public TResult Match<TResult>(Func<TResult> onCharge, Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Charge => onCharge(),
            _ => otherwise(Value)
        };

    public void Match(Action onCharge, Action<string> otherwise)
    {
        if (this == Charge) onCharge();
        else otherwise(Value);
    }
}
