using UnityEngine;
using UnityEngine.UI;
using TMPro; // ������� TextMeshPro������������

public class LevelPagination : MonoBehaviour
{
    public GameObject levelButtonPrefab;  // �ؿ���ť��Ԥ����
    public Transform levelPanel;          // ���ɰ�ť�����
    public Button prevButton;
    public Button nextButton;
    public TextMeshProUGUI pageText;      // ������õ��� Text
    // public Text pageText;

    private int totalLevels = 50;
    private int levelsPerPage = 4;
    private int currentPage = 1;
    private int totalPages;

    void Start()
    {
        totalPages = Mathf.CeilToInt((float)totalLevels / levelsPerPage);

        prevButton.onClick.AddListener(GoToPreviousPage);
        nextButton.onClick.AddListener(GoToNextPage);

        LoadCurrentPage();
    }

    void LoadCurrentPage()
    {
        // ��վɰ�ť
        foreach (Transform child in levelPanel)
        {
            Destroy(child.gameObject);
        }

        int startLevel = (currentPage - 1) * levelsPerPage + 1;
        int endLevel = Mathf.Min(startLevel + levelsPerPage - 1, totalLevels);

        for (int i = startLevel; i <= endLevel; i++)
        {
            GameObject buttonObj = Instantiate(levelButtonPrefab, levelPanel);
            buttonObj.GetComponentInChildren<TextMeshProUGUI>().text = "�ؿ� " + i;
            // �����ʹ�õ��� Text�������� TextMeshPro:
            // buttonObj.GetComponentInChildren<Text>().text = "�ؿ� " + i;

            int levelIndex = i;
            buttonObj.GetComponent<Button>().onClick.AddListener(() => OnLevelSelected(levelIndex));
        }

        pageText.text = $"{currentPage}/{totalPages}";

        prevButton.interactable = currentPage > 1;
        nextButton.interactable = currentPage < totalPages;
    }

    void GoToPreviousPage()
    {
        if (currentPage > 1)
        {
            currentPage--;
            LoadCurrentPage();
        }
    }

    void GoToNextPage()
    {
        if (currentPage < totalPages)
        {
            currentPage++;
            LoadCurrentPage();
        }
    }

    void OnLevelSelected(int level)
    {
        Debug.Log("ѡ���˹ؿ���" + level);
        // ���عؿ����������߼�
    }
}
