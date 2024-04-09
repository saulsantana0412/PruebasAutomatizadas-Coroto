using OpenQA.Selenium;
using PruebasUnitarias_Coroto.Utilidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PruebasUnitarias_Coroto.Paginas
{
	public class PagVehiculos: PagBase
	{
		protected By SelectorAño = By.Id("triger-year-vehicle");
		protected By AñoMinimo = By.Id("car_year_gteq");
		protected By AñoMaximo = By.Id("car_year_lteq");
		protected By BotonGuardar = By.Id("closeModalButton");
		protected By BotonBusqueda = By.Id("filter-button-vehicle");
		protected By PrimerResultado = By.XPath("/html/body/main/div[2]/div[8]/div[2]/div[3]/div[1]/div[1]");
		protected By BotonReferencia = By.Id("offer-btn-sign-in");


		public PagVehiculos(IWebDriver driver)
		{
			Driver = driver;
		}

		public void SeleccionarAño(int minimo, int maximo)
		{
			Driver.FindElement(SelectorAño).Click();
			Driver.FindElement(AñoMinimo).SendKeys(minimo.ToString());
			Driver.FindElement(AñoMaximo).SendKeys(maximo.ToString());
		}

		public void GuardarFiltro()
		{
			Driver.FindElement(BotonGuardar).Click();
		}

		public void Buscar()
		{
			Driver.FindElement(BotonBusqueda).Click();
			IJavaScriptExecutor js = (IJavaScriptExecutor)Driver;
			js.ExecuteScript("arguments[0].scrollIntoView(false);", Driver.FindElement(PrimerResultado));
		}

		public void SeleccionarVehiculo()
		{
			Driver.FindElement(PrimerResultado).Click();
			IJavaScriptExecutor js = (IJavaScriptExecutor)Driver;
			js.ExecuteScript("arguments[0].scrollIntoView(false);", Driver.FindElement(BotonReferencia));
		}

	}
}
