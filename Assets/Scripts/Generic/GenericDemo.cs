using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class GenericDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //[1] 제네릭 사용 전
        Stack st1 = new Stack();
        st1.Push(1234);
        int number1 = (int)st1.Pop();   //object로 반환시키기 때문에 int형(정수형)으로 바꿔주는 귀찮은 코드를 작성해야함 => 언박싱
        Debug.Log(number1);

        //[2] 제네릭 사용 후
        Stack<int> st2 = new Stack<int>();
        st2.Push(1234);
        int number2 = st2.Pop();        //처음에 int형(정수형)으로 지정해줘서 반환할 때도 int형으로 반환해주어 꺼낼때 타입변환을 주지 않아도 됨
        Debug.Log(number2);

        //[3] 제네릭의 장점 : 형식의 안정성, 성능 향상
        Stack o = new Stack();
        o.Push(1234);
        o.Push("Hello");
        Debug.Log(o.Pop());
        Debug.Log(o.Pop());

        Stack<int> i = new Stack<int>();
        i.Push(12345);
        i.Push(67890);
        //i.Push("number")  //int만 처리 가능
        Debug.Log(i.Pop());
        Debug.Log(i.Pop());

        //성능, 최적화
        Stack stack = new Stack();
        stack.Push(1234);   //1234(값형) - object(참조형) 저장 : 박싱
        int iStack = (int)stack.Pop();  //object(참조형) -> 1234(값형) : 언박싱
        Debug.Log(iStack);
    }
}
