using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class Bank : MonoBehaviour
{
    [SerializeField] int startingBalance = 150;

    [SerializeField] int currentBalance;

    //[SerializeField] TextMeshProUGUI displayBalance;

    public int CurrentBalance { get { return currentBalance; } }

    void Awake()
    {
        currentBalance = startingBalance;

        //DisplayGold();
    }

    public void Deposit(int amount)
    {
        currentBalance += Mathf.Abs(amount);

        //DisplayGold();
    }

    public void Withdraw(int amount)
    {
        currentBalance -= Mathf.Abs(amount);

        //DisplayGold();

        if (currentBalance < 0)
        {
            ReloadScene();
        }
    }
    /*
    void DisplayGold()
    {
        displayBalance.text = "Gold: " + currentBalance;
    }*/

    void ReloadScene()
    {
        Scene currentScene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(currentScene.buildIndex);
    }

}
