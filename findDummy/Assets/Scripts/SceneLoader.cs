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
    public void LoadLevel()
    {
        SceneManager.LoadScene("Level");  // 名字必须与场景文件一致
    }
    public void ReturnToHome()
    {
        SceneManager.LoadScene("home"); // 请确保场景名和构建设置中一致
    }
    public void ReturnToSelectLevel()
    {
        SceneManager.LoadScene("SelectLevel"); // 请确保场景名和构建设置中一致
    }  
    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("退出游戏（编辑器中不会生效）");
    }
}
