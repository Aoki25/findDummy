using UnityEngine;

public class StepLoader : MonoBehaviour
{
    public GameObject levelPrefab;  // 拖入 LevelPrefab 预制体
    private GameObject loadedLevel;
    private int currentStepIndex = 0;
    private Transform[] steps;

    void Start()
    {
        // 找到场景中的 Canvas 物体
        Transform canvasTransform = GameObject.Find("Canvas").transform;

        // 实例化 LevelPrefab，并设置为 Canvas 的子物体
        loadedLevel = Instantiate(levelPrefab, canvasTransform);
    }

    public void ShowNextStep()
    {
        if (currentStepIndex < steps.Length)
        {
            steps[currentStepIndex].gameObject.SetActive(false);
            currentStepIndex++;

            if (currentStepIndex < steps.Length)
            {
                steps[currentStepIndex].gameObject.SetActive(true);
            }
        }
    }
}
