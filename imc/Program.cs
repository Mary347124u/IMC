/*
 * Created by SharpDevelop.
 * User: DELL
 * Date: 01/04/2021
 * Time: 22:21
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace imc
{
	class Program
	{
		public static void Main(string[] args)
		{
			float a,p,imc;

			Console.WriteLine("Altura:");

			a = float.Parse(Console.ReadLine());

			Console.WriteLine("Peso:");

			p = float.Parse(Console.ReadLine());

			imc = p / (a * a);

			Console.WriteLine("Seu imc:"+ imc);

			Console.ReadKey();
		}
	}
}