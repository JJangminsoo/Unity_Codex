using UnityEngine;

/// <summary>
/// Represents an action a character can perform.
/// </summary>
[System.Serializable]
public class Skill
{
    public string Name;
    public int MpCost;
    public int Power;

    public virtual void Execute(Character caster, Character target)
    {
        if (caster.Mp < MpCost) return;
        caster.Mp -= MpCost;
        target.TakeDamage(Power + caster.Attack);
    }
}
