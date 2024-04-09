using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebasUnitarias_Coroto.Paginas
{
	public class PagLogin : PagBase
	{
		protected By InputUsuario = By.Id("app_user_email");
		protected By InputContraseña = By.Id("app_user_password");
		protected By BotonLogin = By.Id("submitButton");

		public PagLogin(IWebDriver driver)
		{
			Driver = driver;
		}
		public void EscribirUsuario(string usuario)
		{
			Driver.FindElement(InputUsuario).SendKeys(usuario);
		}

		public void EscribirContraseña(string contraseña)
		{
			Driver.FindElement(InputContraseña).SendKeys(contraseña);
		}

		public void ClickBotonLogin()
		{
			Driver.FindElement(BotonLogin).Click();
		}

		public PagPrincipal Logearse(string usuario, string contraseña)
		{
			EscribirUsuario(usuario);
			EscribirContraseña(contraseña);
			ClickBotonLogin();

			return new PagPrincipal(Driver);
		}

	}
}
