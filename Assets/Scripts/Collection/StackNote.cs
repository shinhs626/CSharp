using UnityEngine;
using System.Collections;

public class StackNote : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //[1] Stack 클래스의 인스턴스(인스턴스,객체) 생성
        Stack stack = new Stack();

        //[2] Push로 데이터 저장
        stack.Push("대한민국");
        stack.Push("만세");
        stack.Push("경기도");

        //[3] 스택의 제일 상단(마지막)의 데이터를 반환
        Debug.Log($"{stack.Peek()}{stack.Count}");

        //[4] Pop() 스택에서 데이터 꺼내기
        stack.Pop();

        //[5] 스택의 제일 상단(마지막)의 데이터를 반환
        Debug.Log($"{stack.Peek()}{stack.Count}");

        if(stack.Count > 0)
        {
            //[6] 0보다 클때만 Pop() 스택에서 데이터 꺼내기
            stack.Pop();
        }

        //[7] 스택의 제일 상단(마지막)의 데이터를 반환
        stack.Clear();
    }
}
