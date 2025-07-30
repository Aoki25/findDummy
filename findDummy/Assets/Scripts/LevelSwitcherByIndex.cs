using UnityEngine;

public class LevelSwitcherByIndex : MonoBehaviour
{
    public Transform canvasTransform;   // 拖进 Canvas
    public int targetIndex = 0;         // 想显示哪一个（0开始）

    void Start()
    {
        if (canvasTransform == null)
        {
            Debug.LogError("请将 Canvas 拖入脚本");
            return;
        }

        int count = canvasTransform.childCount;

        for (int i = 0; i < count; i++)
        {
            Transform child = canvasTransform.GetChild(i);

            // 只显示索引等于目标的子物体
            child.gameObject.SetActive(i == targetIndex);
        }
    }
}
