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
    readonly private float g = 9.8f;
    [SerializeField]
    private float U = 12;
    [SerializeField]
    private float L = 5;

    public void Calculate()
    {
        float i = U / OM.result;
        float fA = m.result * g;
        H.ChangeResult(fA.ToString());
        float B = fA / i * L;
        this.B.ChangeResult(B.ToString());
    }
}
