using System.Text.Json.Serialization;
using Tesla.Core.Enum;

namespace Tesla.Models.Enums;

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
