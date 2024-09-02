using Content.Server.Mind;
using Content.Server.Objectives;
using Content.Server.Objectives.Components;
using Content.Server.Objectives.Systems;
using Robust.Shared.Random;

namespace Content.Server.Imperial.Medieval;

public sealed class MoneyCollectorSystem : EntitySystem
{
    [Dependency] private readonly MindSystem _mindSystem = default!;
    [Dependency] private readonly ObjectivesSystem _objectives = default!;
    [Dependency] private readonly IRobustRandom _random = default!;
    public override void Initialize()
    {
        base.Initialize();

        SubscribeLocalEvent<MoneyCollectorComponent, ComponentInit>(OnComponentInit);
    }

    private void OnComponentInit(EntityUid uid, MoneyCollectorComponent component, ComponentInit args)
    {
        if (!_mindSystem.TryGetMind(uid, out var mindId, out var mind))
            return;

        var objective = _objectives.TryCreateObjective(mindId, mind, component.ObjectivePrototype);

        if (objective == null) { return; }

        _mindSystem.AddObjective(mindId, mind, objective.Value);
    }
}
