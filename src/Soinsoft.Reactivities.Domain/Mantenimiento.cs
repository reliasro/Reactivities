using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Soinsoft.Reactivities.Domain
{
    public class Mantenimiento
    {
        public Guid ID { get; set; }
        public int ActivoID { get; set; }
        public DateTime  FechaMantenimiento { get; set; }
        public string TareaRealizar { get; set; }
        public int EstadoTarea { get; set; }
        public float CostoTotal { get; set; }
        
    }
}