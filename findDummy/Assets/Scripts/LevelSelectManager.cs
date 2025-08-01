using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class LevelSelectManager : MonoBehaviour
{
    public GameObject levelButtonPrefab;
    public Transform levelPanel;
    public TextMeshProUGUI pageText;
    public Button prevButton;
    public Button nextButton;

    private int totalLevels = 50;
    private int levelsPerPage = 4;
    private int currentPage = 1;
    private int totalPages;

    void Start()
    {
        totalPages = Mathf.CeilToInt((float)totalLevels / levelsPerPage);
        LoadPage(currentPage);
    }

    void LoadPage(int page)
    {
        // Çå¿Õ¾É°´Å¥
        foreach (Transform child in levelPanel)
            Destroy(child.gameObject);

        int start = (page - 1) * levelsPerPage + 1;
        int end = Mathf.Min(start + levelsPerPage - 1, totalLevels);

        for (int i = start; i <= end; i++)
        {
            GameObject btn = Instantiate(levelButtonPrefab, levelPanel);
            btn.GetComponentInChildren<TextMeshProUGUI>().text = "¹Ø¿¨ " + i;

            int levelIndex = i;
            btn.GetComponent<Button>().onClick.AddListener(() => LoadLevel(levelIndex));
        }

        pageText.text = $"{page}/{totalPages}";
        //prevButton.interactable = page > 1;
        //nextButton.interactable = page < totalPages;
    }

    public void NextPage()
    {
        if (currentPage < totalPages)
        {
            currentPage++;
            LoadPage(currentPage);
        }
    }

    public void PrevPage()
    {
        if (currentPage > 1)
        {
            currentPage--;
            LoadPage(currentPage);
        }
    }

    void LoadLevel(int level)
    {
        SceneManager.LoadScene("Level" + level);
    }
}
