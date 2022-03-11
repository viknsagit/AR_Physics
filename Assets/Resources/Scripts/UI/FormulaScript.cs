using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FormulaScript : MonoBehaviour
{
    [SerializeField]
    private Text resultText;
    [SerializeField]
    private int minNumber;
    [SerializeField]
    private int maxNumber;
    [SerializeField]
    public int result;
    [SerializeField,Tooltip("Единица измерения")]
    private string unit;
    [SerializeField]
    private Button upButton;
    [SerializeField]
    private Button downButton;
    [SerializeField]
    private bool showButtons = true;

    private void Start()
    {
        if(!showButtons)
        {
            upButton.gameObject.SetActive(false);
            downButton.gameObject.SetActive(false);
        }
        result++;
        resultText.text = $"{result} {unit}";
    }

    public void OnUpButtonClick()
    {
        if (result >= maxNumber)
        {
            result = maxNumber;
            resultText.text = $"{result} {unit}";
        }
        else
        {
            result++;
            resultText.text = $"{result} {unit}";
        }
    }
    public void OnDownButtonClick()
    {
        if (result <= minNumber)
        {
            result = minNumber;
            resultText.text = $"{result} {unit}";
        }
        else
        {
            result--;
            resultText.text = $"{result} {unit}";
        }
    }

    

}
