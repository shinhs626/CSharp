using UnityEngine;

public class TryCatchDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        try
        {
            int now = System.DateTime.Now.Second;
            Debug.Log(now);

            int result = 2 / (now % 2);
            Debug.Log("홀수 초에서는 정상처리");
        }
        catch
        {
            Debug.Log("짝수 초에서는 오류");
        }
    }
}
