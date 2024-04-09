using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebasUnitarias_Coroto.Utilidades
{
	public class UtilidadWait
	{
		public static bool ElementoEstaPresente(IWebDriver driver, By ubicacion, int segundos = 3)
		{
			try
			{
				WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(segundos));
				wait.Until(drv => drv.FindElement(ubicacion));
				return true;
			}
			catch { }

			return false;
		}
	}
}
