using System;
using System.Threading.Tasks;

namespace Prototype.Domain.Contracts.SeedWork
{
    /// <summary>
    ///     Contract for UnitOfWork Pattern
    ///     It helps us save everything, user and his roles - or nothing, if something fails. Unit of Work is mostly
    ///     used when we want to get a set of actions happen, and if one action fails, to cancel all of them.
    ///     In general, Unit of Work has two important tasks:
    ///     to keep a list of requests in one place(the list can contain multiple insert, update, and delete requests),
    ///     and to send that requests as one transaction to the database.
    /// </summary>
    /// <seealso cref="System.IDisposable" />
    public interface IUnitOfWork : IDisposable
    {
        /// <summary>
        ///     Asynchronouses the commit.
        /// </summary>
        /// <returns></returns>
        public Task<int> DoAsyncCommit();

        /// <summary>
        ///     Commits this instance.
        /// </summary>
        public void Commit();

        /// <summary>
        ///     Rollbacks this instance.
        /// </summary>
        public void Rollback();
    }
}