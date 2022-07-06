<h1 align="center">Exercícios SOLID</h1>

Aplicação console desenvolvida para fins acadêmicos, com o objetivo de implementar exercícios utilizando boas práticas e os princípios do SOLID.

O código fonte dos exercícios foram baseados no curso [C# - Aplicando Princípios SOLID na prática](https://www.udemy.com/course/fullstack-vuejs-dotnetcore-efcore/).

## :blue_book: Lista de Exercícios

### :book: [Exercício 1](https://github.com/PauloAlves8039/dotnet-core-solid-exercicios/tree/master/src/01-Exercicio) 

### **Cenário**
Nessa aplicação tem a classe concreta `Cliente` que representa um modelo de domínio e possui as propriedadees: `Nome`, `Pais` e `Email` e um método estático
`ObtendoListaDeClientes()` que retorna uma lista de clientes.

A aplicação possui também uma classe chamada `LocalizaCliente` que permite localizar o cliente pelo nome e pelo pais, para isso esta classe utiliza os métodos:
`PesquisarPorPais(string pais) e PesquisarPorNome(string nome)`.

Após algum tempo foi implementado a funcionalidade para exportar os dados dos clientes no formato `CSV(Comma Separated Values)`, isso foi feito incluindo o método
`ExportarArquivo()` na classe `LocalizaCliente`.

### **Solução**
Antes houve a violação do `princípio da responsabilidade única` na classe `LocalizaCliente` que tinha duas responsábilidades, caso haja uma necessidade de exportar os
dados para outros formatos como `XML` ou `PDF` vai ser necessário alterar a classe `LocalizaCleinte`, qualquer modificação nessa classe também vai exigir testes 
para garantir que as alterações não afetem a aplicação.

Na solução foi criada a classe `ExportarDados` e movendo o método `ExportarArquivo(List<Cliente> dados)` para esta classe.

Dessa forma é aplicado o uso do `SRP — Single Responsibility Principle`, onde as classes `LocalizaCliente` e `ExportarDados` ficam com uma única responsabilidade.


## :floppy_disk: Clonar Repositório

`git clone https://github.com/PauloAlves8039/dotnet-core-solid-exercicios.git`

## Author
:boy: [Paulo Alves](https://github.com/PauloAlves8039)
