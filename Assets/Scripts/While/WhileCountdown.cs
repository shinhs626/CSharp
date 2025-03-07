using UnityEngine;

//1부터 5까지 출력
//5부터 1까지 출력
public class WhileCountdown : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //[1]
        int i = 0;

        while (i < 5)
        {
            Debug.Log($"CountDown : {i + 1}");
            i++;
        }
        Debug.Log("----------------");
        int l = 0;

        while(l < 5)
        {
            Debug.Log($"CountDown : {5 - l}");
            l++;
        }
    }
}
