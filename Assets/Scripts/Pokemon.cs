using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Type
{
    Grass, Fire , Water, Rock, Normal, Electric, Ground, Psychic, Fighting, Flying
}
[CreateAssetMenu(fileName = "Pokemon", menuName = "Pokemon", order = 0)]
public class Pokemon : ScriptableObject
{
    public Sprite icon;
    public Type[] pokeTypes;
    public Color color;
    [Range(0,100)]
    public int level=0;
    public int HP, attack, defense = 0;
    public Pokemon nextEvolution;


}
