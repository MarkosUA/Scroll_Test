using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "PrefabsData", menuName = "Data/PrefabsData")]
public class PrefabsData : ScriptableObject
{
    public List<GameObject> objPrefabs = new List<GameObject>();
}
