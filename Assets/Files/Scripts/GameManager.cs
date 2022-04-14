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
    private float omTemp = 0;
    public void Calculate()
    {
        
        float i = U / OM.result;
        float fA = m.result * g;
        H.ChangeResult(fA.ToString());
        float B = fA / i * L;
        this.B.ChangeResult(B.ToString());

        if(OM.result != omTemp)
        {
            switch (OM.result)
            {
                case 2:
                    {
                        leftObject.transform.position = new Vector3(leftObject.transform.position.x, 0.978f, leftObject.transform.position.z);
                        rightObject.transform.position = new Vector3(rightObject.transform.position.x, 1f, rightObject.transform.position.z);
                        omTemp = OM.result;
                    }
                    break;
                case 3:
                    {
                        leftObject.transform.position = new Vector3(leftObject.transform.position.x, 0.98f, leftObject.transform.position.z);
                        rightObject.transform.position = new Vector3(rightObject.transform.position.x, 1.002f, rightObject.transform.position.z);
                        omTemp = OM.result;
                    }
                    break;
                case 4:
                    {
                        leftObject.transform.position = new Vector3(leftObject.transform.position.x, 0.982f, leftObject.transform.position.z);
                        rightObject.transform.position = new Vector3(rightObject.transform.position.x, 1.004f, rightObject.transform.position.z);
                        omTemp = OM.result;
                    }
                    break;
                case 5:
                    {
                        leftObject.transform.position = new Vector3(leftObject.transform.position.x, 0.984f, leftObject.transform.position.z);
                        rightObject.transform.position = new Vector3(rightObject.transform.position.x, 1.006f, rightObject.transform.position.z);
                        omTemp = OM.result;
                    }
                    break;
                case 6:
                    {
                        leftObject.transform.position = new Vector3(leftObject.transform.position.x, 0.986f, leftObject.transform.position.z);
                        rightObject.transform.position = new Vector3(rightObject.transform.position.x, 1.008f, rightObject.transform.position.z);
                        omTemp = OM.result;
                    }
                    break;
                case 7:
                    {
                        leftObject.transform.position = new Vector3(leftObject.transform.position.x, 0.988f, leftObject.transform.position.z);
                        rightObject.transform.position = new Vector3(rightObject.transform.position.x, 1.01f, rightObject.transform.position.z);
                        omTemp = OM.result;
                    }
                    break;
                case 8:
                    {
                        leftObject.transform.position = new Vector3(leftObject.transform.position.x, 0.99f, leftObject.transform.position.z);
                        rightObject.transform.position = new Vector3(rightObject.transform.position.x, 1.012f, rightObject.transform.position.z);
                        omTemp = OM.result;
                    }
                    break;
            }
            m.result = 1;
            m.ChangeResult("1 ã");

        }    
        

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
