using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BtnManagerScript : MonoBehaviour
{
    [SerializeField]
    private List<GameObject> _objPrefabs = new List<GameObject>();

    public void CreateObj(int objId)
    {
        if (objId <= _objPrefabs.Count)
        {
            var objClone = Instantiate(_objPrefabs[objId], transform.position, Quaternion.identity);
            objClone.transform.SetParent(gameObject.transform);
        }
    }
}
