using NodaTime;
using System;
using System.Collections.Generic;
using System.Text;

namespace Scuola.Model
{
    public class EdizioneCorso
    {
        public long Id { get; set; }
        public Corso Corso { get; set; }
        public LocalDate Start { get; set; }
        public LocalDate End { get; set; }
        public int NumStudents { get; set; }
        public decimal RealPrice { get; set; }

        public EdizioneCorso(long id, Corso corso, LocalDate start, LocalDate end, int numStudents, decimal realPrice)
        {
            Id = id;
            Corso = corso;
            Start = start;
            End = end;
            NumStudents = numStudents;
            RealPrice = realPrice;
        }
        public override string ToString()
        {
            return $"id: {Id} - titolo: {Corso.Titolo} - data inizio: {Start} - prezzo finale: {RealPrice} ";
        }
    }
}
