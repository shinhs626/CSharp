using UnityEngine;

public class FunctionMaxMin : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int MaxResult = GetMax(3, 5);
        Debug.Log($"3과 5중 큰 수는 {MaxResult}입니다");

        int MinResult = GetMin(-3, -5);
        Debug.Log($"-3과 -5중 작은 수는 {MinResult}입니다");

    }

    int GetMax(int x, int y)
    {
        /*int MaxValue;
        if(x > y)
        {
            MaxValue = x;
        }
        else
        {
            MaxValue = y;
        }
        return MaxValue;*/

        //3항 연산자
        int MaxValue = (x > y) ? x : y;
        return MaxValue;
    }
    int GetMin(int x, int y)
    {
        /*int MinValue;
        if (x > y)
        {
            MinValue = y;
        }
        else
        {
            MinValue = x;
        }
        return MinValue;*/

        int MinValue = (x < y) ? x : y;
        return MinValue;
    }
}
/*
[Q]
1. 매개변수로 입력 받은 두 개의 정수 중 큰수를 반환하는 함수
2. 매개변수로 입력 받은 두개의 정수중 작은 수를 반환하는 함수
3. 3, 5를 입력받아 큰 수를 출력하기
4. -3, -5를 입력받아 작은 수를 출력하기

[output]
3과 5중 큰 수는 (반환값)입니다
-3과 -5중 작은 수는 (반환값)입니다
*/