using UnityEngine;

public class ArrayPractice : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int[,] intArray = new int[3,3];

        for(int i = 0; i < intArray.GetLength(0); i++)
        {            
            for (int j = 0; j < intArray.GetLength(1); j++)
            {
                if (i == j)
                {
                    intArray[i, j] = 1;
                }
                else
                {
                    intArray[i, j] = 0;
                }
                Debug.Log($"arr[{i},{j}] : {intArray[i, j]}");
            }
        }
    }
}
/*
[Q]
3행 3열의 2차원 배열을 만들고 값을 저장하는데
행과 열의 인덱스가 같으면 1, 행과 열의 인덱스가 틀리면 0으로 저장하세요


*/