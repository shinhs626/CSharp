using UnityEngine;

public class ArrayString : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //[1-1]
        //string[] stringArray = new string[4] { "대", "한","민","국" };
        //[1-2]
        //string[] stringArray = new string[] { "대", "한","민","국" };
        //[1-3]
        //string[] stringArray = { "대", "한", "민", "국", "만", "세" };

        //문자열은 문자로 된 열 이기 때문에 문자로 된 배열임
        string arr = "C#8";

        Debug.Log(arr.Length);

        Debug.Log(arr[0]);
        Debug.Log(arr[1]);
        Debug.Log(arr[2]);

    }
}
