using betluck.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace betluck.Data.Mappings
{
    public class TeamMap : IEntityTypeConfiguration<Team>
    {
        public void Configure(EntityTypeBuilder<Team> builder)
        {
            // create table
            builder.ToTable("Team");

            //chave primaria
            builder.HasKey(x => x.Id);

            // Mapeando Propriedades
            builder.Property(x => x.Id).ValueGeneratedOnAdd().UseIdentityColumn();

            builder.Property(x => x.Name).IsRequired().HasColumnType("NVARCHAR").HasMaxLength(180);

            builder.Property(x => x.Abbreviation).IsRequired().HasColumnType("NVARCHAR").HasMaxLength(3);

            //relacionamentos
            builder.HasMany(x => x.Leagues).WithMany(x => x.Teams).UsingEntity<Dictionary<string, object>>(
                    "Teamlegues",
                    team => team.HasOne<League>().WithMany().HasForeignKey("TeamId").HasConstraintName("FK_TeamLeague_TeamId").OnDelete(DeleteBehavior.Cascade),
                    league => league.HasOne<Team>().WithMany().HasForeignKey("LeagueId").HasConstraintName("FK_LeagueTeam_LeagueId").OnDelete(DeleteBehavior.Cascade)
                );


        }
    }
}
