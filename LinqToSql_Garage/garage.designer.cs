#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LinqToSql_Garage
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="Garage")]
	public partial class garageDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void Insertgarage(garage instance);
    partial void Updategarage(garage instance);
    partial void Deletegarage(garage instance);
    partial void Insertpiece(piece instance);
    partial void Updatepiece(piece instance);
    partial void Deletepiece(piece instance);
    partial void Insertreparation(reparation instance);
    partial void Updatereparation(reparation instance);
    partial void Deletereparation(reparation instance);
    partial void Insertutilise(utilise instance);
    partial void Updateutilise(utilise instance);
    partial void Deleteutilise(utilise instance);
    partial void Insertvoiture(voiture instance);
    partial void Updatevoiture(voiture instance);
    partial void Deletevoiture(voiture instance);
    #endregion
		
		public garageDataContext() : 
				base(global::LinqToSql_Garage.Properties.Settings.Default.GarageConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public garageDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public garageDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public garageDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public garageDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<garage> garages
		{
			get
			{
				return this.GetTable<garage>();
			}
		}
		
		public System.Data.Linq.Table<piece> pieces
		{
			get
			{
				return this.GetTable<piece>();
			}
		}
		
		public System.Data.Linq.Table<reparation> reparations
		{
			get
			{
				return this.GetTable<reparation>();
			}
		}
		
		public System.Data.Linq.Table<utilise> utilises
		{
			get
			{
				return this.GetTable<utilise>();
			}
		}
		
		public System.Data.Linq.Table<voiture> voitures
		{
			get
			{
				return this.GetTable<voiture>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.garage")]
	public partial class garage : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private long _idGarage;
		
		private string _nomGarage;
		
		private EntitySet<reparation> _reparations;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidGarageChanging(long value);
    partial void OnidGarageChanged();
    partial void OnnomGarageChanging(string value);
    partial void OnnomGarageChanged();
    #endregion
		
		public garage()
		{
			this._reparations = new EntitySet<reparation>(new Action<reparation>(this.attach_reparations), new Action<reparation>(this.detach_reparations));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_idGarage", AutoSync=AutoSync.OnInsert, DbType="BigInt NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public long idGarage
		{
			get
			{
				return this._idGarage;
			}
			set
			{
				if ((this._idGarage != value))
				{
					this.OnidGarageChanging(value);
					this.SendPropertyChanging();
					this._idGarage = value;
					this.SendPropertyChanged("idGarage");
					this.OnidGarageChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_nomGarage", DbType="VarChar(30)")]
		public string nomGarage
		{
			get
			{
				return this._nomGarage;
			}
			set
			{
				if ((this._nomGarage != value))
				{
					this.OnnomGarageChanging(value);
					this.SendPropertyChanging();
					this._nomGarage = value;
					this.SendPropertyChanged("nomGarage");
					this.OnnomGarageChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="garage_reparation", Storage="_reparations", ThisKey="idGarage", OtherKey="idGarage")]
		public EntitySet<reparation> reparations
		{
			get
			{
				return this._reparations;
			}
			set
			{
				this._reparations.Assign(value);
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_reparations(reparation entity)
		{
			this.SendPropertyChanging();
			entity.garage = this;
		}
		
		private void detach_reparations(reparation entity)
		{
			this.SendPropertyChanging();
			entity.garage = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.piece")]
	public partial class piece : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private long _idPiece;
		
		private string _nomPiece;
		
		private System.Nullable<decimal> _prixPiece;
		
		private EntitySet<utilise> _utilises;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidPieceChanging(long value);
    partial void OnidPieceChanged();
    partial void OnnomPieceChanging(string value);
    partial void OnnomPieceChanged();
    partial void OnprixPieceChanging(System.Nullable<decimal> value);
    partial void OnprixPieceChanged();
    #endregion
		
		public piece()
		{
			this._utilises = new EntitySet<utilise>(new Action<utilise>(this.attach_utilises), new Action<utilise>(this.detach_utilises));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_idPiece", AutoSync=AutoSync.OnInsert, DbType="BigInt NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public long idPiece
		{
			get
			{
				return this._idPiece;
			}
			set
			{
				if ((this._idPiece != value))
				{
					this.OnidPieceChanging(value);
					this.SendPropertyChanging();
					this._idPiece = value;
					this.SendPropertyChanged("idPiece");
					this.OnidPieceChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_nomPiece", DbType="VarChar(100)")]
		public string nomPiece
		{
			get
			{
				return this._nomPiece;
			}
			set
			{
				if ((this._nomPiece != value))
				{
					this.OnnomPieceChanging(value);
					this.SendPropertyChanging();
					this._nomPiece = value;
					this.SendPropertyChanged("nomPiece");
					this.OnnomPieceChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_prixPiece", DbType="Money")]
		public System.Nullable<decimal> prixPiece
		{
			get
			{
				return this._prixPiece;
			}
			set
			{
				if ((this._prixPiece != value))
				{
					this.OnprixPieceChanging(value);
					this.SendPropertyChanging();
					this._prixPiece = value;
					this.SendPropertyChanged("prixPiece");
					this.OnprixPieceChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="piece_utilise", Storage="_utilises", ThisKey="idPiece", OtherKey="idPiece")]
		public EntitySet<utilise> utilises
		{
			get
			{
				return this._utilises;
			}
			set
			{
				this._utilises.Assign(value);
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_utilises(utilise entity)
		{
			this.SendPropertyChanging();
			entity.piece = this;
		}
		
		private void detach_utilises(utilise entity)
		{
			this.SendPropertyChanging();
			entity.piece = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.reparation")]
	public partial class reparation : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private long _idReparation;
		
		private string _immatriculation;
		
		private System.Nullable<System.DateTime> _dateReparation;
		
		private System.Nullable<decimal> _prixReparation;
		
		private System.Nullable<long> _idGarage;
		
		private EntitySet<utilise> _utilises;
		
		private EntityRef<garage> _garage;
		
		private EntityRef<voiture> _voiture;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidReparationChanging(long value);
    partial void OnidReparationChanged();
    partial void OnimmatriculationChanging(string value);
    partial void OnimmatriculationChanged();
    partial void OndateReparationChanging(System.Nullable<System.DateTime> value);
    partial void OndateReparationChanged();
    partial void OnprixReparationChanging(System.Nullable<decimal> value);
    partial void OnprixReparationChanged();
    partial void OnidGarageChanging(System.Nullable<long> value);
    partial void OnidGarageChanged();
    #endregion
		
		public reparation()
		{
			this._utilises = new EntitySet<utilise>(new Action<utilise>(this.attach_utilises), new Action<utilise>(this.detach_utilises));
			this._garage = default(EntityRef<garage>);
			this._voiture = default(EntityRef<voiture>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_idReparation", AutoSync=AutoSync.OnInsert, DbType="BigInt NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public long idReparation
		{
			get
			{
				return this._idReparation;
			}
			set
			{
				if ((this._idReparation != value))
				{
					this.OnidReparationChanging(value);
					this.SendPropertyChanging();
					this._idReparation = value;
					this.SendPropertyChanged("idReparation");
					this.OnidReparationChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_immatriculation", DbType="VarChar(20)")]
		public string immatriculation
		{
			get
			{
				return this._immatriculation;
			}
			set
			{
				if ((this._immatriculation != value))
				{
					if (this._voiture.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnimmatriculationChanging(value);
					this.SendPropertyChanging();
					this._immatriculation = value;
					this.SendPropertyChanged("immatriculation");
					this.OnimmatriculationChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_dateReparation", DbType="Date")]
		public System.Nullable<System.DateTime> dateReparation
		{
			get
			{
				return this._dateReparation;
			}
			set
			{
				if ((this._dateReparation != value))
				{
					this.OndateReparationChanging(value);
					this.SendPropertyChanging();
					this._dateReparation = value;
					this.SendPropertyChanged("dateReparation");
					this.OndateReparationChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_prixReparation", DbType="Money")]
		public System.Nullable<decimal> prixReparation
		{
			get
			{
				return this._prixReparation;
			}
			set
			{
				if ((this._prixReparation != value))
				{
					this.OnprixReparationChanging(value);
					this.SendPropertyChanging();
					this._prixReparation = value;
					this.SendPropertyChanged("prixReparation");
					this.OnprixReparationChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_idGarage", DbType="BigInt")]
		public System.Nullable<long> idGarage
		{
			get
			{
				return this._idGarage;
			}
			set
			{
				if ((this._idGarage != value))
				{
					if (this._garage.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnidGarageChanging(value);
					this.SendPropertyChanging();
					this._idGarage = value;
					this.SendPropertyChanged("idGarage");
					this.OnidGarageChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="reparation_utilise", Storage="_utilises", ThisKey="idReparation", OtherKey="idReparation")]
		public EntitySet<utilise> utilises
		{
			get
			{
				return this._utilises;
			}
			set
			{
				this._utilises.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="garage_reparation", Storage="_garage", ThisKey="idGarage", OtherKey="idGarage", IsForeignKey=true)]
		public garage garage
		{
			get
			{
				return this._garage.Entity;
			}
			set
			{
				garage previousValue = this._garage.Entity;
				if (((previousValue != value) 
							|| (this._garage.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._garage.Entity = null;
						previousValue.reparations.Remove(this);
					}
					this._garage.Entity = value;
					if ((value != null))
					{
						value.reparations.Add(this);
						this._idGarage = value.idGarage;
					}
					else
					{
						this._idGarage = default(Nullable<long>);
					}
					this.SendPropertyChanged("garage");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="voiture_reparation", Storage="_voiture", ThisKey="immatriculation", OtherKey="immatriculation", IsForeignKey=true)]
		public voiture voiture
		{
			get
			{
				return this._voiture.Entity;
			}
			set
			{
				voiture previousValue = this._voiture.Entity;
				if (((previousValue != value) 
							|| (this._voiture.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._voiture.Entity = null;
						previousValue.reparations.Remove(this);
					}
					this._voiture.Entity = value;
					if ((value != null))
					{
						value.reparations.Add(this);
						this._immatriculation = value.immatriculation;
					}
					else
					{
						this._immatriculation = default(string);
					}
					this.SendPropertyChanged("voiture");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_utilises(utilise entity)
		{
			this.SendPropertyChanging();
			entity.reparation = this;
		}
		
		private void detach_utilises(utilise entity)
		{
			this.SendPropertyChanging();
			entity.reparation = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.utilise")]
	public partial class utilise : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private long _idPiece;
		
		private long _idReparation;
		
		private System.Nullable<int> _qte;
		
		private EntityRef<piece> _piece;
		
		private EntityRef<reparation> _reparation;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidPieceChanging(long value);
    partial void OnidPieceChanged();
    partial void OnidReparationChanging(long value);
    partial void OnidReparationChanged();
    partial void OnqteChanging(System.Nullable<int> value);
    partial void OnqteChanged();
    #endregion
		
		public utilise()
		{
			this._piece = default(EntityRef<piece>);
			this._reparation = default(EntityRef<reparation>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_idPiece", DbType="BigInt NOT NULL", IsPrimaryKey=true)]
		public long idPiece
		{
			get
			{
				return this._idPiece;
			}
			set
			{
				if ((this._idPiece != value))
				{
					if (this._piece.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnidPieceChanging(value);
					this.SendPropertyChanging();
					this._idPiece = value;
					this.SendPropertyChanged("idPiece");
					this.OnidPieceChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_idReparation", DbType="BigInt NOT NULL", IsPrimaryKey=true)]
		public long idReparation
		{
			get
			{
				return this._idReparation;
			}
			set
			{
				if ((this._idReparation != value))
				{
					if (this._reparation.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnidReparationChanging(value);
					this.SendPropertyChanging();
					this._idReparation = value;
					this.SendPropertyChanged("idReparation");
					this.OnidReparationChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_qte", DbType="Int")]
		public System.Nullable<int> qte
		{
			get
			{
				return this._qte;
			}
			set
			{
				if ((this._qte != value))
				{
					this.OnqteChanging(value);
					this.SendPropertyChanging();
					this._qte = value;
					this.SendPropertyChanged("qte");
					this.OnqteChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="piece_utilise", Storage="_piece", ThisKey="idPiece", OtherKey="idPiece", IsForeignKey=true)]
		public piece piece
		{
			get
			{
				return this._piece.Entity;
			}
			set
			{
				piece previousValue = this._piece.Entity;
				if (((previousValue != value) 
							|| (this._piece.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._piece.Entity = null;
						previousValue.utilises.Remove(this);
					}
					this._piece.Entity = value;
					if ((value != null))
					{
						value.utilises.Add(this);
						this._idPiece = value.idPiece;
					}
					else
					{
						this._idPiece = default(long);
					}
					this.SendPropertyChanged("piece");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="reparation_utilise", Storage="_reparation", ThisKey="idReparation", OtherKey="idReparation", IsForeignKey=true)]
		public reparation reparation
		{
			get
			{
				return this._reparation.Entity;
			}
			set
			{
				reparation previousValue = this._reparation.Entity;
				if (((previousValue != value) 
							|| (this._reparation.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._reparation.Entity = null;
						previousValue.utilises.Remove(this);
					}
					this._reparation.Entity = value;
					if ((value != null))
					{
						value.utilises.Add(this);
						this._idReparation = value.idReparation;
					}
					else
					{
						this._idReparation = default(long);
					}
					this.SendPropertyChanged("reparation");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.voiture")]
	public partial class voiture : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _immatriculation;
		
		private string _MarqueVoiture;
		
		private string _ModeleVoiture;
		
		private string _TelephoneProprietaire;
		
		private EntitySet<reparation> _reparations;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnimmatriculationChanging(string value);
    partial void OnimmatriculationChanged();
    partial void OnMarqueVoitureChanging(string value);
    partial void OnMarqueVoitureChanged();
    partial void OnModeleVoitureChanging(string value);
    partial void OnModeleVoitureChanged();
    partial void OnTelephoneProprietaireChanging(string value);
    partial void OnTelephoneProprietaireChanged();
    #endregion
		
		public voiture()
		{
			this._reparations = new EntitySet<reparation>(new Action<reparation>(this.attach_reparations), new Action<reparation>(this.detach_reparations));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_immatriculation", DbType="VarChar(20) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string immatriculation
		{
			get
			{
				return this._immatriculation;
			}
			set
			{
				if ((this._immatriculation != value))
				{
					this.OnimmatriculationChanging(value);
					this.SendPropertyChanging();
					this._immatriculation = value;
					this.SendPropertyChanged("immatriculation");
					this.OnimmatriculationChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MarqueVoiture", DbType="VarChar(30)")]
		public string MarqueVoiture
		{
			get
			{
				return this._MarqueVoiture;
			}
			set
			{
				if ((this._MarqueVoiture != value))
				{
					this.OnMarqueVoitureChanging(value);
					this.SendPropertyChanging();
					this._MarqueVoiture = value;
					this.SendPropertyChanged("MarqueVoiture");
					this.OnMarqueVoitureChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ModeleVoiture", DbType="VarChar(30)")]
		public string ModeleVoiture
		{
			get
			{
				return this._ModeleVoiture;
			}
			set
			{
				if ((this._ModeleVoiture != value))
				{
					this.OnModeleVoitureChanging(value);
					this.SendPropertyChanging();
					this._ModeleVoiture = value;
					this.SendPropertyChanged("ModeleVoiture");
					this.OnModeleVoitureChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TelephoneProprietaire", DbType="VarChar(30)")]
		public string TelephoneProprietaire
		{
			get
			{
				return this._TelephoneProprietaire;
			}
			set
			{
				if ((this._TelephoneProprietaire != value))
				{
					this.OnTelephoneProprietaireChanging(value);
					this.SendPropertyChanging();
					this._TelephoneProprietaire = value;
					this.SendPropertyChanged("TelephoneProprietaire");
					this.OnTelephoneProprietaireChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="voiture_reparation", Storage="_reparations", ThisKey="immatriculation", OtherKey="immatriculation")]
		public EntitySet<reparation> reparations
		{
			get
			{
				return this._reparations;
			}
			set
			{
				this._reparations.Assign(value);
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_reparations(reparation entity)
		{
			this.SendPropertyChanging();
			entity.voiture = this;
		}
		
		private void detach_reparations(reparation entity)
		{
			this.SendPropertyChanging();
			entity.voiture = null;
		}
	}
}
#pragma warning restore 1591
