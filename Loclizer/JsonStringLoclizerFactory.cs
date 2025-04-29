using Microsoft.Extensions.Localization;

namespace STEELCafe.Loclizer
{
    public class JsonStringLoclizerFactory : IStringLocalizerFactory
    {
        public IStringLocalizer Create(Type resourceSource)
        {
            return new JsonStringLoclizer();
        }

        public IStringLocalizer Create(string baseName, string location)
        {
            return new JsonStringLoclizer();
        }
    }
}
