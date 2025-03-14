using System.Collections.Generic;
using UnityEngine;

// 제네릭 리스트 : 배열, 제네릭 리스트 비교
public class ListOfInt : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //** 속도가 List<T>보다 빠름
        //[1] 배열 - 정수형 배열 변수 선언하고 요소수 생성
        int[] arrNumbers = new int[2];

        //[1] 배열 초기화
        arrNumbers[0] = 10;
        arrNumbers[1] = 20;

        //[1] 배열 사용
        for (int i = 0; i < arrNumbers.Length; i++)
        {
            Debug.Log(arrNumbers[i]);
        }

        //제네릭 리스트 : List<T> ** 속도가 배열보다 느림
        //[2] int형 전용의 List 인스턴스(객체,개체)생성
        List<int> list = new List<int>();

        //[2] 리스트에 데이터 넣기
        list.Add(1234);
        list.Add(1234);
        
        //[2] 리스트 사용
        for (int i = 0; i < list.Count; i++)
        {
            Debug.Log(list[i]);
        }

        //
    }
}
