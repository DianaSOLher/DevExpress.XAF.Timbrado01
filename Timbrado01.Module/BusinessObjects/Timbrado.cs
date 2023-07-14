using DevExpress.Data.Filtering;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.DC;
using DevExpress.ExpressApp.Model;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Persistent.Validation;
using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace Timbrado01.Module.BusinessObjects
{
    [DefaultClassOptions]
    [NavigationItem]
     public class Timbrado : BaseObject
    { // Inherit from a different class to provide a custom primary key, concurrency and deletion behavior, etc. (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument113146.aspx).
        // Use CodeRush to create XPO classes and properties with a few keystrokes.
        // https://docs.devexpress.com/CodeRushForRoslyn/118557
        public Timbrado(Session session)
            : base(session)
        {
        }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
            // Place your initialization code here (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument112834.aspx).
        }


        string identificadorTipo;
        string claveInterna;
        DateTime fechaSolicitud;
        int quincena;
        int numeroEmpleado;
        string receptor;
        string estatus;

        [Size(SizeAttribute.DefaultStringMappingFieldSize)]
        public string Estatus
        {
            get => estatus;
            set => SetPropertyValue(nameof(Estatus), ref estatus, value);
        }


        public int NumeroEmpleado
        {
            get => numeroEmpleado;
            set => SetPropertyValue(nameof(NumeroEmpleado), ref numeroEmpleado, value);
        }


        
        [Size(SizeAttribute.DefaultStringMappingFieldSize)]
        public string IdentificadorTipo
        {
            get => identificadorTipo;
            set => SetPropertyValue(nameof(IdentificadorTipo), ref identificadorTipo, value);
        }

        [Size(SizeAttribute.DefaultStringMappingFieldSize)]
        public string Receptor
        {
            get => receptor;
            set => SetPropertyValue(nameof(Receptor), ref receptor, value);
        }


        public int Quincena
        {
            get => quincena;
            set => SetPropertyValue(nameof(Quincena), ref quincena, value);
        }



        public DateTime FechaSolicitud
        {
            get => fechaSolicitud;
            set => SetPropertyValue(nameof(FechaSolicitud), ref fechaSolicitud, value);
        }


        
        [Size(SizeAttribute.DefaultStringMappingFieldSize)]
        public string ClaveInterna
        {
            get => claveInterna;
            set => SetPropertyValue(nameof(ClaveInterna), ref claveInterna, value);
        }
    }
}