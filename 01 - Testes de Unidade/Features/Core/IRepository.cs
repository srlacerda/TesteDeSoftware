using System;
using System.Collections.Generic;
using System.Text;

namespace Features.Core
{
    public interface IRepository<T> where T: Entity
    //public interface IRepository<T> where T : Entity, IDisposable
    {
        void Adicionar(T entidade);
        void Atualizar(T entidade);
        void Remover(Guid guid);
        IEnumerable<T> ObterTodos();
        void Dispose();
    }
}
