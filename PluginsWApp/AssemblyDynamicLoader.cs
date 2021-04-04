using System;
using System.IO;
using System.Reflection;

namespace PluginRunner
{
    public class AssemblyDynamicLoader
    {
        private AppDomain appDomain;
        private RemoteLoader remoteLoader;
        public AssemblyDynamicLoader(string pluginName)
        {
            AppDomainSetup setup = new AppDomainSetup();
            setup.ApplicationName = "app_" + pluginName;
            setup.ApplicationBase = AppDomain.CurrentDomain.BaseDirectory;
            setup.PrivateBinPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Plugins");
            setup.CachePath = setup.ApplicationBase;
            setup.ShadowCopyFiles = "true";
            setup.ShadowCopyDirectories = setup.ApplicationBase;
            AppDomain.CurrentDomain.SetShadowCopyFiles();
            this.appDomain = AppDomain.CreateDomain("app_" + pluginName, null, setup);

            String name = Assembly.GetExecutingAssembly().GetName().FullName;
            this.remoteLoader = (RemoteLoader)this.appDomain.CreateInstanceAndUnwrap(name, typeof(RemoteLoader).FullName);
        }

        /// <summary>
        /// 加载程序集
        /// </summary>
        /// <param name="assemblyFile"></param>
        public void LoadAssembly(string assemblyFile)
        {
            remoteLoader.LoadAssembly(assemblyFile);
        }

        /// <summary>
        /// 创建对象实例
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="typeName"></param>
        /// <returns></returns>
        public T GetInstance<T>(string typeName) where T : class
        {
            if (remoteLoader == null) return null;
            return remoteLoader.GetInstance<T>(typeName);
        }

        /// <summary>
        /// 执行类型方法
        /// </summary>
        /// <param name="typeName"></param>
        /// <param name="methodName"></param>
        /// <returns></returns>
        public object ExecuteMothod(string typeName, string methodName)
        {
            return remoteLoader.ExecuteMothod(typeName, methodName);
        }

        /// <summary>
        /// 卸载应用程序域
        /// </summary>
        public void Unload()
        {
            try
            {
                if (appDomain == null) return;
                AppDomain.Unload(this.appDomain);
                this.appDomain = null;
                this.remoteLoader = null;
            }
            catch (CannotUnloadAppDomainException ex)
            {
                throw ex;
            }
        }

        public Assembly[] GetAssemblies()
        {
            return this.appDomain.GetAssemblies();
        }
    }
}
