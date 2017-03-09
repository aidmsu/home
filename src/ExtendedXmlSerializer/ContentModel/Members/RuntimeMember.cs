// MIT License
// 
// Copyright (c) 2016 Wojciech Nag�rski
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

using ExtendedXmlSerialization.ContentModel.Xml;

namespace ExtendedXmlSerialization.ContentModel.Members
{
	class RuntimeMember : IRuntimeMember
	{
		readonly IMember _member;
		readonly IRuntimeWriter _writer;

		public RuntimeMember(IMember member, IRuntimeWriter writer)
		{
			_member = member;
			_writer = writer;
		}

		public object Get(IXmlReader parameter) => _member.Get(parameter);

		public void Write(IXmlWriter writer, object instance) => _member.Write(writer, instance);

		public IMemberAdapter Adapter => _member.Adapter;

		public bool IsSatisfiedBy(object parameter) => _writer.IsSatisfiedBy(parameter);

		public IWriter Property => _writer.Property;
	}
}