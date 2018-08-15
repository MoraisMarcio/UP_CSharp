using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula1408_EntityFramework1
{
    /*
     * CONCEITOS
     * 
     * 1 – O que significa ORM?
     * 
     *  Mapeamento Objeto-Relacional (ORM) é um framework ou conjunto de classes que cria 
     *  uma ponte entre o modelo relacional e o modelo orientado a objetos, facilitando o 
     *  trato com as informações a serem armazenadas ou recuperadas no banco de dados. 

     * 2 – O que é o Entity Framework?
     * 
     *  É um framework objeto-relacional que permite que o .NET consiga trabalhar com 
     *  o banco de dados relacional usando seus objetos, eliminando o tempo que os 
     *  programadores perdiam montando as querys. 

     * 3 – Para que serve a classe contexto?
     * 
     *  Representa uma conexão de banco de dados e um conjunto de tabelas.
     *  Contexto contém os métodos e propriedades para comunicação de banco de dados.

     * 4 – O que é e para que serve o DbSet?
     * 
     *  É uma classe de pacote do Entity Framework que serve para mapear um objeto que 
     *  será relacionado ao banco de dados. Usado na configuração da classe de contexto.

     * 
     * INSTALANDO ENTITY FRAMEWORK
     * 
     *  > Botão direito no projeto > Gerenciador Pacotes do NuGet > Procurar > Entity Framework > Instalar
     * 
     * 
     * CRIANDO BASE ( ABORDAGEM: ModelFirst )
     * 
     *  > Botão direito no projeto > Novo item > Dados > ADO.NET Entity Data Model > Empty code "Model"
     *      
     *      - Criar Nova Entidade
     *  > Botão direito na tela em branco > Add New Entity
     *  
     *      - Criar Novo Relacionamento
     *  > Botão direito na tela em branco > Add New Association
     *  
     *      - Criar New Connection
     *  > Botão direito na tela em branco > Generate Database From Model > New Connection
     *  
     */
    public class Class1
    {
    }
}
