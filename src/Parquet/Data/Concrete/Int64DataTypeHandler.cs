﻿using System.IO;

namespace Parquet.Data.Concrete
{
   class Int64DataTypeHandler : BasicPrimitiveDataTypeHandler<long>
   {
      public Int64DataTypeHandler() : base(DataType.Int64, Thrift.Type.INT64)
      {
      }

      protected override long ReadSingle(BinaryReader reader, Thrift.SchemaElement tse, int length)
      {
         return reader.ReadInt64();
      }

      protected override void WriteOne(BinaryWriter writer, long value)
      {
         writer.Write(value);
      }
   }
}
