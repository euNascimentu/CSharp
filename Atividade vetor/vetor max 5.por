programa {
  funcao inicio() {
    inteiro n1, contador
    inteiro vetor[5]
    escreva("Quantos n�meros voc� deseja digitar (m�ximo 5): ")
    leia(n1)
 
    para (contador = 0; contador < n1; contador++) {
      escreva("Digite um n�mero: ")
      leia(vetor[contador])
    }
 
    para (contador = 0; contador < n1; contador++) {
      escreva("A posi��o ", contador, " �: ", vetor[contador], "\n")
    }
  }
}
 