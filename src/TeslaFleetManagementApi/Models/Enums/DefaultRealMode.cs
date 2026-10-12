using System;
using System.Text.Json.Serialization;
using TeslaFleetManagementApi.Core.Enum;

namespace TeslaFleetManagementApi.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<DefaultRealMode>))]
public sealed record DefaultRealMode : OpenStringEnum<DefaultRealMode>
{
    private DefaultRealMode(string value) : base(value)
    {
    }

    public static readonly DefaultRealMode Autonomous = new("autonomous");

    public static readonly DefaultRealMode SelfConsumption = new("self_consumption");

    public TResult Match<TResult>(Func<TResult> onAutonomous,
        Func<TResult> onSelfConsumption,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Autonomous => onAutonomous(),
            _ when this == SelfConsumption => onSelfConsumption(),
            _ => otherwise(Value)
        };

    public void Match(Action onAutonomous, Action onSelfConsumption, Action<string> otherwise)
    {
        if (this == Autonomous) onAutonomous();
        else if (this == SelfConsumption) onSelfConsumption();
        else otherwise(Value);
    }
}
