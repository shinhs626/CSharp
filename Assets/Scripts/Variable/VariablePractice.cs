using UnityEngine;

public class VariablePractice : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int first, second, third;

        first = 10;
        second = 20;
        third = 30;

        Debug.Log("first : " +  first);
        Debug.Log("second : " + second);
        Debug.Log("third : " + third);
    }
}
/*
 [Q]
���� : first, second, third �����ϰ� �� �����Ͽ� �Ʒ����� ���

[output]
10,20,30
*/