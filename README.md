# App.Refit.ConsumerApi
Console Application para utilização da biblioteca Refit para consumo de endpoints de APIs externas.

Para testes, se faz necessário:
* Uma API disponível em https://localhost:44359 
* Resposta do método GET na rota /Aluno/busca-cpf/ com o parâmetro "cpf" do tipo string.
* O response desse GET deve conter os campos: nome (string), aniversário (DateTime), cpf (string), ativo (bool), endereco (string), id (guid)

Referências:
https://github.com/reactiveui/refit
https://www.luisdev.com.br/2020/08/05/asp-net-core-e-refit-simplificando-a-comunicacao-entre-apis/
https://www.youtube.com/watch?v=2izJGgMTFDY
