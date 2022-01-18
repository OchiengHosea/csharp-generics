using System;
using CSGenerics.Interfaces;

namespace CSGenerics.Entities

{
    public class EntityBase: IEntity
    {
        public int Id { get; set; }
    }
}