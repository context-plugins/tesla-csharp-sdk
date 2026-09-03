using System.Text.Json.Serialization;
using TeslaFleetManagementApi.Core.Enum;

namespace TeslaFleetManagementApi.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<Kind>))]
public sealed record Kind : StringEnum<Kind>
{
    private Kind(string value) : base(value)
    {
    }

    public static readonly Kind Backup = new("backup");

    public static readonly Kind Energy = new("energy");

    public static Kind FromValue(string value) => FromValueCore(value);
}
