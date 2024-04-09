using AventStack.ExtentReports.Reporter;
using AventStack.ExtentReports;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebasUnitarias_Coroto.Utilidades
{
	public class UtilidadReporte
	{
		private static ExtentReports reporte;
		private static ExtentSparkReporter ReporteHTML;
		public static ExtentReports ObtenerReporte()
		{ 
			if (reporte == null)
			{
				string RutaReporte = @"C:\Users\sauls\OneDrive - Instituto Tecnológico de Las Américas (ITLA)\5to Cuatrimestre\Programacion 3\Tarea 4\PruebasUnitarias-Coroto\Reportes\Reporte.html";
				ReporteHTML = new ExtentSparkReporter(RutaReporte);
				reporte = new ExtentReports();
				reporte.AttachReporter(ReporteHTML);
			}
			return reporte;
		}
	}
}
