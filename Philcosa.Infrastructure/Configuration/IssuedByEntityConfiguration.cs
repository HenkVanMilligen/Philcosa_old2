using CsvHelper;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Philcosa.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Philcosa.Infrastructure.Configuration
{
    public class IssuedByEntityConfiguration : IEntityTypeConfiguration<IssuedByEntity>
    {
        public void Configure(EntityTypeBuilder<IssuedByEntity> builder)
        {
            string seedFolder = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + "\\Philcosa.Infrastructure\\Seeds\\";
            string file = Path.Combine(seedFolder, "IssuedByEntities.csv");

            var list = new List<IssuedByEntity>();
            using (var rd = new StreamReader(file))
            {
                using var csv = new CsvReader(rd, CultureInfo.InvariantCulture);
                csv.Read();
                csv.ReadHeader();
                var id = 1;
                while (csv.Read())
                {
                    var code = csv.GetField<string>("Code");
                    var name = csv.GetField<string>("Name");

                    if (string.IsNullOrEmpty(name))
                        continue;

                    list.Add(new IssuedByEntity
                    {
                        Id = id,
                        CreatedBy = "DataSeed",
                        CreatedOn = DateTime.Now,
                        LastModifiedBy = null,
                        LastModifiedOn = null,
                        Code = code,
                        Name = name
                    });
                    id++;
                }
            }
            builder.HasData(list);
        }
    }
}
