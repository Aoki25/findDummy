using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ArrestPage : MonoBehaviour
{
    public Button ConfirmArrestButton;             // 确认按钮

    private Button selectBtn = null;       // 当前选中按钮 

    /// <summary>
    /// 选中一个按钮
    /// </summary>
    public void SelectBtn(Button _btn)
    {
        // 以前没有
        if (null == selectBtn)
        {
            selectBtn = _btn;       // 记录当前选中的按钮
        }
        // 以前有的
        else
        {
            selectBtn.transform.Find("selectBox").gameObject.SetActive(false);        // 把旧的子物体关闭
            selectBtn = _btn;       // 记录当前选中的按钮
        }
        selectBtn.transform.Find("selectBox").gameObject.SetActive(true);     // 显示当前选中的框
        // 激活“确定”按钮
        
        ConfirmArrestButton.interactable = true;
    }
}