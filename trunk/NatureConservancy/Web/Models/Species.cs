using System;
using System.Collections.Generic;

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

        public virtual SpeciesType Physiogonomy { get; set; }
        public virtual string SpeciesAcronym { get; set; }
        public virtual string ScientificName { get; set; }
        public virtual string CommonName { get; set; }
        List<Species> AllSpecies = new List<Species>();

        public virtual List<Species> OverstorySpecies
        {
            get { return AllSpecies.FindAll(Or(_overstorySpeciesFilter)); }
        }
        public virtual List<Species> SnagSpecies
        {
            get { return AllSpecies.FindAll(Or(_snagsSpeciesFilter)); }
        }
        public virtual List<Species> UnderstorySpecies
        {
            get { return AllSpecies.FindAll(Or(_understorySpeciesFilter)); }
        }
        public virtual List<Species> DeerHerbevorySpecies
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
