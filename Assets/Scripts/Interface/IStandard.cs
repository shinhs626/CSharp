using UnityEngine;
using System.Collections;

namespace InterfaceTest
{
    public interface IStandard
    {
        void Run();
    }

    //[3] 클래스 : 인스턴스(실체)를 찍어낼 수 있게 만드는 설계도
    public class Car : IStandard
    {
        //[4] 필드 : 멤버변수, 전역변수, private이 기본
        #region Field           //필드 생성
        private string name;    //전역 변수
        private string[] names;
        private readonly int _length;        //읽기 전용
        #endregion

        //[5] 생성자 : 필드(멤버변수) 초기화
        #region Construct
        public Car()
        {
            this.name = "좋은 차";
        }
        public Car(string name)
        {
            this.name = name;
        }
        public Car(int length)
        {
            this.name = "좋은 차";
            this._length = length;       //일기 전용 필드는 생상자 안에서 초기화 가능
            names = new string[length];
        }

        #endregion

        //[6] 메서드
        #region Method
        public void Run()
        {
            Debug.Log("달린다");
        }
        #endregion

        //[7] 속성
        #region Property
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Length
        {
            get { return _length; }
        }
        #endregion

        //[8] 소멸자 : 객체가 소멸될 때 호출
        #region Distruct
        ~Car()
        {
            Debug.Log($"{name}이/가 폐차됨");
        }
        #endregion

        //[9] 인덱서, 이터레이터(반복기)
        #region Indexer
        public string this[int index]
        {
            get { return names[index]; }
            set { names[index] = value; }
        }
        //반복기
        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < _length; i++)
            {
                yield return names[i];
            }
        }
        #endregion

        //[10]대리자
        #region Delegate
        public delegate void EventHandler();

        //이벤트
        public event EventHandler Click;
        public void OnClick()
        {
            if(Click != null)
            {
                Click.Invoke();
            }
        }
        #endregion
    }

}

/*
객체지향 프로그램
*/