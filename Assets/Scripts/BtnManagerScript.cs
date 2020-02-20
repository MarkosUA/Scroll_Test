using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BtnManagerScript : MonoBehaviour
{
    [SerializeField]
    private PrefabsData _prefabsData;
    [SerializeField]
    private Transform _contentObj;

    public void CreateObj(int objId)
    {
        if (objId <= _prefabsData.objPrefabs.Count)
        {
            var objClone = Instantiate(_prefabsData.objPrefabs[objId], _contentObj.transform.position, Quaternion.identity);
            objClone.transform.SetParent(_contentObj.gameObject.transform);
        }
    }
}
