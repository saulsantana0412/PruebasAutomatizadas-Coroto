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
	public class CasoPruebaFiltrarInmueble : CasoPruebaBase
	{
		[Test]
		public void FiltrarInmueble()
		{
			PagLogin pagLogin = new PagLogin(Driver);
			PagPrincipal pagPrincipal = pagLogin.Logearse("saulsantan0412@gmail.com", "luaS.4002.corotos");
			pagPrincipal.CerrarModal();
			
			PagInmuebles pagInmuebles = pagPrincipal.SeleccionarPagInmuebles();
			pagPrincipal.CerrarModal();
			UtilidadCaptura.TomarCaptura(Driver, "CasoPrueba-FiltrarInmueble", "Pagina-Inmbueble");
			reporte.Log(Status.Info, "Iniciando caso de prueba de Filtrar Inmuebles correcta.");
			

			pagInmuebles.SeleccionarTipoInmueble();
			UtilidadCaptura.TomarCaptura(Driver, "CasoPrueba-FiltrarInmueble", "Seleccionado-Tipo-Inmueble");
			reporte.Log(Status.Info, "Seleccionando el tipo de inmueble para filtrar.");
			Thread.Sleep(1000);
			pagInmuebles.GuardarFiltroTipo();

			pagInmuebles.SeleccionarPrecioInmueble(2000000, 4000000);
			UtilidadCaptura.TomarCaptura(Driver, "CasoPrueba-FiltrarInmueble", "Seleccionado-Precio-Inmueble");
			reporte.Log(Status.Info, "Seleccionando el precio del inmueble para filtrar.");
			Thread.Sleep(1000);
			pagInmuebles.GuardarFiltroPrecio();


			pagInmuebles.SeleccionarUbicacionInmueble("Santo Domingo", "Distrito Nacional");
			UtilidadCaptura.TomarCaptura(Driver, "CasoPrueba-FiltrarInmueble", "Seleccionado-Ubicacion-Inmueble");
			reporte.Log(Status.Info, "Seleccionando la ubicacion del inmueble para filtrar.");
			pagInmuebles.GuardarFiltroUbicacion();

			pagInmuebles.Buscar();
			UtilidadCaptura.TomarCaptura(Driver, "CasoPrueba-FiltrarInmueble", "Resultados-Busqueda");
			reporte.Log(Status.Info, "Resultados de la busqueda.");
			Thread.Sleep(1000);

			pagInmuebles.VerResultado();
			UtilidadCaptura.TomarCaptura(Driver, "CasoPrueba-FiltrarInmueble", "Verificacion-Busqueda");
			reporte.Log(Status.Info, "Verificando que los resultados cumplan con los filtros de busqueda.");
			Thread.Sleep(1000);

		}
	}
}
