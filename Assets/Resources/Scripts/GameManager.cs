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
    [SerializeField]
    private GameObject leftObject;
    private float mTemp = 0;
    public void Calculate()
    {
        
        float i = U / OM.result;
        float fA = m.result * g;
        H.ChangeResult(fA.ToString());
        float B = fA / i * L;
        this.B.ChangeResult(B.ToString());
        if(m.result > mTemp)
        {
            mTemp = m.result;
            rightObject.transform.position = new Vector3(6.51966f, rightObject.transform.position.y + 0.01f, -0.01576018f);
            leftObject.transform.position = new Vector3(9.924839f, leftObject.transform.position.y - 0.01f, -15.49707f);

        }
        else if (m.result < mTemp)
        {
            mTemp = m.result;
            rightObject.transform.position = new Vector3(6.51966f, rightObject.transform.position.y - 0.01f, -0.01576018f);
            leftObject.transform.position = new Vector3(9.924839f, leftObject.transform.position.y + 0.01f, -15.49707f);

        }
    }
}
