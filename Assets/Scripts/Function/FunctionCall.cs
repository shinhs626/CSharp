using UnityEngine;

public class FunctionCall : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //[2] �Լ� ȣ���ϱ�
        for(int i = 0; i < 3; i++)
        {
            Hello();
        }
    }
    //[1]�Լ� �����(����,����(
    void Hello()
    {
        Debug.Log("�ȳ��ϼ���");
    }
}
