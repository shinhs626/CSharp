using UnityEngine;

//LogicalOperator(�� ������) : &&(And), ||(Or), !(Not)
//AndOperator(And ������) : && �� �� ���϶��� ��
//��� : True, False
public class AndOperator : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //[1] �� �� ���� ���� ��    
        Debug.Log(true && true); //True

        //[2] �� �߿� �ϳ��� �����̸� ����
        Debug.Log(true && false); //False
        Debug.Log(false && true); //False

        //[3] �� �� �����̸� ����
        Debug.Log(false && false); //False









    }
}
