using FluentNHibernate.Conventions;
using FluentNHibernate.Conventions.Instances;

namespace __NAME__.Core.Persistence
{
    public class CustomReferencesConvention : IReferenceConvention
    {
        public void Apply(IManyToOneInstance instance)
        {
            instance.Cascade.SaveUpdate();
            instance.ForeignKey("fk_" + instance.Property.DeclaringType.Name + "_to_" + instance.Property.Name);
        }
    }
}