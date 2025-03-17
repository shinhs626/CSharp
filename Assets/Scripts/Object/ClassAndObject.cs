using UnityEngine;

//개체(object) : 설계도인 클래스로 부터 하나의 인스턴스(객체, 개체)
//[1] ClassCode 이름의 클래스(class)

public class ClassCode
{
    //Empty
}

public class ClassAndObject : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //[2] ClassCode 클래스의 개체(Object, 인스턴스) 만들기
        ClassCode ObjectCodeOne = new ClassCode();
        Debug.Log(ObjectCodeOne.GetHashCode());

        //[3] ClassCode 클래스의 개체(Object, 인스턴스) 만들기
        ClassCode ObjectCodeSecond = new ClassCode();
        Debug.Log(ObjectCodeSecond.GetHashCode());
    }
}
