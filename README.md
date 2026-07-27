Unity Inventory System (Basic)
Um sistema de inventário desenvolvido em Unity utilizando C#, criado inicialmente a partir de um curso e posteriormente refatorado para se tornar um template reutilizável em diferentes projetos.
Funcionalidades
    • Coleta de itens por interação.
    • Sistema de inventário baseado em Scriptable Objects.
    • Interface de inventário com ícones.
    • Utilização dos itens.
    • Descarte (Drop) de itens na cena.
    • Sistema de pilha (Stack) de itens.
    • Contador de quantidade em cada slot.
    • Atualização automática da interface através de Delegates e Events.
    • Sistema preparado para criação de novos tipos de itens.

Tecnologias
    • Unity 6
    • C#
    • ScriptableObject
    • Delegate
    • Event

Estrutura do Projeto
Item (ScriptableObject)
Cada item do jogo é um ScriptableObject contendo informações como:
    • Nome
    • Ícone
    • ID
    • Prefab utilizado para Drop
    • Comportamento próprio através do método Use()
Essa estrutura permite criar novos itens sem alterar o sistema do inventário.

InventoryItem
Classe responsável por armazenar:
    • Referência ao Item
    • Quantidade daquele item no inventário
Separar essas informações evita modificar diretamente o ScriptableObject, permitindo que vários jogadores ou saves utilizem o mesmo Item mantendo quantidades diferentes.

InventoryCod
Responsável por:
    • Adicionar itens
    • Remover itens
    • Utilizar itens
    • Controlar a lista do inventário
    • Atualizar a interface através de eventos
Também realiza:
    • Empilhamento automático de itens iguais.
    • Instanciação do prefab correto ao descartar um item.

InventoryUI
Atualiza automaticamente os slots do inventário sempre que ocorre qualquer alteração.
A atualização acontece utilizando Delegates e Events.

InventorySlot
Cada slot possui:
    • Ícone
    • Quantidade
    • Botão de descarte
    • Uso do item

Sistema de Stack
Ao coletar um item:
    • Caso ele já exista no inventário, sua quantidade é incrementada.
    • Caso não exista, um novo slot é criado.
Exemplo:
Poção x1
↓
Coletar outra Poção
↓
Poção x2

Uso dos Itens
Cada Item pode sobrescrever o método:
public override void Use()
{
}
Isso permite criar diversos tipos de itens apenas herdando da classe base.
Exemplos:
    • HealItem
    • ManaItem
    • BuffItem
    • KeyItem
    • QuestItem

Melhorias implementadas em relação ao projeto original
Durante o desenvolvimento foram realizadas algumas melhorias em relação ao sistema apresentado no curso:
    • Sistema de Stack de itens.
    • Contador de quantidade por slot.
    • Remoção da necessidade de cadastrar Prefabs em um array no Inventory.
    • Cada Item conhece seu próprio Prefab de Drop.
    • Estrutura preparada para novos tipos de itens através de herança.
    • Código simplificado e mais reutilizável.

Próximas melhorias
    • Limite máximo por pilha.
    • Salvamento do inventário.
    • Sistema de equipamentos.

Uso de Inteligência Artificial no Desenvolvimento
Durante o desenvolvimento deste sistema, ferramentas de Inteligência Artificial foram utilizadas como apoio no processo de programação, principalmente para:
    • Auxílio na identificação e correção de bugs.
    • Análise de estrutura de código.
    • Implementação e revisão de funcionalidades.
Entre as melhorias desenvolvidas com esse apoio estão:
    • Sistema de empilhamento de itens iguais, permitindo que itens repetidos sejam armazenados em um único slot com controle de quantidade.
    • Sistema de descarte de itens mantendo a quantidade correta, permitindo que uma pilha de itens seja removida do inventário e recriada na cena preservando seu valor de quantidade.
A utilização da IA fez parte do processo de desenvolvimento como uma ferramenta de pesquisa, revisão e aprendizado, enquanto a arquitetura, decisões de implementação e integração das funcionalidades foram realizadas no projeto.

Objetivo
Este projeto foi desenvolvido como estudo de arquitetura de sistemas de inventário para Unity, servindo como um template reutilizável em futuros jogos.
O foco foi criar um código simples, organizado e fácil de expandir, aplicando conceitos como Scriptable Objects, Delegates, Events e Programação Orientada a Objetos.
O projeto também teve como objetivo praticar a criação de sistemas escaláveis, buscando uma estrutura que permita adicionar novos tipos de itens e funcionalidades sem grandes alterações no código principal.

