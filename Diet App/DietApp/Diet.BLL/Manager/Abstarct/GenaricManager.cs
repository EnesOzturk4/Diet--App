using AutoMapper;
using AutoMapper.Extensions.ExpressionMapping;
using Diet.DAL.Entites.Abstract;
using Diet.DAL.Repository.Abstract;
using System.Linq.Expressions;


namespace Diet.BLL.Manager.Abstarct
{
    public class GenaricManager<TModel, TEntity> : IGenaricManager<TModel>
                                   where TModel : class, new()
                                  where TEntity : BaseEntity, new()
    {
        private IMapper _mapper;
        protected IGenericRepository<TEntity> _repository;
        public GenaricManager()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddExpressionMapping();
                cfg.CreateMap<TModel, TEntity>().ReverseMap();
            });
            _mapper = new Mapper(config);
        }
        public void Add(TModel obj)
        {
            TEntity entity = _mapper.Map<TEntity>(obj);

            _repository.Add(entity);
        }

        public void Delete(TModel obj)
        {
            TEntity entity = _mapper.Map<TEntity>(obj);

            _repository.Delete(entity);
        }

        public ICollection<TModel> GetAll()
        {
            ICollection<TEntity> entities = _repository.GetAll();

            ICollection<TModel> models = new List<TModel>();
            foreach (TEntity entitiy in entities)
            {
                TModel model = _mapper.Map<TModel>(entitiy);
                models.Add(model);
            }
            return models;
        }

        public TModel GetById(int id)
        {
            TEntity entity = _repository.GetById(id);
            TModel model = _mapper.Map<TModel>(entity);
            return model;
        }

        public void Remove(TModel obj)
        {
            TEntity model = _mapper.Map<TEntity>(obj);
            _repository.Remove(model);
        }



        public ICollection<TModel> Search(Expression<Func<TModel, bool>> perdicate)
        {
            Expression<Func<TEntity, bool>> predicateEntity =
                _mapper.Map<Expression<Func<TEntity, bool>>>(perdicate);
            List<TEntity> entities = _repository.Search(predicateEntity);
            List<TModel> models = new List<TModel>();
            foreach (var entity in entities)
            {
                TModel model = _mapper.Map<TModel>(entity);
                models.Add(model);
            }
            return models;
        }

        public void Update(TModel obj)
        {
            TEntity entity = _mapper.Map<TEntity>(obj);
            _repository.Update(entity);
        }
    }
}
