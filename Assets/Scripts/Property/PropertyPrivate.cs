using UnityEngine;

namespace Property
{
    public class PropertyPrivate : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            //Page 클래스의 인스턴스 생성
            Page page = new Page();
            //page.Message = "외부에서 쓰기 불가능"; //set이 private이기에
            Debug.Log(page.Message);

            User user = new User("홍길동");
            user.BirthYear = 2002;
            Debug.Log(user.Age);


            //Debug.Log(user.Player); //get이 private이기에
            user.Player = "도깨비";
        }
    }

}
