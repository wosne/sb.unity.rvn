using System.Collections;
using UnityEngine;
using TMPro;

public class Burglar : MonoBehaviour
{
    private bool timerStopped;
    private bool win;

    [SerializeField] private GameObject endGameWindow;
    [SerializeField] private TMP_Text endGameText;
    [SerializeField] private TMP_Text timerText;
    private int seconds;

    [SerializeField] private TMP_Text pinOneText;
    [SerializeField] private TMP_Text pinTwoText;
    [SerializeField] private TMP_Text pinThreeText;
    private int pinOne;
    private int pinTwo;
    private int pinThree;

    private void Start() { StartGame(); }



    // start game
    public void StartGame()
    {
        win = false;
        endGameWindow.SetActive(false);

        StartTimer(); ResetPins();
    }



    // pins
    public void PinsChanger(Tool tool)
    {
        pinOne = PinValueSetter(pinOne, tool.firstPin);
        pinTwo = PinValueSetter(pinTwo, tool.secondPin);
        pinThree = PinValueSetter(pinThree, tool.thirdPin);

        RefreshPins(); PinsWinsChecker();
    }

    private int PinValueSetter(int pin, int value)
    {
        pin += value;
        if (pin < 0) { pin = 0; }
        else if (pin > 10) { pin = 10; }

        return pin;
    }

    private void ResetPins()
    {
        var rand = Random.Range(0, 10);
        pinOne = 0; pinTwo = rand; pinThree = 10;
        RefreshPins();
    }

    private void RefreshPins()
    {
        pinOneText.text = pinOne.ToString();
        pinTwoText.text = pinTwo.ToString();
        pinThreeText.text = pinThree.ToString();
    }

    private void PinsWinsChecker()
    {
        if (pinOne == 5)
        {
            if (pinTwo == 5)
            {
                if (pinThree == 5)
                { win = true; EndGame(); }
            }
        }
    }



    // timer
    private void StartTimer()
    {
        win = false; seconds = 30;
        timerStopped = false;
        SecondsRefresher();
        StartCoroutine(TimerDelay());
    }

    private IEnumerator TimerDelay()
    {
        yield return new WaitForSeconds(1);

        if (!timerStopped)
        {
            if (seconds > 0) { seconds--; StartCoroutine(TimerDelay()); }
            else { seconds = 0; }

            SecondsRefresher();
        }
    }

    private void SecondsRefresher()
    {
        timerText.text = seconds.ToString();
        if (seconds == 0) { EndGame(); }
    }



    // end game
    private void EndGame()
    {
        endGameWindow.SetActive(true);
        if (win)
        {
            endGameText.color = Color.green;
            endGameText.text = "Great job!";
            timerStopped = true;
        }
        else
        {
            endGameText.color = Color.red;
            endGameText.text = "Looser!";
        }
    }

}
