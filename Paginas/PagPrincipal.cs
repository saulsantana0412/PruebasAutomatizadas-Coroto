using OpenQA.Selenium;
using PruebasUnitarias_Coroto.Utilidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PruebasUnitarias_Coroto.Paginas
{
	public class PagPrincipal : PagBase
	{
		protected By BotonCerrarModal = By.XPath("//*[@id=\"verify-account\"]/div/a");
		protected By BotonCerrarEncuesta = By.XPath("//*[@id=\"hotjar-survey-61a44774-770b-41b7-87c5-d6795427ba50\"]/div/div/div[3]/div/button");
		
		protected By BarraBusqueda = By.Id("search");
		protected By BotonBuscar = By.Id("g4-navbar-search-button");
		protected By PrimerResultadoBusqueda = By.XPath("/html/body/main/div[2]/div[8]/div[2]/div[1]/div[1]/div[1]/div/div");
				
		protected By PublicacionDestacada = By.XPath("/html/body/main/div/div[2]/div[3]/div[1]/div[2]/div[2]/div[1]");
		protected By BotonAgregarFavorito = By.XPath("//*[@id=\"favorite-form-listing-detail\"]/button");
		protected By BotonFavoritos = By.Id("g4-favorites-navbar-button");
		protected By ItemFavorito = By.XPath("//*[@id=\"favorite-listings\"]");

		protected By OpcionVehiculo = By.Id("g4-navbar-vehiculos-link");
		protected By OpcionInmueble = By.Id("g4-navbar-inmuebles-link");

		public PagPrincipal(IWebDriver driver)
		{
			Driver = driver;
		}
		public void CerrarModal()
		{
			if (UtilidadWait.ElementoEstaPresente(Driver, BotonCerrarModal))
			{
				Driver.FindElement(BotonCerrarModal).Click();
			}
		}

		public void EscribirBusqueda(string busqueda)
		{
			Driver.FindElement(BarraBusqueda).SendKeys(busqueda);
		}

		public void ClickBotonBuscar()
		{
			Driver.FindElement(BotonBuscar).Click();
		}

		public void ClickPrimerResultado()
		{
			Driver.FindElement(PrimerResultadoBusqueda).Click();

		}

		//Caso de Prueba Favorito
		public void SeleccionarPublicacion()
		{
			Driver.FindElement(PublicacionDestacada).Click();
			IJavaScriptExecutor js = (IJavaScriptExecutor)Driver;
			js.ExecuteScript("arguments[0].scrollIntoView(false);", Driver.FindElement(BotonAgregarFavorito));

		}

		public void AgregarFavorito()
		{
			if (UtilidadWait.ElementoEstaPresente(Driver, BotonAgregarFavorito))
			{
				Driver.FindElement(BotonAgregarFavorito).Click();
				
			}

		}

		public void ObservarFavoritos()
		{
			Driver.FindElement(BotonFavoritos).Click();
			IJavaScriptExecutor js = (IJavaScriptExecutor)Driver;
			js.ExecuteScript("arguments[0].scrollIntoView(false);", Driver.FindElement(ItemFavorito));
		}

		// Seleccionar pagina vehiculo en el menu

		public PagVehiculos SeleccionarPagVehiculo()
		{
			Driver.FindElement(OpcionVehiculo).Click();

			return new PagVehiculos(Driver);
		}

		// Seleccionar pagina inmuebles en el menu

		public PagInmuebles SeleccionarPagInmuebles()
		{
			Driver.FindElement(OpcionInmueble).Click();

			return new PagInmuebles(Driver);
		}

	}
}
