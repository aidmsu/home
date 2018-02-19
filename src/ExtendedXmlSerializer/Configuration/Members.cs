// MIT License
//
// Copyright (c) 2016-2018 Wojciech Nag�rski
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

using ExtendedXmlSerializer.Core.Sources;
using ExtendedXmlSerializer.ReflectionModel;
using System.Collections.Concurrent;
using System.Reflection;

namespace ExtendedXmlSerializer.Configuration
{
	sealed class Members : TableValueSource<MemberInfo, IMemberConfiguration>, IMembers
	{
		public static IParameterizedSource<ITypeConfiguration, IMembers> Default { get; }
			= new ReferenceCache<ITypeConfiguration, IMembers>(x => new Members(x));


		public Members(ITypeConfiguration element)
			: this(element, new ConcurrentDictionary<MemberInfo, IMemberConfiguration>(MemberComparer.Default)) {}

		public Members(ITypeConfiguration element, ConcurrentDictionary<MemberInfo, IMemberConfiguration> store)
			: base(new GenericMembers(element, element.Get().Get()).Get, store) {}
	}
}