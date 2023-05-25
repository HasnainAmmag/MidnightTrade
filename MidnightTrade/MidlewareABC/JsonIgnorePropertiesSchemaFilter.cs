using System;
using System.Linq;
using System.Reflection;
using System.Text.Json.Serialization;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;

public class JsonIgnorePropertiesSchemaFilter : ISchemaFilter
{
    public void Apply(OpenApiSchema schema, SchemaFilterContext context)
    {
        var ignoredProperties = context.Type.GetProperties()
            .Where(p => p.GetCustomAttribute<JsonIgnoreAttribute>() != null)
            .Select(p => char.ToLowerInvariant(p.Name[0]) + p.Name.Substring(1));

        foreach (var propertyName in ignoredProperties)
        {
            if (schema.Properties.ContainsKey(propertyName))
                schema.Properties.Remove(propertyName);
        }
    }
}