using UnityEngine;

//RelationalOperator(���� ������, �� ������)
// < (�۴�), > (ũ��), <= (�۰ų� ����), >= (ũ�ų� ����), == (����), != (���� �ʴ�)
// ���� �����ڴ� �� ���� ���� ���Ͽ� ����� ��(true) �Ǵ� ����(false)�� ��ȯ�ϴ� �������̴�.
public class RelationalOperator : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int x = 3;
        int y = 5;

        Debug.Log(x < y);//True
        Debug.Log(x > y);//False
        Debug.Log(x <= y);//True
        Debug.Log(x >= y);//False
        Debug.Log(x == y);//False
        Debug.Log(x != y);//True

        Debug.Log("AAA" == "aaa");//False
        Debug.Log("AAA" != "aaa");//True
    }
}
