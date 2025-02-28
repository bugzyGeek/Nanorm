﻿using Npgsql;

namespace Nanorm.Npgsql;

#if NET7_0_OR_GREATER
/// <summary>
/// Interface for statically creating an instance of <typeparamref name="T"/> from an <see cref="NpgsqlDataReader"/>.
/// </summary>
/// <typeparam name="T">The type that the implementer of <see cref="IDataReaderMapper{T}"/> can create instances of.</typeparam>
public interface IDataReaderMapper<T> where T : IDataReaderMapper<T>
{
    /// <summary>
    /// Maps the <paramref name="dataReader"/> to an instance of <typeparamref name="T"/>.
    /// </summary>
    /// <param name="dataReader">The <see cref="NpgsqlDataReader"/>.</param>
    /// <returns>A new instance of <typeparamref name="T"/>.</returns>
#pragma warning disable CA1000 // Do not declare static members on generic types
    abstract static T Map(NpgsqlDataReader dataReader);
#pragma warning restore CA1000 // Do not declare static members on generic types
}
#endif
