using UnityEngine;

//OrOperator(Or ������) : || �� �� �ϳ��� ���̸� ��
//��� : true, false
public class OrOperator : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //[1] �� �� ���̸� ��
        Debug.Log(true || true); //True
        
        //[2] �� �߿� �ϳ��� ���̸� ��
        Debug.Log(true || false); //True
        Debug.Log(false || true); //True

        //[3] �� �� �����̸� ����
        Debug.Log(false || false); //False
    }
}
