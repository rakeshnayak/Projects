﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.ComponentModel;
using System.Data.EntityClient;
using System.Data.Objects;
using System.Data.Objects.DataClasses;
using System.Linq;
using System.Runtime.Serialization;
using System.Xml.Serialization;

[assembly: EdmSchemaAttribute()]
#region EDM Relationship Metadata

[assembly: EdmRelationshipAttribute("EducationSystemModel", "fk_UserRoles_Roles", "Roles", System.Data.Metadata.Edm.RelationshipMultiplicity.One, typeof(EducationSystem.Data.Role), "UserRoles", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(EducationSystem.Data.UserRole), true)]
[assembly: EdmRelationshipAttribute("EducationSystemModel", "fk_UserRoles_Users", "Users", System.Data.Metadata.Edm.RelationshipMultiplicity.One, typeof(EducationSystem.Data.User), "UserRoles", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(EducationSystem.Data.UserRole), true)]

#endregion

namespace EducationSystem.Data
{
    #region Contexts
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    public partial class EducationSystemEntities : ObjectContext
    {
        #region Constructors
    
        /// <summary>
        /// Initializes a new EducationSystemEntities object using the connection string found in the 'EducationSystemEntities' section of the application configuration file.
        /// </summary>
        public EducationSystemEntities() : base("name=EducationSystemEntities", "EducationSystemEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new EducationSystemEntities object.
        /// </summary>
        public EducationSystemEntities(string connectionString) : base(connectionString, "EducationSystemEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new EducationSystemEntities object.
        /// </summary>
        public EducationSystemEntities(EntityConnection connection) : base(connection, "EducationSystemEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        #endregion
    
        #region Partial Methods
    
        partial void OnContextCreated();
    
        #endregion
    
        #region ObjectSet Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<Role> Roles
        {
            get
            {
                if ((_Roles == null))
                {
                    _Roles = base.CreateObjectSet<Role>("Roles");
                }
                return _Roles;
            }
        }
        private ObjectSet<Role> _Roles;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<UserRole> UserRoles
        {
            get
            {
                if ((_UserRoles == null))
                {
                    _UserRoles = base.CreateObjectSet<UserRole>("UserRoles");
                }
                return _UserRoles;
            }
        }
        private ObjectSet<UserRole> _UserRoles;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<User> Users
        {
            get
            {
                if ((_Users == null))
                {
                    _Users = base.CreateObjectSet<User>("Users");
                }
                return _Users;
            }
        }
        private ObjectSet<User> _Users;

        #endregion

        #region AddTo Methods
    
        /// <summary>
        /// Deprecated Method for adding a new object to the Roles EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToRoles(Role role)
        {
            base.AddObject("Roles", role);
        }
    
        /// <summary>
        /// Deprecated Method for adding a new object to the UserRoles EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToUserRoles(UserRole userRole)
        {
            base.AddObject("UserRoles", userRole);
        }
    
        /// <summary>
        /// Deprecated Method for adding a new object to the Users EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToUsers(User user)
        {
            base.AddObject("Users", user);
        }

        #endregion

    }

    #endregion

    #region Entities
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="EducationSystemModel", Name="Role")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Role : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new Role object.
        /// </summary>
        /// <param name="id">Initial value of the Id property.</param>
        /// <param name="role1">Initial value of the Role1 property.</param>
        public static Role CreateRole(global::System.Int32 id, global::System.String role1)
        {
            Role role = new Role();
            role.Id = id;
            role.Role1 = role1;
            return role;
        }

        #endregion

        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 Id
        {
            get
            {
                return _Id;
            }
            set
            {
                if (_Id != value)
                {
                    OnIdChanging(value);
                    ReportPropertyChanging("Id");
                    _Id = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("Id");
                    OnIdChanged();
                }
            }
        }
        private global::System.Int32 _Id;
        partial void OnIdChanging(global::System.Int32 value);
        partial void OnIdChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Role1
        {
            get
            {
                return _Role1;
            }
            set
            {
                OnRole1Changing(value);
                ReportPropertyChanging("Role1");
                _Role1 = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("Role1");
                OnRole1Changed();
            }
        }
        private global::System.String _Role1;
        partial void OnRole1Changing(global::System.String value);
        partial void OnRole1Changed();

        #endregion

    
        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("EducationSystemModel", "fk_UserRoles_Roles", "UserRoles")]
        public EntityCollection<UserRole> UserRoles
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<UserRole>("EducationSystemModel.fk_UserRoles_Roles", "UserRoles");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<UserRole>("EducationSystemModel.fk_UserRoles_Roles", "UserRoles", value);
                }
            }
        }

        #endregion

    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="EducationSystemModel", Name="User")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class User : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new User object.
        /// </summary>
        /// <param name="id">Initial value of the Id property.</param>
        /// <param name="firstName">Initial value of the FirstName property.</param>
        /// <param name="lastName">Initial value of the LastName property.</param>
        /// <param name="userName">Initial value of the UserName property.</param>
        /// <param name="password">Initial value of the Password property.</param>
        /// <param name="dateOfBirth">Initial value of the DateOfBirth property.</param>
        /// <param name="gender">Initial value of the Gender property.</param>
        public static User CreateUser(global::System.Int64 id, global::System.String firstName, global::System.String lastName, global::System.String userName, global::System.String password, global::System.DateTime dateOfBirth, global::System.String gender)
        {
            User user = new User();
            user.Id = id;
            user.FirstName = firstName;
            user.LastName = lastName;
            user.UserName = userName;
            user.Password = password;
            user.DateOfBirth = dateOfBirth;
            user.Gender = gender;
            return user;
        }

        #endregion

        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int64 Id
        {
            get
            {
                return _Id;
            }
            set
            {
                if (_Id != value)
                {
                    OnIdChanging(value);
                    ReportPropertyChanging("Id");
                    _Id = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("Id");
                    OnIdChanged();
                }
            }
        }
        private global::System.Int64 _Id;
        partial void OnIdChanging(global::System.Int64 value);
        partial void OnIdChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String FirstName
        {
            get
            {
                return _FirstName;
            }
            set
            {
                OnFirstNameChanging(value);
                ReportPropertyChanging("FirstName");
                _FirstName = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("FirstName");
                OnFirstNameChanged();
            }
        }
        private global::System.String _FirstName;
        partial void OnFirstNameChanging(global::System.String value);
        partial void OnFirstNameChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String MiddleName
        {
            get
            {
                return _MiddleName;
            }
            set
            {
                OnMiddleNameChanging(value);
                ReportPropertyChanging("MiddleName");
                _MiddleName = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("MiddleName");
                OnMiddleNameChanged();
            }
        }
        private global::System.String _MiddleName;
        partial void OnMiddleNameChanging(global::System.String value);
        partial void OnMiddleNameChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String LastName
        {
            get
            {
                return _LastName;
            }
            set
            {
                OnLastNameChanging(value);
                ReportPropertyChanging("LastName");
                _LastName = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("LastName");
                OnLastNameChanged();
            }
        }
        private global::System.String _LastName;
        partial void OnLastNameChanging(global::System.String value);
        partial void OnLastNameChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String UserName
        {
            get
            {
                return _UserName;
            }
            set
            {
                OnUserNameChanging(value);
                ReportPropertyChanging("UserName");
                _UserName = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("UserName");
                OnUserNameChanged();
            }
        }
        private global::System.String _UserName;
        partial void OnUserNameChanging(global::System.String value);
        partial void OnUserNameChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Password
        {
            get
            {
                return _Password;
            }
            set
            {
                OnPasswordChanging(value);
                ReportPropertyChanging("Password");
                _Password = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("Password");
                OnPasswordChanged();
            }
        }
        private global::System.String _Password;
        partial void OnPasswordChanging(global::System.String value);
        partial void OnPasswordChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.DateTime DateOfBirth
        {
            get
            {
                return _DateOfBirth;
            }
            set
            {
                OnDateOfBirthChanging(value);
                ReportPropertyChanging("DateOfBirth");
                _DateOfBirth = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("DateOfBirth");
                OnDateOfBirthChanged();
            }
        }
        private global::System.DateTime _DateOfBirth;
        partial void OnDateOfBirthChanging(global::System.DateTime value);
        partial void OnDateOfBirthChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Gender
        {
            get
            {
                return _Gender;
            }
            set
            {
                OnGenderChanging(value);
                ReportPropertyChanging("Gender");
                _Gender = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("Gender");
                OnGenderChanged();
            }
        }
        private global::System.String _Gender;
        partial void OnGenderChanging(global::System.String value);
        partial void OnGenderChanged();

        #endregion

    
        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("EducationSystemModel", "fk_UserRoles_Users", "UserRoles")]
        public EntityCollection<UserRole> UserRoles
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<UserRole>("EducationSystemModel.fk_UserRoles_Users", "UserRoles");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<UserRole>("EducationSystemModel.fk_UserRoles_Users", "UserRoles", value);
                }
            }
        }

        #endregion

    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="EducationSystemModel", Name="UserRole")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class UserRole : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new UserRole object.
        /// </summary>
        /// <param name="id">Initial value of the Id property.</param>
        /// <param name="userId">Initial value of the UserId property.</param>
        /// <param name="roleId">Initial value of the RoleId property.</param>
        public static UserRole CreateUserRole(global::System.Int64 id, global::System.Int64 userId, global::System.Int32 roleId)
        {
            UserRole userRole = new UserRole();
            userRole.Id = id;
            userRole.UserId = userId;
            userRole.RoleId = roleId;
            return userRole;
        }

        #endregion

        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int64 Id
        {
            get
            {
                return _Id;
            }
            set
            {
                if (_Id != value)
                {
                    OnIdChanging(value);
                    ReportPropertyChanging("Id");
                    _Id = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("Id");
                    OnIdChanged();
                }
            }
        }
        private global::System.Int64 _Id;
        partial void OnIdChanging(global::System.Int64 value);
        partial void OnIdChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int64 UserId
        {
            get
            {
                return _UserId;
            }
            set
            {
                OnUserIdChanging(value);
                ReportPropertyChanging("UserId");
                _UserId = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("UserId");
                OnUserIdChanged();
            }
        }
        private global::System.Int64 _UserId;
        partial void OnUserIdChanging(global::System.Int64 value);
        partial void OnUserIdChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 RoleId
        {
            get
            {
                return _RoleId;
            }
            set
            {
                OnRoleIdChanging(value);
                ReportPropertyChanging("RoleId");
                _RoleId = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("RoleId");
                OnRoleIdChanged();
            }
        }
        private global::System.Int32 _RoleId;
        partial void OnRoleIdChanging(global::System.Int32 value);
        partial void OnRoleIdChanged();

        #endregion

    
        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("EducationSystemModel", "fk_UserRoles_Roles", "Roles")]
        public Role Role
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Role>("EducationSystemModel.fk_UserRoles_Roles", "Roles").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Role>("EducationSystemModel.fk_UserRoles_Roles", "Roles").Value = value;
            }
        }
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<Role> RoleReference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Role>("EducationSystemModel.fk_UserRoles_Roles", "Roles");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<Role>("EducationSystemModel.fk_UserRoles_Roles", "Roles", value);
                }
            }
        }
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("EducationSystemModel", "fk_UserRoles_Users", "Users")]
        public User User
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<User>("EducationSystemModel.fk_UserRoles_Users", "Users").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<User>("EducationSystemModel.fk_UserRoles_Users", "Users").Value = value;
            }
        }
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<User> UserReference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<User>("EducationSystemModel.fk_UserRoles_Users", "Users");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<User>("EducationSystemModel.fk_UserRoles_Users", "Users", value);
                }
            }
        }

        #endregion

    }

    #endregion

    
}