using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Controls turn based battles.
/// </summary>
public class BattleManager : MonoBehaviour
{
    private readonly List<Character> _turnOrder = new();
    private int _currentIndex;

    public void Setup(List<Character> party)
    {
        _turnOrder.Clear();
        _turnOrder.AddRange(party);
        _turnOrder.Sort((a, b) => b.Speed.CompareTo(a.Speed));
        _currentIndex = 0;
    }

    public Character CurrentCharacter => _turnOrder.Count > 0 ? _turnOrder[_currentIndex] : null;

    public void NextTurn()
    {
        if (_turnOrder.Count == 0) return;
        _currentIndex = (_currentIndex + 1) % _turnOrder.Count;
    }

    public void ExecuteAction(Skill skill, Character target)
    {
        skill?.Execute(CurrentCharacter, target);
        NextTurn();
    }
}
