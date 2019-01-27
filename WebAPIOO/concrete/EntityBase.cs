using System;

namespace WebAPIOO.concrete
{
    public class EntityBase
    {
        private readonly Uri _parentUri;

        public EntityBase(Uri parentUri)
        {
            _parentUri = parentUri;
        }

        public Uri GetNewUri(string childName)
        {
            string path = $"{_parentUri.AbsolutePath}/{childName}";
            UriBuilder uriBuilder = new UriBuilder(_parentUri.Scheme, _parentUri.Host, _parentUri.Port, path);

            return uriBuilder.Uri;
        }
    }
}
