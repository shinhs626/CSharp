using UnityEngine;

public class Else : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int score = 61;//[1]

        if (score >= 60)//���ǽ��� ���� �� ���๮1(��ɹ�)�� ����
        {
            Debug.Log("�հ��Դϴ�.");//[2]
        }
        else//���ǽ��� ������ �� ���๮2(��ɹ�)�� ����
        {
            Debug.Log("���հ��Դϴ�.");//[3]
        }
        Debug.Log("������ �������ϴ�.");//[4]

    }

    //score = 59; : [1] -> [3] -> [4]
    //score = 60; : [1] -> [2] -> [4]

}
