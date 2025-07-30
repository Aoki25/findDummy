using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public void LoadSceneByName(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    public void LoadSelectLevel()
    {
        SceneManager.LoadScene("SelectLevel");  // 名字必须与场景文件一致
    }

    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("退出游戏（编辑器中不会生效）");
    }
}
