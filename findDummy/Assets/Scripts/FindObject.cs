using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FindObject : MonoBehaviour
{
    public Button ConfirmButton;             // ȷ�ϰ�ť

    private Button selectBtn = null;       // ��ǰѡ�а�ť
    public Image img = null;
    public GameObject foundSceneImage = null;

    public NewBehaviourScript newBehaviourScript; // �����Ľű�

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
            selectBtn.transform.Find("selectBox").gameObject.SetActive(false);        // �Ѿɵ�������ر�
        }
        selectBtn = _btn;       // ��¼��ǰѡ�еİ�ť
        selectBtn.transform.Find("selectBox").gameObject.SetActive(true);     // ��ʾ��ǰѡ�еĿ�
        // ���ȷ������ť
        ConfirmButton.interactable = true;
        if(foundSceneImage.gameObject.activeSelf==true)
        {
            this.img.sprite = selectBtn.GetComponent<Image>().sprite; // ����ͼƬΪѡ�а�ť��ͼƬ
            this.img.gameObject.SetActive(true); // ��ʾͼƬ
        }
    }
    public void chuangru()
    {
         
    }
}

