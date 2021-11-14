using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Entities
{
    public interface IEntity
    {

    }
    public interface IEntity<T>:IEntity where T:struct
    {
        public T Id { get; set; }
    }
}
