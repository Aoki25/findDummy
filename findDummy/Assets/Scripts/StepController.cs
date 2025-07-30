using UnityEngine;

public class StepController : MonoBehaviour
{
    public GameObject[] steps;  // ���в�����棨��˳��
    private int currentStepIndex = 0;

    void Start()
    {
        ShowOnlyCurrentStep(); // ��ʼֻ��ʾ��һ��
    }

    public void ShowNextStep()
    {
        // ���ص�ǰ
        steps[currentStepIndex].SetActive(false);

        currentStepIndex++;

        // ����Ƿ�����һ��
        if (currentStepIndex < steps.Length)
        {
            steps[currentStepIndex].SetActive(true);
        }
        else
        {
            Debug.Log("�Ѿ������һ�������ˣ�");
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
