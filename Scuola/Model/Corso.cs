using System;
using System.Collections.Generic;
using System.Text;

namespace Scuola.Model
{
    public class Corso
    {
        public long Id { get; set; }
        public string Titolo { get; set; }
        public int DurataInOre { get; set; }
        public ExperienceLevel EntryLevel { get; set; }
        public string Description { get; set; }
        public decimal StandardPrice { get; set; } 

        public Corso(long id, string titolo, int durataInOre, ExperienceLevel entryLevel, string description, decimal standardPrice)
        {
            Id = id;
            Titolo = titolo;
            DurataInOre = durataInOre;
            EntryLevel = entryLevel;
            Description = description;
            StandardPrice = standardPrice;
        }

        public override string ToString()
        {
            return $"id: {Id} titolo: {Titolo} livello: {EntryLevel} ";
        }
        


    }
    public enum ExperienceLevel 
    {
        PRINCIPIANTE, MEDIO, ESPERTO, GURU
    }
}
