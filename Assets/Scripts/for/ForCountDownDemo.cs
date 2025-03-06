using UnityEngine;

//1,2,3,4,5
public class ForCountDownDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //[1]1부터 5까지 1씩 증가
        for(int i = 1; i < 6; i++)
        {
            Debug.Log($"증가 Countdown : {i} ==================");
        }

        //[2]5부터 1까지 1씩 감소
        for (int i = 5; i > 0; i--)
        {
            Debug.Log($"감소 Countdown : {i} ==================");
        }

        //[3]i 0부터 시작해서 54321이 나올 수 있도록
        /*for (int i = 0; i > -5; i--)
        {
            Debug.Log(i+5);
        }*/

        for (int i = 0; i < 5; i++)
        {
            Debug.Log($"감소 Countdown: {5-i}");
        }
    }
}
