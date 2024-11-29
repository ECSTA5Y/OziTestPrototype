using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "AssetsHolder", menuName = "Scriptable Objects/AssetsHolder")]
public class AssetsHolder : ScriptableObject
{
    public List<LevelManager> levels;
}