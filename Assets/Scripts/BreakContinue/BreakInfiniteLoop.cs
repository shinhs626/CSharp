using UnityEngine;

//break�� ���ѷ��� ���� ������
public class BreakInfiniteLoop : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //for�� ���ѷ���
        /*for(; ; )
        {

        }*/

        //while�� ���ѷ��� : ������ ���ֱ�
        /*while (���ǽ�)
        {
            �ݺ� ���๮
        }*/

        //doWhile�� ���ѷ��� : ������ ���ֱ�
        /*do
        {
            �ݺ� ���๮
        }while(���ǽ�);*/

        int number = 0;

        while (true)
        {
            Debug.Log($"{number}");
            number++;
            if(number >= 5)
            {
                break;
            }
        }
    }
}
