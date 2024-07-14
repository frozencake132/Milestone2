using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerCollision : MonoBehaviour
{
    public UnityEvent coinCollect;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Coin")
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
