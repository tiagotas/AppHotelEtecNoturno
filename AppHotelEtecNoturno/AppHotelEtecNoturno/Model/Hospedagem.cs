using System;
using System.Collections.Generic;
using System.Text;

namespace AppHotelEtecNoturno.Model
{
    public class Hospedagem
    {
        public Suite QuartoEscolhido { get; set; }
        public int QntAdultos { get; set; }
        public int QntCriancas { get; set; }
        public DateTime DataCheckIn { get; set; }
        public DateTime DataCheckOut { get; set; }
        public int Estadia
        {
            get
            {
                return DataCheckOut.Subtract(DataCheckIn).Days;
            }
        }
        public double ValorTotal
        {
            get => ( (QntAdultos * QuartoEscolhido.DiariaAdulto) +
                     (QntCriancas * QuartoEscolhido.DiariaCrianca)
                   ) * Estadia;
        }

    }
}
