﻿using System;
using System.Collections.Generic;
using System.Linq;

using HerokoRima.Classes;

namespace Classes.Classes
{
    public class Combobox
    {
        public static List<tStaff> staffList;
       // public static List<tArea> areaList;
        public static Staff staffs = new Staff();
        public static Areas areas = new Areas();
        public static CardTypes cardTypes = new CardTypes();
        public static  Price price = new Price();
        public static MemberTypes memberTypes = new MemberTypes();
        public static List<tPrice> priceList; 
        public static Member members = new Member();
        public static List<tType> cardTypesList;

        public static List<tPrice>  LoadComboBoxCardTypes()
        {

            priceList = new List<tPrice>(price.GetPrices().Where(p=>p.PriceId<5));
            //add new item to the comboBox (on index 0; on top):
            AddItemCardTypes(priceList, typeof(tPrice), "PriceId", "PriceDescription", "<Porfavor seleccione un tipo de tarjeta>");

            //bind the generic list:
            return priceList;
        }

        public static List<tMemberType> LoadComboBoxMemberTypes()
        {

            var mTypes = new List<tMemberType>(memberTypes.GetMemberTypes());
            //add new item to the comboBox (on index 0; on top):
            AddItemCardTypes(priceList, typeof(tMemberType), "MemberTypeId", "MemberTypeDescription", "<Porfavor seleccione un tipo>");

            //bind the generic list:
            return mTypes;
        }        

        public static List<tStaff> LoadComboBoxStaff(int areaId)
        {
            staffList =  new List<tStaff>(Staff.GetStaffList()) ;

            //add new item to the comboBox (on index 0; on top):
            AddItemsStaff(staffList, typeof(tStaff), "StaffId", "Firstname", "<Porfavor seleccione un monitor>");

            //bind the generic list:
            return staffList;
        }

        public static void AddItemsStaff(IList<tStaff> list, Type type, string valueMember, string displayMember, string displayText)
        {
            var obj = Activator.CreateInstance(type);
            var displayProperty = type.GetProperty(displayMember);
            displayProperty.SetValue(obj, displayText, null);
            var valueProperty = type.GetProperty(valueMember);
            valueProperty.SetValue(obj, -1, null);
            list.Insert(0, obj as tStaff);
        }

        //public static List<tArea> LoadComboBoxAreas()
        //{
        //    areaList = new List<tArea>(areas.GetAreas());
        //    //add new item to the comboBox (on index 0; on top):
        //    AddItemsAreas(areaList, typeof(tArea), "AreaId", "AreaDescription", "<Porfavor seleccione un area>");

        //    //bind the generic list:
        //    return areaList;
        //}

        //public static void AddItemsAreas(IList<tArea> list, Type type, string valueMember, string displayMember, string displayText)
        //{
        //    var obj = Activator.CreateInstance(type);
        //    var displayProperty = type.GetProperty(displayMember);
        //    displayProperty.SetValue(obj, displayText, null);
        //    var valueProperty = type.GetProperty(valueMember);
        //    valueProperty.SetValue(obj, -1, null);
        //    list.Insert(0, obj as tArea);
        //}
        private static void AddItemCardTypes(IList<tPrice> list, Type type, string valueMember, string displayMember, string displayText)
        {
            var obj = Activator.CreateInstance(type);
            var displayProperty = type.GetProperty(displayMember);
            displayProperty.SetValue(obj, displayText, null);
            var valueProperty = type.GetProperty(valueMember);
            valueProperty.SetValue(obj, -1, null);
            list.Insert(0, obj as tPrice);
        }
    }
}


