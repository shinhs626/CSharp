using UnityEngine;

public class StringPractice : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int numberThree = 3;    //int�� ���� numberThree�� 3�� �ʱ�ȭ
        string result = "Ȧ��";

        Debug.Log($"{numberThree}��(��) {result}�Դϴ�.");

        numberThree = 4;
        result = "¦��";
        Debug.Log($"{numberThree}��(��) {result}�����ϴ�.");
    }
}

/*
[Q]
3, Ȧ���� ���� �����ϰ� �ʱ�ȭ�Ѵ�
���ڿ� �������� �̿��ؼ� ����� ������ ���


*/