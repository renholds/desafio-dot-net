# Criar um site de consulta a API de Filmes #

Criar um site para consultar a API de Filmes e trazer os filmes enviados pelo endpoint. Seguem abaixo telas como guia:

![Pesquisa de filmes](https://github.com/digounet/desafio-dot-net/blob/master/pesquisa.png)
![Detalhes do filme](https://github.com/digounet/desafio-dot-net/blob/master/detalhes.png)

### **O aplicativo deve contemplar** ###

- __Uma lista de filmes populares__. Exemplo de chamada na API: `https://api.themoviedb.org/3/movie/popular?api_key={api_key}`.
    * Paginação na tela de lista.
    * Cada filme deve exibir Nome do filme e Foto do filme.
    * Ao clicar em um item da lista, deve levar ao detalhe do filme.
- __Permitir pesquisar um filme de forma assíncrona__. Exemplo de chamada na API: `https://api.themoviedb.org/3/search/movie?api_key={api_key}&query=Jack+Reacher`.
- __Detalhes de um filme__. Exemplo de chamada na API: `https://api.themoviedb.org/3/movie/343611?api_key={api_key}`.
    * O item de detalhe deve exibir Nome, Foto e Descrição do filme.

### **Essencial** ##
* IDE Utilizada deve ser o Visual Studio Community ou Visual Studio Code
* O projeto deve ser estruturado em camadas (onion architecture)
* O projeto WEB deve ser feito em MVC
* Implementar em .Net Core e C#
* O site deve ser diagramado em bootstrap
* A pesquisa de filmes deve ser feita de forma assíncrona
* A listagem deve conter uma paginação
* caso utilize a biblioteca dattatables, a pesquisa não deve ser realizada com o padrão do componente

### **Desejável** ###

* Bibliotecas de terceiros para reduzir o boilerplate
* Arquitetura onion, ou similares

### **Sugestões** ###

Nesta seção sugerimos algumas bibliotecas para o uso, mas fique à vontade para escolher outras que não estiverem na lista.

* Automapper
* MediatR
* FluentValidation
* Datatables

### **OBS** ###

Para realizar chamadas a API é necessário se cadastrar no site (https://www.themoviedb.org/documentation/api) e gerar uma chave.
A foto das telas de mockup são só um guia, fique a vontade para usar o padrão de usabilidade da sua escolha.

### **Etapas para submissão** ###

O canditador ao finalizar a implementação deverá enviar um pull request para o repositório em questão.

Segue o passo-a-passo:

1. Fazer fork do respositório
2. Implementar seu projeto no fork realizado.
3. Comitar e subir todas as alteraçes para o fork criado por você.
4. Enviar um pull request pelo Github.

O fork deverá ser público para inspeção do código.

### **Observações** ###

Não fazer push para este repositório.
Após o envio do pull request, não serão aceitas novas alterações.
