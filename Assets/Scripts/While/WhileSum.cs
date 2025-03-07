using UnityEngine;

//while문을 이용해서 1부터 100까지 합을 구하는 프로그램
public class WhileSum : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int i = 0;
        int n = 100;
        int sum = 0;

        while(i < n)
        {
            sum = sum + (i+1);
            i++;
        }
        Debug.Log($"1부터 {n}까지의 합은 {sum}입니다");
    }
}
