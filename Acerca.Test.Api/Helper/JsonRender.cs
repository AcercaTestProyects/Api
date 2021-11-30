using System.IO;
using System.Text.Json;

namespace Acerca.Test.Api.Helper
{
    public static class JsonRender
    {
        public static string GetJsonData(string configuration)
        {
            return new StreamReader(configuration).ReadToEnd();
        }
    }
}