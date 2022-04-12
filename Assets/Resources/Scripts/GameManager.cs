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
            rightObject.transform.position = new Vector3(rightObject.transform.position.x, rightObject.transform.position.y + 0.001f, rightObject.transform.position.z);
            leftObject.transform.position = new Vector3(leftObject.transform.position.x, leftObject.transform.position.y - 0.001f, leftObject.transform.position.z);

        }
        else if (m.result < mTemp)
        {
            mTemp = m.result;
            rightObject.transform.position = new Vector3(rightObject.transform.position.x, rightObject.transform.position.y - 0.001f, rightObject.transform.position.z);
            leftObject.transform.position = new Vector3(leftObject.transform.position.x, leftObject.transform.position.y + 0.001f, leftObject.transform.position.z);
        }
    }
}
