using System;
using System.Collections.Generic;
using WebAPIOO.contracts;

namespace WebAPIOO.concrete
{
    public class WebsiteGroup : EntityBase, ISubGroup
    {
        private const string _websiteGroupName = "WebsiteGroup";
        private readonly Dictionary<Type, IWebsiteOperation> _operatins;

        public WebsiteGroup(Uri parentUri, IHttpRoot httpRoot)
            : base (parentUri)
        {
            _operatins = new Dictionary<Type, IWebsiteOperation>();
            InitializeWebsiteGroupOperation(GetUri(), httpRoot);
        }

        public T GetOperation<T>()
        {
            return (T)_operatins[typeof(T)];
        }

        private Uri GetUri()
        {
            return GetNewUri(_websiteGroupName);
        }

        private void InitializeWebsiteGroupOperation(Uri parentUri, IHttpRoot httpRoot)
        {
            _operatins[typeof(WebsiteListOperation)] = new WebsiteListOperation(parentUri, httpRoot);

            // add more operations here..
        }
 
    }
}
