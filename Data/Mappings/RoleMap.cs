using betluck.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace betluck.Data.Mappings
{
    public class RoleMap : IEntityTypeConfiguration<Role>
    {
        public void Configure(EntityTypeBuilder<Role> builder)
        {
            // create table
            builder.ToTable("Role");

            //chave primaria
            builder.HasKey(x => x.Id);

            // Mapeando Propriedades
            builder.Property(x => x.Id).ValueGeneratedOnAdd().UseIdentityColumn();

            builder.Property(x => x.Name).IsRequired().HasColumnType("NVARCHAR").HasMaxLength(180);


        }
    }
}
