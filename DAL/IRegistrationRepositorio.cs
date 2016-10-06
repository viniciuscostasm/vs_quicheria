using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace DAL
{
    public interface IRegistrationRepositorio : IRepositorio<Registration>
    {
    }

    /* Observe que não precisamos definir nenhum código na interface e classe acima  
     * pois estamos usando o mecanismo da herança e da implementação da interface e assim 
     * estamos usando os métodos definidos na interface IRepositorio e na classe Repositorio. 
     * Note também que estamos usando as entidades que foram separadas no projeto Model. */
}
