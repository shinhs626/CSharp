using UnityEngine;

//NotOperator(���� ������) : !(Not)���̸� ����, �����̸� ��

public class NotLogical : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //[1] �� �϶�
        Debug.Log(!true); //False

        //[2] ���� �϶�
        Debug.Log(!false); //True

        //[3] ������ ����
        bool bin = false;

        Debug.Log(!bin); //True
        Debug.Log(!!bin);//false
        Debug.Log(!(!(!bin)));//True

    }
}
