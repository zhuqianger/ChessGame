﻿using System;
using UnityEngine;

namespace Manager
{
    public class GridManager : MonoBehaviour
    {
        private void Start()
        {
            DontDestroyOnLoad(this.gameObject);
        }
    }
}