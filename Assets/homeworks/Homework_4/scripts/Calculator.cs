using UnityEngine;
using TMPro;

public class Calculator : MonoBehaviour
{
    [SerializeField] private TMP_InputField aField;
    [SerializeField] private TMP_InputField bField;
    [SerializeField] private TMP_Text errorWindow;
    [SerializeField] private TMP_Text result;

    private void OnEnable()
    {
        ResetFields();
    }

    public void Operation(string opera)
    { 
        if (aField.text != "" & bField.text !="")
        {
            var a = float.Parse(aField.text);
            var b = float.Parse(bField.text);

            if (opera == "+") { result.text = (a + b).ToString(); }
            else if (opera == "-") { result.text = (a - b).ToString(); }
            else if (opera == "*") { result.text = (a * b).ToString(); }
            else if (opera == "/") { result.text = (a / b).ToString(); }

            errorWindow.text = string.Empty;
        }
        else { errorWindow.text = "¬ведите корректные значени€!"; }

    }

    private void ResetFields()
    {
        aField.text = string.Empty;
        bField.text = string.Empty;
        result.text = string.Empty;
        errorWindow.text = string.Empty;
    }

}
