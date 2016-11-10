using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Data.Entity;

namespace DAL
{
    // classe chamada Repositorio que irá implementar a nossa interface
    public class Repositorio<T> : IRepositorio<T> , IDisposable where T : class
    {
        /* Aqui estamos referenciando o contexto representando por RMS_DBEntities na variável Context 
         * e criando uma nova instância do contexto. Tudo depende do contexto e vamos usar sua 
         * referência em todos os métodos para acessar as entidades no Entity Data Model. */

        private CadastroEntities Context;
        protected Repositorio()
        {
            Context = new CadastroEntities();
        }

        /* O método GetTodos() recebe uma entidade (uma classe) e retorna um IQueryable,  
         * ou seja uma lista completa das entidades. (Aqui o método Set<T> do contexto 
         * retorna uma instância instância DbSet<T> para o acesso a entidades de determinado 
         * tipo no contexto.) */

        public IQueryable<T> GetTodos()
        {
            return Context.Set<T>();
        }

        /* O método Get() usa um delegate Func<> como parâmetro de entrada, onde será 
         * usada uma expressão lambda (Ex: p => p.ProductID == ProductID) como critério, 
         * e, um predicate para validar o critério usando a cláusula Where. 
         * O retorno será uma lista IQueryable. */

        public IQueryable<T> Get(Expression<Func<T, bool>> predicate)
        {
            return  Context.Set<T>().Where(predicate);
        }

        /* O método Find() realiza uma busca pela chave primária. 
         * O parâmetro de entrada é um array de objetos. O método localiza uma entidade 
         * com os valores indicados na chave primária. Se a entidade existir no contexto, 
         * então ela é devolvida imediatamente. Caso contrário, é feita uma solicitação à base. 
         * Se nenhuma entidade for encontrada no contexto ou na base, então é retornado null. */

        public T Find(params object[] key)
        {
            return Context.Set<T>().Find(key);
        }


        /* O método First() usa uma expressão com o delegate Func<> como entrada, 
         * aqui usei uma expressão lambda que será validada pelo predicate usando a cláusula Where. 
         * FirstOrDefault() garante que será retornado o primeiro elemento da seqüência que satisfaça 
         * a condição definida na expressão lambda ou o valor padrão se nenhum elemento for encontrado. */

        public T First(Expression<Func<T, bool>> predicate)
        {
            return Context.Set<T>().Where(predicate).FirstOrDefault();
        }

        /* O método Adicionar() recebe uma entidade e usando o método Add() 
         * do contexto inclui a entidade no contexto. (O Entity Framework cria uma instrução SQL Insert).
         * Podemos incluir diversas entidades de uma vez. Neste cenário estou trabalhando na memória. 
         * Para persistir no banco de dados devemos o método SaveChanges(). */

        public void Adicionar(T entity)
        {
            Context.Set<T>().Add(entity);
        }

        /* O método Atualizar() recebe uma entidade e define o seu EntityState como Modified 
         * informando ao contexto que a entidade foi alterada. */

        public void Atualizar(T entity)
        {
            Context.Entry(entity).State = EntityState.Modified;
        }

        /* O método Deletar() usa como parâmetro de entrada um delegate Func<>, 
         * onde foi usada uma expressão lambda, que foi validada pelo predicate usando a cláusula Where(). 
         * Usei o método Remove do contexto com uma expressão lambda (del => Context.Set<T>().Remove(del)) 
         * em um .ForEach(), o efeito disso é que ele irá varrer a lista retornada e irá remover todos os 
         * itens que atendem ao critério definido para remoção. */

        public void Deletar(Func<T, bool> predicate)
        {
            Context.Set<T>()
           .Where(predicate).ToList()
           .ForEach(del => Context.Set<T>().Remove(del));
        }

        /* O método Commit() é um dos mais importantes porque ele usa o método SaveChanges() 
         * do contexto para persistir no banco de dados as inclusões, exclusões e alterações 
         * feitas no contexto que ainda estão na memória. Quando trabalhamos com o Contexto e 
         * seus métodos esta trabalhando na memória. O método SaveChanges() efetiva todas as 
         * operações gravando-as no banco de dados. Assim quando você trabalha na memória pode 
         * ter muitas entidades em diversos estados, e quando usa o SaveChanges() elas serão 
         * efetivamente gravadas no banco de dados. */
        public void Commit()
        {
            Context.SaveChanges();
        }


        /* O método Dispose() implementa a interface IDisposable e verifica se o 
         * contexto não é nulo para liberar recursos usados. */

        public void Dispose()
        {
            if (Context != null)
            {
                Context.Dispose();
            }
            GC.SuppressFinalize(this);
        }
    }
}
