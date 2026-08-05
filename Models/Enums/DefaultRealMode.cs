using System.Text.Json.Serialization;
using TeslaFleetManagementApi.Core.Enum;

namespace TeslaFleetManagementApi.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<DefaultRealMode>))]
public sealed record DefaultRealMode : StringEnum<DefaultRealMode>
{
    private DefaultRealMode(string value) : base(value)
    {
    }

    public static readonly DefaultRealMode Autonomous = new("autonomous");

    public static readonly DefaultRealMode SelfConsumption = new("self_consumption");

    public static DefaultRealMode FromValue(string value) => FromValueCore(value);
}
