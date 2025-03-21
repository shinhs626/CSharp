using UnityEngine;

namespace InheritanceF
{
    public class Parent
    {
        public string Word
        {
            get;
            set;
        }
        //생성자
        public Parent(string word)
        {
            this.Word = word;
        }
    }

}
