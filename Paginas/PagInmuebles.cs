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
	public class PagInmuebles : PagBase
	{
		protected By SelectorTipoInmueble = By.Id("select_sub_categories");
		protected By TipoApartamento = By.XPath("//*[@id=\"subCategoryModal\"]/div/div/div/div[2]");

		protected By SelectorPrecio = By.Id("select_price_sub_categories");
		protected By PrecioMinimo = By.Id("minValue");
		protected By PrecioMaximo = By.Id("maxValue");
		protected By BotonGuardarFiltroPrecio = By.Id("save-filter-currency");

		protected By SelectorUbicacion = By.Id("open-location-dialog");
		protected By SelectorProvincia = By.XPath("//*[@id=\"location-modal\"]/div[1]/div[2]/div[4]/div/div/div/span[1]/span[1]/span");
		protected By InputProvincia = By.XPath("/html/body/span/span/span[1]/input");
		protected By SelectorMunicipio = By.XPath("//*[@id=\"location-modal\"]/div[1]/div[2]/div[4]/div/div/div/span[2]/span[1]/span");
		protected By InputMunicipio = By.XPath("/html/body/span/span/span[1]/input");
		protected By BotonGuardarFiltroUbicacion = By.Id("filter-location-button");

		protected By BotonBuscar = By.Id("filter-button-alter-state");

		protected By Resultado = By.XPath("/html/body/main/div[2]/div[8]/div[2]/div[2]/div[2]/div[1]");
		protected By BotonReferencia = By.Id("offer-btn-sign-in");

		public PagInmuebles(IWebDriver driver)
		{
			Driver = driver;
		}

		public void SeleccionarTipoInmueble()
		{
			Driver.FindElement(SelectorTipoInmueble).Click();
		}

		public void GuardarFiltroTipo()
		{
			Driver.FindElement(TipoApartamento).Click();
		}

		public void SeleccionarPrecioInmueble(int minimo, int maximo)
		{
			Driver.FindElement(SelectorPrecio).Click();
			Driver.FindElement(PrecioMinimo).SendKeys(minimo.ToString());
			Driver.FindElement(PrecioMaximo).SendKeys(maximo.ToString());

		}

		public void GuardarFiltroPrecio()
		{
			Driver.FindElement(BotonGuardarFiltroPrecio).Click();
		}


		public void SeleccionarUbicacionInmueble(string provincia, string municipio)
		{
			Driver.FindElement(SelectorUbicacion).Click();
			Driver.FindElement(SelectorProvincia).Click();
			Driver.FindElement(InputProvincia).SendKeys(provincia);
			Driver.FindElement(InputProvincia).SendKeys(Keys.Enter);
			Driver.FindElement(SelectorMunicipio).Click();
			Thread.Sleep(2000);
			Driver.FindElement(SelectorMunicipio).Click();
			Thread.Sleep(5000);
			Driver.FindElement(SelectorMunicipio).Click();
			Driver.FindElement(InputMunicipio).SendKeys(municipio);
			Driver.FindElement(InputMunicipio).SendKeys(Keys.Enter);
			Thread.Sleep(3000);
		}

		public void GuardarFiltroUbicacion()
		{
			Driver.FindElement(BotonGuardarFiltroUbicacion).Click();
		}

		public void Buscar()
		{
			Driver.FindElement(BotonBuscar).Click();
			IJavaScriptExecutor js = (IJavaScriptExecutor)Driver;
			js.ExecuteScript("arguments[0].scrollIntoView(false);", Driver.FindElement(Resultado));
		}

		public void VerResultado()
		{
			Driver.FindElement(Resultado).Click();
			IJavaScriptExecutor js = (IJavaScriptExecutor)Driver;
			js.ExecuteScript("arguments[0].scrollIntoView(false);", Driver.FindElement(BotonReferencia));
		}


	}
}
