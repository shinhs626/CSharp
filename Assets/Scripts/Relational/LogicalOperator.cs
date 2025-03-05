using UnityEngine;

public class LogicalOperator : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int i = 3;
        int j = 5;
        bool r = false;

        r = (i == 3) && (j != 3); //True
        Debug.Log($"r: {r}"); //True

        r = (i != 3) || (j == 3); //False
        Debug.Log($"r: {r}"); //False

        r = (i >= 5);
        Debug.Log($"!r: {!r}"); //True

        Debug.Log((1 == 1) || (1 != 1));//True

        bool bln1 = true;
        bool bln2 = false;

        Debug.Log(bln1 && bln2); //True && False = False
        Debug.Log(bln1 || bln2); //True || False = True
    }
}
