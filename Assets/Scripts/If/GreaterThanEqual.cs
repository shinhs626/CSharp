using UnityEngine;

//�μ��� �Է� �޾� ���߿��� ū ���� ���
public class GreaterThanEqual : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int first = 5;
        int second = 8;

        //first�� second�� ���ؼ� ū ���� ���

        if (first >= second)
        {
            Debug.Log($"{first}�� �� ū �� �Դϴ�.");
        }
        else
        {
            Debug.Log($"{second}�� �� ū �� �Դϴ�.");
        }
    }
}
