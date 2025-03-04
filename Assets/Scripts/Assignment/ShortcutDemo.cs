using UnityEngine;
// +=, -=, *=, /=, %= 등의 연산자를 사용하여 대입 연산자를 축약할 수 있습니다.
public class ShortcutDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int a = 3;
        int b = 5;

        //b변수에 a 변수의 값을 누적하라
        //b = b + a;
        b += a;
        Debug.Log("b: " + b);// 8

        //b변수에 a변수의 값을 감산하라
        b -= a;
        Debug.Log("b: " + b);// 5
    }
}
