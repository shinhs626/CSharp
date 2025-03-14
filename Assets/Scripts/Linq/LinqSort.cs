using UnityEngine;
using System.Linq;
using System.Collections.Generic;

//sort : 정수
public class LinqSort : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //문자열 배열을 오름차순으로 정렬
        string[] colors = { "Red", "Green", "Blue" };

        //오름차순
        IEnumerable<string> sortedColors = colors.OrderBy(s => s);

        foreach(var i in sortedColors)
        {
            Debug.Log(i);
        }

        //내림차순
        IEnumerable<string> sortedColorsSecond = colors.OrderByDescending(s => s);

        foreach (var i in sortedColorsSecond)
        {
            Debug.Log(i);
        }
    }
}
