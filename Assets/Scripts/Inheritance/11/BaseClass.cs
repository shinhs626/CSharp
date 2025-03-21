using UnityEngine;

namespace InheritanceL
{
    //부모 클래스
    public class BaseClass
    {
        //필드 선언 - 기본적으로 private 으로 설정
        private string word;

        //속성 - 상속받은 자식클래스에서만 접근 가능
        protected string Word
        {
            get { return word; }
            set { word = value; }
        }
    }

    //자식 클래스
    public class SubClass : BaseClass
    {
        public void SetWord(string word)
        {
            base.Word = word;
        }
        public string GetWord()
        {
            return base.Word;
        }
    }
}
