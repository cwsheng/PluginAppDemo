using IPluginInterface;
using System;
using System.Linq.Expressions;
using System.Reflection;

namespace PluginRunner
{
    public class RemoteLoader : MarshalByRefObject
    {
        private Assembly _assembly;

        public void LoadAssembly(string assemblyFile)
        {
            try
            {
                _assembly = Assembly.LoadFrom(assemblyFile);
                //return _assembly;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public T GetInstance<T>(string typeName) where T : class
        {
            if (_assembly == null) return null;
            var type = _assembly.GetType(typeName);
            if (type == null) return null;
            return Activator.CreateInstance(type) as T;
        }

        public object ExecuteMothod(string typeName, string args)
        {
            if (_assembly == null) return null;
            var type = _assembly.GetType(typeName);
            var obj = Activator.CreateInstance(type);
            if (obj is IPlugin)
            {
                return (obj as IPlugin).Exec(args);
            }
            return null;
        }
    }
}