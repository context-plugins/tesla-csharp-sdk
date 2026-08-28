using System.Text.Json.Serialization;
using Tesla.Core.Enum;

namespace Tesla.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<KindGetWallConnectorChargingHistory>))]
public sealed record KindGetWallConnectorChargingHistory : StringEnum<KindGetWallConnectorChargingHistory>
{
    private KindGetWallConnectorChargingHistory(string value) : base(value)
    {
    }

    public static readonly KindGetWallConnectorChargingHistory Charge = new("charge");

    public static KindGetWallConnectorChargingHistory FromValue(string value) => FromValueCore(value);
}
