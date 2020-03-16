using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ElectricSys.Entity;

namespace ElectricSys.IDAL
{
    public  interface IBaseService<T> : IDisposable where T : BaseEntity
    {
     /// <summary>
     /// 
     /// </summary>
     /// <param name="model"></param>
     /// <param name="saved"></param>
     /// <returns></returns>
        Task CreateAsync(T model, bool saved = true);
       /// <summary>
       /// 修改数据
       /// </summary>
       /// <param name="model"></param>
       /// <param name="saved"></param>
       /// <returns></returns>
        Task EditAsync(T model, bool saved = true);
      /// <summary>
      /// 通过id删除数据
      /// </summary>
      /// <param name="id"></param>
      /// <param name="saved"></param>
      /// <returns></returns>
        Task RemoveAsync(Guid id, bool saved = true);
      /// <summary>
      /// 通过泛型T删除数据
      /// </summary>
      /// <param name="model"></param>
      /// <param name="saved"></param>
      /// <returns></returns>
        Task RemoveAsync(T model, bool saved = true);
        /// <summary>
        /// 保存
        /// </summary>
        /// <returns></returns>
        Task Save();
         /// <summary>
         /// 通过id查询一条数据
         /// </summary>
         /// <param name="id"></param>
         /// <returns></returns>
        Task<T> GetOneByIdAsync(Guid id);
        /// <summary>
        /// 查询出所有的数据
        /// </summary>
        /// <returns></returns>
        IQueryable<T> GetAllAsync();
        /// <summary>
        /// 查询所有数据通过分页的方式展示
        /// </summary>
        /// <param name="pageSize"></param>
        /// <param name="pageIndex"></param>
        /// <returns></returns>
        IQueryable<T> GetAllByPageAsync(int pageSize = 10, int pageIndex = 0);
        /// <summary>
        /// 默认查询方式升序（ascend）展示,或者（desc）降序
        /// </summary>
        /// <param name="asc"></param>
        /// <returns></returns>
        IQueryable<T> GetAllOrderAsync(bool asc = true);
        /// <summary>
        /// 分页通过升序来展示
        /// </summary>
        /// <param name="pageSize"></param>
        /// <param name="pageIndex"></param>
        /// <param name="asc"></param>
        /// <returns></returns>
        IQueryable<T> GetAllByPageOrderAsync(int pageSize = 10, int pageIndex = 0, bool asc = true);



    }
}
