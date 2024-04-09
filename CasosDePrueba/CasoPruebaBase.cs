using AventStack.ExtentReports;
using AventStack.ExtentReports.Model;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Edge;
using PruebasUnitarias_Coroto.Utilidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebasUnitarias_Coroto.CasosDePrueba
{
	public class CasoPruebaBase
	{
		protected IWebDriver Driver;
		protected ExtentTest reporte;

		[SetUp]
		public void IniciacionPrueba()
		{
			Driver = new EdgeDriver(@"C:\Users\sauls\OneDrive - Instituto Tecnológico de Las Américas (ITLA)\5to Cuatrimestre\Programacion 3\Tarea 4\edgedriver_win64\msedgedriver.exe");
			Driver.Navigate().GoToUrl("https://www.corotos.com.do/app_users/sign_in");
			Driver.Manage().Window.Maximize();
			reporte = UtilidadReporte.ObtenerReporte().CreateTest(TestContext.CurrentContext.Test.Name);

		}

		[TearDown]
		public void TerminacionPrueba()
		{
			UtilidadReporte.ObtenerReporte().Flush();
			Driver.Quit();	
		}
	}
}
