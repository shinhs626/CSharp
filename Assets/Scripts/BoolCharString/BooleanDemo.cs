using UnityEngine;

//bool(��) : ����, ���ڷ���, ��(true) or ����(false) ���� �����Ѵ�
public class BooleanDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //[1] bool ���� �����ϰ� �ʱ�ȭ
        bool bln = true;
        Debug.Log("bln: "+bln);
        Debug.Log($"bln:{bln}");

        bool isOut = false;
        Debug.Log("isOut: " + isOut);
        Debug.Log($"isOut:{isOut}");
    }
}
