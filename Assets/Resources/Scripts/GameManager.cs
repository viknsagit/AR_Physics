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
    [SerializeField]
    private GameObject rightObject;

    public void Calculate()
    {
        float i = U / OM.result;
        float fA = m.result * g;
        H.ChangeResult(fA.ToString());
        float B = fA / i * L;
        this.B.ChangeResult(B.ToString());
        Debug.Log(B.ToString());
        rightObject.transform.position = new Vector3(6.51966f, Mathf.Clamp(-m.result/15, -1.53f, -1.136053f), -0.01576018f);
        Debug.Log(Mathf.Clamp(-m.result/15, -1.53f, -1.136053f));

    }
}
