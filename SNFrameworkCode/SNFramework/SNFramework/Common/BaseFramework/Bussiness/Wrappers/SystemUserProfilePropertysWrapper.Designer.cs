// Generated by MyGeneration Version # (1.3.0.9)
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using Spring.Context.Support;
using Common.Logging;
using Legendigital.Framework.Common.Bussiness.NHibernate;
using Legendigital.Framework.Common.BaseFramework.Entity.Tables;
using Legendigital.Framework.Common.BaseFramework.Bussiness.ServiceProxys.Tables.Container;
using Legendigital.Framework.Common.BaseFramework.Bussiness.ServiceProxys.Tables;
using Legendigital.Framework.Common.Data.NHibernate.DynamicQuery;

namespace Legendigital.Framework.Common.BaseFramework.Bussiness.Wrappers
{
    public partial class SystemUserProfilePropertysWrapper    //: BaseSpringNHibernateWrapper<SystemUserProfilePropertysEntity, ISystemUserProfilePropertysServiceProxy, SystemUserProfilePropertysWrapper,int>
    {
        #region Member

		internal static readonly ISystemUserProfilePropertysServiceProxy businessProxy = ((Legendigital.Framework.Common.BaseFramework.Bussiness.ServiceProxys.Tables.Container.BaseFrameworkServiceProxyContainer)(ContextRegistry.GetContext().GetObject("BaseFrameworkServiceProxyContainerIocID", typeof(Legendigital.Framework.Common.BaseFramework.Bussiness.ServiceProxys.Tables.Container.BaseFrameworkServiceProxyContainer)))).SystemUserProfilePropertysServiceProxyInstance;
		
		
		internal SystemUserProfilePropertysEntity Entity
        {
            get { return this.entity; }
        }
		
        #endregion

        #region Construtor
		public SystemUserProfilePropertysWrapper() : base(new SystemUserProfilePropertysEntity())
        {
            
        }

        internal SystemUserProfilePropertysWrapper(SystemUserProfilePropertysEntity entityObj)
            : base(entityObj)
        {
        }
		#endregion

        #region Process Column Name
        private static string ProcessColumnName(string columnName)
        {
            switch (columnName)
            {
              default:
                    return columnName;
            }
        }

        private static void ProcessQueryFilters(List<QueryFilter> filters)
        {
            foreach (QueryFilter queryFilter in filters)
            {
                queryFilter.FilterFieldName = ProcessColumnName(queryFilter.FilterFieldName);
            }
        }
		#endregion
		
      #region 公共常量

		public static readonly string CLASS_FULL_NAME = "Legendigital.Framework.Common.BaseFramework.Entity.Tables.SystemUserProfilePropertysEntity";
		public static readonly string PROPERTY_NAME_PROPERTYID = "PropertyID";
		public static readonly string PROPERTY_NAME_PROPERTYNAME = "PropertyName";
		public static readonly string PROPERTY_NAME_PROPERTYDESCRIPTION = "PropertyDescription";
		
        #endregion
	
 
      	
	
	
		 
		
		
		
		


		#region Public Property
		/// <summary>
		/// 
		/// </summary>
		[DataMember]
		public int PropertyID
		{
			get
			{
				return entity.PropertyID;
			}
			set
			{
				entity.PropertyID = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		[DataMember]
		public string PropertyName
		{
			get
			{
				return entity.PropertyName;
			}
			set
			{
				entity.PropertyName = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		[DataMember]
		public string PropertyDescription
		{
			get
			{
				return entity.PropertyDescription;
			}
			set
			{
				entity.PropertyDescription = value;
			}
		}
		#endregion 


		#region Query Property
		
		
      	
   
		#endregion


        #region "FKQuery"



        #endregion








        #region Static Common Data Operation
		
		internal static List<SystemUserProfilePropertysWrapper> ConvertToWrapperList(List<SystemUserProfilePropertysEntity> entitylist)
        {
            List<SystemUserProfilePropertysWrapper> list = new List<SystemUserProfilePropertysWrapper>();
            foreach (SystemUserProfilePropertysEntity lentity in entitylist)
            {
                list.Add(ConvertEntityToWrapper(lentity));
            }
            return list;
        }

		internal static List<SystemUserProfilePropertysWrapper> ConvertToWrapperList(IList<SystemUserProfilePropertysEntity> entitylist)
        {
            List<SystemUserProfilePropertysWrapper> list = new List<SystemUserProfilePropertysWrapper>();
            foreach (SystemUserProfilePropertysEntity lentity in entitylist)
            {
                list.Add(ConvertEntityToWrapper(lentity));
            }
            return list;
        }
		
		internal static List<SystemUserProfilePropertysEntity> ConvertToEntityList(List<SystemUserProfilePropertysWrapper> wrapperlist)
        {
            List<SystemUserProfilePropertysEntity> list = new List<SystemUserProfilePropertysEntity>();
            foreach (SystemUserProfilePropertysWrapper wrapper in wrapperlist)
            {
                list.Add(wrapper.entity);
            }
            return list;
        }

        internal static SystemUserProfilePropertysWrapper ConvertEntityToWrapper(SystemUserProfilePropertysEntity entity)
        {
            if (entity == null)
                return null;
				
            if (entity.PropertyID == 0)
                return null;

            return new SystemUserProfilePropertysWrapper(entity);
        }
		
		#endregion

    }//End Class
}// End Namespace

