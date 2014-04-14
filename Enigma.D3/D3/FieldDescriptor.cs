﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Enigma.D3.Enums;

namespace Enigma.D3
{
	public class FieldDescriptor : MemoryObject
	{
		public const int SizeOf = 0x8C; // = 140

		public FieldDescriptor(ProcessMemory memory, int address)
			: base(memory, address) { }

		public string x00_Name { get { return Dereference(0x00, 256); } } // Max length unknown
		public ValueTypeDescriptor x04_Type { get { return Dereference<ValueTypeDescriptor>(0x04); } }
		public int x08_Offset { get { return Field<int>(0x08); } }
		public int x0C_DefaultValuePtr { get { return Field<int>(0x0C); } }
		public int x10_Min { get { return Field<int>(0x10); } }
		public int x14_Max { get { return Field<int>(0x14); } }
		public int x18 { get { return Field<int>(0x18); } }
		public ValueTypeDescriptor x1C_BaseType { get { return Dereference<ValueTypeDescriptor>(0x1C); } }
		public int x20 { get { return Field<int>(0x20); } }
		public int x24_ArrayLength { get { return Field<int>(0x24); } } // -1 if not an array
		public int x28 { get { return Field<int>(0x28); } }
		public int x2C { get { return Field<int>(0x2C); } }
		public SnoGroupId x30_SnoType { get { return (SnoGroupId)Field<int>(0x30); } } // -1 if no SNO type
		public int x34 { get { return Field<int>(0x34); } }
		public int x38_SymbolTable { get { return Field<int>(0x38); } } // Used for DT_ENUM
		public int x3C { get { return Field<int>(0x3C); } }
		public int x40 { get { return Field<int>(0x40); } }
		public int x44 { get { return Field<int>(0x44); } }
		public int x48 { get { return Field<int>(0x48); } }
		public string x4C_Text { get { return Field(0x4C, 64); } } // Always empty
	}
}
