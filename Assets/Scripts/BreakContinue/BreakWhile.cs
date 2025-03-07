using UnityEngine;


//구한 합이 22이상이 되면 더이상 합을 구하지 않는다
//while문 사용
public class BreakWhile : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int n = 10;
        int sum = 0;
        int goal = 22;

        int i = 0;

        while(i < n)
        {
            sum = sum + i;

            if (sum >= goal)
            {
                break;
            }
            i++;
        }
        Debug.Log($"{sum}");
    }
}
