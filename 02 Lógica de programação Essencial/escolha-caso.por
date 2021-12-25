programa
{
	
	funcao inicio()
	{
		escreva("1 - abrir netflix \n2 - abrir amazon \n3 - abrir HBO \n4 - sair")
		inteiro menu = 0
		escreva("\n" + "digite uma opção")
		leia(menu)

		escolha (menu)
		{
		
		caso 1:
			escreva ("abra netflix!")
			pare
		caso 2:
			escreva ("abra amazon!")
			pare
		caso 3:
			escreva ("abra HBO!")
			pare
		caso 4:
			escreva ("tchau")
			pare
		caso contrario:
			escreva ("vc deve escolher uma opção entre 1, 2, 3 ou 4")
		}
	}
}
/* $$$ Portugol Studio $$$ 
 * 
 * Esta seção do arquivo guarda informações do Portugol Studio.
 * Você pode apagá-la se estiver utilizando outro editor.
 * 
 * @POSICAO-CURSOR = 442; 
 * @PONTOS-DE-PARADA = ;
 * @SIMBOLOS-INSPECIONADOS = ;
 * @FILTRO-ARVORE-TIPOS-DE-DADO = inteiro, real, logico, cadeia, caracter, vazio;
 * @FILTRO-ARVORE-TIPOS-DE-SIMBOLO = variavel, vetor, matriz, funcao;
 */