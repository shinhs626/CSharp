using UnityEngine;

//두수를 입력 받아 그중에서 큰 수를 출력
public class GreaterThanEqual : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int first = 5;
        int second = 8;

        //first와 second를 비교해서 큰 수를 출력

        if (first >= second)
        {
            Debug.Log($"{first}가 더 큰 수 입니다.");
        }
        else
        {
            Debug.Log($"{second}가 더 큰 수 입니다.");
        }
    }
}
