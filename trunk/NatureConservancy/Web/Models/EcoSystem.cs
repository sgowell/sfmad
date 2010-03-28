using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Web.Models
{
	public class EcoSystem : Entity
	{

        public virtual String EcoSystemName
        {
            get; set;
        }
	}
}
