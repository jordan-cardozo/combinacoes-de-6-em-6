/*
 * Criado por SharpDevelop.
 * Usuário: Trajectory2
 * Data: 05/02/2022
 * Hora: 15:42
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
using System;
using System.IO;

namespace combinacoes
{
	class Program
	{
		public static void Main(string[] args)
		{
			int p=1;
			string name = "combinacoes";
			string curFile = name+".txt";
			
			if(File.Exists(curFile)){
				while(File.Exists(curFile)){
					curFile = name + p +".txt";
					p++;
				}
			}
			
			using (StreamWriter writer = new StreamWriter(curFile))
			{
				int[] conjunto = {1,2,3,4,5,6,7,8};
				int[] dezena = new int[6];
				int c = 0;
				
				for (int i = 0; i < conjunto.Length ; i++){
					dezena[0] = conjunto[i];
					for (int j = 0; j < conjunto.Length ; j++){
						if(conjunto[j] > dezena[0]){
							dezena[1] = conjunto[j];
							for (int k = 0; k < conjunto.Length ; k++){
								if(conjunto[k] > dezena[0] && conjunto[k] > dezena[1]){
									dezena[2] = conjunto[k];
									for (int l = 0; l < conjunto.Length ; l++){
										if(conjunto[l] > dezena[0] && conjunto[l] > dezena[1] && conjunto[l] > dezena[2]){
											dezena[3] = conjunto[l];
											for (int m = 0; m < conjunto.Length ; m++){
												if(conjunto[m] > dezena[0] && conjunto[m] > dezena[1] && conjunto[m] > dezena[2]  && conjunto[m] > dezena[3]){
													dezena[4] = conjunto[m];
													for (int n = 0; n < conjunto.Length ; n++){
														if(conjunto[n] > dezena[0] && conjunto[n] > dezena[1] && conjunto[n] > dezena[2] && conjunto[n] > dezena[3] && conjunto[n] > dezena[4]){
															dezena[5] = conjunto[n];
															
															Console.WriteLine(dezena[0]+" "+dezena[1]+" "+dezena[2]+" "+dezena[3]+" "+dezena[4]+" "+dezena[5]);
															writer.WriteLine(dezena[0]+" "+dezena[1]+" "+dezena[2]+" "+dezena[3]+" "+dezena[4]+" "+dezena[5]);
															c++;
															
														}
														
													}
												}
											}
										}
									}
								}
							}
							
						}
					}
				}
				Console.WriteLine("");
				Console.WriteLine(c+" combinações");
				Console.WriteLine("");
			}
			
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}