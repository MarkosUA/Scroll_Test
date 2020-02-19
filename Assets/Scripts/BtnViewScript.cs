using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BtnViewScript : MonoBehaviour
{
    [SerializeField]
    private BtnManagerScript _btnManager;

    public void OnBtnClick(int btnId)
    {
        _btnManager.CreateObj(btnId);
    }
}
