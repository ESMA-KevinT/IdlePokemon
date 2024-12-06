using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class MoneyManager : MonoBehaviour
{
    [SerializeField]
    private int _money;
    [SerializeField]
    private TextMeshProUGUI moneyText;

    public void ChangeMoney(int newMoney)
    {
        _money = newMoney;
        moneyText.text = _money.ToString();
    }

    public void RiseMoney()
    {
        ChangeMoney(_money + 1);
    }
}
