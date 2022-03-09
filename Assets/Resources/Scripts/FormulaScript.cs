using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FormulaScript : MonoBehaviour
{
    [SerializeField]
    private Text resultText;
    [SerializeField]
    private int result;
    [SerializeField,Tooltip("Единица измерения")]
    private string unit;
    [SerializeField]
    private Button upButton;
    [SerializeField]
    private Button downButton;

    private void Start()
    {
        result++;
        resultText.text = $"{result} {unit}";
    }

    public void OnUpButtonClick()
    {
        result++;
        resultText.text = $"{result} {unit}";
    }
    public void OnDownButtonClick()
    {
        result--;
        resultText.text = $"{result} {unit}";
    }

}
