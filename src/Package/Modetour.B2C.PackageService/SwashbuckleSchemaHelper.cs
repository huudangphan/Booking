namespace Modetour.B2C.PackageService

{
    public class SwashbuckleSchemaHelper

    {
        private Dictionary<string, int> _schemaNameRepetition;

        private Dictionary<string, string> _schemaNameResolved;

        public SwashbuckleSchemaHelper()

        {
            this._schemaNameRepetition = new();

            this._schemaNameResolved = new();
        }

        // borrowed from https://github.com/domaindrivendev/Swashbuckle.AspNetCore/blob/95cb4d370e08e54eb04cf14e7e6388ca974a686e/src/Swashbuckle.AspNetCore.SwaggerGen/SchemaGenerator/SchemaGeneratorOptions.cs#L44

        private string DefaultSchemaIdSelector(Type modelType)

        {
            if (!modelType.IsConstructedGenericType) return modelType.Name.Replace("[]", "Array");

            var prefix = modelType.GetGenericArguments()

            .Select(genericArg => DefaultSchemaIdSelector(genericArg))

            .Aggregate((previous, current) => previous + current);

            return prefix + modelType.Name.Split('`').First();
        }

        public string GetSchemaId(Type modelType)

        {
            string id = DefaultSchemaIdSelector(modelType);

            if (!this._schemaNameRepetition.ContainsKey(id))

                this._schemaNameRepetition.Add(id, 0);

            int count = this._schemaNameRepetition[id] + 1;

            this._schemaNameRepetition[id] = count;

            string resolvedName = $"{id}{(count > 1 ? count.ToString() : "")}";

            string fullName = modelType.FullName;

            if (!this._schemaNameResolved.ContainsKey(fullName))
            {
                this._schemaNameResolved.Add(fullName, resolvedName);

                return resolvedName;
            }
            else
            {
                return this._schemaNameResolved[fullName];
            }
        }
    }
}