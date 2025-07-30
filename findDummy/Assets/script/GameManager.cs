using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject[] levelPrefabs;   // 拖入所有关卡预制体
    public Transform levelParent;       // 可选：用于放置关卡对象的容器

    void Start()
    {
        int levelIndex = PlayerPrefs.GetInt("SelectedLevel", 1);
        int prefabIndex = levelIndex - 1;

        if (prefabIndex >= 0 && prefabIndex < levelPrefabs.Length)
        {
            GameObject level = Instantiate(levelPrefabs[prefabIndex], levelParent);
        }
        else
        {
            Debug.LogError("关卡索引无效: " + prefabIndex);
        }
    }
}
