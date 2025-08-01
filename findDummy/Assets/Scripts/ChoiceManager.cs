using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using Unity.VisualScripting;

public class ChoiceManager : MonoBehaviour
{
    public Transform optionsParent;          // �����壺Options
    public Button confirmButton;             // ȷ�ϰ�ť

    private Button[] optionButtons;          // ����ѡ�ť
    private Button selectBtn = null;       // ��ǰѡ�а�ť
    private Image[] selectBox;             // ����ѡ�п�
    private int selectedIndex = -1;          // ��ǰѡ���-1 ��ʾδѡ��

    void Start()
    {
        int childCount = optionsParent.childCount;
        optionButtons = new Button[childCount];
        selectBox = new Image[childCount];

        for (int i = 0; i < childCount; i++)
        {
            Transform child = optionsParent.GetChild(i);
            Button btn = child.GetComponent<Button>();
            Image img = child.GetComponentInChildren<Image>();

            int index = i; // �հ����⣬�������
            //btn.onClick.AddListener(() => OnOptionSelected(index));

            optionButtons[i] = btn;
            selectBox[i] = img;

            if (img.name == "selectBox")
            {
                // һ��ʼ����ѡ�п�����
                img.gameObject.SetActive(false);
            }
            else { }
        }

        // ȷ�ϰ�ť���ɵ��
        confirmButton.interactable = false;
        confirmButton.onClick.AddListener(OnConfirm);
    }

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
        confirmButton.interactable = true;
    }

    void OnOptionSelected(int index)
    {
        //// �������ѡ�п�
        //for (int i = 0; i < selectBox.Length; i++)
        //{
        //    selectBox[i].gameObject.SetActive(false);
        //}
        Debug.Log("����˵� " + index + " ����ť");
        // ��ʾ��ǰѡ�еĿ�
        selectBox[index].gameObject.SetActive(true);
        selectedIndex = index;

        // ���ȷ������ť
        confirmButton.interactable = true;
    }

    void OnConfirm()
    {
        if (selectedIndex != -1)
        {
            Debug.Log("��ѡ���˵� " + selectedIndex + " ��");
            // ��ת����һ�������뻻����ĳ�������
            //SceneManager.LoadScene("VictoryInterface");
        }
    }
}
