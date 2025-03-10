using UnityEngine;

public class ArrayTwoSecond : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //2차원 배열 선언, 요소수 생성, 초기화
        //int[,] intArray = new int[2, 3] {{1,2,3}, {4,5,6}};
        //2차원 배열 선언, 요소수 생성, 초기화
        //int[,] intArray = new int[,] {{1,2,3}, {4,5,6}};

        int[,] intArray = { { 1,2,3}, {4,5,6 } };

        //배열의 길이
        //Debug.Log(intArray.Length);

        //출력

        for (int i = 0;  i < intArray.GetLength(0); i++)
        {
            for (int j = 0; j < intArray.GetLength(1); j++)
            {
                Debug.Log(intArray[i, j]);
            }
        }
    }
}
