using UnityEngine;

namespace Indexer
{
    public class Catalog
    {
        //string 인덱서
        public string this[int index]
        {
            get
            {
                return (index % 2 == 0) ? "짝수" : "홀수";
            }
        }
    }
}

