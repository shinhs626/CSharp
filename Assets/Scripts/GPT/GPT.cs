using System;
using UnityEngine;

public class GPT : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // 고정된 숫자들
        int[] numbers = { 5, 3, 6, 8, 9 };

        // 최솟값을 저장할 변수 선언, 초기값은 최대값으로 설정
        int minValue = int.MaxValue;

        // 배열 내의 숫자들을 순차적으로 확인하여 최솟값을 찾음
        foreach (int number in numbers)
        {
            // 현재 숫자가 최솟값보다 작으면 최솟값을 갱신
            if (number < minValue)
            {
                minValue = number;
            }
        }

        // 최솟값 출력
        Debug.Log($"최솟값은 : {minValue}입니다");
    }
}
