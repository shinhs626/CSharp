using UnityEngine;

//대입 연산자를 축약하여 사용
public class ShortcutOperator : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int x = 3;
        x = x + 2;  // x = 5
        Debug.Log("x: " + x);   // 5

        int y = 3;
        //y = y + 2;
        y += 2;     // y = 5
        Debug.Log("y: " + y);   // 5
    }
}
