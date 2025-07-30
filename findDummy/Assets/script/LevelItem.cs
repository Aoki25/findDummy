using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelItem : MonoBehaviour
{
    public GameObject selectsp =null;

   public void  clickLevel()
    {
        Debug.Log("click");
        this.selectsp.SetActive(true);
    }
}
