using UnityEngine;
using TMPro;

public class Comparator : MonoBehaviour
{
    [SerializeField] private TMP_InputField aField;
    [SerializeField] private TMP_InputField bField;
    [SerializeField] private TMP_Text errorWindow;
    [SerializeField] private TMP_Text result;

    private void OnEnable()
    {
        ResetFields();
    }

    public void Compare()
    {
        if (aField.text != "" & bField.text != "")
        {
            var a = float.Parse(aField.text);
            var b = float.Parse(bField.text);

            if (a == b) { result.text = "="; }
            else if (a > b) { result.text = aField.text; }
            else if (a < b) { result.text = bField.text; }
            errorWindow.text = string.Empty;
        }
        else
        {
            errorWindow.text = "¬ведите корректные значени€!";
        }
    }
    private void ResetFields()
    {
        aField.text = string.Empty;
        bField.text = string.Empty;
        result.text = string.Empty;
        errorWindow.text = string.Empty;
    }

}
