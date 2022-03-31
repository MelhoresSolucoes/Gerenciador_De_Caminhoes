# GcApp - Gerenciador de Caminhões

### Sobre:
Este é um exemplo de aplicação ASP.NETcore, MVC com Razor, Entity Framework e banco de dados local com Migration.
Possui um cadastro de caminhoes e de Modelos de Veículos.

### Objetivo:
* Visualizar o caminhões cadastrados
    - A propriedades mínimas do caminhão deverão ser:
        - Modelo (Poderá aceitar somente FH e FM)
        - Ano de Fabricação  (ano deverá ser o atual)
        - Ano Modelo (poderá ser atual ou o ano subsequente)
* Atualizar as informações de um caminhão
* Excluir um caminhão
* Inserir um novo caminhão

### Detalhes:

Foi utilizado o Visual Studio 2022 para o desenvolvimento.

A arquitetura utilizada foi o MVC com o ASP.NETCore.

Para persistência dos dados fou utilizado Entity Framework com banco de dados local criado automaticamente através de Migrations.

![image](https://user-images.githubusercontent.com/96745777/160299219-9c3cfff2-d462-4836-9405-efb50b47f32d.png)

A aplicação consistem em um cadastro de caminhoes com as opções de Cadastrar, Editar, Excluir e Visualizar.

![image](https://user-images.githubusercontent.com/96745777/161079191-3126c130-876f-4ebc-aaad-96a143252b10.png)

![image](https://user-images.githubusercontent.com/96745777/161079303-93fb1e62-8ed5-49e1-b695-fb7272f360a0.png)

Na tela de cadastro de caminhões, há uma condição quanto ao modelo, que devem ser aceitos somente dois tipos: FH e FM, então foi criado uma pagina para criação dos modelos, no qual possui um campo para bloqueio, permitindo somente utilizar os modelos ativos:

![image](https://user-images.githubusercontent.com/96745777/161079673-e036bad8-50f1-4fc3-b07c-71b06893fe6a.png)


## Melhorias Futuras:
* Desempenho
* Front
* Testes
* Campo para foto do caminhão
* link para os detalhes técnicos, se for um HTTP
