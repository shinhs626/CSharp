using UnityEngine;
namespace PrivatePublic
{
    public class StaticDemo : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            //PublicPrivate 클래스의 정적 필드, 정적 메서드 사용
            //클래스 이름.정적필드이름, 클래스 이름.정적메서드이름
            PublicPrivate.name = "홍길동";
            Debug.Log(PublicPrivate.name);

            //static(정적) 메서드를 이용해 이름 가져오기
            string sName = PublicPrivate.GetName();
            Debug.Log(sName);

            //접근 (X)
            //PublicPrivate.age = 22; (X) 정적도 아니며 public도 아니기에 접근할 수 없음

            //PublicPrivate의 객체
            PublicPrivate publicPrivate = new PublicPrivate();
            //publicPrivate.age = 22; (X) private이기에 접근할 수 없음
            publicPrivate.SetAge(22);
            int myAge = publicPrivate.GetAge();
            Debug.Log(myAge);


        }
    }
}

