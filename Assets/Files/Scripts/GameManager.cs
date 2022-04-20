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
    private void Start()
    {
        Calculate();
    }
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
                        GameObjectMoveY(leftObject, 0.978f);
                        GameObjectMoveY(rightObject, 1f);
                        omTemp = OM.result;
                    }
                    break;
                case 3:
                    {
                        GameObjectMoveY(leftObject, 0.98f);
                        GameObjectMoveY(rightObject, 1.002f);
                        omTemp = OM.result;
                    }
                    break;
                case 4:
                    {
                        GameObjectMoveY(leftObject, 0.982f);
                        GameObjectMoveY(rightObject, 1.004f);
                        omTemp = OM.result;
                    }
                    break;
                case 5:
                    {
                        GameObjectMoveY(leftObject, 0.984f);
                        GameObjectMoveY(rightObject, 1.006f);
                        omTemp = OM.result;
                    }
                    break;
                case 6:
                    {
                        GameObjectMoveY(leftObject, 0.986f);
                        GameObjectMoveY(rightObject, 1.008f);
                        omTemp = OM.result;
                    }
                    break;
                case 7:
                    {
                        GameObjectMoveY(leftObject, 0.988f);
                        GameObjectMoveY(rightObject, 1.008f);
                        omTemp = OM.result;
                    }
                    break;
                case 8:
                    {
                        GameObjectMoveY(leftObject, 0.99f);
                        GameObjectMoveY(rightObject, 1.008f);
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
            GameObjectMoveY(leftObject, leftObject.transform.position.y - 0.001f);
            GameObjectMoveY(rightObject, rightObject.transform.position.y + 0.001f);

        }
        else if (m.result < mTemp)
        {
            mTemp = m.result;
            GameObjectMoveY(leftObject, leftObject.transform.position.y + 0.001f);
            GameObjectMoveY(rightObject, rightObject.transform.position.y - 0.001f);
        }
    }

    private void GameObjectMoveY(GameObject objectForMove, float yPos)
    {
        objectForMove.transform.position = new Vector3(leftObject.transform.position.x, yPos, leftObject.transform.position.z);
    }
}
