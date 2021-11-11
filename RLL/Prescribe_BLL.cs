using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model;
using DAL;

namespace BLL
{
   public class Prescribe_BLL
    {
       public string Bingli_Insert(Bingli bl)
       {
           int re = new Prescribe_DAL().Bingli_Insert(bl);
           if (re == 0)
               return "该病历已经存在";
           else if (re == 1)
               return "提交病历成功";
           else
               return "提交病历失败";
       }

       public string kaiyao_Insert(kaiyao ky)
       {
           int re = new Prescribe_DAL().kaiyao_Insert(ky);
           if (re == 0)
               return "该药方已经存在";
           else if (re == 1)
               return "提交药方成功";
           else
               return "提交药方失败";
       }

       public List<IdCard> SelectAll(int kid)
       {
           return new Prescribe_DAL().SelectAll(kid);
       }
    }
}
