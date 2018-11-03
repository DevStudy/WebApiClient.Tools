﻿using NJsonSchema.CodeGeneration.CSharp;
using NSwag;
using NSwag.CodeGeneration.CSharp;
using NSwag.CodeGeneration.CSharp.Models;

namespace WebApiClient.Tools.Swagger
{
    public class HttpApiOperation : CSharpOperationModel
    {
        public HttpApiOperation(SwaggerOperation operation, SwaggerToCSharpGeneratorSettings settings, SwaggerToCSharpGeneratorBase generator, CSharpTypeResolver resolver)
            : base(operation, settings, generator, resolver)
        {
        }

        public override string ResultType
        {
            get
            {
                return SyncResultType == "void"
                    ? "ITask<HttpResponseMessage>"
                    : $"ITask<{SyncResultType}>";
            }
        }
    }
}