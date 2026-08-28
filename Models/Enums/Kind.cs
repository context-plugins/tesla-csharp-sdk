using System.Text.Json.Serialization;
using Tesla.Core.Enum;

namespace Tesla.Models.Enums;

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
