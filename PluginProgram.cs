using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GeniePlugin.Interfaces;

namespace PluginExampleCSharp
{
	class PluginProgram : IPlugin
	{
		static void Main(string[] args)
		{
		}

		private IHost _host;

		public void Initialize(IHost host)
		{
			_host = host;
		}

		public void Show()
		{
			
		}

		public void VariableChanged(string variable)
		{
			
		}

		public string ParseText(string text, string window)
		{
			return text;
		}

		public string ParseInput(string text)
		{
			return text;
		}

		public void ParseXML(string xml)
		{
			
		}

		public void ParentClosing()
		{
			
		}

		public string Name
		{
			get { return "Plugin Name"; }
		}

		public string Version
		{
			get { return "1.0"; }
		}

		public string Description
		{
			get { return "Plugin Description";  }
		}

		public string Author
		{
			get { return "Your name"; }
		}

		private bool _enabled = true;
		public bool Enabled
		{
			get { return _enabled; }
			set { _enabled = value; }
		}
	}
}
