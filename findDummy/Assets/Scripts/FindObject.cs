using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FindObject : MonoBehaviour
{
    public Button ConfirmButton;             // 确认按钮

    private Button selectBtn = null;       // 当前选中按钮
    public Image img = null;
    public GameObject foundSceneImage = null;

    public NewBehaviourScript newBehaviourScript; // 关联的脚本

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
            selectBtn.transform.Find("selectBox").gameObject.SetActive(false);        // 把旧的子物体关闭
        }
        selectBtn = _btn;       // 记录当前选中的按钮
        selectBtn.transform.Find("selectBox").gameObject.SetActive(true);     // 显示当前选中的框
        // 激活“确定”按钮
        ConfirmButton.interactable = true;
        if(foundSceneImage.gameObject.activeSelf==true)
        {
            this.img.sprite = selectBtn.GetComponent<Image>().sprite; // 设置图片为选中按钮的图片
            this.img.gameObject.SetActive(true); // 显示图片
        }
    }
    public void chuangru()
    {
         
    }
}

