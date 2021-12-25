//Função do algoritmo é calcular a média aritmética
//autor: tuliobgn

programa
{
	
	funcao inicio()
	{
		real jan,fev,mar,abr,media
		cadeia funcionario
		
		escreva("Digite o nome do vendedor")
		leia(funcionario)
		escreva("digite quanto vendeu em jan")
		leia(jan)
		escreva("digite quanto vendeu em fev")
		leia(fev)
		escreva("digite quanto vendeu em mar")
		leia(mar)
		escreva("digite quanto vendeu em abr")
		leia(abr)
		
		media = (jan+fev+mar+abr)/4

		escreva ("sua media é: " + media)
		//verifiva se a média é maior ou igual a 50000
		se(media>=50000){
			escreva("\n" + "Parabéns, vai ganhar um bônus!")
		}
		//caso a média seja menor que 50000
		senao{
			escreva("\n" + "Bora trabalhar que próximo quadrimestre tem!")
		}
	}
}
/* $$$ Portugol Studio $$$ 
 * 
 * Esta seção do arquivo guarda informações do Portugol Studio.
 * Você pode apagá-la se estiver utilizando outro editor.
 * 
 * @POSICAO-CURSOR = 660; 
 * @PONTOS-DE-PARADA = ;
 * @SIMBOLOS-INSPECIONADOS = ;
 * @FILTRO-ARVORE-TIPOS-DE-DADO = inteiro, real, logico, cadeia, caracter, vazio;
 * @FILTRO-ARVORE-TIPOS-DE-SIMBOLO = variavel, vetor, matriz, funcao;
 */