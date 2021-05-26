using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Philcosa.Domain.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Philcosa.Infrastructure.Configuration
{
    public class ThemeConfiguration : IEntityTypeConfiguration<Theme>
    {
        public void Configure(EntityTypeBuilder<Theme> builder)
        {
            string seedFolder = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + "\\Philcosa.Infrastructure\\Seeds\\";
            string file = Path.Combine(seedFolder, "Themes.csv");
            

            var dictionary = new List<string>();
            using (var rd = new StreamReader(file))
            {
                while (!rd.EndOfStream)
                {
                    var splits = rd.ReadLine().Split(',');
                    //string clean is done with Regex
                    dictionary.Add(Regex.Replace(splits[0], "[^A-Za-z0-9()/ ]", ""));
                }
            }

            var id = 1;
            var themeList = new List<Theme>();
            foreach(var theme in dictionary)
            {
                if (String.IsNullOrEmpty(theme))
                    continue;

                themeList.Add(new Theme
                {
                    Id = id++,
                    CreatedBy = "DataSeed",
                    CreatedOn = DateTime.Now,
                    LastModifiedBy = null,
                    LastModifiedOn = null,
                    Name = theme
                });


            }
            builder.HasData(themeList);
        }
    }
}
