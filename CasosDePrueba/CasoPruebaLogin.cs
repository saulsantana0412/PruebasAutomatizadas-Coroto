using NUnit.Framework.Legacy;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PruebasUnitarias_Coroto.Paginas;
using AventStack.ExtentReports;
using PruebasUnitarias_Coroto.Utilidades;
using System.Threading;

namespace PruebasUnitarias_Coroto.CasosDePrueba
{
		[TestFixture]
		public class CasoPruebaLogin : CasoPruebaBase
		{

			[Test]
			public void LoginCorrecto()
			{
				UtilidadCaptura.TomarCaptura(Driver,"CasoPrueba-Login","c1-Login-Correcto");
				reporte.Log(Status.Info, "Iniciando prueba de login con credenciales correctas");

				PagLogin pagLogin = new PagLogin(Driver);
				PagPrincipal pagPrincipal = pagLogin.Logearse("saulsantan0412@gmail.com", "luaS.4002.corotos");

				UtilidadCaptura.TomarCaptura(Driver, "CasoPrueba-Login", "c1-Login-LLeno");
				reporte.Log(Status.Info, "Agregando credenciales correctas.");

				pagPrincipal.CerrarModal();

				UtilidadCaptura.TomarCaptura(Driver, "CasoPrueba-Login", "c1-Pagina-Principal");
				reporte.Log(Status.Info, "Terminando prueba, mostrando pagina principal.");

		}

		[Test]
			public void LoginIncorrecto()
			{
				UtilidadCaptura.TomarCaptura(Driver, "CasoPrueba-Login", "c2-Login-Incorrecto");
				reporte.Log(Status.Info, "Iniciando prueba de login con credenciales incorrectas.");

				PagLogin pagLogin = new PagLogin(Driver);
				PagPrincipal pagPrincipal = pagLogin.Logearse("affsd@gmail.com", "fasfd");

				UtilidadCaptura.TomarCaptura(Driver, "CasoPrueba-Login", "c2-Login-LLeno");
				reporte.Log(Status.Info, "Agregando credenciales incorrectas.");
				
				Thread.Sleep(1000);
				UtilidadCaptura.TomarCaptura(Driver, "CasoPrueba-Login", "c2-Error-Login");
				reporte.Log(Status.Info, "Terminando prueba, mostrando error de credenciales.");
			}

	}
}
