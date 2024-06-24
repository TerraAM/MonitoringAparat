﻿namespace MonitoringAparat.Repository
{
    public class BaseRepository<T> : IRepository<T> where T : class
    {
        protected MonitContext context;

        public BaseRepository(MonitContext context)
        {
            this.context = context;
        }

        public async Task Create(T entity)
        {
            context.Add<T>(entity);
            await context.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            var e = context.Find<T>(id);
            context.Remove<T>(e);
            await context.SaveChangesAsync();
        }

        public async Task<T> Read(int id)
        {
            return await context.FindAsync<T>(id);
        }

        public async Task<IAsyncEnumerable<T>> ReadAll() =>
            (IAsyncEnumerable<T>)context.Set<T>();

        public async Task<IAsyncEnumerable<T>> ReadPage(int start, int count) =>
            (IAsyncEnumerable<T>)context.Set<T>().Skip(start).Take(count);

        public async Task Update(T entity)
        {
            context.Update<T>(entity);
            await context.SaveChangesAsync();
        }
    }
}

