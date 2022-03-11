using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public FormulaScript A;
    public FormulaScript OM;
    public FormulaScript H;
    public FormulaScript B;
    public FormulaScript m;
    readonly public float g = 9.8f;

    public float Calculate()
    {
        Debug.Log(A.result);

        return 0;
    }
    private void Start()
    {
        Calculate();
    }
}
