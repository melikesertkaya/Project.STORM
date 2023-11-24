using Project.CORE.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Project.CORE.DAL.Abstarct
{
    public interface IEntityRepository<T> where T : class, IEntity, new()
    {
        List<T> GetAllAsync();
        T Get(Expression<Func<T, bool>> filter);
    
        Task CreateAsync(T item);
        void UpdateAsync(T item);
        void DeleteAsync(T item);
        void Remove(Guid id);

        //T GetActiveAsync();
        //T GetPassiveAsync();
        //void PassiveAsync(T item);
        /// <summary>
        /// Toplu Async metotlar
        /// </summary>
        /// <param name="item"></param>
        Task CreateRange(List<T> item);
        void UpdateRange(List<T> item);
        void DeleteRange(List<T> item);

        List<T> Where(Expression<Func<T, bool>> exp); //Filter ı where ile arayacak bool dönecek

        bool Any(Expression<Func<T, bool>> exp); //True yada false yanıt yönecek List değil

        T FirstOrDefault(Expression<Func<T, bool>> exp); // T  yani verdiği model tipinde deger dönecek

        T Find(Guid id); //Metota id gönder sana modele dönecek

        // Task<T> MaxLength(Expression<Func<T, bool>> exp); //List tipinde data döeneceksin girdiğin değerlere göre
        // Task<T> MinLength(Expression<Func<T, bool>> exp); //List tipinde data döeneceksin girdiğin değerlere göre






    }
}
