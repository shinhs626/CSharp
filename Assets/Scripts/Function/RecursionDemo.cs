using UnityEngine;

//팩토리얼 구하는 알고리즘(4!)

public class RecursionDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //4! = 1 * 2 * 3 * 4
        Debug.Log(4 * 3 * 2 * 1);

        //For Factorial
        Debug.Log(FactorialFor(4));

        Debug.Log(Factorial(8));

        Debug.Log(Factor(4));
    }

    //3항 연산자를 이용한 Factorial 만들기
    int Factor(int n)
    {
        //if (n <= 1) return 1;
        //return n * Factor(n - 1);

        return (n > 1) ? n * Factor(n - 1) : 1;
    }

    //For문 이용 Factorial 값 구하기
    int FactorialFor(int n)
    {
        int result = 1;

        if (n < 0)
        {
            // 음수에 대한 팩토리얼은 정의되지 않으므로 오류 값 반환
            // 실제 사용 시에는 오류 처리를 추가하는 것이 좋습니다
            return -1; // 또는 에러 코드
        }
        else if (n == 0)
        {
            // 0! = 1
            return 1;
        }
        else
        {
            // 양수에 대한 팩토리얼 계산
            for (int i = 1; i <= n; i++)
            {
                result = result * i;
            }
            return result;
        }
    }

    //재귀함수 이용한 Factorial 값 구하기
    int Factorial(int n)
    {
        if(n == 1 || n == 0)
        {
            return 1;
        }
        else
        {
            return n * Factorial(n - 1);
        }
            
    }
}

/*
재귀함수 : 함수가 자신의 코드 블록 안에서 자기 자신을 다시 호출(재귀 호출)하는 함수
-재귀함수 매개 변수: 매개 변수는 감산, 가산이 된다
-재귀함수 코드 블록안에는 재귀함수를 종료 할 수 있는 조건이 필요하다

*/