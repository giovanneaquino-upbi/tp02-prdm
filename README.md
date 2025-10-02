# CBTPRDM - Trabalho Prático 02

## Visão Geral do Projeto

Este repositório contém o código-fonte do Trabalho Prático 02. O projeto consiste em uma aplicação de lista de tarefas simples, desenvolvida utilizando o framework .NET MAUI para a criação de aplicativos multiplataforma (Android, iOS, macOS e Windows). O objetivo é criar uma aplicação que permita gerenciar tarefas, visualizar detalhes, editar e excluir tarefas existentes, além de adicionar novas tarefas através de um modal.

---

## Funcionalidades Implementadas

O aplicativo, chamado "TarefasApp", possui as seguintes características:

* **Página Inicial (Lista de Tarefas):**
  * Exibe uma lista de tarefas utilizando `ListView` ou `CollectionView`.
  * Cada item da lista deve incluir o título da tarefa e uma breve descrição.
* **Navegação Hierárquica:**
  * Ao tocar em um item da lista, o aplicativo navega para uma página de detalhes da tarefa.
* **Página de Detalhes da Tarefa:**
  *Exibe informações adicionais sobre a tarefa, como data de criação e prioridade.
  * **Botão "Editar":** Permite ao usuário editar os detalhes da tarefa. Ao tocar, abre um modal de edição para alterar título, descrição, data de criação e prioridade.
  * **Botão "Excluir":** Permite ao usuário excluir a tarefa. Ao tocar, exibe um diálogo de confirmação para garantir a intenção do usuário.
* **Adição de Novas Tarefas:**
  * Acessível por meio de um botão "Adicionar" na página inicial.
  * Ao tocar, abre um modal que permite ao usuário inserir um novo título, descrição, data de criação e prioridade para a nova tarefa.
* **Passagem de Dados:**
  * Utiliza o conceito de passagem de dados entre páginas para preencher os detalhes da tarefa na página de detalhes e para preencher os campos de edição e adição de tarefas nos modais.
* **Layout Agradável e Navegação Intuitiva:**
  * A aplicação foi desenvolvida com um layout amigável e uma navegação fácil de usar.

---

## Demonstração em Vídeo

Assista ao vídeo abaixo para ver a aplicação em funcionamento:

**Link direto:** [https://youtu.be/628Ap2aDuCA](https://youtu.be/628Ap2aDuCA)

---

Autores

Este projeto foi desenvolvido por:

* `Ricardo Oliani`
* `Giovanne Aquino`
