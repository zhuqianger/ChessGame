using System;
using System.Collections.Generic;
using MVC.CreateRole;
using MVC.Login;
using Unity.Collections;
using UnityEngine;

namespace Define
{
    public static class ViewDefine
    {
        public static Dictionary<string, string> viewMap = new Dictionary<string, string>()
        {
            {"WndLogin","MVC.Login.WndLogin"},
            {"WndCreateRole","MVC.CreateRole.WndCreateRole"},
            {"WndMainUI","MVC.MainUI.WndMainUI"}
        };
    }
}