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
    
    
    [TableOptions(TableName="E_EgitimTalepDegerlendirmeSureci_FormEgitimTalep")]
    public class E_EgitimTalepDegerlendirmeSureci_FormEgitimTalepEntity : FormEntity<E_EgitimTalepDegerlendirmeSureci_FormEgitimTalepEntity> {
        
        private Bimser.Framework.Domain.DataField<string> _umTalepEden;
        
        private E_EgitimTalepDegerlendirmeSureci_FormEgitimTalepVREntity _VersionEntity;
        
        private RDEntityCollection<E_EgitimTalepDegerlendirmeSureci_FormEgitimTalepRDEntity, E_EgitimTalepDegerlendirmeSureci_FormEgitimTalepRDMLEntity> _RD;
        
        private RDCEntityCollection<E_EgitimTalepDegerlendirmeSureci_FormEgitimTalepRDCEntity, E_EgitimTalepDegerlendirmeSureci_FormEgitimTalepRDCMLEntity> _RDC;
        
        private MLEntityCollection<E_EgitimTalepDegerlendirmeSureci_FormEgitimTalepMLEntity> _ML;
        
        private SLEntityCollection<E_EgitimTalepDegerlendirmeSureci_FormEgitimTalepSLEntity, E_EgitimTalepDegerlendirmeSureci_FormEgitimTalepSLMLEntity> _SL;
        
        public E_EgitimTalepDegerlendirmeSureci_FormEgitimTalepEntity() {
            this.ML = new MLEntityCollection<E_EgitimTalepDegerlendirmeSureci_FormEgitimTalepMLEntity>();
            this.VersionEntity = new E_EgitimTalepDegerlendirmeSureci_FormEgitimTalepVREntity();
            this.RD = new RDEntityCollection<E_EgitimTalepDegerlendirmeSureci_FormEgitimTalepRDEntity, E_EgitimTalepDegerlendirmeSureci_FormEgitimTalepRDMLEntity>();
            this.RDC = new RDCEntityCollection<E_EgitimTalepDegerlendirmeSureci_FormEgitimTalepRDCEntity, E_EgitimTalepDegerlendirmeSureci_FormEgitimTalepRDCMLEntity>();
            this.SL = new SLEntityCollection<E_EgitimTalepDegerlendirmeSureci_FormEgitimTalepSLEntity, E_EgitimTalepDegerlendirmeSureci_FormEgitimTalepSLMLEntity>();
        }
        
        [ColumnOptionsAttribute(Name="umTalepEden", Mandatory=false, Size=50)]
        public Bimser.Framework.Domain.DataField<string> umTalepEden {
            get {
                return this._umTalepEden;
            }
            set {
                this._umTalepEden = value;
            }
        }
        
        public E_EgitimTalepDegerlendirmeSureci_FormEgitimTalepVREntity VersionEntity {
            get {
                return this._VersionEntity;
            }
            set {
                this._VersionEntity = value;
            }
        }
        
        public RDEntityCollection<E_EgitimTalepDegerlendirmeSureci_FormEgitimTalepRDEntity, E_EgitimTalepDegerlendirmeSureci_FormEgitimTalepRDMLEntity> RD {
            get {
                return this._RD;
            }
            set {
                this._RD = value;
            }
        }
        
        public RDCEntityCollection<E_EgitimTalepDegerlendirmeSureci_FormEgitimTalepRDCEntity, E_EgitimTalepDegerlendirmeSureci_FormEgitimTalepRDCMLEntity> RDC {
            get {
                return this._RDC;
            }
            set {
                this._RDC = value;
            }
        }
        
        public MLEntityCollection<E_EgitimTalepDegerlendirmeSureci_FormEgitimTalepMLEntity> ML {
            get {
                return this._ML;
            }
            set {
                this._ML = value;
            }
        }
        
        public SLEntityCollection<E_EgitimTalepDegerlendirmeSureci_FormEgitimTalepSLEntity, E_EgitimTalepDegerlendirmeSureci_FormEgitimTalepSLMLEntity> SL {
            get {
                return this._SL;
            }
            set {
                this._SL = value;
            }
        }
    }
    
    [TableOptions(TableName="E_EgitimTalepDegerlendirmeSureci_FormEgitimTalepML")]
    public class E_EgitimTalepDegerlendirmeSureci_FormEgitimTalepMLEntity : MLEntity<E_EgitimTalepDegerlendirmeSureci_FormEgitimTalepMLEntity> {
        
        private Bimser.Framework.Domain.DataField<string> _umDepartman;
        
        private Bimser.Framework.Domain.DataField<string> _txAciklama;
        
        [ColumnOptionsAttribute(Name="umDepartman", Mandatory=false, Size=50)]
        public Bimser.Framework.Domain.DataField<string> umDepartman {
            get {
                return this._umDepartman;
            }
            set {
                this._umDepartman = value;
            }
        }
        
        [ColumnOptionsAttribute(Name="txAciklama", Mandatory=false, Size=350)]
        public Bimser.Framework.Domain.DataField<string> txAciklama {
            get {
                return this._txAciklama;
            }
            set {
                this._txAciklama = value;
            }
        }
    }
    
    [TableOptions(TableName="E_EgitimTalepDegerlendirmeSureci_FormEgitimTalepSL")]
    public class E_EgitimTalepDegerlendirmeSureci_FormEgitimTalepSLEntity : SLEntity<E_EgitimTalepDegerlendirmeSureci_FormEgitimTalepSLEntity, E_EgitimTalepDegerlendirmeSureci_FormEgitimTalepSLMLEntity> {
    }
    
    [TableOptions(TableName="E_EgitimTalepDegerlendirmeSureci_FormEgitimTalepSLML")]
    public class E_EgitimTalepDegerlendirmeSureci_FormEgitimTalepSLMLEntity : SLMLEntity<E_EgitimTalepDegerlendirmeSureci_FormEgitimTalepSLMLEntity> {
    }
    
    [TableOptions(TableName="E_EgitimTalepDegerlendirmeSureci_FormEgitimTalepVR")]
    public class E_EgitimTalepDegerlendirmeSureci_FormEgitimTalepVREntity : VersionEntity<E_EgitimTalepDegerlendirmeSureci_FormEgitimTalepVREntity> {
    }
    
    [TableOptions(TableName="E_EgitimTalepDegerlendirmeSureci_FormEgitimTalepRDC")]
    public class E_EgitimTalepDegerlendirmeSureci_FormEgitimTalepRDCEntity : RDCEntity<E_EgitimTalepDegerlendirmeSureci_FormEgitimTalepRDCEntity, E_EgitimTalepDegerlendirmeSureci_FormEgitimTalepRDCMLEntity> {
    }
    
    [TableOptions(TableName="E_EgitimTalepDegerlendirmeSureci_FormEgitimTalepRDCML")]
    public class E_EgitimTalepDegerlendirmeSureci_FormEgitimTalepRDCMLEntity : RDCMLEntity<E_EgitimTalepDegerlendirmeSureci_FormEgitimTalepRDCMLEntity> {
    }
    
    [TableOptions(TableName="E_EgitimTalepDegerlendirmeSureci_FormEgitimTalepRD")]
    public class E_EgitimTalepDegerlendirmeSureci_FormEgitimTalepRDEntity : RDEntity<E_EgitimTalepDegerlendirmeSureci_FormEgitimTalepRDEntity, E_EgitimTalepDegerlendirmeSureci_FormEgitimTalepRDMLEntity> {
    }
    
    [TableOptions(TableName="E_EgitimTalepDegerlendirmeSureci_FormEgitimTalepRDML")]
    public class E_EgitimTalepDegerlendirmeSureci_FormEgitimTalepRDMLEntity : RDMLEntity<E_EgitimTalepDegerlendirmeSureci_FormEgitimTalepRDMLEntity> {
    }
}




