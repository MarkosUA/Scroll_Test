using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitBtnView : MonoBehaviour
{
    public void OnExitBtnClick()
    {
        Debug.Log("Out");
        Application.Quit();
    }
}
