using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class Intento_Singleton : MonoBehaviour
{
    private static Intento_Singleton instance;
    public static Intento_Singleton Instance
    {
        get
        {
            if (instance == null)
                instance = GameObject.FindObjectOfType<Intento_Singleton>();
            return instance;
        }
    }

    public void SpawnCoin()
    {
        EventManager.m_Instance.InvokeEvent<SpawnCoin>(new SpawnCoin));
    } 
}
