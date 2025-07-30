using UnityEngine;

public class StepController : MonoBehaviour
{
    public GameObject[] steps;  // 所有步骤界面（按顺序）
    private int currentStepIndex = 0;

    void Start()
    {
        ShowOnlyCurrentStep(); // 初始只显示第一步
    }

    public void ShowNextStep()
    {
        // 隐藏当前
        steps[currentStepIndex].SetActive(false);

        currentStepIndex++;

        // 检查是否还有下一步
        if (currentStepIndex < steps.Length)
        {
            steps[currentStepIndex].SetActive(true);
        }
        else
        {
            Debug.Log("已经是最后一个步骤了！");
        }
    }

    private void ShowOnlyCurrentStep()
    {
        for (int i = 0; i < steps.Length; i++)
        {
            steps[i].SetActive(i == currentStepIndex);
        }
    }
}
