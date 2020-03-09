using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShopController : MonoBehaviour
{

    public static int coinAmount;
    public bool CapIsSold = false;

    public Button buyButton;

    public void BuyCap()
    {
        if( coinAmount >= 5 && CapIsSold == false )
        {
            coinAmount -= 5;
            buyButton.gameObject.SetActive(false);
            CapIsSold = true;
        }
    }

    
}
