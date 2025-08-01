using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using Unity.VisualScripting;

public class ChoiceManager : MonoBehaviour
{
    public Transform optionsParent;          // 父物体：Options
    public Button confirmButton;             // 确认按钮

    private Button[] optionButtons;          // 所有选项按钮
    private Button selectBtn = null;       // 当前选中按钮
    private Image[] selectBox;             // 所有选中框
    private int selectedIndex = -1;          // 当前选中项（-1 表示未选）

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

            int index = i; // 闭包问题，必须另存
            //btn.onClick.AddListener(() => OnOptionSelected(index));

            optionButtons[i] = btn;
            selectBox[i] = img;

            if (img.name == "selectBox")
            {
                // 一开始所有选中框都隐藏
                img.gameObject.SetActive(false);
            }
            else { }
        }

        // 确认按钮不可点击
        confirmButton.interactable = false;
        confirmButton.onClick.AddListener(OnConfirm);
    }

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
        confirmButton.interactable = true;
    }

    void OnOptionSelected(int index)
    {
        //// 清除所有选中框
        //for (int i = 0; i < selectBox.Length; i++)
        //{
        //    selectBox[i].gameObject.SetActive(false);
        //}
        Debug.Log("点击了第 " + index + " 个按钮");
        // 显示当前选中的框
        selectBox[index].gameObject.SetActive(true);
        selectedIndex = index;

        // 激活“确定”按钮
        confirmButton.interactable = true;
    }

    void OnConfirm()
    {
        if (selectedIndex != -1)
        {
            Debug.Log("你选择了第 " + selectedIndex + " 项");
            // 跳转到下一场景（请换成你的场景名）
            //SceneManager.LoadScene("VictoryInterface");
        }
    }
}
