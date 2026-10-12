using System;
using System.Text.Json.Serialization;
using TeslaFleetManagementApi.Core.Enum;

namespace TeslaFleetManagementApi.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<WhichTrunk>))]
public sealed record WhichTrunk : OpenStringEnum<WhichTrunk>
{
    private WhichTrunk(string value) : base(value)
    {
    }

    public static readonly WhichTrunk Front = new("front");

    public static readonly WhichTrunk Rear = new("rear");

    public TResult Match<TResult>(Func<TResult> onFront, Func<TResult> onRear, Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Front => onFront(),
            _ when this == Rear => onRear(),
            _ => otherwise(Value)
        };

    public void Match(Action onFront, Action onRear, Action<string> otherwise)
    {
        if (this == Front) onFront();
        else if (this == Rear) onRear();
        else otherwise(Value);
    }
}
