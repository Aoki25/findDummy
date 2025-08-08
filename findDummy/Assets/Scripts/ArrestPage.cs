using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ArrestPage : MonoBehaviour
{
    public Button ConfirmArrestButton;             // ȷ�ϰ�ť

    private Button selectBtn = null;       // ��ǰѡ�а�ť 

    /// <summary>
    /// ѡ��һ����ť
    /// </summary>
    public void SelectBtn(Button _btn)
    {
        // ��ǰû��
        if (null == selectBtn)
        {
            selectBtn = _btn;       // ��¼��ǰѡ�еİ�ť
        }
        // ��ǰ�е�
        else
        {
            selectBtn.transform.Find("selectBox").gameObject.SetActive(false);        // �Ѿɵ�������ر�
            selectBtn = _btn;       // ��¼��ǰѡ�еİ�ť
        }
        selectBtn.transform.Find("selectBox").gameObject.SetActive(true);     // ��ʾ��ǰѡ�еĿ�
        // ���ȷ������ť
        
        ConfirmArrestButton.interactable = true;
    }
}