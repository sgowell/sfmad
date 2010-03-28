using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Web.Models
{
    public class Species : Entity
    {
        public enum SpeciesType
        {
            ATree,
            NTree,
            AForb,
            NForb,
            AVine,
            NVine,
            AShrub,
            NShrub,
            AFern,
            NFern,
            AGrass,
            NGrass,
            ASedge,
            NSedge
        }

        [Required(ErrorMessage = "Please select a {0}")]
        [DisplayName("Physiognomy")]
        public virtual SpeciesType Physiognomy { get; set; }

        [Required(ErrorMessage = "Please enter an {0}")]
        [DisplayName("Acronym")]
        public virtual string SpeciesAcronym { get; set; }

        [Required(ErrorMessage = "Please enter a {0}")]
        [DisplayName("Scientific Name")]
        public virtual string ScientificName { get; set; }

        [Required(ErrorMessage = "Please enter a {0}")]
        [DisplayName("Common Name")]
        public virtual string CommonName { get; set; }

        private List<Species> allSpecies = new List<Species>();

        public virtual List<Species> OverstorySpecies
        {
            get { return allSpecies.FindAll(Or(_overstorySpeciesFilter)); }
        }
        public virtual List<Species> SnagSpecies
        {
            get { return allSpecies.FindAll(Or(_snagsSpeciesFilter)); }
        }
        public virtual List<Species> UnderstorySpecies
        {
            get { return allSpecies.FindAll(Or(_understorySpeciesFilter)); }
        }
        public virtual List<Species> DeerHerbevorySpecies
        {
            get { return allSpecies.FindAll(Or(_deerHerbevorySpeciesFilter)); }
        }

        public virtual List<Species> AllSpecies
        {
            get { return allSpecies; }
            set { allSpecies = value; }
        }


        private readonly Predicate<Species>[] _overstorySpeciesFilter = new []
                                                                   {
                                                                       s => s.Physiognomy == SpeciesType.ATree,
                                                                       new Predicate<Species>(s => s.Physiognomy == SpeciesType.NTree)
                                                                   };

        private readonly Predicate<Species>[] _snagsSpeciesFilter = new []
                                                                   {
                                                                       s => s.Physiognomy == SpeciesType.ATree,
                                                                       new Predicate<Species>(s => s.Physiognomy == SpeciesType.NTree)
                                                                   };
        private readonly Predicate<Species>[] _understorySpeciesFilter = new []
                                                                   {
                                                                       s => s.Physiognomy == SpeciesType.ATree,
                                                                       s => s.Physiognomy == SpeciesType.NTree,
                                                                       s => s.Physiognomy == SpeciesType.AShrub,
                                                                       new Predicate<Species>(s => s.Physiognomy == SpeciesType.NShrub)
                                                                   };
        private readonly Predicate<Species>[] _deerHerbevorySpeciesFilter = new []
                                                                   {
                                                                       s => s.Physiognomy == SpeciesType.ATree,
                                                                       s => s.Physiognomy == SpeciesType.NTree,
                                                                       s => s.Physiognomy == SpeciesType.AShrub,
                                                                       s => s.Physiognomy == SpeciesType.NShrub,
                                                                       s => s.Physiognomy == SpeciesType.AVine,
                                                                       new Predicate<Species>(s => s.Physiognomy == SpeciesType.NVine)
                                                                   };


        public static Predicate<T> Or<T>(params Predicate<T>[] predicates)
        {
            return delegate(T item)
            {
                foreach (Predicate<T> predicate in predicates)
                {
                    if (predicate(item))
                    {
                        return true;
                    }
                }
                return false;
            };
        }

        public static Predicate<T> And<T>(params Predicate<T>[] predicates)
        {
            return delegate(T item)
            {
                foreach (Predicate<T> predicate in predicates)
                {
                    if (!predicate(item))
                    {
                        return false;
                    }
                }
                return true;
            };
        }
    }
}
