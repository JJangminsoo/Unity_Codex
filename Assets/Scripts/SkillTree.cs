using System.Collections.Generic;

/// <summary>
/// Holds unlocked and available skills for a character.
/// </summary>
[System.Serializable]
public class SkillTree
{
    public List<Skill> UnlockedSkills = new();

    public void UnlockSkill(Skill skill)
    {
        if (!UnlockedSkills.Contains(skill))
        {
            UnlockedSkills.Add(skill);
        }
    }
}
