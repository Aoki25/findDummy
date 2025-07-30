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
        SceneManager.LoadScene("SelectLevel");  // ���ֱ����볡���ļ�һ��
    }

    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("�˳���Ϸ���༭���в�����Ч��");
    }
}
