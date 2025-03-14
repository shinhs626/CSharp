using UnityEngine;
using System.Collections;

//HashTable : 정수 형식, 문자열 형식의 인덱스를 사용하여 데이터(값)들을 저장, 관리하는 클래스
// [0], [1], [2], ["문자열"], ["이름"]
public class HashTableDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //[1] HashTable 클래스의 인스턴스(객체,개체)를 생성
        Hashtable hash = new Hashtable();

        //[2] 데이터 넣기 : 인덱스 사용
        hash[0] = "대한민국";
        hash["도"] = "경기도";
        hash["대륙"] = "아시아";

        //[3] 데이터 사용
        /*for (int i = 0; i < hash.Count; i++)
        {
            Debug.Log(hash[i]);
            Debug.Log(hash["도"]);
            Debug.Log(hash["대륙"]);
        }*/

        foreach(var i in hash.Keys)
        {
            Debug.Log(hash[i]);
        }
    }
}
