using System;
using System.IO;
using System.Reflection;

namespace PluginRunner
{
    public class AssemblyDynamicLoader
    {
        private AppDomain appDomain;
        private RemoteLoader remoteLoader;
        public AssemblyDynamicLoader()
        {
            AppDomainSetup setup = new AppDomainSetup();
            setup.ApplicationName = "ApplicationLoader";
            setup.ApplicationBase = AppDomain.CurrentDomain.BaseDirectory;
            setup.PrivateBinPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Plugins");
            setup.CachePath = setup.ApplicationBase;
            setup.ShadowCopyFiles = "true";
            setup.ShadowCopyDirectories = setup.ApplicationBase;
            //AppDomain.CurrentDomain.SetShadowCopyFiles();
            this.appDomain = AppDomain.CreateDomain("ApplicationLoaderDomain", null, setup);

            String name = Assembly.GetExecutingAssembly().GetName().FullName;
            this.remoteLoader = (RemoteLoader)this.appDomain.CreateInstanceAndUnwrap(name, typeof(RemoteLoader).FullName);
        }

        public void LoadAssembly(string assemblyFile)
        {
            remoteLoader.LoadAssembly(assemblyFile);
        }

        public T GetInstance<T>(string typeName) where T : class
        {
            if (remoteLoader == null) return null;
            return remoteLoader.GetInstance<T>(typeName);
        }

        public object ExecuteMothod(string typeName, string methodName)
        {
            return remoteLoader.ExecuteMothod(typeName, methodName);
        }

        public void Unload()
        {
            try
            {
                if (appDomain == null) return;
                AppDomain.Unload(this.appDomain);
                this.appDomain = null;
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
