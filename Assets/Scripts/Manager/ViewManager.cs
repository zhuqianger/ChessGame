using System;
using System.Collections.Generic;
using Base;
using UnityEngine;

namespace Manager
{
    public class ViewManager : MonoBehaviour
    {
        private Dictionary<string, WndBase> cacheViewMap = new Dictionary<string, WndBase>();
        private void Start()
        {
            DontDestroyOnLoad(this.gameObject);
            
        }
        
        public void GetView(string viewName)
        {
            
        }

        private void BindScriptToPrefab()
        {
            
        }
        
        
    }
}