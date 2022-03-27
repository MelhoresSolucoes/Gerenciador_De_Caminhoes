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

![WhatsApp Image 2022-03-25 at 13 53 23](https://user-images.githubusercontent.com/96745777/160299750-eb457987-b174-42de-a78c-004985cdcfc8.jpeg)

![image](https://user-images.githubusercontent.com/96745777/160299804-3917e164-cf47-4e2b-b0f2-e1f71f3e0b8e.png)

Na tela de cadastro de caminhões, há uma condição quanto ao modelo, que devem ser aceitos somente dois tipos: FH e FM, então foi criado uma pagina para criação dos modelos, no qual possui um campo para bloqueio, permitindo somente utilizar os modelos ativos:

![WhatsApp Image 2022-03-25 at 20 35 18](https://user-images.githubusercontent.com/96745777/160299909-dda6fcfa-40d5-417e-bda6-10e14793531e.jpeg)

## Melhorias Futuras:
* Desempenho
* Front
* Testes
* Campo para foto do caminhão
* link para os detalhes técnicos, se for um HTTP
