﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicScript : MonoBehaviour
{
    void Start()
    {
        GameObject[] musicGameObjects = GameObject.FindGameObjectsWithTag("Music");
        if (musicGameObjects.Length > 1)
        {
            Destroy(this.gameObject);
        }
        DontDestroyOnLoad(this.gameObject);
    }
}
