using UnityEngine;

//������ ������ ���� 1����
public class DecrementNumber : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //������ ���� num�� �����ϰ� 10���� �ʱ�ȭ
        int num = 10;       // num = 10

        num = num - 1;      // num = 9

        Debug.Log(num);     // 9

    }
}
