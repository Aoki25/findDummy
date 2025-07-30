using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject[] levelPrefabs;   // �������йؿ�Ԥ����
    public Transform levelParent;       // ��ѡ�����ڷ��ùؿ����������

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
            Debug.LogError("�ؿ�������Ч: " + prefabIndex);
        }
    }
}
