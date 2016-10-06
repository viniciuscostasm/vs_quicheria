using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    /*
     * Vamos definir os métodos na nossa interface que deverão ser implementados para realizar 
     * o acesso e persistência dos dados na camada de acesso a dados. Lembrando que uma interface 
     * é um contrato que define como uma classe deve ser implementada, assim vamos definir assinaturas 
     * de métodos que deverão implementados por qualquer classe que desejar usar a nossa interface.
     */
    public interface IRepositorio<T> where T : class
    {

        IQueryable<T> GetTodos(); /* Este método retorna todos os dados como IQueryable;
                                   * Dessa forma podemos retornar a lista e aplicar expressões lambdas para filtrar e classificar os dados */
        IQueryable<T> Get(Expression<Func<T, bool>> predicate);  /* Retorna os dados que atendem o critério informado em tempo de execução via expressão lambada.
                                                                  * Estamos usando o delegate Func, e aplicando o predicate para verificar 
                                                                  * se o dado atende o critério (retorna true ou false); */
        T Find(params object[] key); // Recebe um array de objetos e efetua a pesquisa pela chave primária
        T First(Expression<Func<T, bool>> predicate); // Retorna o primeiro dado que atende o critério informado via expressão lambda.
        void Adicionar(T entity); // Recebe o objeto T para realizar a inclusão no banco de dados.
        void Atualizar(T entity); // Recebe o objeto T para realizar a atualização no banco de dados.
        void Deletar(Func<T, bool> predicate); // Excluir registros usando uma condição definida na expressão lambda (via delegate Func)
        void Commit(); /* Chama o método ChaveChanges() do contexto para efetivar todas as alterações realizadas no contexto. 
                          Ao final de cada operação você deve sempre chamar este método para efetivar as operações que foram 
                          feitas na memória no banco de dados. Se não fizer isso irá perder todas as operações realizadas; */
        void Dispose(); // Executa a limpeza dos objetos;
    }
}
