using UnityEngine;

namespace InheritanceL
{
    public class FieldHiddenDemo : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            SubClass sub = new SubClass();
            sub.SetWord("홍길동");
            Debug.Log(sub.GetWord());
        }
    }

}
