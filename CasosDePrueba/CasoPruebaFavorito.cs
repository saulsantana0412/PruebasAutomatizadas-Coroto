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
	public class CasoPruebaFavorito : CasoPruebaBase
	{
		[Test]
		public void AgregarFavorito()
		{
			PagLogin pagLogin = new PagLogin(Driver);
			PagPrincipal pagPrincipal = pagLogin.Logearse("saulsantan0412@gmail.com", "luaS.4002.corotos");
			pagPrincipal.CerrarModal();

			UtilidadCaptura.TomarCaptura(Driver, "CasoPrueba-Favorito", "Pagina-Principal");
			reporte.Log(Status.Info, "Iniciando caso de prueba de item favorito.");

			pagPrincipal.SeleccionarPublicacion();
			UtilidadCaptura.TomarCaptura(Driver, "CasoPrueba-Favorito", "Seleccionando-Item");
			reporte.Log(Status.Info, "Seleccionado Item.");

			pagPrincipal.AgregarFavorito();
			Thread.Sleep(1000);
			UtilidadCaptura.TomarCaptura(Driver, "CasoPrueba-Favorito", "Agregando-Favorito");
			reporte.Log(Status.Info, "Agregando item seleccionado como favorito.");

			pagPrincipal.ObservarFavoritos();
			UtilidadCaptura.TomarCaptura(Driver, "CasoPrueba-Favorito", "Observando-Favoritos");
			reporte.Log(Status.Info, "Observando los items que estan agregados como favoritos.");

		}
	}
}
