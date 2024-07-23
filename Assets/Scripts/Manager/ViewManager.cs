using System;
using System.Collections.Generic;
using Base;
using Define;
using UnityEngine;

namespace Manager
{
    public class ViewManager : MonoBehaviour
    {
        private Dictionary<string, MonoBehaviour> cacheViewMap = new Dictionary<string, MonoBehaviour>();
        public static ViewManager instance;

        [SerializeField]
        public GameObject middle;
        
        [SerializeField]
        public GameObject top;
        
        private void Start()
        {
            DontDestroyOnLoad(this.gameObject);
            instance = this;
            instance.GetView("WndLogin");
            instance.GetView("WndCreateRole");
        }
        
        public MonoBehaviour GetView(string viewName)
        {
            if (instance.cacheViewMap.TryGetValue(viewName, out var view))
            {
                return view;
            }
            Type monoBehaviourType = Type.GetType(ViewDefine.viewMap[viewName]);
            if (monoBehaviourType != null && typeof(MonoBehaviour).IsAssignableFrom(monoBehaviourType))
            {
                GameObject prefab = Resources.Load<GameObject>("Prefab/" + viewName);
                if (prefab != null)
                {
                    GameObject instance = Instantiate(prefab, middle.transform);
                    instance.name = viewName;
                    instance.AddComponent(monoBehaviourType);
                }
            }
            instance.cacheViewMap[viewName] = instance.GetComponent<MonoBehaviour>();
            return instance.cacheViewMap[viewName];
        }
    }
}