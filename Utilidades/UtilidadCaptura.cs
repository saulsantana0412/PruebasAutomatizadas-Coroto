﻿using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebasUnitarias_Coroto.Utilidades
{
	public class UtilidadCaptura
	{
		public static string TomarCaptura(IWebDriver driver, string carpeta, string nombre)
		{
			string RutaImagen = "..\\..\\Capturas\\" +carpeta +"\\" + nombre + ".png";
			Screenshot imagen = ((ITakesScreenshot)driver).GetScreenshot();
			imagen.SaveAsFile(RutaImagen);

			return RutaImagen;
		}
	} 
}
