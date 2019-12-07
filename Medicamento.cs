using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projMedicamentos
{
    class Medicamento
    {
        private int id;
        private string nome;
        private string laboratorio;
        private Queue<Lote> lotes;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public string Laboratorio
        {
            get { return laboratorio; }
            set { laboratorio = value; }
        }
        public Queue<Lote> GetLotes()
        {
            return lotes;
        }
        public void SetLotes(Queue<Lote> value)
        {
            lotes = value;
        }
       
        public Medicamento() : this(0, "", "")
        {
        }
        public Medicamento(int id, string nome, string laboratorio)
        {
            this.id = id;
            this.nome = nome;
            this.laboratorio = laboratorio;
            this.lotes = new Queue<Lote>();
        }
        public int qtdeDisponivel()
        {
            int aux = 0;
            foreach (Lote lote in this.lotes)
                aux += lote.Qtde;

            return aux;
        }

        public void comprar(Lote lote)
        {
            lotes.Enqueue(lote);
        }
        public bool vender(int qtde)
        {
            if (qtde <= qtdeDisponivel())
            {
                while (qtde > 0)
                {
                    Lote lote = GetLotes().Dequeue();
                    if (qtde >= lote.Qtde)
                    {
                        qtde -= lote.Qtde;
                    }
                }
                return true;
            }
            else
            {
                return false;
            }
        }
        public override string ToString()
        {
            return this.nome + " - " + this.laboratorio + " - " + this.qtdeDisponivel().ToString();
        }
        public override bool Equals(object obj)
        {
            return this.id.Equals(((Medicamento)obj).Id);
        }
    }
}
