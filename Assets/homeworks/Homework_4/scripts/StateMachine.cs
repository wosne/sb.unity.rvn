using UnityEngine;

public class StateMachine : MonoBehaviour
{
    [SerializeField] private GameObject calculatorScreen;
    [SerializeField] private GameObject comparatorScreen;

    private GameObject currentScreen;

    private void Start()
    {
        calculatorScreen.SetActive(true);
        currentScreen = calculatorScreen;
    }

    public void ChangeScreen(GameObject screen)
    {
        if (currentScreen != null)
        {
            if (currentScreen != screen)
            {
                currentScreen.SetActive(false);
                screen.SetActive(true);
                currentScreen = screen;
            }
        }
    }

}
