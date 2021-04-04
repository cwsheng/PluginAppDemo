using IPluginInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrintPlugin
{
    public class PrintPlugin : IPlugin
    {
        public object Exec(string pars)
        {
            //v1.0
            //return $"打印插件执行-{pars} 完成";
            //v1.1
            return $"打印插件执行-{pars} 完成-更新版本v1.1";
        }

        public bool Init()
        {
            return true;
        }
    }
}
