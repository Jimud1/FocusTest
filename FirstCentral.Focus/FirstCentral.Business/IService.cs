using FirstCentral.Models.FocusModels;

namespace FirstCentral.Business
{
    public interface IService<T> where T : IModel
    {
        T Get();
        T GetById(int id);
        T Add(T obj);
        T Update(T obj);
        void Delete(int id);
        T GetByPolicyNumber(string policyNo);
    }
}
