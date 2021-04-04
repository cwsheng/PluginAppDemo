using System;

namespace IPluginInterface
{
    public interface IPlugin
    {

        /// <summary>
        /// 执行插件方法
        /// </summary>
        /// <param name="pars">参数json</param>
        /// <returns>执行结果json串</returns>
        object Exec(string pars);

        /// <summary>
        /// 插件初始化
        /// </summary>
        /// <returns></returns>
        bool Init();

    }
}
