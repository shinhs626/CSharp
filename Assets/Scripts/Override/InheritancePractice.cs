using UnityEngine;

namespace Override
{
    public class InheritancePractice : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            //HyunDai
            HyunDai hd = new HyunDai();
            hd.Back();
            hd.Go();
            hd.Left();

            HyunDai hdE = new HyunDai(CarType.전기);
            Debug.Log($"{hdE.Style}");

            //Tesla
            Tesla ts = new Tesla();
            ts.Back();
            ts.Go();
            ts.Left();

            //Mirae
            Mirae mr = new Mirae();
            mr.Back();
            mr.Go();
            mr.Left();
        }
    }

}
