using UnityEngine;

public class StepLoader : MonoBehaviour
{
    public GameObject levelPrefab;  // ���� LevelPrefab Ԥ����
    private GameObject loadedLevel;
    private int currentStepIndex = 0;
    private Transform[] steps;

    void Start()
    {
        // �ҵ������е� Canvas ����
        Transform canvasTransform = GameObject.Find("Canvas").transform;

        // ʵ���� LevelPrefab��������Ϊ Canvas ��������
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
