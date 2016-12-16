﻿// MIT License
// 
// Copyright (c) 2016 Wojciech Nagórski
//                    Michael DeMond
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in all
// copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
// SOFTWARE.

using System;
using System.Collections.Immutable;
using System.IO;
using System.Xml;
using ExtendedXmlSerialization.Elements;
using ExtendedXmlSerialization.Extensibility.Write;
using ExtendedXmlSerialization.Sources;

namespace ExtendedXmlSerialization.ProcessModel.Write
{
    /*public class SerializationFactory : ISerializationFactory
    {
        private readonly ISerializationToolsFactoryHost _services;
        /*private readonly INamespaceLocator _locator;
        private readonly INamespaces _namespaces;#1#

        public SerializationFactory(
            ISerializationToolsFactoryHost services/*,
            INamespaceLocator locator,
            INamespaces namespaces#1#
        )
        {
            _services = services;
            /*_locator = locator;
            _namespaces = namespaces;#1#
        }

        public ISerialization Get(Stream parameter)
        {
            var settings = new XmlWriterSettings {NamespaceHandling = NamespaceHandling.OmitDuplicates, Indent = true};
            var xmlWriter = XmlWriter.Create(parameter, settings);

            var writer = new Writer(xmlWriter);

            /*var emitter = new NamespaceEmitter(xmlWriter);
            var services = new InstanceServices(writer, emitter);#1#
            //var root = new RootContextFactory(services);
            /*var controller = new ContextController();
            var factory = new ScopeFactory(controller);
            var result = new Serialization(controller, factory, new Emitter(writer), 
                                           /*services:#2# _services, writer, xmlWriter);
            return result;#1#
            return null;
        }
    }*/

    /*public interface IScopeFactory
    {
        IScope Create(object instance);
    }

    class ScopeFactory : IScopeFactory
    {
        private readonly IContextController _controller;
        /*private readonly IParameterizedSource<object, IScope> _root;
        private readonly IParameterizedSource<object, IScope> _instance;
        private readonly IParameterizedSource<object, IScope> _members;
        private readonly IParameterizedSource<object, IScope> _member;#1#

        public ScopeFactory(
            IContextController controller/*,
            IParameterizedSource<object, IScope> root,
            IParameterizedSource<object, IScope> instance,
            IParameterizedSource<object, IScope> members,
            IParameterizedSource<object, IScope> member#1#
        )
        {
            _controller = controller;
            /*_root = root;
            _instance = instance;
            _members = members;
            _member = member;#1#
        }

        public IScope Create(object instance)
        {
            /*var definition = instance as IMemberDefinition;
            if (definition != null)
            {
                // return new MemberScope(this, _monitor.Current, definition); // _member.Get(instance);
            }

            /*if (instance is IImmutableList<IMemberDefinition>)
            {
                return _members.Get(instance);
            }
            var factory = _monitor.Current.Parent == null ? _root : _instance;
            var result = factory.Get(instance);
            return result;#2#
            return null;#1#
        }
    }

    public interface IInstanceServices : IWriter, INamespaceLocator, INamespaceEmitter {}

    class InstanceServices : IInstanceServices
    {
        private readonly IWriter _writer;
        private readonly INamespaceLocator _locator;
        private readonly INamespaceEmitter _emitter;

        public InstanceServices(IWriter writer, INamespaceEmitter emitter) : this(writer, emitter, DefaultNamespaceLocator.Default) {}

        public InstanceServices(IWriter writer, INamespaceEmitter emitter, INamespaceLocator locator)
        {
            _writer = writer;
            _emitter = emitter;
            _locator = locator;
        }

        public void Dispose() => _writer.Dispose();
        public void Begin(string elementName, Uri identifier = null) => _writer.Begin(elementName, identifier);
        public void EndElement() => _writer.EndElement();
        public void Emit(string text) => _writer.Emit(text);

        public void Emit(string attribute, string value, Uri identifier = null, string prefix = null)
            => _writer.Emit(attribute, value, identifier, prefix);

        public void Emit(string attribute, Uri identity, string name, string value)
            => _writer.Emit(attribute, identity, name, value);

        public Uri Locate(object candidate) => _locator.Locate(candidate);
        public void Execute(object instance) => _emitter.Execute(instance);
    }


    class RootContextFactory : IParameterizedSource<object, IScope>
    {
        private readonly IInstanceServices _services;

        public RootContextFactory(IInstanceServices services)
        {
            _services = services;
        }

        public IScope Get(object parameter) => new RootScope(_services, parameter);
    }*/
}