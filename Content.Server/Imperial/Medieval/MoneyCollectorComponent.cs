using Content.Shared.Random;
using Robust.Shared.Prototypes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Content.Server.Imperial.Medieval;

[RegisterComponent]
public sealed partial class MoneyCollectorComponent : Component
{
    [DataField]
    public int MinimumMoneyAmount = 5;

    [DataField]
    public int MaximumMoneyAmount = 20;

    [DataField]
    public string ObjectivePrototype = "MedievalGetMoneyObjective";
}

