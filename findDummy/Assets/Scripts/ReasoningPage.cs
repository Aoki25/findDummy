using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ReasoningPage_cla : MonoBehaviour
{
    public Button Button;             // 确认按钮

    private Button selectBtn = null;       // 当前选中按钮

    /// <summary>
    /// 选中一个按钮
    /// </summary>
    public void SelectBtn(Button _btn)
    {
        // 以前没有
        if (null == selectBtn)
        {

        }
        // 以前有的
        else
        {
            selectBtn.transform.Find("chooseImage").gameObject.SetActive(false);        // 把旧的子物体关闭
        }
        selectBtn = _btn;       // 记录当前选中的按钮
        selectBtn.transform.Find("chooseImage").gameObject.SetActive(true);     // 显示当前选中的框
        // 激活“确定”按钮
        Button.interactable = true;
    }
}
