using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projMedicamentos
{
    class Lote
    {
        private int id;
        private int qtde;
        private DateTime venc;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public int Qtde
        {
            get { return qtde; }
            set { qtde = value; }
        }
        public DateTime Venc
        {
            get { return venc; }
            set { venc = value; }
        }


        public Lote(int id, int qtde) : this(0, 0, DateTime.Now)
        {

        }

        public Lote(int id, int qtde, DateTime venc)
        {
            this.Id = id;
            this.Qtde = qtde;
            this.Venc = venc;

        }
        public Lote(int id)
        {
            this.id = id;

        }

        public override string ToString()
        {
            return Id.ToString() +
                " - : " + Qtde.ToString() + " - " + Venc.ToString();

        }
}
}
