using AsamaGlobal.ERP.Model.Entities.Base;

namespace AsamaGlobal.ERP.Bll.Interfaces
{
   public interface IBaseGenelBll
   {
       bool Insert(BaseEntity entity);
       bool Update(BaseEntity oldEntity, BaseEntity currentEntity);
       string YeniKodVer();

   }
}
