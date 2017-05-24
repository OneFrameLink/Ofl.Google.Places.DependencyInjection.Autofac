using System;
using Autofac;

namespace Ofl.Google.Places.DependencyInjection.Autofac
{
    public class DefaultModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            // Validate parameters.
            if (builder == null) throw new ArgumentNullException(nameof(builder));

            // Bind.
            builder.RegisterType<PlacesClient>().As<IPlacesClient>();
        }
    }
}
