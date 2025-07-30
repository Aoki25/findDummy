using UnityEngine;

public class LevelSwitcherByIndex : MonoBehaviour
{
    public Transform canvasTransform;   // �Ͻ� Canvas
    public int targetIndex = 0;         // ����ʾ��һ����0��ʼ��

    void Start()
    {
        if (canvasTransform == null)
        {
            Debug.LogError("�뽫 Canvas ����ű�");
            return;
        }

        int count = canvasTransform.childCount;

        for (int i = 0; i < count; i++)
        {
            Transform child = canvasTransform.GetChild(i);

            // ֻ��ʾ��������Ŀ���������
            child.gameObject.SetActive(i == targetIndex);
        }
    }
}
