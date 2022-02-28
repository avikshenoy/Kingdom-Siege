using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GoldDisplay : MonoBehaviour
{
    TMP_Text goldText;

    Bank bank;

    void Start()
    {
        goldText = GetComponent<TMP_Text>();
        bank = FindObjectOfType<Bank>();
    }

    void Update()
    {
        DisplayMoney();
    }

    void DisplayMoney()
    {
        goldText.text = "Gold: " + bank.CurrentBalance;
    }
}
