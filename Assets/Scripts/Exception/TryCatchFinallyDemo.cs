using UnityEngine;

public class TryCatchFinallyDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()    
    {
        int x = 5;
        int y = 5;
        int result = 0;

        try         //���ܰ� �߻��� ���ɼ��� �ִ� ��ɹ�
        {
            //[1]
            result = x / y;
            Debug.Log($"{x} / {y} = {result}");
        }
        catch       //try ������ ���ܰ� �߻��ϸ� catch���� ��
        {
            //[2]
            Debug.Log("���ܰ� �߻��߽��ϴ�.");
        }
        finally     //���ܰ� �߻� �ϵ� ���� �������� ����
        {
            //[3]
            Debug.Log("���α׷��� �����ϰڽ��ϴ�");
        }
    }
}
