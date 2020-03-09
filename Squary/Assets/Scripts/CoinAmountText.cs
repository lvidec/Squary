using UnityEngine;
using UnityEngine.UI;

public class CoinAmountText : MonoBehaviour
{
    public Text CoinText;

    // Update is called once per frame
    void Update()
    {
        CoinText.text = ShopController.coinAmount.ToString("0");
    }
}
