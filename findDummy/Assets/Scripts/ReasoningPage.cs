using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ReasoningPage_cla : MonoBehaviour
{
    public Button Button;             // ȷ�ϰ�ť

    private Button selectBtn = null;       // ��ǰѡ�а�ť

    /// <summary>
    /// ѡ��һ����ť
    /// </summary>
    public void SelectBtn(Button _btn)
    {
        // ��ǰû��
        if (null == selectBtn)
        {

        }
        // ��ǰ�е�
        else
        {
            selectBtn.transform.Find("chooseImage").gameObject.SetActive(false);        // �Ѿɵ�������ر�
        }
        selectBtn = _btn;       // ��¼��ǰѡ�еİ�ť
        selectBtn.transform.Find("chooseImage").gameObject.SetActive(true);     // ��ʾ��ǰѡ�еĿ�
        // ���ȷ������ť
        Button.interactable = true;
    }
}
