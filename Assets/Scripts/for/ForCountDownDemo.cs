using UnityEngine;

//1,2,3,4,5
public class ForCountDownDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //[1]1���� 5���� 1�� ����
        for(int i = 1; i < 6; i++)
        {
            Debug.Log($"���� Countdown : {i} ==================");
        }

        //[2]5���� 1���� 1�� ����
        for (int i = 5; i > 0; i--)
        {
            Debug.Log($"���� Countdown : {i} ==================");
        }

        //[3]i 0���� �����ؼ� 54321�� ���� �� �ֵ���
        /*for (int i = 0; i > -5; i--)
        {
            Debug.Log(i+5);
        }*/

        for (int i = 0; i < 5; i++)
        {
            Debug.Log($"���� Countdown: {5-i}");
        }
    }
}
