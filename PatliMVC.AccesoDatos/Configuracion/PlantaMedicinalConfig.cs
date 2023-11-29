using Microsoft.EntityFrameworkCore;
using PatliMVC.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatliMVC.AccesoDatos.Configuracion
{
    public class PlantaMedicinalConfig: IEntityTypeConfiguration<PlantaMedicinal>
    { 
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<PlantaMedicinal> builder)
        {
            builder.HasKey(e => e.ID);
            builder.Property(e => e.NombreComun).IsRequired().HasMaxLength(50);
            builder.Property(e => e.NombreCientifico).IsRequired().HasMaxLength(50);
            builder.Property(e => e.NombreNahuatl).IsRequired().HasMaxLength(50);
            builder.Property(e => e.Descripcion).IsRequired().HasMaxLength(2500);
            builder.Property(e => e.UsoMedicinal).IsRequired().HasMaxLength(2500);
            builder.Property(e => e.Contraindicaciones).IsRequired().HasMaxLength(2500);
            builder.Property(e => e.EvaluacionCientifica).IsRequired().HasMaxLength(2500);
            builder.Property(e => e.Imagen);
            builder.Property(e => e.Aprobado).IsRequired();
        }
    }
    
}
