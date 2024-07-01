using UnityEngine;

namespace Manager
{
    public class ViewManager : MonoBehaviour
    {
        private void Start()
        {
            DontDestroyOnLoad(this.gameObject);
        }
    }
}