using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ2
{
    class Cliente
    {
        private String iNroDocumento, iNombre;
        private TipoDocumento iTipoDocumento;

        public Cliente(TipoDocumento pTipoDocumento, String pNroDocumento, String pNombre)
        {
            iNroDocumento = pNroDocumento;
            iNombre = pNombre;
            iTipoDocumento = pTipoDocumento;
        }


        public TipoDocumento TipoDocumento
        {
            get { return this.iTipoDocumento; }
        }

        public String NroDocumento
        {
            get { return this.iNroDocumento; }
        }

        public String Nombre
        {
            get { return this.iNombre; }
        }

    }
}
