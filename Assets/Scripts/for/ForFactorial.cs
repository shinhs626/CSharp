using UnityEngine;

//4! 값을 구하는 프로그램
public class ForFactorial : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int n = 10;
        int fact = 1;

        for(int i = 1; i < n+1; i++)
        {
            fact = fact*i;
        }
        Debug.Log($"4!의 합은 {fact}입니다");
    }
}

/*
Fatorial(!)
1! = 1
2! = 2
3! = 6
4! = 24
5! = 120
6! = 720
.......
n! = 1 * 2 * 3 *.........* (n-1) * n


*/