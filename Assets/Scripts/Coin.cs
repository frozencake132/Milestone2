using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Coin : MonoBehaviour
{
    public UnityEvent coinCollect;

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Player") 
        {
            print("FireCoinCollect");
            coinCollect.Invoke();
            Destroy(gameObject);
        }
    }

    public void TestMethod()
    {
        print("FireCoinCollect");
    }
}
