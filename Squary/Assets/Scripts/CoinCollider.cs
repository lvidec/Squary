using UnityEngine;

public class CoinCollider : MonoBehaviour
{

    public void OnTriggerEnter2D(Collider2D collision)
    {

        if(gameObject.tag == "Money")
        {
            ShopController.coinAmount++;
            Destroy(gameObject);
        }
    }



}
