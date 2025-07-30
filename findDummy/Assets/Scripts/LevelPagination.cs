using UnityEngine;
using UnityEngine.UI;
using TMPro; // 如果你用 TextMeshPro，就启用这行

public class LevelPagination : MonoBehaviour
{
    public GameObject levelButtonPrefab;  // 关卡按钮的预制体
    public Transform levelPanel;          // 容纳按钮的面板
    public Button prevButton;
    public Button nextButton;
    public TextMeshProUGUI pageText;      // 如果你用的是 Text
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
        // 清空旧按钮
        foreach (Transform child in levelPanel)
        {
            Destroy(child.gameObject);
        }

        int startLevel = (currentPage - 1) * levelsPerPage + 1;
        int endLevel = Mathf.Min(startLevel + levelsPerPage - 1, totalLevels);

        for (int i = startLevel; i <= endLevel; i++)
        {
            GameObject buttonObj = Instantiate(levelButtonPrefab, levelPanel);
            buttonObj.GetComponentInChildren<TextMeshProUGUI>().text = "关卡 " + i;
            // 如果你使用的是 Text，而不是 TextMeshPro:
            // buttonObj.GetComponentInChildren<Text>().text = "关卡 " + i;

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
        Debug.Log("选择了关卡：" + level);
        // 加载关卡场景或处理逻辑
    }
}
