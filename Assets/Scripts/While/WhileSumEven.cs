using UnityEngine;

//while문을 이용해서 1부터 n(100)까지의 정수중에서 짝수의 합을 구하는 프로그램 구현
public class WhileSumEven : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int n = 100;
        int sum = 0;

        int i = 0;

        while(i < n)
        {
            if(i % 2 == 0)
            {
                sum = sum + i;
            }
            i++;
        }

        Debug.Log($"1부터 {n}까지의 정수중에서 짝수의 합은 {sum}입니다");
    }
}
