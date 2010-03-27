using System;
using System.Collections.Generic;
using System.Web.UI.MobileControls;

namespace Web.Models
{
    public class Species
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

        public SpeciesType Physiogonomy { get; set; }
        public string SpeciesAcronym { get; set; }
        public string ScientificName { get; set; }
        public string CommonName { get; set; }
        public List<Species> AllSpecies = new List<Species>();

        public List<Species> OverstorySpecies
        {
            get { return AllSpecies.FindAll(Or(_overstorySpeciesFilter)); }
        }
        public List<Species> SnagSpecies
        {
            get { return AllSpecies.FindAll(Or(_snagsSpeciesFilter)); }
        }
        public List<Species> UnderstorySpecies
        {
            get { return AllSpecies.FindAll(Or(_understorySpeciesFilter)); }
        }
        public List<Species> DeerHerbevorySpecies
        {
            get { return AllSpecies.FindAll(Or(_deerHerbevorySpeciesFilter)); }
        }


        private readonly Predicate<Species>[] _overstorySpeciesFilter = new Predicate<Species>[]
                                                                   {
                                                                       new Predicate<Species>(
                                                                           s => s.Physiogonomy == SpeciesType.ATree),
                                                                       new Predicate<Species>(
                                                                           s => s.Physiogonomy == SpeciesType.NTree),
                                                                   };

        private readonly Predicate<Species>[] _snagsSpeciesFilter = new Predicate<Species>[]
                                                                   {
                                                                       new Predicate<Species>(
                                                                           s => s.Physiogonomy == SpeciesType.ATree),
                                                                       new Predicate<Species>(
                                                                           s => s.Physiogonomy == SpeciesType.NTree),
                                                                   };
        private readonly Predicate<Species>[] _understorySpeciesFilter = new Predicate<Species>[]
                                                                   {
                                                                       new Predicate<Species>(
                                                                           s => s.Physiogonomy == SpeciesType.ATree),
                                                                       new Predicate<Species>(
                                                                           s => s.Physiogonomy == SpeciesType.NTree),
                                                                       new Predicate<Species>(s => s.Physiogonomy == SpeciesType.AShrub),
                                                                       new Predicate<Species>(s => s.Physiogonomy == SpeciesType.NShrub),
                                                                   };
        private readonly Predicate<Species>[] _deerHerbevorySpeciesFilter = new Predicate<Species>[]
                                                                   {
                                                                       new Predicate<Species>(
                                                                           s => s.Physiogonomy == SpeciesType.ATree),
                                                                       new Predicate<Species>(
                                                                           s => s.Physiogonomy == SpeciesType.NTree),
                                                                       new Predicate<Species>(s => s.Physiogonomy == SpeciesType.AShrub),
                                                                       new Predicate<Species>(s => s.Physiogonomy == SpeciesType.NShrub),
                                                                                                                                             new Predicate<Species>(s => s.Physiogonomy == SpeciesType.AVine),
                                                                       new Predicate<Species>(s => s.Physiogonomy == SpeciesType.NVine),
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
