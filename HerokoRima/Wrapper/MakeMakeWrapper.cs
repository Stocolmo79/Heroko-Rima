﻿using System.Collections.Generic;
using System.Linq;

namespace HerokoRima.Wrapper
{
    public class MakeMakeWrapper
    {
        private readonly MakeMakeEntities mmEntities;
        public MakeMakeWrapper()
        {
            if (mmEntities == null)
            {
                mmEntities = new MakeMakeEntities();
            }
        }

        public List<tStaff> GetStaff()
        {
            return mmEntities.tStaffs.Select(m => m).ToList();
        }

        public List<tStaff> GetStaffByArea(int areaId)
        {
            var staffs = (from s in mmEntities.tStaffs
                          from sa in mmEntities.tStaffAreas
                          where s.Id == sa.StaffId && sa.AreaId == areaId
                          select s).ToList<tStaff>();
            return staffs;
        }

        public void SaveStaff(tStaff staff)
        {
            mmEntities.tStaffs.Add(staff);

            mmEntities.SaveChanges();
        }

        public void SaveStaff()
        {

            mmEntities.SaveChanges();
        }

        public void DeleteStaffArea(tStaffArea tStaffArea)
        {
            mmEntities.tStaffAreas.Remove(tStaffArea);

        }
        public void SaveStaffArea(tStaffArea tStaffArea)
        {
            mmEntities.tStaffAreas.Add(tStaffArea);
            mmEntities.SaveChanges();
        }

        #region Area

        public List<tArea> GetAreas()
        {
            return mmEntities.tAreas.Select(a => a).ToList();
        }

        #endregion

        public long SaveClass(tClass tClass)
        {
            mmEntities.tClasses.Add(tClass);
         mmEntities.SaveChanges();
            return tClass.ClassId;

        }

        public void SaveStaffClass(tStaffClass tStaffClass)
        {
            mmEntities.tStaffClasses.Add(tStaffClass);
            mmEntities.SaveChanges();
        }
    }
}