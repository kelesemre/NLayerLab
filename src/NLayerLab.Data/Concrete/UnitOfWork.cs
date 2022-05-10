using NLayerLab.Data.Abstract;
using NLayerLab.Data.Concrete.EntityFramework.Contexts;
using NLayerLab.Data.Concrete.EntityFramework.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayerLab.Data.Concrete
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly NLayerLabContext _context;

        private EfArticleRepository _articleRepository;
        private EfCategoryRepository _categotyRepository;
        private EfCommentRepository _commentRepository;
        private EfRoleRepository _roleRepository;
        private EfUserRepository _userRepository;

        public UnitOfWork(NLayerLabContext context)
        {
            _context = context;
        }

        // if we need Articles, the program returns initialized object if it is null
        public IArticleRepository Articles => _articleRepository ?? new EfArticleRepository(_context);

        public ICategoryRepository Categories => _categotyRepository ?? new EfCategoryRepository(_context);

        public ICommentRepository Comments => _commentRepository ?? new EfCommentRepository(_context);

        public IRoleRepository Roles => _roleRepository ?? new EfRoleRepository(_context);

        public IUserRepository Users => _userRepository ?? new EfUserRepository(_context);

        public async ValueTask DisposeAsync()
        {
            await _context.DisposeAsync();
        }

        public async Task<int> SaveAsync()
        {
            return await _context.SaveChangesAsync();
        }
    }
}
