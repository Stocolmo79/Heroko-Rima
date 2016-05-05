using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Core.Common.CommandTrees;
using System.Data.Entity.Core.Objects;
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
            return mmEntities.tStaffs.FirstOrDefault(s => s.StaffId == staffId);
        }

        //public List<tStaff> GetStaffByArea(int areaId)
        //{
        //    return (from s in mmEntities.tStaffs
        //            from sa in mmEntities.tStaffAreas
        //            where s.Id == sa.StaffId && sa.AreaId == areaId
        //            select s).ToList<tStaff>();

        //}

        public void SaveStaff(tStaff staff)
        {
            mmEntities.tStaffs.Add(staff);

            mmEntities.SaveChanges();
        }

        public void SaveStaff()
        {

            mmEntities.SaveChanges();
        }

        //public void DeleteStaffArea(tStaffArea tStaffArea)
        //{
        //    mmEntities.tStaffAreas.Remove(tStaffArea);

        //}
        //public void SaveStaffArea(tStaffArea tStaffArea)
        //{
        //    mmEntities.tStaffAreas.Add(tStaffArea);
        //    mmEntities.SaveChanges();
        //}

        #region Area

        //public List<tArea> GetAreas()
        //{
        //    return mmEntities.tAreas.Select(a => a).ToList();
        //}

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

            return (from m in mmEntities.tMembers
                    join t in mmEntities.tMemberTypes on m.MemberType equals t.MemberTypeId
                    where m.CardId.ToString() == input || m.Cellphone == input
                    select m).FirstOrDefault();
        }

        #endregion

        #region Cards

        public void SaveCard(tCard tCard)
        {
            mmEntities.tCards.AddOrUpdate(tCard);
            mmEntities.SaveChanges();
        }
        public void SaveNewCard(tCard tCard)
        {
            mmEntities.tCards.Add(tCard);
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
            //return (from c in mmEntities.tCards
            //        join cu in mmEntities.tCardUsages on c.CardId equals cu.CardId
            //        join p in mmEntities.tPrices on cu.tCard.TypeId equals p.PriceId select cu
            //);
            var query =
                mmEntities.tCards.Join(
                    mmEntities.tCardUsages,
                    c => c.CardId,
                    cm => cm.CardId,
                    (c, cm) => new { tCards = c, tCardUsages = cm })
                    .Select(x => x.tCardUsages)
                    .Where(cu => cu.CardId == input);
            return query;
        }


        public void SaveCardUsage(tCardUsage cardUsage)
        {
            mmEntities.tCardUsages.Add(cardUsage);
            mmEntities.SaveChanges();
        }

        public void SetCardsToDisabled()
        {
            mmEntities.tCards.Where(x => x.EndDate < DateTime.Now).ToList().ForEach(a => a.Enabled = false);

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

        public List< tOrderItem>GetOrderItemsByDate(DateTime dateTime)
        {
            return (from oi in mmEntities.tOrderItems
                    join p in mmEntities.tPrices on oi.PriceId  equals p.PriceId where oi.OrderDate == dateTime
                    select oi
            ).ToList();
     
               // return mmEntities.tOrderItems.Where(oi => oi.OrderDate == dateTime).ToList();
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

        public List<tMemberType> GetMemberTypes()
        {
            return mmEntities.tMemberTypes.ToList();
        }

        public void SaveInCharge(tInCharge inCharge)
        {
            mmEntities.tInCharges.Add(inCharge);
            mmEntities.SaveChanges();
        }

        public tHourType GetHourType(int type)
        {
            return mmEntities.tHourTypes.FirstOrDefault(h => h.HourTypeId == type);
        }

        public List<tInCharge> GetStaffDays(long id)
        {
            //return (from c in mmEntities.tCards
            //        join cu in mmEntities.tCardUsages on c.CardId equals cu.CardId
            //        join p in mmEntities.tPrices on cu.tCard.TypeId equals p.PriceId select cu
            //);
            return (from ic in mmEntities.tInCharges
                    join ht in mmEntities.tHourTypes on ic.HourType equals ht.HourTypeId
                    join s in mmEntities.tStaffs on ic.StaffId equals s.StaffId
                    where ic.StaffId == id
                    select ic).ToList();
        }

        public List<tInCharge> GetdaysByParam(int param)
        {


            DateTime pastDate;
            if (param == 1)
            {
                pastDate = DateTime.Today.AddDays(-7);
                return (from ic in mmEntities.tInCharges
                        join ht in mmEntities.tHourTypes on ic.HourType equals ht.HourTypeId
                        join s in mmEntities.tStaffs on ic.StaffId equals s.StaffId
                        where ic.Date > pastDate
                        select ic).ToList();
            }
            pastDate = DateTime.Today.AddMonths(-1);
            return (from ic in mmEntities.tInCharges
                    join ht in mmEntities.tHourTypes on ic.HourType equals ht.HourTypeId
                    join s in mmEntities.tStaffs on ic.StaffId equals s.StaffId
                    where ic.Date > pastDate
                    select ic).ToList();


        }

        public List<tInCharge> GetdaysBetweenDates(DateTime d1, DateTime d2)
        {

            return (from ic in mmEntities.tInCharges
                    join ht in mmEntities.tHourTypes on ic.HourType equals ht.HourTypeId
                    join s in mmEntities.tStaffs on ic.StaffId equals s.StaffId
                    where ic.Date > d1 && ic.Date < d2
                    select ic).ToList();

        }
        #region endOfDay

        //public List<tInCharge> GetdaysBetweenDates(DateTime d1, DateTime d2)
        //{
        //}

        #endregion

        public List<tInCharge> GetStaffByDate(DateTime today)
        {
            return
                (from ic in mmEntities.tInCharges join s in mmEntities.tStaffs on ic.StaffId equals s.StaffId where ic.Date == today select ic )
                    .ToList();
         
        }

        public void MoveCardUsage(long oldCardId, long newCardId)
        {
            mmEntities.tCardUsages.Where(x => x.CardId == oldCardId).ToList().ForEach(a => a.CardId = newCardId);

            mmEntities.SaveChanges();
        }

        public void MoveCardMember(long oldCardId, long newCardId)
        {
            mmEntities.tMembers.Where(x => x.CardId == oldCardId).ToList().ForEach(a => a.CardId = newCardId);

            mmEntities.SaveChanges();
        }

        public void SavePrice(tPrice price)
        {
          mmEntities.tPrices.AddOrUpdate(price);
          mmEntities.SaveChanges();
        }

        public void DeltePrice(tPrice price)
        {
            mmEntities.tPrices.Remove(price);
            mmEntities.SaveChanges();

        }
    }
}
