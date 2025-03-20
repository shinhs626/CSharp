using System;
using UnityEngine;

namespace Property
{
    public class User
    {
        //필드
        private int birthYear; //생년

        //자동 속성
        public string Name { get; set; }

        //쓰기 전용 속성
        public int BirthYear
        {
            set
            {
                if(value >= 1900)
                {
                    birthYear = value;
                }
                else
                {
                    birthYear = 0;
                }
               
            }
        }

        //
        public int Age
        {
            get
            {
                if(birthYear != 0)
                {
                    return (DateTime.Now.Year - birthYear);
                }
                else
                {
                    Debug.Log("생일을 입력해주세요");
                    return 0;
                }
            }
        }

        //생성자 - 매개변수를 받아서 속성 초기화
        public User(string name)
        {
            Name = name;
        }

        public string Player { private get; set; }


    }
}

