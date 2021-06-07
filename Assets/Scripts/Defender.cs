using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Defender : MonoBehaviour
{
    [SerializeField] int coinCost = 100;

    public void AddCoins(int amount)
    {
        FindObjectOfType<CoinDisplay>().AddCoins(amount);
    }
    public int GetCoinsCost()
    {
        return coinCost;
    }
}
