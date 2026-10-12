using System;
using System.Text.Json.Serialization;
using TeslaFleetManagementApi.Core.Enum;

namespace TeslaFleetManagementApi.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<Kind>))]
public sealed record Kind : OpenStringEnum<Kind>
{
    private Kind(string value) : base(value)
    {
    }

    public static readonly Kind Backup = new("backup");

    public static readonly Kind Energy = new("energy");

    public TResult Match<TResult>(Func<TResult> onBackup, Func<TResult> onEnergy, Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Backup => onBackup(),
            _ when this == Energy => onEnergy(),
            _ => otherwise(Value)
        };

    public void Match(Action onBackup, Action onEnergy, Action<string> otherwise)
    {
        if (this == Backup) onBackup();
        else if (this == Energy) onEnergy();
        else otherwise(Value);
    }
}
