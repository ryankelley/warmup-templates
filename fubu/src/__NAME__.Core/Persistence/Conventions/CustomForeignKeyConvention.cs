using System;
using FluentNHibernate;
using FluentNHibernate.Conventions;

namespace __NAME__.Core.Persistence.Conventions
{
    public class CustomForeignKeyConvention : ForeignKeyConvention
    {
        protected override string GetKeyName(Member property, Type type)
        {
            if (property == null)
                return type.Name + "_id";

            return property.Name + "_id";

        }
    }
}