# Conversor de Unidades Avançado

Este é um projeto em C# que implementa um **Conversor de Unidades Avançado**, projetado para ser executado no console. Ele suporta conversões nas categorias de temperatura, distância e peso, com uma interface simples e mensagens destacadas por cores.

## Funcionalidades

- **Conversão de Temperatura**
  - Celsius para Fahrenheit
  - Fahrenheit para Celsius
  - Celsius para Kelvin
- **Conversão de Distância**
  - Quilômetros para Milhas
  - Milhas para Quilômetros
  - Metros para Pés
- **Conversão de Peso**
  - Quilogramas para Libras
  - Libras para Quilogramas
  - Quilogramas para Onças

## Estrutura do Projeto

O código foi projetado para ser simples e eficiente, utilizando uma única classe principal com métodos dedicados para cada categoria de conversão:

- `Main`: Ponto de entrada do programa, controla o menu principal e navegação entre as opções.
- Métodos de conversão:
  - `ConverterTemperatura`: Lógica para conversões de temperatura.
  - `ConverterDistancia`: Lógica para conversões de distância.
  - `ConverterPeso`: Lógica para conversões de peso.
- Métodos auxiliares:
  - `MostrarMenuPrincipal`: Exibe o menu principal no console.
  - `LerEscolha`: Valida a entrada do usuário para as opções do menu.
  - `LerDouble`: Valida a entrada do usuário para os valores numéricos.
  - `ExibirResultado`: Mostra os resultados das conversões com destaque em cores.

## Como Executar

1. Clone o repositório:
   ```bash
   git clone https://github.com/KillDarkness/CalculadoraDeValor.git
   ```

2. Abra o projeto em uma IDE como Visual Studio ou Visual Studio Code.

3. Compile e execute o programa.

4. Navegue pelo menu para realizar conversões.

## Requisitos

- .NET SDK (versão compatível com C# 10 ou superior)

## Capturas de Tela

### Menu Principal

```plaintext
************** Conversor de Unidades Avançado **************
Escolha uma categoria de conversão:
1 - Temperatura
2 - Distância
3 - Peso
4 - Sair
************************************************************
```

### Exemplo de Conversão

```plaintext
Converter Temperatura:
1 - Celsius para Fahrenheit
2 - Fahrenheit para Celsius
3 - Celsius para Kelvin
Digite o valor da temperatura: 25
Resultado: 25 °C => 77 °F
```

## Contribuições

Contribuições são bem-vindas! Para contribuir:

1. Faça um fork deste repositório.
2. Crie um branch com sua feature/bugfix: `git checkout -b minha-feature`.
3. Envie suas alterações: `git commit -m 'Minha feature'`.
4. Faça o push para o branch: `git push origin minha-feature`.
5. Abra um Pull Request.

---

Desenvolvido com ❤ por KillDarkness.

