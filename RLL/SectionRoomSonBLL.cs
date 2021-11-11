using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model;
using DAL;

namespace BLL
{
    public class SectionRoomSonBLL
    {
        public string Son(SectionRoomSo s)
        {
          return  new SectionRoomSonDAL().SonInsert(s);
        }
        public List<SectionRoomSo> Section()
        {
            return new SectionRoomSonDAL().SectionRoomSonCheck();
        }
        public string SonDelet(SectionRoomSo s)
        {
            return new SectionRoomSonDAL().SonDelteDal(s);
        }
    }
}
