using FirstCentral.Models.FocusModels;
using System.Collections.Generic;

namespace FirstCentral.Business
{
    public interface IService<T> where T : IModel
    {
        List<T> Get();
        T GetById(int id);
        T Add(T obj);
        T Update(T obj);
        void Delete(int id);
    }
}
