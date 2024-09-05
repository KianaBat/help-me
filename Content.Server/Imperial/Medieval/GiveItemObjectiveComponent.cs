namespace Content.Server.Imperial.Medieval;

[RegisterComponent]
public sealed partial class GiveItemObjectiveComponent : Component
{
    [DataField]
    public List<string> Objectives = new List<string> { "MedievalGetTrayObjective", "MedievalGetGPSObjective" };

    [DataField]
    public int MinObjectives = 2;

    [DataField]
    public int MaxObjectives = 2;
}
