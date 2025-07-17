using UnityEngine;

/// <summary>
/// Basic character data including stats and equipped items.
/// </summary>
[System.Serializable]
public class Character
{
    public string Name;
    public int Level;
    public int MaxHp = 100;
    public int Hp = 100;
    public int MaxMp = 50;
    public int Mp = 50;
    public int Attack = 10;
    public int Defense = 5;
    public int Speed = 5;

    public SkillTree SkillTree = new();

    public void TakeDamage(int damage)
    {
        int finalDamage = Mathf.Max(damage - Defense, 0);
        Hp = Mathf.Clamp(Hp - finalDamage, 0, MaxHp);
    }

    public void Heal(int amount)
    {
        Hp = Mathf.Clamp(Hp + amount, 0, MaxHp);
    }
}
