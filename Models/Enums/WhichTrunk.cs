using System.Text.Json.Serialization;
using TeslaFleetManagementApi.Core.Enum;

namespace TeslaFleetManagementApi.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<WhichTrunk>))]
public sealed record WhichTrunk : StringEnum<WhichTrunk>
{
    private WhichTrunk(string value) : base(value)
    {
    }

    public static readonly WhichTrunk Front = new("front");

    public static readonly WhichTrunk Rear = new("rear");

    public static WhichTrunk FromValue(string value) => FromValueCore(value);
}
