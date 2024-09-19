using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Intento_Singleton.Instance.ReturnObjectToPool(this.gameObject);
        Destroy(this.gameObject);
    }
}
