using System;
using System.Collections.Generic;
using WebAPIOO.contracts;

namespace WebAPIOO.concrete
{
    public class RootGroup : IRootGroup
    {
        private readonly Dictionary<Type, ISubGroup> _subGroups;
        private readonly Uri _rootUri;
        private const string _apiPrefix = "http://machine/RootGroup";

        public RootGroup(IHttpRoot httpRoot)
        {
            _rootUri = new Uri(_apiPrefix);

            _subGroups = new Dictionary<Type, ISubGroup>();
            InitializeAllGroups(_rootUri, httpRoot);
        }

        private void InitializeAllGroups(Uri rootUri, IHttpRoot httpRoot)
        {
            _subGroups[typeof(WebsiteGroup)] = new WebsiteGroup(rootUri, httpRoot);
        }

        public ISubGroup GetSubGroup<T>()
        {
            return _subGroups[typeof(T)];
        }
    }
}
