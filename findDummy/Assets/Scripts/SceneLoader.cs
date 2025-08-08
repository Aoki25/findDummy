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
    public void LoadLevel()
    {
        SceneManager.LoadScene("Level");  // ���ֱ����볡���ļ�һ��
    }
    public void ReturnToHome()
    {
        SceneManager.LoadScene("home"); // ��ȷ���������͹���������һ��
    }
    public void ReturnToSelectLevel()
    {
        SceneManager.LoadScene("SelectLevel"); // ��ȷ���������͹���������һ��
    }  
    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("�˳���Ϸ���༭���в�����Ч��");
    }
}
