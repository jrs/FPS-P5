using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public TextMeshProUGUI targetText;
    private int _targetAmount;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        int floatingTarget = GameObject.FindGameObjectsWithTag("TargetFloating").Length;
        int standingTarget = GameObject.FindGameObjectsWithTag("TargetStanding").Length;
        _targetAmount = floatingTarget + standingTarget;
        targetText.text = "Targets: " + _targetAmount.ToString();
    }

    public void UpdateTargetAmount()
    {
        _targetAmount -= 1;
        targetText.text = "Targets: " + _targetAmount.ToString();

        if(_targetAmount <= 0)
        {
            //stop the timer
            GameObject.Find("Game Manager").GetComponent<Timer>().EndGameTimer();
        }
    }
}
