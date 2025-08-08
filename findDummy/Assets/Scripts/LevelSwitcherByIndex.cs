   using UnityEngine;

public class LevelSwitcherByIndex : MonoBehaviour
{
    public int targetIndex = 1;         // 想显示哪一个（0开始）

    void Start()
    {
        this.ShowNextPage();
    }
    void ShowNextPage()
    {
        int count = this.transform.childCount;

        for (int i = 0; i < count; i++)
        {
            Transform child = transform.GetChild(i);
            // 只显示索引等于目标的子物体
            child.gameObject.SetActive(i == targetIndex);
        }
    }
    public void NextIndex()
    {
        this.targetIndex++;
        ShowNextPage();
    }
}
