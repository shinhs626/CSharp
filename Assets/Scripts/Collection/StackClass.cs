using System.Collections;
using UnityEngine;

//  Collections : Stack, Queue, ArrayList, Hashtable //�÷��Ǿȿ� �ִ� �͵�
public class StackClass : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //Stack Ŭ������ �ν��Ͻ�(��ü)����
        Stack st = new Stack();

        //���ÿ� ������ �ֱ�: Push
        st.Push("First");
        st.Push("Second");

        //���ÿ��� ������ ������ : Pop
        Debug.Log(st.Pop());
        Debug.Log(st.Pop());
    }
}
