using AventStack.ExtentReports;
using NUnit.Framework;
using PruebasUnitarias_Coroto.Paginas;
using PruebasUnitarias_Coroto.Utilidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PruebasUnitarias_Coroto.CasosDePrueba
{
	public class CasoPruebaFiltrarVehiculos : CasoPruebaBase
	{
		[Test]
		public void FiltradoVehiculo()
		{
			PagLogin pagLogin = new PagLogin(Driver);
			PagPrincipal pagPrincipal = pagLogin.Logearse("saulsantan0412@gmail.com", "luaS.4002.corotos");
			pagPrincipal.CerrarModal();

			PagVehiculos pagVehiculos = pagPrincipal.SeleccionarPagVehiculo();
			pagPrincipal.CerrarModal();
			UtilidadCaptura.TomarCaptura(Driver, "CasoPrueba-FiltrarVehiculo", "Pagina-Vehiculo");
			reporte.Log(Status.Info, "Iniciando caso de prueba de filtrar vehiculos correctamente.");

			pagVehiculos.SeleccionarAño(2010, 2015);
			UtilidadCaptura.TomarCaptura(Driver, "CasoPrueba-FiltrarVehiculo", "Seleccionado-Año-Vehiculo");
			reporte.Log(Status.Info, "Seleccionando el año del vehiculo para filtrar.");
			Thread.Sleep(1000);
			pagVehiculos.GuardarFiltro();

			pagVehiculos.Buscar();
			UtilidadCaptura.TomarCaptura(Driver, "CasoPrueba-FiltrarVehiculo", "Resultados-Busqueda");
			reporte.Log(Status.Info, "Resultados de la busqueda.");
			Thread.Sleep(1000);

			pagVehiculos.SeleccionarVehiculo();
			UtilidadCaptura.TomarCaptura(Driver, "CasoPrueba-FiltrarInmueble", "Verificacion-Busqueda");
			reporte.Log(Status.Info, "Verificando que los resultados cumplan con los filtros de busqueda.");
			Thread.Sleep(1000);


		}
	}
}
