using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Globalization;
using System.Linq;

namespace Classes.Wrapper
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

        public List<tStaff> GetStaffsList()
        {
            return mmEntities.tStaffs.Select(m => m).ToList();
        }

        public tStaff GetStaff(int staffId)
        {
            return mmEntities.tStaffs.FirstOrDefault(s => s.Id == staffId);
        }
        public List<tStaff> GetStaffByArea(int areaId)
        {
            return (from s in mmEntities.tStaffs
                    from sa in mmEntities.tStaffAreas
                    where s.Id == sa.StaffId && sa.AreaId == areaId
                    select s).ToList<tStaff>();

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
        #region Class

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

        public DbSet<tClass> GetClasses()
        {

            return mmEntities.tClasses;
        }

        public DbSet<tStaffClass> GetStaffClasses()
        {

            return mmEntities.tStaffClasses;
        }
        #endregion


        #region Members

        public long SaveMember(tMember tMember)
        {
            mmEntities.tMembers.AddOrUpdate(tMember);
            mmEntities.SaveChanges();
            return tMember.MemberId;
        }

        public tMember GetMember(string input)
        {
            return (from m in mmEntities.tMembers where m.Firstname == input || m.MemberId.ToString() == input select m).FirstOrDefault();
        }

        #endregion

        #region Cards

        public void SaveCard(tCard tCard)
        {
            mmEntities.tCards.AddOrUpdate(tCard);
            mmEntities.SaveChanges();
        }
        public tCard GetCardInfo(long cardnumber)
        {
            return mmEntities.tCards.FirstOrDefault(s => s.CardId == cardnumber);
        }

        public void CardUsage(tCardUsage tCardUsage)
        {
            mmEntities.tCardUsages.Add(tCardUsage);
            mmEntities.SaveChanges();
        }

        public tType GetCardType(int typeId)
        {
            return mmEntities.tTypes.FirstOrDefault(t => t.TypeId == typeId);
        }

        public DbSet<tType> GetCardTypes()
        {
            return mmEntities.tTypes;
        }

        public void SaveType(tType type)
        {
            mmEntities.tTypes.Add(type);
            mmEntities.SaveChanges();
        }


        public IQueryable<tCardUsage> GetCardUsage(long input)
        {
            var query = mmEntities.tCards.Join(mmEntities.tCardUsages, c => c.CardId,
      cm => cm.CardId, (c, cm) => new { tCards = c, tCardUsages = cm }).Select(x => x.tCardUsages).Where(cu => cu.CardId == input);
            return query;
        }


        public void SaveCardUsage(tCardUsage cardUsage)
        {
            mmEntities.tCardUsages.Add(cardUsage);
            mmEntities.SaveChanges();
        }

        public void SetCardsToDisabled()
        {
            mmEntities.tCards.Where(x => x.EndDate < DateTime.Now)
      .ToList()
      .ForEach(a => a.Enabled = false);

            mmEntities.SaveChanges();
        }
        #endregion
        #region Order
        public void SaveOrder(tOrder order)
        {
            mmEntities.tOrders.Add(order);
            mmEntities.SaveChanges();

        }
        public tOrder GetOrder(int input)
        {
            return mmEntities.tOrders.FirstOrDefault(s => s.OrderId == input);
        }
       

        public void SaveOrderItem(tOrderItem orderItem)
        {

            mmEntities.tOrderItems.AddOrUpdate(orderItem);
            mmEntities.SaveChanges();
        }
         public tOrderItem GetOrderItems(int input)
        {
            return mmEntities.tOrderItems.FirstOrDefault(oi => oi.OrderId == input);
        }

        #endregion

         #region Price  

         public tPrice GetPrice(int priceId)
        {
            return mmEntities.tPrices.FirstOrDefault(p => p.PriceId == priceId);
        } 
        public List<tPrice> GetPrices()
        {
            return new List<tPrice>(mmEntities.tPrices);
        }
#endregion

     
    } 
}
