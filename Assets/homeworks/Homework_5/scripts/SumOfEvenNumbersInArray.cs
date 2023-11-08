using UnityEngine;

public class SumOfEvenNumbersInArray : MonoBehaviour
{
    /// <summary>
    /// ����� ��������� ������� OnClick ������ "����� ������ ����� � �������� �������"
    /// </summary>
    public void OnSumEvenNumbersInArray()
    {
        int[] array = { 81, 22, 13, 54, 10, 34, 15, 26, 71, 68 };
        int want = 214;
        int got = SumEvenNumbersInArray(array);
        string message = want == got ? "��������� ������" : $"��������� �� ������, ��������� {want}";
        Debug.Log($"����� ������ ����� � �������� �������: {got} - {message}");
    }

    /// <summary>
    /// ����� ��������� ����� ������ ����� � ������� 
    /// </summary>
    /// <param name="array">�������� ������ �����</param>
    /// <returns>����� ����� ������ �����</returns>
    private int SumEvenNumbersInArray(int[] array)
    {
        var got = 0;

        for (int i = 0; i < array.Length; i++)
        { if (array[i] % 2 == 0) { got++; } }

        return got;
    }
}