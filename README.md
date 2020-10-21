# TriNote Desktop

Aplicação desktop desenvolvida em C# com chat em
tempo real e login personalizado.

![Dashboard](https://github.com/kevinsn/trinote-desktop-csharp/blob/master/.github/dashboard-admin.png)

## O que é?

TCC desenvolvido no técnico de Desenvolvimento
de Sistemas. Utilizado pelos colaboradores
para atender os usuários da plataforma TriNote.

## Tecnologias utilizadas

- C#
- SQL Server
- Azure (hospedada aplicação e banco SQL)

## Funcionalidades

- Sistema de chat (real-time), chamado e histórico de atendimento.
- Validador de anúncios no sistema.
- Integração com o aplicativo TriNote Web:
  - Chat em tempo real entre aplicativo Web e Desktop,
  - Anúncios cadastrados na plataforma Web serão validados na plataforma Desktop.
- Cadastro de funcionários com sistema de permissões, 4 tipos: 
  - Suporte (responsável pelo atendimento no chat),
  - Marketing (validação de anúncios), 
  - Gerência (cadastro de funcionários e visualização dos chats e anúncios), 
  - Administrador (todas as permissões de Gerência e possibilidade de edição de cadastro de funcionários).
- Dashboard personalizada de acordo com o tipo de permissão.

# Imagens

![Login](https://github.com/kevinsn/trinote-desktop-csharp/blob/master/.github/login.png)
![Chat](https://github.com/kevinsn/trinote-desktop-csharp/blob/master/.github/support.png)
![Ad](https://github.com/kevinsn/trinote-desktop-csharp/blob/master/.github/marketing.png)