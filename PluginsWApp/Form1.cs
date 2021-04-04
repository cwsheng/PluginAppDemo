using PluginRunner;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace PluginWFApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Dictionary<string, AssemblyDynamicLoader> PluginsList = new Dictionary<string, AssemblyDynamicLoader>();

        private void btnSelPlugin_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "类库文件|*.dll";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string dllPath = openFileDialog.FileName;
                string pluginName = Path.GetFileNameWithoutExtension(dllPath);
                if (!PluginsList.ContainsKey(pluginName))
                {
                    txt_dllName.Text = dllPath;
                    txtPluginName.Text = pluginName;

                    var loader = new AssemblyDynamicLoader(pluginName);
                    loader.LoadAssembly(dllPath);
                    PluginsList.Add(pluginName, loader);
                }
                else
                {
                    MessageBox.Show("插件已加载");
                }
            }
        }

        private void OutPut(string msg)
        {
            txtOutput.Text += $"{DateTime.Now} {msg} \r\n";
        }

        private void btnUnload_Click(object sender, EventArgs e)
        {
            string pluginName = txtPluginName.Text;
            if (!string.IsNullOrEmpty(pluginName) && PluginsList.ContainsKey(pluginName))
            {
                var loader = PluginsList[pluginName];
                loader.Unload();
                PluginsList.Remove(pluginName);
            }
            else
            {
                MessageBox.Show("插件未指定或未加载");
            }
        }

        private void btnRunPlugin_Click(object sender, EventArgs e)
        {
            string pluginName = txtPluginName.Text;
            if (!string.IsNullOrEmpty(pluginName) && PluginsList.ContainsKey(pluginName))
            {
                var loader = PluginsList[pluginName];
                var strResult = loader.ExecuteMothod("PrintPlugin.PrintPlugin", "Exec")?.ToString();
                MessageBox.Show(strResult);
            }
            else
            {
                MessageBox.Show("插件未指定或未加载");
            }
        }

        private void btnAppdomain_Click(object sender, EventArgs e)
        {
            OutPut("主程序域：");
            foreach (var item in AppDomain.CurrentDomain.GetAssemblies())
            {
                OutPut(item.FullName);
            }

            //OutPut($"{pluginName}-插件程序域：");
            //foreach (var item in loader.GetAssemblies())
            //{
            //    OutPut(item.FullName);
            //}
        }
    }
}
