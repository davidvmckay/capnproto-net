﻿using System;

namespace CapnProto
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Field
        | AttributeTargets.Enum | AttributeTargets.Module, AllowMultiple = false, Inherited = false)]
#if FULLCLR
    [System.ComponentModel.ImmutableObject(true)]
#endif
    public sealed class IdAttribute : Attribute
    {
        public IdAttribute(ulong id, string name = null)
        {
            this.Id = id;
            this.Name = name;
        }
        public ulong Id { get; private set; }

        public string Name { get; private set; }
    }
}
