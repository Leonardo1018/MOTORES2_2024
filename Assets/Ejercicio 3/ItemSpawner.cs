using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemSpawner : MonoBehaviour
{
    public GameObject itemPrefab;


    void Start()
    {
        EventManager.m_Instance.AddListener<SpawnItemEvent>(SpawnItemEventListener);
    }

    // Update is called once per frame
    private void SpawnItemEventListener( SpawnItemEvent _event)
    {
        Item newItem;
       PoolManager.Instance.SpawnObject<Item>(out newItem, this.transform);
    }
}
