//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Bimser.CSP.FormControls.Entities;
using Bimser.Framework.Attributes.Database;
using Bimser.Framework.Domain;
using Bimser.Framework.Domain.Entities;

namespace EgitimTalepDegerlendirmeSureci.Entities {
    
    
    [TableOptions(TableName="E_EgitimTalepDegerlendirmeSureci_FormEgitimTanim")]
    public class E_EgitimTalepDegerlendirmeSureci_FormEgitimTanimEntity : FormEntity<E_EgitimTalepDegerlendirmeSureci_FormEgitimTanimEntity> {
        
        private E_EgitimTalepDegerlendirmeSureci_FormEgitimTanimVREntity _VersionEntity;
        
        private RDEntityCollection<E_EgitimTalepDegerlendirmeSureci_FormEgitimTanimRDEntity, E_EgitimTalepDegerlendirmeSureci_FormEgitimTanimRDMLEntity> _RD;
        
        private RDCEntityCollection<E_EgitimTalepDegerlendirmeSureci_FormEgitimTanimRDCEntity, E_EgitimTalepDegerlendirmeSureci_FormEgitimTanimRDCMLEntity> _RDC;
        
        private GridEntityCollection<E_EgitimTalepDegerlendirmeSureci_FormEgitimTanim_dgEgitimBilgiEntity, E_EgitimTalepDegerlendirmeSureci_FormEgitimTanim_dgEgitimBilgiMLEntity, E_EgitimTalepDegerlendirmeSureci_FormEgitimTanim_dgEgitimBilgiSLEntity, E_EgitimTalepDegerlendirmeSureci_FormEgitimTanim_dgEgitimBilgiSLMLEntity> _E_EgitimTalepDegerlendirmeSureci_FormEgitimTanim_dgEgitimBilgi;
        
        public E_EgitimTalepDegerlendirmeSureci_FormEgitimTanimEntity() {
            this.VersionEntity = new E_EgitimTalepDegerlendirmeSureci_FormEgitimTanimVREntity();
            this.RD = new RDEntityCollection<E_EgitimTalepDegerlendirmeSureci_FormEgitimTanimRDEntity, E_EgitimTalepDegerlendirmeSureci_FormEgitimTanimRDMLEntity>();
            this.RDC = new RDCEntityCollection<E_EgitimTalepDegerlendirmeSureci_FormEgitimTanimRDCEntity, E_EgitimTalepDegerlendirmeSureci_FormEgitimTanimRDCMLEntity>();
            this.E_EgitimTalepDegerlendirmeSureci_FormEgitimTanim_dgEgitimBilgi = new GridEntityCollection<E_EgitimTalepDegerlendirmeSureci_FormEgitimTanim_dgEgitimBilgiEntity, E_EgitimTalepDegerlendirmeSureci_FormEgitimTanim_dgEgitimBilgiMLEntity, E_EgitimTalepDegerlendirmeSureci_FormEgitimTanim_dgEgitimBilgiSLEntity, E_EgitimTalepDegerlendirmeSureci_FormEgitimTanim_dgEgitimBilgiSLMLEntity>();
            this.E_EgitimTalepDegerlendirmeSureci_FormEgitimTanim_dgEgitimBilgi.MLEntityEnabled = true;
            this.E_EgitimTalepDegerlendirmeSureci_FormEgitimTanim_dgEgitimBilgi.SLEntityEnabled = false;
        }
        
        public E_EgitimTalepDegerlendirmeSureci_FormEgitimTanimVREntity VersionEntity {
            get {
                return this._VersionEntity;
            }
            set {
                this._VersionEntity = value;
            }
        }
        
        public RDEntityCollection<E_EgitimTalepDegerlendirmeSureci_FormEgitimTanimRDEntity, E_EgitimTalepDegerlendirmeSureci_FormEgitimTanimRDMLEntity> RD {
            get {
                return this._RD;
            }
            set {
                this._RD = value;
            }
        }
        
        public RDCEntityCollection<E_EgitimTalepDegerlendirmeSureci_FormEgitimTanimRDCEntity, E_EgitimTalepDegerlendirmeSureci_FormEgitimTanimRDCMLEntity> RDC {
            get {
                return this._RDC;
            }
            set {
                this._RDC = value;
            }
        }
        
        public GridEntityCollection<E_EgitimTalepDegerlendirmeSureci_FormEgitimTanim_dgEgitimBilgiEntity, E_EgitimTalepDegerlendirmeSureci_FormEgitimTanim_dgEgitimBilgiMLEntity, E_EgitimTalepDegerlendirmeSureci_FormEgitimTanim_dgEgitimBilgiSLEntity, E_EgitimTalepDegerlendirmeSureci_FormEgitimTanim_dgEgitimBilgiSLMLEntity> E_EgitimTalepDegerlendirmeSureci_FormEgitimTanim_dgEgitimBilgi {
            get {
                return this._E_EgitimTalepDegerlendirmeSureci_FormEgitimTanim_dgEgitimBilgi;
            }
            set {
                this._E_EgitimTalepDegerlendirmeSureci_FormEgitimTanim_dgEgitimBilgi = value;
            }
        }
    }
    
    [TableOptions(TableName="E_EgitimTalepDegerlendirmeSureci_FormEgitimTanim_dgEgitimBilgi")]
    public class E_EgitimTalepDegerlendirmeSureci_FormEgitimTanim_dgEgitimBilgiEntity : GridEntity<E_EgitimTalepDegerlendirmeSureci_FormEgitimTanim_dgEgitimBilgiEntity, E_EgitimTalepDegerlendirmeSureci_FormEgitimTanim_dgEgitimBilgiMLEntity, E_EgitimTalepDegerlendirmeSureci_FormEgitimTanim_dgEgitimBilgiSLEntity, E_EgitimTalepDegerlendirmeSureci_FormEgitimTanim_dgEgitimBilgiSLMLEntity> {
        
        private Bimser.Framework.Domain.DataField<System.Nullable<decimal>> _DGID;
        
        private Bimser.Framework.Domain.DataField<System.Nullable<bool>> _cbxDurum;
        
        public E_EgitimTalepDegerlendirmeSureci_FormEgitimTanim_dgEgitimBilgiEntity() {
        }
        
        [ColumnOptionsAttribute(Name="DGID", Mandatory=false)]
        public Bimser.Framework.Domain.DataField<System.Nullable<decimal>> DGID {
            get {
                return this._DGID;
            }
            set {
                this._DGID = value;
            }
        }
        
        [ColumnOptionsAttribute(Name="cbxDurum", Mandatory=false)]
        public Bimser.Framework.Domain.DataField<System.Nullable<bool>> cbxDurum {
            get {
                return this._cbxDurum;
            }
            set {
                this._cbxDurum = value;
            }
        }
    }
    
    [TableOptions(TableName="E_EgitimTalepDegerlendirmeSureci_FormEgitimTanim_dgEgitimBilgiML")]
    public class E_EgitimTalepDegerlendirmeSureci_FormEgitimTanim_dgEgitimBilgiMLEntity : GridMLEntity<E_EgitimTalepDegerlendirmeSureci_FormEgitimTanim_dgEgitimBilgiMLEntity> {
        
        private Bimser.Framework.Domain.DataField<string> _tbxEgitimAdi;
        
        private Bimser.Framework.Domain.DataField<string> _tbxEgitmen;
        
        [ColumnOptionsAttribute(Name="tbxEgitimAdi", Mandatory=false, Size=50)]
        public Bimser.Framework.Domain.DataField<string> tbxEgitimAdi {
            get {
                return this._tbxEgitimAdi;
            }
            set {
                this._tbxEgitimAdi = value;
            }
        }
        
        [ColumnOptionsAttribute(Name="tbxEgitmen", Mandatory=false, Size=50)]
        public Bimser.Framework.Domain.DataField<string> tbxEgitmen {
            get {
                return this._tbxEgitmen;
            }
            set {
                this._tbxEgitmen = value;
            }
        }
    }
    
    [TableOptions(TableName="E_EgitimTalepDegerlendirmeSureci_FormEgitimTanim_dgEgitimBilgiSL")]
    public class E_EgitimTalepDegerlendirmeSureci_FormEgitimTanim_dgEgitimBilgiSLEntity : GridSLEntity<E_EgitimTalepDegerlendirmeSureci_FormEgitimTanim_dgEgitimBilgiSLEntity, E_EgitimTalepDegerlendirmeSureci_FormEgitimTanim_dgEgitimBilgiSLMLEntity> {
    }
    
    [TableOptions(TableName="E_EgitimTalepDegerlendirmeSureci_FormEgitimTanim_dgEgitimBilgiSLML")]
    public class E_EgitimTalepDegerlendirmeSureci_FormEgitimTanim_dgEgitimBilgiSLMLEntity : GridSLMLEntity<E_EgitimTalepDegerlendirmeSureci_FormEgitimTanim_dgEgitimBilgiSLMLEntity> {
    }
    
    [TableOptions(TableName="E_EgitimTalepDegerlendirmeSureci_FormEgitimTanimVR")]
    public class E_EgitimTalepDegerlendirmeSureci_FormEgitimTanimVREntity : VersionEntity<E_EgitimTalepDegerlendirmeSureci_FormEgitimTanimVREntity> {
    }
    
    [TableOptions(TableName="E_EgitimTalepDegerlendirmeSureci_FormEgitimTanimRDC")]
    public class E_EgitimTalepDegerlendirmeSureci_FormEgitimTanimRDCEntity : RDCEntity<E_EgitimTalepDegerlendirmeSureci_FormEgitimTanimRDCEntity, E_EgitimTalepDegerlendirmeSureci_FormEgitimTanimRDCMLEntity> {
    }
    
    [TableOptions(TableName="E_EgitimTalepDegerlendirmeSureci_FormEgitimTanimRDCML")]
    public class E_EgitimTalepDegerlendirmeSureci_FormEgitimTanimRDCMLEntity : RDCMLEntity<E_EgitimTalepDegerlendirmeSureci_FormEgitimTanimRDCMLEntity> {
    }
    
    [TableOptions(TableName="E_EgitimTalepDegerlendirmeSureci_FormEgitimTanimRD")]
    public class E_EgitimTalepDegerlendirmeSureci_FormEgitimTanimRDEntity : RDEntity<E_EgitimTalepDegerlendirmeSureci_FormEgitimTanimRDEntity, E_EgitimTalepDegerlendirmeSureci_FormEgitimTanimRDMLEntity> {
    }
    
    [TableOptions(TableName="E_EgitimTalepDegerlendirmeSureci_FormEgitimTanimRDML")]
    public class E_EgitimTalepDegerlendirmeSureci_FormEgitimTanimRDMLEntity : RDMLEntity<E_EgitimTalepDegerlendirmeSureci_FormEgitimTanimRDMLEntity> {
    }
}




