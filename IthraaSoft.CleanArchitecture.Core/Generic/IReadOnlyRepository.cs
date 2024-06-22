using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace IthraaSoft.CleanArchitecture.Core.Generic;

public interface IReadOnlyRepository<T> where T : class, IEntity
{
    /// <summary>
    /// Finds an entity with the given primary key value.
    /// </summary>
    /// <typeparam name="TId">The type of primary key.</typeparam>
    /// <param name="id">The value of the primary key for the entity to be found.</param>
    /// <param name="cancellationToken"></param>
    /// <returns>
    /// A task that represents the asynchronous operation.
    /// The task result contains the <typeparamref name="T" />, or <see langword="null"/>.
    /// </returns>
    Task<T?> GetByIdAsync<TId>(TId id, CancellationToken cancellationToken = default) where TId : notnull;

    /// <summary>
    /// Finds all entities of <typeparamref name="T" /> from the database.
    /// </summary>
    /// <returns>
    /// A task that represents the asynchronous operation.
    /// The task result contains a <see cref="List{T}" /> that contains elements from the input sequence.
    /// </returns>
    Task<List<T>> ListAsync(CancellationToken cancellationToken = default);

    /// <summary>
    /// Returns the total number of records.
    /// </summary>
    /// <returns>
    /// A task that represents the asynchronous operation. The task result contains the
    /// number of elements in the input sequence.
    /// </returns>
    Task<int> CountAsync(CancellationToken cancellationToken = default);
}
