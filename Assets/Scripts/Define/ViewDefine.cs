using System.Collections.Generic;
using Unity.Collections;

namespace Define
{
    public class ViewDefine
    {
        public static Dictionary<string, string> viewMap = new Dictionary<string, string>()
        {
            {"WndLogin","Login/WndLogin"},
            {"WndCreateRole","CreateRole/WndCreateRole"},
            {"WndMainUI","MainUI/WndMainUI"}
        };
    }
}