using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Prototype.Domain.Contracts.SeedWork;
using Prototype.Infrastructure.Data.Context;

namespace Prototype.Infrastructure.Data.repositories
{
    /// <summary>
    ///     Generic repository
    /// </summary>
    public class GenericRepository : IRepository
    {
        private readonly ProtoContext _context;

        /// <summary>
        ///     Instantiates a new Generic repository object.
        /// </summary>
        /// <param name="context"></param>
        public GenericRepository(IUnitOfWork context)
        {
            Console.WriteLine("GenericRepository : Instantiating generic repository");
            if (context == null) throw new ArgumentNullException(nameof(context));

            if (context is ProtoContext ctx) _context = ctx;
        }

        /// <summary>
        ///     Unit of work
        /// </summary>
        public IUnitOfWork UnitOfWork => _context;

        /// <summary>
        ///     Remove entity
        /// </summary>
        /// <typeparam name="TEntity">Type de l'entité</typeparam>
        /// <param name="entity"></param>
        public bool RemoveEntity<TEntity>(TEntity entity) where TEntity : Entity
        {
            Console.WriteLine("GenericRepository : Removing entity");
            var isDeleted = false;
            try
            {
                _context.Set<TEntity>().Remove(entity);
                _context.Commit();
                isDeleted = true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                isDeleted = false;
            }

            return isDeleted;
        }

        /// <summary>
        ///     Add entity
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="entity"></param>
        public void AddEntity<TEntity>(TEntity entity) where TEntity : class
        {
            Console.WriteLine("GenericRepository : Adding entity");
            if (entity == null) throw new ArgumentNullException(nameof(entity));

            _context.Set<TEntity>().Add(entity);

            _context.Commit();
        }

        /// <summary>
        ///     Get entity
        /// </summary>
        /// <typeparam name="TEntity">Type de l'entité</typeparam>
        /// <param name="id"></param>
        /// <returns></returns>
        public TEntity GetEntity<TEntity>(int id) where TEntity : class, IAggregateRoot, IEntity
        {
            Console.WriteLine("GenericRepository : Getting entity");
            return _context.Set<TEntity>().FirstOrDefault(w => w.Id == id);
        }

        /// <summary>
        ///     Get all the entities
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <returns></returns>
        public IEnumerable<TEntity> GetAll<TEntity>()
            where TEntity : class, IEntity
        {
            Console.WriteLine("GenericRepository : Getting all the entities");
            return _context.Set<TEntity>().AsEnumerable();
        }

        /// <summary>
        ///     Get entities by filter
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <typeparam name="TKey"></typeparam>
        /// <param name="predicate"></param>
        /// <param name="order"></param>
        /// <param name="ascending"></param>
        /// <returns></returns>
        public IEnumerable<TEntity> GetByFilter<TEntity, TKey>(Expression<Func<TEntity, bool>> predicate,
            Expression<Func<TEntity, TKey>> order, bool ascending) where TEntity : class, IEntity
        {
            Console.WriteLine("GenericRepository : Getting entities by filter");
            throw new NotImplementedException();
        }

        /// <summary>
        ///     Get entities by filter
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <typeparam name="TKey"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="selectResult"></param>
        /// <param name="predicate"></param>
        /// <param name="order"></param>
        /// <param name="ascending"></param>
        /// <returns></returns>
        public IEnumerable<TResult> GetByFilter<TEntity, TKey, TResult>(
            Expression<Func<TEntity, TResult>> selectResult,
            Expression<Func<TEntity, bool>> predicate,
            Expression<Func<TEntity, TKey>> order,
            bool ascending)
            where TEntity : class, IEntity
        {
            Console.WriteLine("GenericRepository : Getting entities by filter");
            //TKEY est le filtre order
            var objectSet = _context.Set<TEntity>();
            if (predicate == null) throw new ArgumentNullException();

            var query = objectSet.Where(predicate);
            if (ascending)
                query = query.OrderBy(order);
            else
                query = query.OrderByDescending(order);
            var result = query.Select(selectResult);
            return result.AsEnumerable();
        }

        /// <summary>
        ///     Gets entities by filter.
        /// </summary>
        /// <typeparam name="TEntity">The type of the entity.</typeparam>
        /// <typeparam name="TKey">The type of the key.</typeparam>
        /// <typeparam name="TResult">The type of the result.</typeparam>
        /// <param name="selectResult">The select result.</param>
        /// <param name="specification">The specification.</param>
        /// <param name="order">The order.</param>
        /// <param name="ascending">if set to <c>true</c> [ascending].</param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public virtual IEnumerable<TResult> GetByFilter<TEntity, TKey, TResult>(
            Expression<Func<TEntity, TResult>> selectResult,
            ISpecification<TEntity> specification,
            Expression<Func<TEntity, TKey>> order,
            bool ascending)
            where TEntity : class, IEntity
        {
            Console.WriteLine("GenericRepository : Getting entities by filter");
            //TKEY est le filtre order
            var objectSet = _context.Set<TEntity>();
            if (specification == null)
                throw new ArgumentNullException();
            //TODO : Log

            var query = objectSet.Where(specification.IsSatisfiedBy());

            if (ascending)
                query = query.OrderBy(order);
            else
                query = query.OrderByDescending(order);

            var result = query.Select(selectResult);

            return result.AsEnumerable();
        }
    }
}