using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class ItemManager : MonoBehaviour
{
    private static ItemManager instance;
    public static ItemManager Instance
    {
        get
        {
            if (instance == null)
            {
                instance = GameObject.FindObjectOfType<ItemManager>();
            }
            return instance;
        }
    }

    public void InvokeSpawnItemEvent()
    {
        EventManager.m_Instance.InvokeEvent<SpawnItemEvent>(new SpawnItemEvent());
    }
}
