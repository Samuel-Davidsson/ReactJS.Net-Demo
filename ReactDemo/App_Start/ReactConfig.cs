using JavaScriptEngineSwitcher.Core;
using JavaScriptEngineSwitcher.V8;
using React;

[assembly: WebActivatorEx.PreApplicationStartMethod(typeof(ReactDemo.ReactConfig), "Configure")]

namespace ReactDemo
{
	public static class ReactConfig
	{
		public static void Configure()
		{
			JsEngineSwitcher.Current.DefaultEngineName = V8JsEngine.EngineName;
			JsEngineSwitcher.Current.EngineFactories.AddV8();
			ReactSiteConfiguration.Configuration
			.AddScript("~/js/remarkable.min.js")
			.AddScript("~/Scripts/Tutorial.jsx");
		}
	}
}