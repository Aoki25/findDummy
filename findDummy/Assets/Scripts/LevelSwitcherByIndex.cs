   using UnityEngine;

public class LevelSwitcherByIndex : MonoBehaviour
{
    public int targetIndex = 1;         // ����ʾ��һ����0��ʼ��

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
            // ֻ��ʾ��������Ŀ���������
            child.gameObject.SetActive(i == targetIndex);
        }
    }
    public void NextIndex()
    {
        this.targetIndex++;
        ShowNextPage();
    }
}
