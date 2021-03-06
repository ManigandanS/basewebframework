// Generated by MyGeneration Version # (1.3.0.9)
using System;
using System.Collections.Generic;
using System.Text;
using NHibernate.Criterion;
using Legendigital.Framework.Common.Data.NHibernate.DynamicQuery;
using Legendigital.Framework.Common.BaseFramework.Entity.Tables;
using Legendigital.Framework.Common.Data.NHibernate;


namespace Legendigital.Framework.Common.BaseFramework.Data.Tables
{
    public partial class SystemUserProfilePropertysDataObject : BaseNHibernateDataObject<SystemUserProfilePropertysEntity>
    {
				#region Expression Query Property (标准查询字段)
		public static readonly Property PROPERTY_PROPERTYID = Property.ForName(SystemUserProfilePropertysEntity.PROPERTY_NAME_PROPERTYID);
		public static readonly Property PROPERTY_PROPERTYNAME = Property.ForName(SystemUserProfilePropertysEntity.PROPERTY_NAME_PROPERTYNAME);
		public static readonly Property PROPERTY_PROPERTYDESCRIPTION = Property.ForName(SystemUserProfilePropertysEntity.PROPERTY_NAME_PROPERTYDESCRIPTION);
      
		#region 子类集合字段查询字段
	
		#endregion

		#endregion

		
		public override string[] PkPropertyName
        {
            get { return new string[] { "PropertyID" }; }
        }
		
		public override Type GetFieldTypeByFieldName(string fieldName)
        {
			switch (fieldName)
            {
                case "PropertyID":
                    return typeof (int);
                case "PropertyName":
                    return typeof (string);
                case "PropertyDescription":
                    return typeof (string);
          }
			return typeof(string);
        }
    }
}
