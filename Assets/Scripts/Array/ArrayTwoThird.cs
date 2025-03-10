using UnityEngine;

//가변형 배열: 배열의 길이가 가변이다
public class ArrayTwoThird : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //[1] 2차원 배열 선언 : 첫 번째 요소수(크기)만 생성
        int[][] intArray = new int[2][];

        //[2,3] 2차원 배열 두 번째 요소수(크기) 각각 따로 생성, 초기화
        intArray[0] = new int[3] { 1, 2, 3 };
        intArray[1] = new int[2] { 4, 5 };

        //[4] 2차원 배열 사용하기
        //Debug.Log(intArray.Length);

        for(int i = 0; i < intArray.Length; i++)
        {
            for(int j = 0; j < intArray[i].Length; j++)
            {
                Debug.Log(intArray[i][j]);
            }
        }
    }
}
