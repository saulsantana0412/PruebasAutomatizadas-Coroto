using AventStack.ExtentReports;
using NUnit.Framework;
using PruebasUnitarias_Coroto.Paginas;
using PruebasUnitarias_Coroto.Utilidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebasUnitarias_Coroto.CasosDePrueba
{
	public class CasoPruebaBuscador : CasoPruebaBase
	{
		[Test]
		public void BusquedaCorrecta()
		{
			PagLogin pagLogin = new PagLogin(Driver);
			PagPrincipal pagPrincipal = pagLogin.Logearse("saulsantan0412@gmail.com", "luaS.4002.corotos");
			pagPrincipal.CerrarModal();
			
			UtilidadCaptura.TomarCaptura(Driver, "CasoPrueba-Buscador", "c1-Pagina-Principal");
			reporte.Log(Status.Info, "Iniciando caso de prueba de busqueda correcta.");
			
			pagPrincipal.EscribirBusqueda("telefono");
			UtilidadCaptura.TomarCaptura(Driver, "CasoPrueba-Buscador", "c1-Buscando-Telefono");
			reporte.Log(Status.Info, "Colocando \"telefono\" en la barra de busqueda.");
			
			pagPrincipal.ClickBotonBuscar();
			pagPrincipal.CerrarModal();

			UtilidadCaptura.TomarCaptura(Driver, "CasoPrueba-Buscador", "c1-Resultados-Busqueda");
			reporte.Log(Status.Info, "Resultados de busqueda para \"telefono\".");
		}

		[Test]
		public void BusquedaIncorrecta()
		{
			PagLogin pagLogin = new PagLogin(Driver);
			PagPrincipal pagPrincipal = pagLogin.Logearse("saulsantan0412@gmail.com", "luaS.4002.corotos");
			pagPrincipal.CerrarModal();
			
			UtilidadCaptura.TomarCaptura(Driver, "CasoPrueba-Buscador", "c2-Pagina-Principal");
			reporte.Log(Status.Info, "Iniciando caso de prueba de busqueda correcta.");

			pagPrincipal.EscribirBusqueda("asfd");
			UtilidadCaptura.TomarCaptura(Driver, "CasoPrueba-Buscador", "c2-Buscando-Erroneamente");
			reporte.Log(Status.Info, "Colocando busqueda erronea en el buscador.");

			pagPrincipal.ClickBotonBuscar();
			pagPrincipal.CerrarModal();

			UtilidadCaptura.TomarCaptura(Driver, "CasoPrueba-Buscador", "c2-Resultados-Busqueda");
			reporte.Log(Status.Info, "Resultado de busqueda erronea.");

		}




	}
}
